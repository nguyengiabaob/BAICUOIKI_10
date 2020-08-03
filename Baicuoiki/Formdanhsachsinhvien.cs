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
    public partial class Formdanhsachsinhvien : Form
    {
        public Formdanhsachsinhvien()
        {
            InitializeComponent();
        }
        Bangnhanvien tbnhanvien = new Bangnhanvien();


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btloc_Click(object sender, EventArgs e)
        {
            if(cbxchedocloc.Text=="Tên nhân viên")
            {
                
                var r = tbnhanvien.DefaultView.RowFilter;
                r= "HOTENNV='" + tbxlochitiet.Text + "'";
                if(r.Count()<0)
                {
                    MessageBox.Show("Không tìm thấy");
                }

            }
            if(cbxchedocloc.Text == "Mã nhân viên")
            {
               
                tbnhanvien.locdulieu("MANV='" + tbxlochitiet.Text + "'");

            }
            if(cbxchedocloc.Text == "Tên Phòng")
            {
                
                var r = tbnhanvien.DefaultView.RowFilter;
                r = "TENPHONG='" + tbxlochitiet.Text + "'";
                if (r.Count() < 0)
                {
                    MessageBox.Show("Không tìm thấy");
                }

            }
            if(cbxchedocloc.Text == "Lương")
            {
               
                var r = tbnhanvien.DefaultView.RowFilter;
                r = "LUONG='" + tbxlochitiet.Text + "'";
                if (r.Count() < 0)
                {
                    MessageBox.Show("Không tìm thấy");
                }
            
            }
            if(cbxchedocloc.Text == "Chức vụ")
            {
                
                var r = tbnhanvien.DefaultView.RowFilter;
                r = "CHUCVU='" + tbxlochitiet.Text + "'";
                if (r.Count() < 0)
                {
                    MessageBox.Show("Không tìm thấy");
                }

            }

        }
        private void addcolumn()
        {
            Phongban tbphong = new Phongban();
           

            DataSet ds=new DataSet();
            ds.Tables.AddRange( new DataTable[] { tbphong, tbnhanvien });
            DataRelation qh = new DataRelation("FRK_PHONGBAN_NHANVIEN", tbphong.Columns["MAPHG"], tbnhanvien.Columns["PHG"]);
            ds.Relations.Add(qh);
            DataColumn cottenphonng = new DataColumn("TENPHONG", Type.GetType("System.String"), "Parent(FRK_PHONGBAN_NHANVIEN).TENPHG");
            tbnhanvien.Columns.Add(cottenphonng);
        }
        private void loadcbchedoloc()
        {
            cbxchedocloc.Items.Add("Mã nhân viên");
            cbxchedocloc.Items.Add("Tên nhân viên");
            cbxchedocloc.Items.Add("Tên phòng");
            cbxchedocloc.Items.Add("Lương");
            cbxchedocloc.Items.Add("Chức vụ");
        }

        private void Formdanhsachsinhvien_Load(object sender, EventArgs e)
        {
            loadcbchedoloc();
            addcolumn();
            dataGridViewdanhsachnhanvien.AutoGenerateColumns=false;
            dataGridViewdanhsachnhanvien.DataSource = tbnhanvien;
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void tbxlochitiet_TextChanged(object sender, EventArgs e)
        {
            if (cbxchedocloc.Text == "Mã nhân viên")
            {

                tbnhanvien.locdulieu("MANV like'" + tbxlochitiet.Text + "*'");

            }
            if (cbxchedocloc.Text == "Tên nhân viên")
            {

                tbnhanvien.locdulieu("HOTENNV like'" + tbxlochitiet.Text + "*'");

            }
            if (cbxchedocloc.Text == "Tên phòng")
            {

                tbnhanvien.locdulieu("TENPHONG like'" + tbxlochitiet.Text + "*'");

            }
            if (cbxchedocloc.Text == "Lương")
            {

                tbnhanvien.locdulieu("LUONG like='" + Convert.ToChar(tbxlochitiet.Text) + "'");

            }
            if (cbxchedocloc.Text == "CHUCVU")
            {

                tbnhanvien.locdulieu("CHUCVU like'" + tbxlochitiet.Text + "*'");

            }
        }

        private void btin_Click(object sender, EventArgs e)
        {
            formindanhsach indanhsachnhanvien = new formindanhsach();
            indanhsachnhanvien.StartPosition = FormStartPosition.CenterScreen;
            indanhsachnhanvien.WindowState = FormWindowState.Normal;
            indanhsachnhanvien.Show();

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
