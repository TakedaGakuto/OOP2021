using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class fmMain : Form {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();


        public fmMain() {
            InitializeComponent();
            dgvRegistData.DataSource = listCarReport;
        }

        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpen.FileName);
            }
        }

        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void btArticleAdd_Click(object sender, EventArgs e) {
            
            if (cbEditorName.Text !="" && cbCarName.Text != "") {
                CarReport carReport = new CarReport {
                    Date = dtpDate.Value,
                    EditorName = cbEditorName.Text,
                    Maker = selectedGroup(),
                    CarName = cbCarName.Text,
                    Report = tbReport.Text,
                    Picture = pbPicture.Image
                };
                listCarReport.Add(carReport);
                setCbName(cbEditorName.Text);
                setCbCarName(cbCarName.Text);
            }
            else {
                MessageBox.Show("入力されていない項目があります");
            }
        }
        private CarReport.MakerGroup selectedGroup() {
            foreach(var rb in gbMakers.Controls) {
                if (((RadioButton)rb).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((string)((RadioButton)rb).Tag));
                }
            }
            return CarReport.MakerGroup.その他;
        }
        //コンボボックス記録者
        private void setCbName(string Name) {
            if (!cbEditorName.Items.Contains(Name)) {
                cbEditorName.Items.Add(Name);
            }
        }
        //コンボボックス車名
        private void setCbCarName(string CarName) {
            if (!cbCarName.Items.Contains(CarName)) {
                cbCarName.Items.Add(CarName);
            }
        }
    }
}
