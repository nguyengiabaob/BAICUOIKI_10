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
    public partial class Formtinhluong : Form
    {
        public Formtinhluong()
        {
            InitializeComponent();
        }
        luongchitiet tbluongchitiet = new luongchitiet();
        luongtamung tbluongtamung = new luongtamung();
        luongtheothanhtich luongtheothanhtich = new luongtheothanhtich();
        DataSet ds = new DataSet();
        Bangnhanvien tbnhanvien = new Bangnhanvien();
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void addcot()
        {
            ds.Tables.AddRange(new DataTable[] { tbluongchitiet, tbnhanvien });
            DataRelation qh = new DataRelation("FRK_LUONGCT_NHANVIEN", tbnhanvien.Columns["MANV"], tbluongchitiet.Columns["MANV"]);
            ds.Relations.Add(qh);
            DataColumn cottenhanvien = new DataColumn("HOTENNV", Type.GetType("System.String"), "Parent(FRK_LUONGCT_NHANVIEN).HOTENNV");
            DataColumn cotchuvu = new DataColumn("CHUCVU", Type.GetType("System.String"), "Parent(FRK_LUONGCT_NHANVIEN).CHUCVU");
            tbluongchitiet.Columns.Add(cottenhanvien);
            tbluongchitiet.Columns.Add(cotchuvu);
        }
        private void loadlistnhanvien()
        {
            listnhanvien.DataSource = tbnhanvien;
            listnhanvien.DisplayMember = "HOTENNV";
            listnhanvien.ValueMember = "MANV";

        }

        private void listnhanvien_SelectedIndexChanged(object sender, EventArgs e)
        { SqlParameter ngay = new SqlParameter("@ngay", dtngay.Value);
            SqlParameter manv = new SqlParameter("@MANV", tbxmanhanvien.Text);
            SqlParameter[] d = new SqlParameter[] { ngay, manv };
            int index = listnhanvien.SelectedIndex;
            if (index >= 0)
            {
                int tonguongtamung = 0;
                int lluongtheohanhtich = 0;
                tbxmanhanvien.Text = tbnhanvien.Rows[index]["MANV"].ToString();
                tbxchucvu.Text = tbnhanvien.Rows[index]["CHUCVU"].ToString();
                tbxluongmacdinh.Text = tbnhanvien.Rows[index]["LUONG"].ToString();
                var query = "select* from LUONGTAMUNG where month(NGAYUNG) = MONTH('" + dtngay.Value + "' ) and MANV='" + tbxmanhanvien.Text + "'";
                var ppquery= "select* from LUONGTHEOTHANHTICH where month(NGAYTHUONG) = MONTH('" + dtngay.Value + "' ) and MANV='" + tbxmanhanvien.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, Bang.Bang.cnn);
                SqlDataAdapter da_1 = new SqlDataAdapter(ppquery, Bang.Bang.cnn);
                SqlCommandBuilder cmm = new SqlCommandBuilder(da);
                SqlCommandBuilder cmm_1 = new SqlCommandBuilder(da_1);
                DataTable b = new DataTable();
                DataTable c = new DataTable();
                da_1.Fill(c);
                da.Fill(b);
                if (b.DefaultView.Count == 0)
                    tbxluongtamung.Text = "";
                else
                { foreach (DataRowView r in b.DefaultView)
                    {
                        tonguongtamung += int.Parse(r["LUONGTUNG"].ToString());
                    }
                    tbxluongtamung.Text = tonguongtamung.ToString();
                        }
               

                if (c.DefaultView.Count == 0)
                    tbxluongtheothanhtich.Text = "";
                else
                {
                    foreach (DataRowView r in b.DefaultView)
                    {
                        lluongtheohanhtich += int.Parse(r["LUONGTHEOTHANHTICH"].ToString());
                    }
                    tbxluongtamung.Text = tonguongtamung.ToString();
                }
            }
        }

        private void btthem_Click(object sender, EventArgs e)
       {
           long tongluong;
             if (tbxluongtamung.Text == "")
            {
                tongluong = (Convert.ToInt64(tbxluongmacdinh.Text)*Convert.ToInt64(numericUpDownsogio.Value))+ Convert.ToInt64(tbxluongtheothanhtich.Text);
            }
            else if (tbxluongtheothanhtich.Text == "")
            {
                tongluong = (Convert.ToInt64(tbxluongmacdinh.Text) * Convert.ToInt64(numericUpDownsogio.Value)) -Convert.ToInt64(tbxluongtamung.Text);
            }
            else if (tbxluongtheothanhtich.Text == "" && tbxluongtamung.Text == "")
                tongluong = (Convert.ToInt64(tbxluongmacdinh.Text) * Convert.ToInt64(numericUpDownsogio.Value));
            else
            { tongluong = (Convert.ToInt64(tbxluongmacdinh.Text) * Convert.ToInt64(numericUpDownsogio.Value)) -Convert.ToInt64(tbxluongtamung.Text) + Convert.ToInt64(tbxluongtheothanhtich.Text); }

            tbxtongluong.Text =Convert.ToString(tongluong);
            DataRow r = tbluongchitiet.NewRow();
            r["MANV"] = tbxmanhanvien.Text;
            r["NGAYCHAMCONG"] = dtngay.Text;
            if (tbxluongtamung.Text != "")
                r["LUONGTAMUNG"] = Convert.ToInt64(tbxluongtamung.Text);
            else
                r["LUONGTAMUNG"] = 0;
            if (tbxluongtheothanhtich.Text != "")
                r["LUONGTHUONG"] = Convert.ToInt64(tbxluongtheothanhtich.Text);
            else
                r["LUONGTHUONG"] = 0 ;
            r["TONGLUONG"] = Convert.ToInt16(tbxtongluong.Text);
            tbluongchitiet.Rows.Add(r);
            tbluongchitiet.ghi();
        }

        private void dgvtinhluongtheothanhtich_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                tbluongchitiet.Rows[e.RowIndex].Delete();
                tbluongchitiet.ghi();
                if (tbluongchitiet.ghi() == true)
                {
                    MessageBox.Show("Xóa thành công!!!");
                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                tbluongchitiet.ghi();
                if (tbluongchitiet.ghi() == true)
                {
                    MessageBox.Show("Lưu thành công!!!");
                }
            }
        }

        private void dgvtinhluong_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach(DataGridViewRow r in dgvtinhluong.Rows)
            {
                r.Cells[0].Value = r.Index + 1;
            }
        }

        private void Formtinhluong_Load(object sender, EventArgs e)
        {
            addcot();
            loadlistnhanvien();
            dgvtinhluong.AutoGenerateColumns = false;
            dgvtinhluong.DataSource = tbluongchitiet;



        }

        private void btxóa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
