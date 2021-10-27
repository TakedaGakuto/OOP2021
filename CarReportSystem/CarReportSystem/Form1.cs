using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    
    public partial class fmMain : Form {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();
        
        public fmMain() {
            InitializeComponent();
            dgvRegistData.DataSource = listCarReport;
            dgvRegistData.Columns[5].Visible = false;
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
        private void dgvRegistData_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) {
                return;
            }
            CarReport selectedCar = listCarReport[e.RowIndex];
            dtpDate.Value = selectedCar.Date;
            cbEditorName.Text = selectedCar.EditorName;
            cbCarName.Text = selectedCar.CarName;
            tbReport.Text = selectedCar.Report;
            pbPicture.Image = selectedCar.Picture;
            selectmaker(selectedCar.Maker);
        }

        private void selectmaker(CarReport.MakerGroup maker) {
            switch (maker) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.外車:
                    rbForeign.Checked = true;
                    break;
                default:
                    rbOther.Checked = true;
                    break;
            }
        }
        private void btArticleDelete_Click(object sender, EventArgs e) {
            listCarReport.RemoveAt(dgvRegistData.CurrentRow.Index);
        }

        private void btArticleFix_Click(object sender, EventArgs e) {
            listCarReport[dgvRegistData.CurrentRow.Index].UpData(dtpDate.Value, cbEditorName.Text,
                                                                 selectedGroup(), cbCarName.Text, 
                                                                 tbReport.Text, pbPicture.Image);
            dgvRegistData.Refresh(); //コントロールの強制描画
        }
        private void btArticleSave_Click(object sender, EventArgs e) {
            
            if(sfdFileSave.ShowDialog() == DialogResult.OK) {
                try{	        
		            //シリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdFileSave.FileName,FileMode.Create)) {
                        bf.Serialize(fs,listCarReport);
                    }
	            }
	            catch (Exception ex){
                    MessageBox.Show(ex.Message+"\r\nこの形式のファイルは保存できません。");
	            }
            }
        }

        private void btArticleOpen_Click(object sender, EventArgs e) {
            if(ofdFileOpen.ShowDialog() == DialogResult.OK) {
                try { 
                //逆シリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdFileOpen.FileName,FileMode.Open,FileAccess.Read)){
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvRegistData.DataSource = null;
                        dgvRegistData.DataSource = listCarReport;
                    }
                }
                catch (Exception ex){
                    MessageBox.Show(ex.Message+"\r\nこの形式のファイルを開くことはできません。");
                    //MessageBox.Show("この形式のファイルを開くことはできません。");
                }
                //コンボボックスに登録
                foreach(var items in listCarReport) {
                    setCbCarName(items.CarName);
                    setCbName(items.EditorName);
                }
                /*for(int i = 0; i < dgvRegistData.RowCount; i++) {
                    setCbName(dgvRegistData.Rows[1].Cells[1].Value.ToString());
                    setCbCarName(dgvRegistData.Rows[1].Cells[3].Value.ToString());
                }*/
            }
        }
    }
}
