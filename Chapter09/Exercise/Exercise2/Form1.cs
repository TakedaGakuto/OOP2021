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
            if (ofdOpenFile.ShowDialog() == DialogResult.OK)
            {
                var lines = File.ReadLines(ofdOpenFile.FileName).Select((s, ix) => string.Format("{0,4}:{1}", ix + 1, s)).ToArray();
                if (sfdSaveFile.ShowDialog() == DialogResult.OK) { }
                {
                    using (var writer = new StreamWriter(sfdSaveFile.FileName))
                    {
                        foreach(var line in lines)
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
            }
        }
    }
}
