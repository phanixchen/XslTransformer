using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Forms;


namespace XslTransformer
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   File checker provides a service to verify that a file or folder exists. </summary>
    ///
    /// <remarks>   V 8i, 02/03/2011. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    class FileChecker
    {
        public String GetDirectoryName(String filePath)
        {
            String path = Path.GetDirectoryName(filePath);
            return path;
        }
        String path_;
        public FileChecker(String path) { path_ = path; }
        public String FilePath { get { return path_; } set { path_ = value; } }
        public bool IsValidPath(bool showAlert)
        {
            if (Directory.Exists(path_))
                return true;
            //else
            if (showAlert)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Path {0} does not exist", path_);
                MessageBox.Show(sb.ToString(), "Invalid Path",
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Exclamation);
            }
            return false;
        }
        public bool IsValidFile(bool showAlert)
        {
            if (File.Exists(path_))
                return true;
            //else
            if (showAlert)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("File {0} does not exist", path_);
                MessageBox.Show(sb.ToString(), "Invalid File",
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Exclamation);
            }
            return false;
        }
    }
}
