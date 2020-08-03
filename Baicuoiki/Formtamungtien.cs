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

namespace Baicuoiki
{
    public partial class Formtamungtien : Form
    {
        public Formtamungtien()
        {
            InitializeComponent();
        }
        Bangnhanvien tbnhanvien = new Bangnhanvien();
        luongchitiet tbluongchitiet = new luongchitiet();
        luongtamung tbluongtamung = new luongtamung();
        DataSet ds = new DataSet();

        private void addcot()
        {
            ds.Tables.AddRange(new DataTable[] { tbluongchitiet, tbnhanvien });
            DataRelation qh = new DataRelation("FRK_LUONGCT_NHANVIEN", tbnhanvien.Columns["MANV"], tbluongchitiet.Columns["MANV"]);
            ds.Relations.Add(qh);
            DataColumn cotluongthuong = new DataColumn("LUONGTHUONG", Type.GetType("System.Int32"), "Child(FRK_LUONGCT_NHANVIEN).LUONGTHUONG");
            DataColumn cotluongung= new DataColumn("LUONGTAMUNG", Type.GetType("System.Int32"), "Child(FRK_LUONGCT_NHANVIEN).LUONGTAMUNG");
            DataColumn cottongluong = new DataColumn("TONGLUONG", Type.GetType("System.Int32"), "Child(FRK_LUONGCT_NHANVIEN).TONGLUONG");
            tbnhanvien.Columns.Add(cotluongthuong);
            tbnhanvien.Columns.Add(cotluongung);
            tbnhanvien.Columns.Add(cottongluong);
        }
        private void addcottennhanvien_tbtamung()
        {
            ds.Tables.AddRange(new DataTable[] { tbluongtamung, tbnhanvien });
            DataRelation qh = new DataRelation("FRK_LUONGTAMUNG_NHANVIEN", tbnhanvien.Columns["MANV"], tbluongtamung.Columns["MANV"]);
            ds.Relations.Add(qh);
            DataColumn cottenhanvien = new DataColumn("HOTENNV", Type.GetType("System.String"), "Parent(FRK_LUONGTAMUNG_NHANVIEN).HOTENNV");
           
            tbluongtamung.Columns.Add(cottenhanvien);
            
        }
        private void loadlistnhanvien()
        {
            listnhanvien.DataSource = tbnhanvien;
            listnhanvien.DisplayMember = "HOTENNV";
            listnhanvien.ValueMember = "MANV";
           
        }

        private void Formtamungtien_Load(object sender, EventArgs e)
        {
            loadlistnhanvien();
            addcottennhanvien_tbtamung();
            dgvtinhluongtamung.AutoGenerateColumns = false;
            dgvtinhluongtamung.DataSource = tbluongtamung;
          
        }

        private void listnhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listnhanvien.SelectedIndex;
            if(index>=0)
            {
                tbxmanhanvien.Text = tbnhanvien.Rows[index]["MANV"].ToString();
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            DataRow r = tbluongtamung.NewRow();
            r["MANV"] = tbxmanhanvien.Text;
            r["NGAYUNG"] = dtngaytamung.Text;
            r["LUONGTAMUNG"] = nrudowmluongtamung.Value;
            tbluongtamung.Rows.Add(r);
            tbluongtamung.ghi();


        }

        private void dgvtinhluongtamung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0&&e.ColumnIndex==6)
            {
                tbluongtamung.Rows[e.RowIndex].Delete();
                tbluongtamung.ghi();
                if (tbluongtamung.ghi() == true)
                {
                    MessageBox.Show("Xóa thành công!!!");
                }
            }
            if(e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                tbluongtamung.ghi();
                if(tbluongtamung.ghi()==true)
                {
                    MessageBox.Show("Lưu thành công!!!");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvtinhluongtamung_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           foreach(DataGridViewRow r in dgvtinhluongtamung.Rows)
            {
                r.Cells[0].Value = r.Index + 1;
            }
        }
    }
        
 
}
