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
    public partial class FormQLDH : Form
    {

        string strConnect = @"Data Source=DESKTOP-Q6N4J46\SQLEXPRESS;Initial Catalog=BANHANG;Integrated Security=True";
        SqlConnection sqlConnect = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;


        List<string> Ds_kh;
        List<string> Ds_sp;

        public FormQLDH()
        {
            InitializeComponent();
        }

        void load_DSKH()
        {
            Ds_kh = new List<string>();

            if (sqlConnect == null)
            {
                sqlConnect = new SqlConnection(strConnect);
            }

            if (sqlConnect.State == ConnectionState.Closed)
            {
                sqlConnect.Open();
            }

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT MaKH FROM KhachHang";

            sqlCmd.Connection = sqlConnect;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string makh = reader.GetString(0);
                Ds_kh.Add(makh);
            }

            reader.Close();
            cmb_makh.DataSource = Ds_kh;
        }

        void load_DSSP()
        {
            Ds_sp = new List<string>();

            if (sqlConnect == null)
            {
                sqlConnect = new SqlConnection(strConnect);
            }

            if (sqlConnect.State == ConnectionState.Closed)
            {
                sqlConnect.Open();
            }

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT MaSP FROM SanPham";

            sqlCmd.Connection = sqlConnect;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string masp = reader.GetString(0);
                Ds_sp.Add(masp);
            }

            reader.Close();
            cmbDsSP.DataSource =Ds_sp ;
        }

        private void FormQLDH_Load(object sender, EventArgs e)
        {
            load_DSKH();
            load_DSSP();
        }

        private void btn_themHD_Click(object sender, EventArgs e)
        {
            if (sqlConnect == null)
            {
                sqlConnect = new SqlConnection(strConnect);
            }

            if (sqlConnect.State == ConnectionState.Closed)
            {
                sqlConnect.Open();
            }

            string ma_hd = txt_mahd.Text;
            string makh = cmb_makh.Text;
            
            

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = $"INSERT INTO HoaDon VALUES('{ma_hd}','{makh}','{DateTime.Now.ToString("MM/dd/yyyy")}',null)";

            sqlCmd.Connection = sqlConnect;

            
            try
            {
                int kq = sqlCmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show( "Đã thêm hóa đơn mới thành công", "Thông báo");
                }

            }
            catch(Exception ex) {
                MessageBox.Show("Thêm hóa đơn không thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void txt_mahd_TextChanged(object sender, EventArgs e)
        {
            txt_mahd1.Text = txt_mahd.Text;
        }

        private void btn_themCT_HD_Click(object sender, EventArgs e)
        {
            if (sqlConnect == null)
            {
                sqlConnect = new SqlConnection(strConnect);
            }

            if (sqlConnect.State == ConnectionState.Closed)
            {
                sqlConnect.Open();
            }

            string ma_hd = txt_mahd.Text;
            string masp = cmbDsSP.SelectedItem.ToString();
            float soluong = (float)Convert.ToDouble(txtSoluong.Text);
            float giaban = (float)Convert.ToDouble(txtGiaban.Text);
            float giagiam = (float)Convert.ToDouble(txtGiagiam.Text);



            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = $"INSERT INTO CT_HoaDon VALUES('{ma_hd}','{masp}',{soluong},{giaban},{giagiam},{soluong*(giaban-giagiam)})";

            sqlCmd.Connection = sqlConnect;

            
            try
            {
                int kq = sqlCmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Đã thêm chi tiết hóa đơn mới thành công", "Thông báo");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã sản phẩm và mã đơn hàng đã tồn tại. Vui lòng nhập giá trị khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtSoluong.Clear();
            txtGiaban.Clear();
            txtGiagiam.Clear();

            txtSoluong.Focus();
          
        }
                
        private void btn_XemDoanhthu_Click(object sender, EventArgs e)
        {
            if(sqlConnect == null)
            {
                sqlConnect = new SqlConnection(strConnect);
            }
            if(sqlConnect.State == ConnectionState.Closed)
            {
                sqlConnect.Open();
            }


            if(cmbThang.Text.Trim() != "" && cmbNam.Text.Trim() != "")
            {
                int nam = int.Parse(cmbNam.SelectedItem.ToString().Trim());
                int thang = int.Parse(cmbThang.SelectedItem.ToString().Trim());

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = $"SELECT SUM(TongTien) FROM HOADON WHERE YEAR(NgayLap) = {nam} AND MONTH(NgayLap) = {thang}";

                sqlCmd.Connection = sqlConnect;

                object TongDoanhThu = sqlCmd.ExecuteScalar();
                
                if (TongDoanhThu.ToString().Trim() == "")
                {
                    MessageBox.Show($"Không có hóa đơn nào trong tháng {thang}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    txtDoanhthu.Text = TongDoanhThu.ToString();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tháng và năm trước khi muốn xem doanh thu", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void btn_XemDanhSach_Click(object sender, EventArgs e)
        {
            if (sqlConnect == null)
            {
                sqlConnect = new SqlConnection(strConnect);
            }


            string queryStr = "SELECT * FROM HoaDon";
            adapter = new SqlDataAdapter(queryStr, sqlConnect);

            ds = new DataSet();
            adapter.Fill(ds, "dboHoadon");

          
            dgvDanhSach.DataSource = ds.Tables["dboHoadon"];
            
        }

        private void ts_dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban có thực sự muốn thoát không?", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
