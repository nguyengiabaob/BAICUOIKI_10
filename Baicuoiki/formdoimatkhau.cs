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
    public partial class formdoimatkhau : Form
    { taikhoan TK = new taikhoan();
        public formdoimatkhau()
        {
            InitializeComponent();
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        { int T = 0;
            if(check()==true)
                checkmk(T);
                if(T==0)
            {
                DOIMAK();
            }


        }
        private void checkmk(int t)
        {
            t = 0;
            dxErrorProvider1.SetError(tbxmatkhau, "");
            dxErrorProvider1.SetError(tbxxacnhanmatkhau, "");
            if (tbxmatkhau.Text.Length < 8 || (tbxmatkhau.Text.Any(char.IsDigit)) || (tbxmatkhau.Text.Any(char.IsLower)) || (tbxmatkhau.Text.Any(char.IsUpper)))
            {
                dxErrorProvider1.SetError(tbxmatkhau, "Mật khẩu mới gồm 8 kí tự,gồm chữ số," + "in hoa in thường");
                t = 1;
                return;
            }
            if (tbxmatkhau.Text != tbxxacnhanmatkhau.Text)
            {
                dxErrorProvider1.SetError(tbxxacnhanmatkhau, "Mật khẩu nhập lại không trủng");
                t = 2;
                return;

            }
            
            }
        private bool check()
        {
            bool b = true;
            DataRow[] r = TK.Select("MANV='" + tbxmanhanvien.Text + "'");

            if (r.Count() == 0)
            {

                MessageBox.Show("Mã nhân viên không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return b;

        }
        private void DOIMAK()
        {
            DataRow[] r = TK.Select("MANV='" + tbxmanhanvien.Text + "'");
            if(r.Count()>0)
            {
                r[0]["MATKHAU"] = tbxmatkhau.Text;
                TK.ghi();
                if (TK.ghi() == true)
                    MessageBox.Show("Mật khẩu đã được đổi");
            }
        }
    }
}
