using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baicuoiki.Bang;
using System.Data.SqlClient;

namespace Baicuoiki
{   
    public partial class danhsachdean : Form
    {
        TabControl c = null;
        duan tbduan = new duan();
        BindingManagerBase bduan;
        public danhsachdean()
        {
            InitializeComponent();
        }
        public danhsachdean(TabControl t)
        {
            c = t;
            InitializeComponent();
        }

        private void danhsachdean_Load(object sender, EventArgs e)
        {
            loadcbchedoloc();
            dataGridViewdanhsachdean.AutoGenerateColumns = false;
            dataGridViewdanhsachdean.DataSource = tbduan;
            bduan = this.BindingContext[tbduan];
        }

        private void dataGridViewdanhsachdean_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach(DataGridViewRow R in dataGridViewdanhsachdean.Rows)
            {
                R.Cells[0].Value = R.Index + 1;
            }
        }
        private void loadcbchedoloc()
        {
            cbxchedocloc1.Items.Add("Mã đề án");
            cbxchedocloc1.Items.Add("Tên đề án");
            cbxchedocloc1.Items.Add("Phòng ban");
            cbxchedocloc1.Items.Add("Địa điểm");
        }

        private void tbxlochitiet1_TextChanged(object sender, EventArgs e)
        {
            if (cbxchedocloc1.Text == "Mã đề án")
            {

                tbduan.locdulieu("MADA like'" + tbxlochitiet1.Text + "*'");

            }
            if (cbxchedocloc1.Text == "Phòng ban")
            {

                tbduan.locdulieu("PHONG like'" + tbxlochitiet1.Text + "*'");

            }
            if (cbxchedocloc1.Text == "Tên đề án")
            {

                tbduan.locdulieu("TENDA like'" + tbxlochitiet1.Text + "*'");

            }
            if (cbxchedocloc1.Text == "Địa điểm")
            {

                tbduan.locdulieu("DDIEM_DA like'" + tbxlochitiet1.Text + "*'");

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmm = new SqlCommand("Select dbo.fu_CreateMaDA()", Bang.Bang.cnn);
            Bang.Bang.cnn.Open();
            DataRow r = tbduan.NewRow();
            r["MADA"]= cmm.ExecuteScalar().ToString();
            tbduan.Rows.Add(r);
            tbduan.ghi();


      
          
        }

        private void dataGridViewdanhsachdean_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                tbduan.Rows[e.RowIndex].Delete();
                tbduan.ghi();
                if (tbduan.ghi() == true)
                {
                    MessageBox.Show("Xóa thành công!!!");
                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                try
                {
                    tbduan.ghi();
                    if (tbduan.ghi() == true)
                    {
                        MessageBox.Show("Lưu thành công!!!");
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btin_Click(object sender, EventArgs e)
        {
            c.TabPages.RemoveByKey("pagedanhsachdean");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Lưu.Visible = true;
            Xóa.Visible = true;
        }
    }
}
