using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickStarter
{
    public partial class Form1 : Form
    {
        private string _path = "";

        public Form1()
        {
            InitializeComponent();
        }

        private string BrowseFile()
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "*.exe|*.EXE";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return "";
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            this._path = BrowseFile();
            path.Text = this._path;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this._path))
                Process.Start(this._path);
        }
    }
}
