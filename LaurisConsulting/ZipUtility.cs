using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaurisConsulting.Zip
{
    public static class ZipUtility
    {
        public static void ExtractFilesFromZip(string filename, string outputPath)
        {
            ////Check File exists in zip
            ////Extract Files Using Ionic Zip Library
            //string zipPath = SelectedItem;
            //string RootPath = textBox2.Text + "\\"; 
            //string subfolder = SetSubfolder(filename);
            //string extractPath = Path.Combine(RootPath + subfolder);
            //Boolean filefound = false;
            //
            //using (ZipFile zip = ZipFile.Read(SelectedItem))
            //{
            //    filefound = false;
            //    foreach (ZipEntry e in zip)
            //    {
            //        if (e.FileName.Equals(filename))
            //            filefound = true;
            //    }
            //
            //    if (filefound == true)
            //    {
            //        zip[filename].ExtractWithPassword(extractPath, "eng123");
            //
            //        // Post Process Web Portal zip files
            //        if ((filename == EngenixConstants.DevelopmentFileName) || (filename == "WebEngenix_Ent.zip"))
            //        {
            //            using (ZipFile zip2 = ZipFile.Read(extractPath + filename))
            //            {
            //                foreach (ZipEntry e2 in zip2)
            //                {
            //                    e2.Extract(extractPath);
            //                }
            //            }
            //        }
            //    }
            //    else
            //        MessageBox.Show("Requested file not found in zip");
            //}        
        }
    }
}
