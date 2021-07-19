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

namespace Exercise3
{
    public partial class Form1 : Form
    {
        string filePath = " ";
        string AddfilePath = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            if(ofdOpenFile.ShowDialog() == DialogResult.OK)
            {
                filePath = ofdOpenFile.FileName;    
            }
        }

        private void btAddFile_Click(object sender, EventArgs e)
        {
            if (sfdSaveFile.ShowDialog() == DialogResult.OK)
            {
                AddfilePath = sfdSaveFile.FileName;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var lines = File.ReadLines(filePath).ToArray();
            //追加
            using (var writer = new StreamWriter(filePath, append: true))
            {
                foreach (var line in lines)
                    writer.WriteLine(line);
            }
        }
    }
}
