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
    public partial class Formluongtheothanhtich : Form
    {
        TabControl c = null;
        Bangnhanvien tbnhanvien = new Bangnhanvien();
        luongtheothanhtich luongtheothanhtich = new luongtheothanhtich();
        DataSet ds = new DataSet();
        public Formluongtheothanhtich()
        {
            InitializeComponent();
        }
        public Formluongtheothanhtich(TabControl t)
        {
            c = t;
            InitializeComponent();
        }
        private void addcot()
        {
            ds.Tables.AddRange(new DataTable[] { luongtheothanhtich, tbnhanvien });
            DataRelation qh = new DataRelation("FRK_LUONGTAMUNG_NHANVIEN", tbnhanvien.Columns["MANV"], luongtheothanhtich.Columns["MANV"]);
            ds.Relations.Add(qh);
            DataColumn cottenhanvien = new DataColumn("HOTENNV", Type.GetType("System.String"), "Parent(FRK_LUONGTAMUNG_NHANVIEN).HOTENNV");

            luongtheothanhtich.Columns.Add(cottenhanvien);
        }
        private void loadlistnhanvien()
        {
            listnhanvien.DataSource = tbnhanvien;
            listnhanvien.DisplayMember = "HOTENNV";
            listnhanvien.ValueMember = "MANV";

        }

        private void listnhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listnhanvien.SelectedIndex;
            if (index >= 0)
            {
                tbxmanhanvien.Text = tbnhanvien.Rows[index]["MANV"].ToString();
                tbxchucvu.Text = tbnhanvien.Rows[index]["CHUCVU"].ToString();

            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            DataRow r = luongtheothanhtich.NewRow();
            r["MANV"] = tbxmanhanvien.Text;
            r["NGAYTHUONG"] = dtngaytamung.Text;
            r["LUONGTHEOTHANHTICH"] = nrudowmluongtheothanhtich.Value;
            luongtheothanhtich.Rows.Add(r);
            luongtheothanhtich.ghi();
        }

        private void dgvtinhluongtheothanhtich_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                luongtheothanhtich.Rows[e.RowIndex].Delete();
                try
                {
                    if (luongtheothanhtich.ghi() == true)
                    {
                        MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                luongtheothanhtich.Rows[e.RowIndex].EndEdit();
                try
                {
                    if (luongtheothanhtich.ghi() == true)
                    {
                        MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvtinhluongtheothanhtich_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvtinhluongtheothanhtich.Rows)
            {
                r.Cells[0].Value = r.Index + 1;
            }
        }

        private void Formluongtheothanhtich_Load(object sender, EventArgs e)
        {
            addcot();
            loadlistnhanvien();
            dgvtinhluongtheothanhtich.AutoGenerateColumns = false;
            dgvtinhluongtheothanhtich.DataSource = luongtheothanhtich;


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            c.TabPages.RemoveByKey("pagetinhluongtheothanhtich");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            lưu.Visible = true;
            xóa.Visible = true;
        }
    }
}
