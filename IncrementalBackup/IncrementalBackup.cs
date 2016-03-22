using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncrementalBackup
{
    public partial class IncrementalBackup : Form
    {
        public IncrementalBackup()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonBackupPath_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBoxBackupPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonNewDataPath_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBoxNewDataPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {

        }

        public static string CreateMD5(String path)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                using (FileStream fs = File.Open(path, FileMode.Open))
                {
                    byte[] hashBytes = md5.ComputeHash(fs);

                    // Convert the byte array to hexadecimal string
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hashBytes.Length; i++)
                    {
                        sb.Append(hashBytes[i].ToString("X2"));
                    }
                    return sb.ToString();
                }
            }
        }
    }

    
    class BkDir
    {
        public string Name
        {
            get
            {
                if (Info != null)
                    return Info.Name;
                return "";
            }
        }
        public DirectoryInfo Info { get; set; }
        public List<BkDir> BkDirs { get; set; }
        public List<BkFile> BkFiles { get; set; }
        public BkDir()
        {
            BkDirs = new List<BkDir>();
            BkFiles = new List<BkFile>();
        }

        public BkDir(string path):this()
        {
            Info = new DirectoryInfo(path);
        }
    }

    class BkFile
    {
        public string Name
        {
            get
            {
                if (Info != null)
                    return Info.Name;
                return "";
            }
        }
        public FileInfo Info { get; set; }
        public string Hash { get; set; }

        public BkFile()
        {
        }

        public BkFile(string path):this()
        {
            Info = new FileInfo(path);
        }
    }
}
