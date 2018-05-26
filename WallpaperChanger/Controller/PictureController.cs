using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using WallpaperChanger.Resources;

namespace WallpaperChanger.Controller
{
    public class PictureController
    {
        public static List<string> GetPictureList()
        {
            List<string> pictureList = new List<string>();

            pictureList.Add("Pony1");
            pictureList.Add("Pony2");
            pictureList.Add("Bieber1");
            pictureList.Add("Gej1");
            pictureList.Add("Gej2");
            pictureList.Add("Gej3");
            pictureList.Add("Pedal1");
            pictureList.Add("karny1");

            return pictureList;
        }

        public static Uri GetUriPicByName(string name)
        {
            string picString = PictureLinkResource.ResourceManager.GetString(name);
            Uri PicUri = new Uri(picString);

            return PicUri;
        }

        public static Uri GetRandomUriPic()
        {
            List<string> pictureList = GetPictureList();

            Random r = new Random();
            int rInt = r.Next(0, pictureList.Count());
            string picName = pictureList[rInt];

            Uri picUri = GetUriPicByName(picName);
            return picUri;
        }
    }
}
