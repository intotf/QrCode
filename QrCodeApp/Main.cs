using QrCodeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QrCodeApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            var selectList = new List<SelectItem>();
            for (int i = 1; i <= 20; i++)
            {
                selectList.Add(new SelectItem()
                {
                    Value = i,
                    Text = string.Format("{0} 像素", (i * 29).ToString()),
                    Selecter = i == 4 ? true : false
                });
            }
            this.cbSize.Items.AddRange(selectList.ToArray());
            this.cbSize.DisplayMember = "Text";
            this.cbSize.SelectedItem = selectList.Where(item => item.Selecter).FirstOrDefault();
        }

        /// <summary>
        /// 选择背景色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plForeground_Click(object sender, EventArgs e)
        {
            this.colorDialog.Color = ((Panel)sender).BackColor;
            var result = this.colorDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ((Panel)sender).BackColor = this.colorDialog.Color;
            }
        }

        /// <summary>
        /// 选择前景色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plBackground_Click(object sender, EventArgs e)
        {
            this.colorDialog.Color = ((Panel)sender).BackColor;
            var result = this.colorDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ((Panel)sender).BackColor = this.colorDialog.Color;
            }
        }

        /// <summary>
        /// 选择边框颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plBorder_Click(object sender, EventArgs e)
        {
            this.colorDialog.Color = ((Panel)sender).BackColor;
            var result = this.colorDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ((Panel)sender).BackColor = this.colorDialog.Color;
            }
        }

        /// <summary>
        /// 选择Icon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbLogo_Click(object sender, EventArgs e)
        {
            this.fileDialog.DefaultExt = "图片文件|*.jpg|*.png";
            DialogResult result = this.fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.tbLogo.Text = this.fileDialog.FileName;
            }
        }

        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCreate_Click(object sender, EventArgs e)
        {
            var sizeItem = this.cbSize.SelectedItem as SelectItem;
            var borderText = this.tbBorder.Text;
            var border = 0;
            int.TryParse(borderText, out border);
            QrPicture.Image = QrCode.Create(this.tbTxt.Text, sizeItem.Value)
                .SetColor(this.plBackground.BackColor, this.plForeground.BackColor)
                .SetBorder(this.plBorder.BackColor, border)
                .SetIcon(this.tbLogo.Text, this.plBackground.BackColor)
                .GetBitmap();
        }

        /// <summary>
        /// 保存图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Jpg文件 (*.jpg)|*.jpg|Png 文件 (*.png)|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                QrPicture.Image.Save(sfd.FileName);
            }
        }

    }
}
