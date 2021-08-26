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

        

        private void bt_Click(object sender, EventArgs e)
        {

            int ans = 1;
            for(int i = 0; i < int.Parse(tbJyou.Text); i++)
            {
                ans = ans * int.Parse(tbNumber.Text);
            }
            tbResult.Text = ans.ToString() ;

            //tbResult.Text = Math.Pow(int.Parse(tbNumber.Text), int.Parse(tbJyou.Text)).ToString();
        }
    }
}
