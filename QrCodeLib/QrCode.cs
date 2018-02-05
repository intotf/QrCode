using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace QrCodeLib
{
    /// <summary>
    /// 生成二维码
    /// </summary>
    public class QrCode
    {
        /// <summary>
        /// 生成二维码明文
        /// </summary>
        private string plainText { get; set; }

        /// <summary>
        /// 尺寸
        /// </summary>
        private int Size { get; set; }

        /// <summary>
        /// 背景色
        /// </summary>
        private Color Background { get; set; }

        /// <summary>
        /// 前景色
        /// </summary>
        private Color Foreground { get; set; }

        /// <summary>
        /// icon 图标
        /// </summary>
        private Bitmap icon { get; set; }

        /// <summary>
        /// icon图片大小
        /// </summary>
        private int iconSize { get; set; }

        /// <summary>
        /// icon图片边框宽度
        /// </summary>
        private int iconBorderWidth { get; set; }

        /// <summary>
        /// icon图片边框颜色
        /// </summary>
        private Color iconBorderColor { get; set; }

        /// <summary>
        /// 二维码连框开启
        /// </summary>
        private bool QrIsBorder { get; set; }

        /// <summary>
        /// 二维码边框大小,像素
        /// </summary>
        private int QrCodeBorderWidth { get; set; }

        /// <summary>
        /// 二维码边框大小,像素
        /// </summary>
        private Color QrCodeBorderColor { get; set; }

        /// <summary>
        /// 创建默认二维码
        /// </summary>
        /// <param name="plainText">二维码内容</param>
        /// <param name="Size">二维码大小 29的倍数像素</param>
        private QrCode(string plainText, int Size, bool IsBorder)
        {
            this.plainText = plainText;
            this.Background = Color.White;
            this.Foreground = Color.Black;
            this.iconBorderWidth = 6;
            this.iconSize = 15;
            this.iconBorderColor = Color.White;
            this.QrCodeBorderWidth = 0;
            this.QrCodeBorderColor = Color.White;
            this.Size = Size;
            this.QrIsBorder = IsBorder;
        }

        /// <summary>
        /// 创建二维码
        /// </summary>
        /// <param name="plainText">文字内容</param>
        /// <param name="Size">二维码大小,默认 6*29 像素</param>
        /// <param name="IsBorder">是否增加边框</param>
        /// <returns></returns>
        public static QrCode Create(string plainText, int Size = 6, bool IsBorder = true)
        {
            return new QrCode(plainText, Size, IsBorder);
        }


        /// <summary>
        /// 设置二维码
        /// </summary>
        /// <param name="Background">背景色</param>
        /// <param name="Foreground">前景色</param>
        /// <returns></returns>
        public QrCode SetColor(Color Background, Color Foreground)
        {
            this.Background = Background;
            this.Foreground = Foreground;
            return this;
        }

        /// <summary>
        /// 设置边框
        /// </summary>
        /// <param name="QrCodeBorderColor">边框颜色</param>
        /// <param name="QrCodeBorderWidth">边框宽度（小于0 不添加边框,等于0 二维码高度10%）,</param>
        /// <returns></returns>
        public QrCode SetBorder(Color QrCodeBorderColor, int QrCodeBorderWidth = 0)
        {
            this.QrCodeBorderColor = QrCodeBorderColor;
            this.QrCodeBorderWidth = QrCodeBorderWidth;
            this.QrIsBorder = (QrCodeBorderWidth >= 0) ? true : false;
            return this;
        }

        /// <summary>
        /// 设置 Icon图
        /// </summary>
        /// <param name="iconPath">Icon 图片地址</param>
        /// <param name="iconBorderColor">边框颜色</param>
        /// <param name="iconBorderWidth">边框宽</param>
        /// <returns></returns>
        public QrCode SetIcon(string iconPath, Color iconBorderColor, int iconBorderWidth = 3, int iconSize = 18)
        {
            this.iconBorderColor = iconBorderColor;
            this.iconBorderWidth = iconBorderWidth;
            if (!string.IsNullOrEmpty(iconPath) && File.Exists(iconPath))
            {
                this.icon = WhiteBorder(new Bitmap(iconPath), iconBorderWidth, iconBorderColor);
            }
            this.iconSize = iconSize;
            return this;
        }

        /// <summary>
        /// 获取二维码 Bitmap
        /// </summary>
        /// <returns></returns>
        public Bitmap GetBitmap()
        {
            // 生成二维码的内容
            QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(this.plainText, QRCodeGenerator.ECCLevel.Q);
            QRCode qrcode = new QRCode(qrCodeData);

            Bitmap qrCodeImage = qrcode.GetGraphic(this.Size, this.Foreground, this.Background, this.icon, this.iconSize, 1, false);
            if (!this.QrIsBorder)
            {
                return qrCodeImage;
            }
            return WhiteBorder(qrCodeImage, this.QrCodeBorderWidth, this.QrCodeBorderColor);
        }

        /// <summary>
        /// 获取二维码文件流 Stream
        /// </summary>
        /// <param name="imageFormat"></param>
        /// <returns></returns>
        public MemoryStream GetStream(ImageFormat imageFormat)
        {
            var img = this.GetBitmap();
            var stream = new MemoryStream();
            img.Save(stream, imageFormat);
            return stream;
        }

        /// <summary>
        /// 获取二维码文件流 Stream
        /// 默认为 Png 文件
        /// </summary>
        /// <param name="imageFormat"></param>
        /// <returns></returns>
        public MemoryStream GetStream()
        {
            var img = this.GetBitmap();
            var stream = new MemoryStream();
            img.Save(stream, ImageFormat.Png);
            return stream;
        }

        /// <summary>
        /// 保存二维码到本地
        /// </summary>
        /// <param name="filePath">保存路径</param>
        /// <returns></returns>
        public void Save(string file)
        {
            var img = this.GetBitmap();
            using (var fs = new FileStream(file, FileMode.Create))
            {
                img.Save(fs, ImageFormat.Png);
            }
        }

        /// <summary>
        /// 在图片上加入边框
        /// </summary>
        /// <param name="Img">图片</param>
        /// <param name="Margin">白边的宽高,如果< 0，自动默认 图片宽度的10%</param>
        /// <param name="color">边框颜色</param>
        /// <returns>Bitmap</returns>
        private Bitmap WhiteBorder(Bitmap Img, int BorderWidth, Color BorderColor)
        {
            if (BorderWidth <= 0)
            {
                BorderWidth = (int)(Img.Width * 0.1);
            }

            var newW = Img.Width + BorderWidth * 2;
            var newH = Img.Height + BorderWidth * 2;
            Bitmap newImg = new Bitmap(newW, newH); //创建一张新图片
            using (Graphics gImg = Graphics.FromImage(newImg))
            {  //创建新图的Graphics
                Pen myPen = new Pen(BorderColor, BorderWidth * 2);
                gImg.DrawRectangle(myPen, 0, 0, newW - 1, newH - 1);
                gImg.DrawImage(Img, BorderWidth, BorderWidth);
            }
            return newImg;
        }
    }
}
