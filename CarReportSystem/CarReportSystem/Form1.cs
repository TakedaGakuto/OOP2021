﻿using System;
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

namespace CarReportSystem
{

    public partial class fmMain : Form
    {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public fmMain()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btPictureOpen_Click(object sender, EventArgs e)
        {
            if (ofdFileOpen.ShowDialog() == DialogResult.OK)
            {
                pbPicture.Image = Image.FromFile(ofdFileOpen.FileName);
            }
        }

        private void btPictureDelete_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
        }

        private void btArticleAdd_Click(object sender, EventArgs e)
        {

            if (cbEditorName.Text != "" && cbCarName.Text != "")
            {
                CarReport carReport = new CarReport
                {
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
            else
            {
                MessageBox.Show("入力されていない項目があります");
            }
        }
        private CarReport.MakerGroup selectedGroup()
        {
            foreach (var rb in gbMakers.Controls)
            {
                if (((RadioButton)rb).Checked)
                {
                    return (CarReport.MakerGroup)int.Parse(((string)((RadioButton)rb).Tag));
                }
            }
            return CarReport.MakerGroup.その他;
        }
        //コンボボックス記録者
        private void setCbName(string Name)
        {
            if (!cbEditorName.Items.Contains(Name))
            {
                cbEditorName.Items.Add(Name);
            }
        }
        //コンボボックス車名
        private void setCbCarName(string CarName)
        {
            if (!cbCarName.Items.Contains(CarName))
            {
                cbCarName.Items.Add(CarName);
            }
        }
        private void dgvRegistData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
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

        private void selectmaker(CarReport.MakerGroup maker)
        {
            switch (maker)
            {
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
        private void btUpdate_Click(object sender, EventArgs e)
        {

            if (carReportDataGridView.CurrentRow == null) return;

            carReportDataGridView.CurrentRow.Cells[1].Value = dtpDate.Value;        //日付
            carReportDataGridView.CurrentRow.Cells[2].Value = cbEditorName.Text;    //記録者
            carReportDataGridView.CurrentRow.Cells[3].Value = selectedGroup();      //メーカー名
            carReportDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;       //車名
            carReportDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;        //レポート
            carReportDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image);      //画像


            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202108DataSet);
            
            setCbName(carReportDataGridView.CurrentRow.Cells[2].Value.ToString());
            setCbCarName(carReportDataGridView.CurrentRow.Cells[4].Value.ToString());

#if false
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
#endif
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202108DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202108DataSet.CarReport);
            for (int i = 1; i < carReportDataGridView.RowCount; i++)
            {
                setCbName(carReportDataGridView.Rows[i-1].Cells[2].Value.ToString());
                setCbCarName(carReportDataGridView.Rows[i-1].Cells[4].Value.ToString());
            }
#if false
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
#endif
        }

        private void carReportDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (carReportDataGridView.Rows == null) return;
            try
            {
                dtpDate.Value = (DateTime)carReportDataGridView.CurrentRow.Cells[1].Value;      //日付
                cbEditorName.Text = carReportDataGridView.CurrentRow.Cells[2].Value.ToString(); //記入者
                selectmaker((CarReport.MakerGroup)Enum.Parse(typeof(CarReport.MakerGroup),carReportDataGridView.CurrentRow.Cells[3].Value.ToString()));//メーカー名(文字→列挙)
                cbCarName.Text = carReportDataGridView.CurrentRow.Cells[4].Value.ToString();    //車名
                tbReport.Text = carReportDataGridView.CurrentRow.Cells[5].Value.ToString();     //レポート
                pbPicture.Image = ByteArrayToImage((byte[])carReportDataGridView.CurrentRow.Cells[6].Value);     //画像
            }
            catch (Exception)
            {
                pbPicture.Image = null;
            }
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b)
        {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }
        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

            if (carReportDataGridView.Rows == null) return;
            try
            {
                dtpDate.Value = (DateTime)carReportDataGridView.CurrentRow.Cells[1].Value;      //日付
                cbEditorName.Text = carReportDataGridView.CurrentRow.Cells[2].Value.ToString(); //記入者
                selectmaker((CarReport.MakerGroup)Enum.Parse(typeof(CarReport.MakerGroup), carReportDataGridView.CurrentRow.Cells[3].Value.ToString()));//メーカー名(文字→列挙)
                cbCarName.Text = carReportDataGridView.CurrentRow.Cells[4].Value.ToString();    //車名
                tbReport.Text = carReportDataGridView.CurrentRow.Cells[5].Value.ToString();     //レポート
                pbPicture.Image = ByteArrayToImage((byte[])carReportDataGridView.CurrentRow.Cells[6].Value);     //画像
            }
            catch (Exception)
            {
                pbPicture.Image = null;
            }
        }

        private void carReportDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
