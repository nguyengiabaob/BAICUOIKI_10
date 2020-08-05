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
            if(tbxmatkhau.Text==""||tbxxacnhanmatkhau.Text=="")
            {
                T = 3;
                MessageBox.Show("Thông tin yêu cầu chưa nhập đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (T == 0)
            {
                if (check() == true)
                  
                dxErrorProvider1.SetError(tbxmatkhau, "");
                dxErrorProvider1.SetError(tbxxacnhanmatkhau, "");
                if (tbxmatkhau.Text.Length < 8 || (tbxmatkhau.Text.Any(char.IsDigit)==false) || (tbxmatkhau.Text.Any(char.IsLower)==false) || (tbxmatkhau.Text.Any(char.IsUpper)==false))
                {
                    dxErrorProvider1.SetError(tbxmatkhau, "Mật khẩu mới gồm 8 kí tự,gồm chữ số," + "in hoa in thường");
                    T = 1;
                    return;
                }
                if (tbxmatkhau.Text != tbxxacnhanmatkhau.Text)
                {
                    dxErrorProvider1.SetError(tbxxacnhanmatkhau, "Mật khẩu nhập lại không trủng");
                    T = 2;
                    return;
                }
                if (T == 0)
                {
                    DOIMAK();
                }
            }

        }
        //private void checkmk(int t)
        //{
        //    t = 0;
        //    dxErrorProvider1.SetError(tbxmatkhau, "");
        //    dxErrorProvider1.SetError(tbxxacnhanmatkhau, "");
        //    if (tbxmatkhau.Text.Length < 8 || (tbxmatkhau.Text.Any(char.IsDigit)) || (tbxmatkhau.Text.Any(char.IsLower)) || (tbxmatkhau.Text.Any(char.IsUpper)))
        //    {
        //        dxErrorProvider1.SetError(tbxmatkhau, "Mật khẩu mới gồm 8 kí tự,gồm chữ số," + "in hoa in thường");
        //        t = 1;
        //        return;
        //    }
        //    if (tbxmatkhau.Text != tbxxacnhanmatkhau.Text)
        //    {
        //        dxErrorProvider1.SetError(tbxxacnhanmatkhau, "Mật khẩu nhập lại không trủng");
        //        t = 2;
        //        return;

        //    }
            
        //    }
        private bool check()
        {
            bool b = true;
            DataRow[] r = TK.Select("MANV='" + Bang.Bang.manhanvien + "'");

            if (r.Count() == 0)
            {

                MessageBox.Show("Mã nhân viên không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                b = false;
            }
            return b;

        }
        private void DOIMAK()
        {
            int t = 0;
            DataRow[] r = TK.Select("MANV='" + Bang.Bang.manhanvien + "'");
            DataRow[] d = TK.Select("MATKHAU='" + tbxmatkhau.Text + "'");
            if(d.Count()>=1)
            {
                MessageBox.Show("Mật khẩu mới trùng mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t = 1;
            }
            if (r.Count()>0&&t==0)
            {
                r[0]["MATKHAU"] = tbxmatkhau.Text;
                if (TK.ghi() == true)
                    MessageBox.Show("Mật khẩu đã được đổi","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
