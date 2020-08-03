using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Baicuoiki.Bang;

namespace Baicuoiki
{
    public partial class Formcapnhatnhanvien : Form
    {
        public Formcapnhatnhanvien()
        {
            InitializeComponent();
        }
        BindingManagerBase nhanvien;
        string gt;
        Bangnhanvien tbnhanvien = new Bangnhanvien();


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonnu.Checked = !radioButtonnam.Checked;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void nhanvien_PositonChanged(object sender,EventArgs e)
        {
            int r = nhanvien.Position+1;
            loadradio();
            LBTRANG.Text = r.ToString();
        }

        private void Formcapnhatnhanvien_Load(object sender, EventArgs e)
        {
            loadcbtenphong();
            tbxmanhanvien.DataBindings.Add("text", tbnhanvien, "MANV", true);
            tbxhoten.DataBindings.Add("text", tbnhanvien, "HOTENNV", true);
            tbxdiachi.DataBindings.Add("text", tbnhanvien, "DCHI", true);
            datetpickerngaysinh.DataBindings.Add("Value", tbnhanvien, "NGSINH", true);
  
            cbxtenphong.DataBindings.Add("SelectedValue", tbnhanvien, "PHG", true);
            tbxluong.DataBindings.Add("text", tbnhanvien, "LUONG", true);
            tbxchucvu.DataBindings.Add("text", tbnhanvien, "CHUCVU", true);
            tbxthoihanhopdong.DataBindings.Add("text", tbnhanvien, "THOIHANHOPDONG", true);
            loadradio();
            nhanvien = BindingContext[tbnhanvien];
            LBTONGSO.Text = tbnhanvien.getcount.ToString();
            nhanvien.PositionChanged += new EventHandler(nhanvien_PositonChanged);
        


    }
        private void loadcbtenphong()
        {
            Phongban bangphongban = new Phongban();
            cbxtenphong.DataSource = bangphongban;
            cbxtenphong.DisplayMember = "TENPHG";
            cbxtenphong.ValueMember = "MAPHG";
        }

        private void loadradio()
        {
            var gioitinh = tbnhanvien.Select("MANV='" + tbxmanhanvien.Text + "'");
            gt = gioitinh[0]["PHAI"].ToString();
            if (gt == "Nam")
            {
                radioButtonnam.Checked = true;
            }
            else
                if(gt=="Nữ ")
                radioButtonnam.Checked = false;
        }

        private void btdau_Click(object sender, EventArgs e)
        {
            nhanvien.Position = 0;
            int r = nhanvien.Position + 1;
            loadradio();
            LBTRANG.Text = r.ToString();
        }

        private void bttruoc_Click(object sender, EventArgs e)
        {
            if (nhanvien.Position > 0)
            {
                LBTRANG.Text = nhanvien.Position.ToString();
                nhanvien.Position = nhanvien.Position - 1;
                loadradio();
            }
        }

        private void btsau_Click(object sender, EventArgs e)
        {
            if (nhanvien.Position < tbnhanvien.getcount)
            {
                nhanvien.Position += 1;
                int r = nhanvien.Position + 1;
                loadradio();
                LBTRANG.Text = r.ToString();
            }
        }

        private void btcuoi_Click(object sender, EventArgs e)
        {
            nhanvien.Position = tbnhanvien.getcount;
            loadradio();
        }

        private void btthemmoi_Click(object sender, EventArgs e)
        {
            tbxhoten.Text = "";
            tbxdiachi.Text = "";
            tbxluong.Text = "";
            tbxthoihanhopdong.Text = "";
            tbxchucvu.Text = "";
            cbxtenphong.SelectedIndex = -1;
            datetpickerngaysinh.Text = DateTime.Now.ToString();
       
            
            nhanvien.AddNew();
            SqlCommand cmm = new SqlCommand("Select dbo.fu_CreateMaNV()", Bang.Bang.cnn);
            Bang.Bang.cnn.Open();
            tbxmanhanvien.Text = cmm.ExecuteScalar().ToString();



        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (tbxhoten.Text == null || tbxdiachi.Text == null || tbxluong.Text == null || tbxthoihanhopdong.Text == null || tbxchucvu.Text == null || cbxtenphong.SelectedIndex == -1)
                MessageBox.Show("Thông tin còn thiếu !!!");
            nhanvien.EndCurrentEdit();
            tbnhanvien.ghi();
            if(tbnhanvien.ghi()==true)
            {
                MessageBox.Show("Lưu thành công");

            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            nhanvien.RemoveAt(nhanvien.Position);
            tbnhanvien.ghi();
            if(tbnhanvien.ghi())
            {
                MessageBox.Show("Xóa thành công");

            }
        
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            btthemmoi.Enabled = false;
           


        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            nhanvien.CancelCurrentEdit();
            tbnhanvien.RejectChanges();
            nhanvien.Position = nhanvien.Position;
            bthuy.Enabled = false;
            btluu.Enabled = false;


        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            DataRow[] r = tbnhanvien.Select("MANV like'" + tbxtimkiem.Text + "*'");
            nhanvien.Position = (int)r[0]["STT"] - 1;

            nhanvien_PositonChanged(sender, e);
        }

        private void tbxtimkiem_Click(object sender, EventArgs e)
        {
            tbxtimkiem.Text = "";
        }
    }
}
