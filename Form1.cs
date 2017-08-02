using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;

namespace QrCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.cbSize.SelectedIndex = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var codeTxt = this.tbTxt.Text;
            if (string.IsNullOrEmpty(codeTxt) || codeTxt.Length > 300)
            {
                MessageBox.Show("输入的字符长度在 1 至 300之间");
                return;
            }
            var CodeScale = int.Parse(this.cbSize.SelectedItem.ToString());
            //打印出 preResponse.QrCode 对应的条码
            Bitmap bt;
            string enCodeString = this.tbTxt.Text;
            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;
            qrCodeEncoder.QRCodeScale = CodeScale;
            qrCodeEncoder.QRCodeVersion = 0;
            bt = qrCodeEncoder.Encode(enCodeString, Encoding.UTF8);
            string filename = System.DateTime.Now.ToString("yyyyMMddHHmmss") + "0000" + (new Random()).Next(1, 10000).ToString() + ".jpg";
            var filePath = System.Environment.CurrentDirectory;
            var imgPath = filePath + filename;
            //bt.Save(imgPath);
            var img = bt;
            var logoPath = this.tbLogo.Text;
            if (!string.IsNullOrEmpty(logoPath))
            {
                if (System.IO.File.Exists(logoPath))
                {
                    System.IO.MemoryStream MStream = new System.IO.MemoryStream();
                    img = (Bitmap)CombinImage(bt, logoPath);
                }
                else
                {
                    MessageBox.Show(string.Format("Logo文件：{0} 不存在.", logoPath));
                    return;
                }
            }
            this.pictureBox1.Image = img;
        }


        /// <summary>
        /// 调用此函数后使此两种图片合并，类似相册，有个
        /// 背景图，中间贴自己的目标图片
        /// </summary>
        /// <param name="imgBack">粘贴的源图片</param>
        /// <param name="destImg">粘贴的目标图片</param>
        public static Image CombinImage(Image imgBack, string destImg)
        {
            Image img = Image.FromFile(destImg);    //照片图片
            if (img.Height != 65 || img.Width != 65)
            {
                img = KiResizeImage(img, 65, 65, 0);
            }
            Graphics g = Graphics.FromImage(imgBack);
            g.DrawImage(imgBack, 0, 0, imgBack.Width, imgBack.Height);   //g.DrawImage(imgBack, 0, 0, 相框宽, 相框高);
            //g.FillRectangle(System.Drawing.Brushes.White, imgBack.Width / 2 - img.Width / 2 - 1, imgBack.Width / 2 - img.Width / 2 - 1,1,1);//相片四周刷一层黑色边框
            //g.DrawImage(img, 照片与相框的左边距, 照片与相框的上边距, 照片宽, 照片高);
            g.DrawImage(img, imgBack.Width / 2 - img.Width / 2, imgBack.Width / 2 - img.Width / 2, img.Width, img.Height);
            GC.Collect();
            return imgBack;
        }
        /// <summary>
        /// Resize图片
        /// </summary>
        /// <param name="bmp">原始Bitmap</param>
        /// <param name="newW">新的宽度</param>
        /// <param name="newH">新的高度</param>
        /// <param name="Mode">保留着，暂时未用</param>
        /// <returns>处理以后的图片</returns>
        public static Image KiResizeImage(Image bmp, int newW, int newH, int Mode)
        {
            try
            {
                Image b = new Bitmap(newW, newH);
                Graphics g = Graphics.FromImage(b);
                // 插值算法的质量
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(bmp, new Rectangle(0, 0, newW, newH), new Rectangle(0, 0, bmp.Width, bmp.Height), GraphicsUnit.Pixel);
                g.Dispose();
                return b;
            }
            catch
            {
                return null;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "图片文件|*.jpg|*.png";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.tbLogo.Text = openFileDialog1.FileName;
            }
        }


    }
}
