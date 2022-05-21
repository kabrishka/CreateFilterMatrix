using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KC_20_Gimalova_lab8.Forms
{
    internal class DataBank
    {
        public static int valueCols;
        public static int valueRows;
        public static double k;

        public static string createFolder()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fileFolder = Path.Combine(appData, "myDir");

            return fileFolder;
        }
    }
}
