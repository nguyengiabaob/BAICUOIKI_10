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
            DataRow[] r = tk.Select("MANV='" + tbxmanhanvien.Text + "'");
            if (r.Count() > 0)
            {
                MessageBox.Show("Mật khẩu là:" + r[0]["MATKHAU"].ToString() + "");
            }
            else
                MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
