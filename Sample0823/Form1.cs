using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0823
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btExec_Click(object sender, EventArgs e)
        {
            double ans = 1;
            if(0 <= int.Parse(tbjyou.Text))
            {
                for (int i = 0; i < int.Parse(tbjyou.Text); i++)
                {
                    ans = ans * int.Parse(tbValue.Text);
                }
            }
            if(int.Parse(tbjyou.Text) < 0)
            {
                for(int i = 0; i < Math.Abs(int.Parse(tbjyou.Text)); i++)
                {
                    ans = ans / int.Parse(tbValue.Text);
                }
            }
            
            tbResult.Text = ans.ToString();
            //tbResult.Text = Math.Pow(int.Parse(tbValue.Text), int.Parse(tbjyou.Text)).ToString();
        }
    }
}
