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
    public partial class Danhsachthuongvakiluat : Form
    {
        Bangnhanvien tbnhanvien = new Bangnhanvien();
        khenthuongvakiluat tbkhenthuongvakiluat = new khenthuongvakiluat();
        public Danhsachthuongvakiluat()
        {
            InitializeComponent();
        }
        private void ADDCOT()
        {
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { tbkhenthuongvakiluat, tbnhanvien });
            DataRelation qh = new DataRelation("FRK_KHENTHUONGVAKILUAT_NHANVIEN", tbnhanvien.Columns["MANV"], tbkhenthuongvakiluat.Columns["MANV"]);
            ds.Relations.Add(qh);
            DataColumn cottenhanvien = new DataColumn("TENNV", Type.GetType("System.String"), "Parent(FRK_KHENTHUONGVAKILUAT_NHANVIEN).HOTENNV");
            DataColumn cotchucvu = new DataColumn("CHUCVU", Type.GetType("System.String"), "Parent(FRK_KHENTHUONGVAKILUAT_NHANVIEN).CHUCVU");
            tbkhenthuongvakiluat.Columns.Add(cottenhanvien);
            tbkhenthuongvakiluat.Columns.Add(cotchucvu);
        }

        private void Danhsachthuongvakiluat_Load(object sender, EventArgs e)
        {
            cbchedocloc();
            ADDCOT();
            dataGridViewdanhsachkhenvakiluat.AutoGenerateColumns = false;
            dataGridViewdanhsachkhenvakiluat.DataSource = tbkhenthuongvakiluat;
            tbxlochitiet.Enabled = false;
        } 
        private void cbchedocloc()
        {
            cbxchedocloc.Items.Add("Chế độ lọc");
            cbxchedocloc.Items.Add("Mã nhân viên");
            cbxchedocloc.Items.Add("Tên nhân viên");
            cbxchedocloc.Items.Add("Khen thưởng");
            cbxchedocloc.Items.Add("Kỉ luật");
        }

        private void tbxlochitiet_TextChanged(object sender, EventArgs e)
        {
            if (cbxchedocloc.Text == "Mã nhân viên")
            {

                tbkhenthuongvakiluat.locdulieu("MANV like'" + tbxlochitiet.Text + "*'");

            }
            if (cbxchedocloc.Text == "Tên nhân viên")
            {

               tbkhenthuongvakiluat.locdulieu("TENNV like'" + tbxlochitiet.Text + "*'");

            }
            if (cbxchedocloc.Text == "Khen thưởng")
            {

                tbkhenthuongvakiluat.locdulieu("PHANTHUONG like'" + tbxlochitiet.Text + " *'");
            }
            if (cbxchedocloc.Text == "Kỉ luật")
            {

                tbkhenthuongvakiluat.locdulieu("HINHPHAT like'" + tbxlochitiet.Text + " *'");
            }

        }

        private void cbxchedocloc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            object kt = "Khen thưởng";
            object kl = "Kỉ luật";
            object cdl = "Chế độ lọc";
            if (cbxchedocloc.SelectedItem==kt)
            {

                tbkhenthuongvakiluat.locdulieu("PHANTHUONG is not null");
            }
            if (cbxchedocloc.SelectedItem == kl)
            {

                tbkhenthuongvakiluat.locdulieu("HINHPHAT is not null");
            }
            if (cbxchedocloc.SelectedItem == cdl)
            {

                tbkhenthuongvakiluat.locdulieu("MANV is not null");
            }
        }

        private void dataGridViewdanhsachkhenvakiluat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                
                tbkhenthuongvakiluat.Rows[e.RowIndex].EndEdit();
                try
                {
                    if (tbkhenthuongvakiluat.ghi())
                        MessageBox.Show("Lưu thành cõng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                tbkhenthuongvakiluat.Rows[e.RowIndex].Delete();
                try
                {
                    if (tbkhenthuongvakiluat.ghi())
                        MessageBox.Show("Xóa thành cõng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            lưu.Visible = true;
            xóa.Visible = true;
        }

        private void cbxchedocloc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbxchedocloc.SelectedIndex;
            if (index >= 0)
                tbxlochitiet.Enabled = true;
        }
    }
    
}
