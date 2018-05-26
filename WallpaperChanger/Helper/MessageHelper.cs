using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallpaperChanger.Resources;

namespace WallpaperChanger.Helper
{
    public class MessageHelper
    {
        public static string GetMessageByName(string name)
        {
            return StringResource.ResourceManager.GetString(name);
        }
    }
}
