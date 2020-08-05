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
    public partial class Formdangky : Form
    {
        taikhoan tk = new taikhoan();
        Bangnhanvien tbnhanvien = new Bangnhanvien();
        int c = 0;
        public Formdangky()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            if (tbxmanhanvien.Text==""||tbxhoten.Text==""||tbxtendangnhap.Text=="")
            {
                c = 1;
                MessageBox.Show("Thông tin yêu cầu chưa nhập đầy đủ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
           
            //DataRow[] u = tbnhanvien.Select("MANV='" + tbxmanhanvien.Text + "'");
            //DataRow[] d = tbnhanvien.Select("HOTENNV='" + tbxhoten.Text + "'");
            //if (u.Count() == 0 || d.Count() == 0)
            //{
            //    c = 1;
            //    MessageBox.Show("Mã nhân viên hoặc họ tên không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
              if (c == 0&&check()==true)
            {
                int a = 0;
                DataRow r = tk.NewRow();
                r["MANV"] = tbxmanhanvien.Text;
                r["TENNV"] = tbxhoten.Text;
                r["USERNAME"] = tbxtendangnhap.Text;
                r["MAPHANQUYEN"] = DBNull.Value;
                errorProvider1.SetError(tbxmatkhau, "");
                errorProvider1.SetError(tbxnhaplaimatkhau, "");
                if (tbxmatkhau.Text.Length < 8 || (tbxmatkhau.Text.Any(char.IsDigit)==false) || (tbxmatkhau.Text.Any(char.IsLower) == false) || (tbxmatkhau.Text.Any(char.IsUpper) == false))
                {
                    errorProvider1.SetError(tbxmatkhau, "Mật khẩu mới gồm 8 kí tự,gồm chữ số," + "in hoa in thường");
                    a = 1;
                    return;
                }
                if (tbxmatkhau.Text != tbxnhaplaimatkhau.Text)
                {
                    errorProvider1.SetError(tbxnhaplaimatkhau, "Mật khẩu nhập lại không trùng");
                    a = 2;
                    return;

                }
                if (a == 0)
                {
                    r["MATKHAU"] = tbxmatkhau.Text;
                    tk.Rows.Add(r);
                    try
                    {
                        
                        if(tk.ghi())
                        {
                            MessageBox.Show("Chúc mừng bạn đăng ký thành công","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        //private int checkmk(int t)
        //{
        //    t = 0;
        //    dxErrorProvider1.SetError(tbxmatkhau,"");
        //    dxErrorProvider1.SetError(tbxnhaplaimatkhau,"");
        //    if (tbxmatkhau.Text.Length < 8 || (tbxmatkhau.Text.Any(char.IsDigit)) || (tbxmatkhau.Text.Any(char.IsLower)) || (tbxmatkhau.Text.Any(char.IsUpper)))
        //    {
        //        dxErrorProvider1.SetError(tbxmatkhau, "Mật khẩu mới gồm 8 kí tự,gồm chữ số," + "in hoa in thường");
        //        t = 1;
                
        //    }
        //    if (tbxmatkhau.Text != tbxnhaplaimatkhau.Text)
        //    {
        //        dxErrorProvider1.SetError(tbxnhaplaimatkhau, "Mật khẩu nhập lại không trùng");
        //        t = 2;
              

        //    }
        //    return t;
        //}
        private bool check()
        {
            bool b = true;
            DataRow[] r = tbnhanvien.Select("MANV='" + tbxmanhanvien.Text +"'");
            DataRow[] d = tbnhanvien.Select("HOTENNV='" + tbxhoten.Text + "'");
            if(r.Count()==0||d.Count()==0)
            {
                
                MessageBox.Show("Mã nhân viên hoặc họ tên không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                b= false;
            }
            return b;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
