using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btOpen_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (ofdOpenFile.ShowDialog() == DialogResult.OK)
            {
                using (var reader = new StreamReader(ofdOpenFile.FileName, Encoding.UTF8))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine(); //1行読み込み
                        count++;
                        tbOutPut.Text += count + ":"+ line+"\r\n";
                    }
                }
            }
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (sfdSaveFile.ShowDialog() == DialogResult.OK) {
                using (var writer = new StreamWriter(sfdSaveFile.FileName))
                {
                    writer.WriteLine(tbOutPut.Text);
                }
            }
        }
    }
}
