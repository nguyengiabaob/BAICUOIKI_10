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
    public partial class formdangnhap : Form
    { formmain f = null;
        public formdangnhap()
        {
            InitializeComponent();
        }
        public formdangnhap(formmain frmain)
        {
            f = frmain;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            taikhoan tk = new taikhoan();
            var r = tk.Select("USERNAME='" + tbxtendangnhap.Text + "'and MATKHAU='" + tbxmatkhau.Text + "'");
            if (r.Count() > 0)

            { f.Text = "Xin Chào " + r[0]["TENNV"].ToString();
                f.enablebutton((int)r[0]["MAPHANQUYEN"]);
                this.OnClosed(e); }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }
       

        private void hyperlinkdangky_Click(object sender, EventArgs e)
        {
            Formdangky f = new Formdangky();
            f.ShowDialog();

            
        }

        private void btdangnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void formdangnhap_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (int)Keys.Enter)
            {
                btdangnhap_Click_1(sender, e);
            }
                
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

            
        }

        private void formdangnhap_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void hyperlinkquenmatkhau_Click(object sender, EventArgs e)
        {
            formmatkhau f = new formmatkhau();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void formdangnhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void formdangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
           // if (MessageBox.Show("bạn có muốn thoát khỏi chương trình ?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                //e.Cancel = true;
        }

        private void btdangnhap_Click_1(object sender, EventArgs e)
        {
            taikhoan tk = new taikhoan();
            var r = tk.Select("USERNAME='" + tbxtendangnhap.Text + "'and MATKHAU='" + tbxmatkhau.Text + "'");
            if (r.Count() > 0)

            {
                f.Text = "Xin Chào " + r[0]["TENNV"].ToString();
                f.enablebutton((int)r[0]["MAPHANQUYEN"]);
                this.Hide();
              
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void formdangnhap_Load_1(object sender, EventArgs e)
        {

        }

        private void hyperlinkdangky_Click_1(object sender, EventArgs e)
        {
            Formdangky f = new Formdangky();
            f.ShowDialog();

        }
    }
}
