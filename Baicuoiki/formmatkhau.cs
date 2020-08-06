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
    public partial class formmatkhau : Form
    { Bangnhanvien tbnhavien = new Bangnhanvien();
        taikhoan tk = new taikhoan();
        public formmatkhau()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int t = 0;
            if(tbxmanhanvien.Text=="")
            {
                t = 1;
                MessageBox.Show("Thông tin yêu cầu chưa nhập đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (t == 0)
            {
                DataRow[] r = tk.Select("MANV='" + tbxmanhanvien.Text + "'");
                if (r.Count() > 0)
                {
                    MessageBox.Show("Mật khẩu là:" + r[0]["MATKHAU"].ToString() + "");
                }
                else
                    MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close()
        }
    }
}
