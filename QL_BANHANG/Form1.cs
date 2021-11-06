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


namespace QL_BANHANG
{
    public partial class Form1 : Form
    {
        string strConnect = @"Data Source=DESKTOP-Q6N4J46\SQLEXPRESS;Initial Catalog=BANHANG;Integrated Security=True";
        SqlConnection sqlConnect = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban có thực sự muốn thoát không?", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Dangnhap_Click(object sender, EventArgs e)
        {
          
            if(sqlConnect == null)
            {
                sqlConnect = new SqlConnection(strConnect);
            }

            if(sqlConnect.State == ConnectionState.Closed)
            {
                sqlConnect.Open();
            }

            string tenDN = txtTenDN.Text;
            string matKhau = txtMatkh.Text;
            

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT TENDANGNHAP, MATKHAU FROM NGUOIDUNG";

            sqlCmd.Connection = sqlConnect;

            SqlDataReader reader = sqlCmd.ExecuteReader();

            bool isValid = false;
            while (reader.Read())
            {
                string tendn = reader.GetString(0).Trim();
                string matkhau = reader.GetString(1).Trim();
                
                if (tenDN == tendn && matKhau == matkhau)
                {
                    isValid = true;
                    break;
                }
            }
            reader.Close();
            if(isValid == true)
            {
                FormQLDH frm = new FormQLDH();
                frm.Show();

            }
            else
            {
                MessageBox.Show( "Tên đăng nhập hoặc mật khẩu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatkh.Clear();
                txtTenDN.Clear();
                txtTenDN.Focus();
            }



        }
    }
}
