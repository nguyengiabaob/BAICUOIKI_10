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
    public partial class danhsachphongban : Form
    {
        TabControl c = null;
        public danhsachphongban()
        {
            InitializeComponent();
        }
        public danhsachphongban(TabControl t)
        {
            c = t;
            InitializeComponent();
        }
        Phongban phongban = new Phongban();
        Bangnhanvien tbnhanvien = new Bangnhanvien();
        DataSet ds = new DataSet();

        private void btin1_Click(object sender, EventArgs e)
        {
            Formfdanhsachphongban f = new Formfdanhsachphongban();
            f.ShowDialog();
        }
        private void addcot()
        {
            ds.Tables.AddRange(new DataTable[] { phongban, tbnhanvien });
            DataRelation qh = new DataRelation("FRK_PHONG_NHANVIEN", tbnhanvien.Columns["MANV"], phongban.Columns["TRPHG"]);
            ds.Relations.Add(qh);
            DataColumn cottentp = new DataColumn("TENTRUONGPHONG", Type.GetType("System.String"), "Parent(FRK_PHONG_NHANVIEN).HOTENNV");
            phongban.Columns.Add(cottentp);
        }

        private void danhsachphongban_Load(object sender, EventArgs e)
        {
            loadcbchedoloc();
            addcot();
            dataGridViewdanhsachphongban.AutoGenerateColumns = false;
            dataGridViewdanhsachphongban.DataSource = phongban;


        }
        private void loadcbchedoloc()
        {
            cbxchedocloc2.Items.Add("Chế độ lọc");
            cbxchedocloc2.Items.Add("Mã phòng ban");
            cbxchedocloc2.Items.Add("Tên phòng ban");
            cbxchedocloc2.Items.Add("Mã trưởng phòng");
            cbxchedocloc2.Items.Add("Tên trưởng phòng");
        }

        private void tbxlochitiet2_TextChanged(object sender, EventArgs e)
        {
            if (cbxchedocloc2.Text == "Mã phòng ban")
            {

                phongban.locdulieu("MAPHG='" + tbxlochitiet2.Text + "'");

            }
            if (cbxchedocloc2.Text == "Tên phòng ban")
            {

                phongban.locdulieu("TENPHG like'" + tbxlochitiet2.Text + "*'");

            }
            if (cbxchedocloc2.Text == "Mã trưởng phòng")
            {

                phongban.locdulieu("TRPHG like'" + tbxlochitiet2.Text + "*'");

            }
            if (cbxchedocloc2.Text == "Tên trưởng phòng")
            {

                phongban.locdulieu("TENTRUONGPHONG like'" + tbxlochitiet2.Text + "*'");

            }

        }

        private void dataGridViewdanhsachphongban_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dataGridViewdanhsachphongban.Rows)
            {
                r.Cells[0].Value = r.Index + 1;
            }
        }

        private void cbxchedocloc2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            object cdl = "Chế độ lọc";
            if (cbxchedocloc2.SelectedItem == cdl)
            {
                phongban.locdulieu("MAPHG is not null");
            }
        }

        private void dataGridViewdanhsachphongban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
               phongban.Rows[e.RowIndex].EndEdit();
                try
                {
                    if (phongban.ghi() == true && tbnhanvien.ghi() == true)
                    {
                        MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                phongban.Rows[e.RowIndex].Delete();
                DataRow[] r = tbnhanvien.Select("MANV='" + phongban.Rows[e.RowIndex]["TRPHG"] + "'");
                r[0]["CHUCVU"] = DBNull.Value;
                try
                {
                    if (phongban.ghi() == true && tbnhanvien.ghi() == true)
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            c.TabPages.RemoveByKey("pagedanhsachphongban");

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DataRow r = phongban.NewRow();
            phongban.Rows.Add(r);
            lưu.Visible = true;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            lưu.Visible = true;
            Xóa.Visible = true;
        }
    }
}
