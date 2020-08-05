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
    public partial class formdanhsachphancongdeancs : Form
    {
        duan duan = new duan();
        Phongban tbphong = new Phongban();

        phancongdean pcdean = new phancongdean();
        Bangnhanvien tbnhanvien = new Bangnhanvien();
        DataSet ds = new DataSet();
        public formdanhsachphancongdeancs()
        {
            InitializeComponent();
        }

        private void formdanhsachphancongdeancs_Load(object sender, EventArgs e)
        {
            addcot1();
            addcot2();
            addcot3();
            dataGridViewdanhsachduan.AutoGenerateColumns = false;
            dataGridViewdanhsachduan.DataSource = pcdean;
            tbxlochitiet1.Enabled = false;
        }
        private void loadcbchedoloc()
        {
            cbxchedocloc1.Items.Add("Mã đề án");
            cbxchedocloc1.Items.Add("Tên đề án");
            cbxchedocloc1.Items.Add("Tên phòng thực hiện");
         
        }

        private void tbxlochitiet1_TextChanged(object sender, EventArgs e)
        {
            if (cbxchedocloc1.Text == "Mã đề án")
            {

                pcdean.locdulieu("MADA like'" + tbxlochitiet1.Text + "*'");

            }
            if (cbxchedocloc1.Text == "Phòng ban")
            {

                pcdean.locdulieu("TENPHONG like'" + tbxlochitiet1.Text + "*'");

            }
            if (cbxchedocloc1.Text == "Tên đề án")
            {

                pcdean.locdulieu("TENDA like'" + tbxlochitiet1.Text + "*'");

            }
            
        }
            private void addcot1()
            {

                ds.Tables.AddRange(new DataTable[] { pcdean, duan });
                DataRelation qh = new DataRelation("FRK_PHANCONG_DEAN", duan.Columns["MADA"], pcdean.Columns["MADEAN"]);
                ds.Relations.Add(qh);
                DataColumn cottenda = new DataColumn("TENDA", Type.GetType("System.String"), "Parent(FRK_PHANCONG_DEAN).TENDA");
                DataColumn cotdiadiem = new DataColumn("DIADIEM", Type.GetType("System.String"), "Parent(FRK_PHANCONG_DEAN).DDIEM_DA");
                DataColumn cottiemloinhuan = new DataColumn("TIENLOINHUAN", Type.GetType("System.Int32"), "Parent(FRK_PHANCONG_DEAN).TIENLOINHUAN");
                pcdean.Columns.Add(cottenda);
                pcdean.Columns.Add(cotdiadiem);
                pcdean.Columns.Add(cottiemloinhuan);
            }
            private void addcot2()
            {

                ds.Tables.AddRange(new DataTable[] { tbphong, tbnhanvien });
                DataRelation qh = new DataRelation("FRK_PHONG_NHANVIEN", tbnhanvien.Columns["MANV"], tbphong.Columns["TRPHG"]);
                ds.Relations.Add(qh);
                DataColumn cottentp = new DataColumn("TENTRUONGPHONG", Type.GetType("System.String"), "Parent(FRK_PHONG_NHANVIEN).HOTENNV");
                tbphong.Columns.Add(cottentp);

            }
            private void addcot3()
            {


                DataRelation qh = new DataRelation("FRK_PHONG_PCDEAN", tbphong.Columns["MAPHG"], pcdean.Columns["MAPHONG"]);
                ds.Relations.Add(qh);
                DataColumn cottenphong = new DataColumn("TENPHONG", Type.GetType("System.String"), "Parent(FRK_PHONG_PCDEAN).TENPHG");
                DataColumn cottentrp = new DataColumn("TENTRUONGPHONG", Type.GetType("System.String"), "Parent(FRK_PHONG_PCDEAN).TENTRUONGPHONG");
                DataColumn cotmatrp = new DataColumn("MATRP", Type.GetType("System.String"), "Parent(FRK_PHONG_PCDEAN).TRPHG");
                pcdean.Columns.Add(cottenphong);
                pcdean.Columns.Add(cottentrp);
                pcdean.Columns.Add(cotmatrp);

            }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            lưu.Visible = true;
            Xóa.Visible = true;
        }

        private void dataGridViewdanhsachduan_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach(DataGridViewRow r in dataGridViewdanhsachduan.Rows)
            {
                r.Cells[0].Value = r.Index + 1;
            }
        }

        private void dataGridViewdanhsachduan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0 && e.ColumnIndex==7)
            {
                pcdean.Rows[e.RowIndex].EndEdit();
                try
                {
                    pcdean.ghi();
                    if (pcdean.ghi() == true)
                    {
                        MessageBox.Show("Lưu thành công!!!");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == 8)
            {
                pcdean.Rows[e.RowIndex].Delete();
               
                try
                {
                    if (pcdean.ghi() == true)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void cbxchedocloc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbxchedocloc1.SelectedIndex;
            if(index>=0)
            {
                tbxlochitiet1.Enabled = true;
            }
        }
    }
}
