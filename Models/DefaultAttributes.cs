﻿using Microsoft.Win32;
using System;
using System.Drawing;

namespace FileSortApplication.Models
{

    public static class DefaultAttributes
    {
        public static String originalDefaultDir = @"C:\Users";
        private static String defaultDir = @"C:\Users";
        private static bool isUserAware = false;
        //private static Icon iconObj = new Icon(@"C:\Users\Akshay\Source\Repos\akshay265\FileSortApplication\Models\man.ico");
        private static Icon iconObj = new Icon(CurrentPath.GetCurrentPath() + "//Icon/folder.ico");

        public static String DefaultDir
        {
            get { return defaultDir; }
            set { defaultDir = value; }
        }

        public static bool UserAware
        {
            get { return isUserAware; }
            set { isUserAware = value; }
        }

        public static Icon DefaultIconObj
        {
            get { return iconObj; }
        }

        /*
         * https://stackoverflow.com/questions/62282360/is-it-possible-to-detect-windows-dark-mode-on-winforms-application
         * https://stackoverflow.com/questions/4479421/get-windows-theme
         */
        public static String GetTheme()
        {

            int res;
            try
            {
                res = (int)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", -1);
                Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "AppsUseLightTheme", 1);
                Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "SystemUsesLightTheme", 1);
            }
            catch (Exception e)
            {

                return "ThemeUnknownException";
            }

            return (res == 0) ? "Dark" : "Light";
        }
    }
}
