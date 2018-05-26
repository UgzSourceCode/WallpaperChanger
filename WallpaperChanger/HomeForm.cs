using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WallpaperChanger.Controller;
using WallpaperChanger.Helper;

namespace WallpaperChanger
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            foreach (string item in PictureController.GetPictureList())
            {
                this.PictureListCB.Items.Add(item);
            }
        }

        private void SetRandomWallpaperBtn_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 6; i++)
            {
                try
                {
                    Uri randomPic = PictureController.GetRandomUriPic();
                    WallpaperController.Set(randomPic, WallpaperController.Style.Stretched);
                    return;
                }
                catch
                {
                    MessageBox.Show(MessageHelper.GetMessageByName("RandomPicError"));
                }
            }
        }

        private void SetWallpaperBtn_Click(object sender, EventArgs e)
        {
            string pictureKey = this.PictureListCB.SelectedItem.ToString();

            if (String.IsNullOrEmpty(pictureKey))
            {
                MessageBox.Show(MessageHelper.GetMessageByName("EmptyPictureKey"));
                return;
            }

            try
            {
                Uri Pic = PictureController.GetUriPicByName(pictureKey);
                WallpaperController.Set(Pic, WallpaperController.Style.Stretched);
            }
            catch
            {
                MessageBox.Show(MessageHelper.GetMessageByName("SetPictureError"));
            }
        }
    }
}
