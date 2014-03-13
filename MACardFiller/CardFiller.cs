using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Caching;
using System.Windows.Forms;

namespace MACardFiller
{
    public partial class CardFiller : Form
    {
        readonly string ProcessPath = System.Windows.Forms.Application.StartupPath;

        public CardFiller()
        {
            InitializeComponent();
            if (!ImageTools.InitFontPic(ProcessPath))
            {
                MessageBox.Show("字体文件初始化失败！");
                this.Enabled = false;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "卡牌图鉴(*.png)|*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtImagePath.Text = dialog.FileName;
                try
                {
                    Image img = Image.FromFile(txtImagePath.Text);
                    if (chkSize.Checked)
                        img = img.GetThumbnailImage(640, 896, null, System.IntPtr.Zero);
                    if (img.Width == 640 && img.Height == 896)
                    {
                        pbCard.Image = ImageTools.GetHalfView(img);
                        Cache.SetAbsolute("img", img, 99999);
                        Cache.Remove("ImgDone");
                        SetWords();
                    }
                    else
                        MessageBox.Show("请使用640px*896px的图鉴原图！");
                }
                catch
                {
                    txtImagePath.Text = null;
                    MessageBox.Show("路径或图片无效！");
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                Image img = Image.FromFile(txtImagePath.Text);
                if (chkSize.Checked)
                    img = img.GetThumbnailImage(640, 896, null, System.IntPtr.Zero);
                if (img.Width == 640 && img.Height == 896)
                {
                    txtLv.Text = "";
                    txtHP.Text = "";
                    txtATK.Text = "";
                    Cache.SetAbsolute("img", img, 99999);
                    Cache.Remove("ImgDone");
                }
                else
                    MessageBox.Show("请使用640px*896px的图鉴原图！");
            }
            catch
            {
                txtImagePath.Text = null;
                MessageBox.Show("路径或图片无效！");
            }
        }

        private void txtLv_TextChanged(object sender, EventArgs e)
        {
            SetWords();
        }

        private void txtHP_TextChanged(object sender, EventArgs e)
        {
            SetWords();
        }

        private void txtATK_TextChanged(object sender, EventArgs e)
        {
            SetWords();
        }

        private void SetWords()
        {
            pbCard.Image = null;
            Image img = Cache.Get("img") as Image;
            if (img == null)
                return;
            Image card = ImageTools.OverlayAll(img, txtLv.Text, txtHP.Text, txtATK.Text);
            if (card != null)
                pbCard.Image = ImageTools.GetHalfView(card);
            Cache.SetAbsolute("ImgDone", card, 99999);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLv.Text = "";
            txtHP.Text = "";
            txtATK.Text = "";
            Image img = Cache.Get("img") as Image;
            if (img == null)
                return;
            pbCard.Image = ImageTools.GetHalfView(img);
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            Image outImg = Cache.Get("ImgDone") as Image;
            if (outImg == null)
            {
                MessageBox.Show("无已处理的图像！");
                return;
            }
            string path = txtImagePath.Text.Substring(0, txtImagePath.Text.LastIndexOf('\\')) + "\\";
            string filename = txtImagePath.Text.Replace(path, "");
            try
            {
                path += "MACardFillerOutput";
                filename = filename.Replace(".png", "_Lv" + txtLv.Text + ".png");
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                outImg.Save(path + "\\" + filename);
                MessageBox.Show("保存成功！");
            }
            catch
            {
                MessageBox.Show("保存失败！");
            }
        }

    }
}
