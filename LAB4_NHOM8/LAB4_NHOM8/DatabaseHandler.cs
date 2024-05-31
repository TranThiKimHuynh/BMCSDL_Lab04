using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LAB4_NHOM8
{
    public class DatabaseHandler
    {
        private static string _connString = "";
        private static SqlConnection _conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=QLSVNhom;Integrated Security=True");

        public static bool Connect()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "(local)";
                builder.InitialCatalog = "QLSVNhom";
                builder.IntegratedSecurity = true;

                _connString = builder.ConnectionString;
                _conn = new SqlConnection(_connString);
                _conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối với cơ sở dữ liệu thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static bool IsSignIn(string username, string password)
        {
            try
            {
                Connect();
                string query = "EXEC SP_SEL_PUBLIC_ENCRYPT_NHANVIEN @TENDN, @MK";
                SqlDataAdapter sda = new SqlDataAdapter(query, _conn);
                sda.SelectCommand.Parameters.AddWithValue("@TENDN", username);
                sda.SelectCommand.Parameters.AddWithValue("@MK", password);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    _conn.Close();
                    return true;
                }

                _conn.Close();
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static DataTable GetNhanVienInfo()
        {
            _conn.Open();

            DataTable dt = new DataTable();
            string query = "SELECT MANV, HOTEN, EMAIL, LUONG FROM NHANVIEN";
            SqlDataAdapter sda = new SqlDataAdapter(query, _conn);
            sda.Fill(dt);

            _conn.Close();
            return dt;
        }

        public static string GetMANV(string username)
        {
            _conn.Open();
            string query = "SELECT MANV FROM NHANVIEN WHERE TENDN = @TENDN";
            SqlDataAdapter sda = new SqlDataAdapter(query, _conn);
            sda.SelectCommand.Parameters.AddWithValue("@TENDN", username);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            string res = dt.Rows[0][0].ToString();
            _conn.Close();
            return res;
        }

        public static void DeleteNhanVien(string maNV)
        {
            _conn.Open();
            string query = "EXEC SP_DEL_NHANVIEN @MANV";
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@MANV", maNV);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        public static void UpdateNhanVien(string maNV, string maNV_new, string hoTen, string eMail)
        {
            _conn.Open();
            string query = "EXEC SP_UPD_NHANVIEN @MANV, @MANV_NEW, @HOTEN, @EMAIL";
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@MANV", maNV);
            cmd.Parameters.AddWithValue("@MANV_NEW", maNV_new);
            cmd.Parameters.AddWithValue("@HOTEN", hoTen);
            cmd.Parameters.AddWithValue("@EMAIL", eMail);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        public static void InsertNhanVien(string maNV, string hoTen, string eMail, string luong, string tenDN, string mk, string pubKeyName)
        {
            _conn.Open();
            string query = "EXEC SP_INS_PUBLIC_ENCRYPT_NHANVIEN @MANV, @HOTEN, @EMAIL, @LUONG, @TENDN, @MK, @PUB";
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@MANV", maNV);
            cmd.Parameters.AddWithValue("@HOTEN", hoTen);
            cmd.Parameters.AddWithValue("@EMAIL", eMail);
            cmd.Parameters.AddWithValue("@LUONG", luong);
            cmd.Parameters.AddWithValue("@TENDN", tenDN);
            cmd.Parameters.AddWithValue("@MK", mk);
            cmd.Parameters.AddWithValue("@PUB", pubKeyName);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        public static DataTable GetLopInfo()
        {
            _conn.Open();

            DataTable dt = new DataTable();
            string query = "SELECT * FROM LOP";
            SqlDataAdapter sda = new SqlDataAdapter(query, _conn);
            sda.Fill(dt);

            _conn.Close();
            return dt;
        }

        public static void UpdateLop(string maLop, string nvQL)
        {
            _conn.Open();
            string query = "EXEC SP_UPD_NVQL_LOP @MALOP, @MANV";
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@MALOP", maLop);
            cmd.Parameters.AddWithValue("@MANV", nvQL);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        public static string GetNVQL(string malop)
        {
            _conn.Open();
            string query = "SELECT MANV FROM LOP WHERE MALOP = @MALOP";
            SqlDataAdapter sda = new SqlDataAdapter(query, _conn);
            sda.SelectCommand.Parameters.AddWithValue("@MALOP", malop);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            string res = dt.Rows[0][0].ToString();
            _conn.Close();
            return res;
        }

        public static DataTable GetSinhVienLopInfo(string malop)
        {
            _conn.Open();
            DataTable dt = new DataTable();
            string query = "SELECT MASV, HOTEN, CAST(NGAYSINH AS DATE), DIACHI FROM SINHVIEN WHERE MALOP=@MALOP";
            SqlDataAdapter sda = new SqlDataAdapter(query, _conn);
            sda.SelectCommand.Parameters.AddWithValue("@MALOP", malop);
            sda.Fill(dt);

            _conn.Close();
            return dt;
        }

        public static void UpdateSinhVien(string maSV, string maSV_new, string hoTen, string ngaySinh, string diaChi)
        {
            _conn.Open();
            
            string query = "EXEC SP_UPD_SINHVIEN @MASV, @MASV_NEW, @HOTEN, @NGAYSINH, @DIACHI";
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@MASV", maSV);
            cmd.Parameters.AddWithValue("@MASV_NEW", maSV_new);
            cmd.Parameters.AddWithValue("@HOTEN", hoTen);
            cmd.Parameters.AddWithValue("@NGAYSINH", ngaySinh);
            cmd.Parameters.AddWithValue("@DIACHI", diaChi);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        public static DataTable GetBangDiem(string masv)
        {
            _conn.Open();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM BANGDIEM WHERE MASV = @MASV";
            SqlDataAdapter sda = new SqlDataAdapter(query, _conn);
            sda.SelectCommand.Parameters.AddWithValue("@MASV", masv);
            sda.Fill(dt);

            _conn.Close();
            return dt;
        }

        public static void DeleteDiem(string maSV, string maHP)
        {
            _conn.Open();
            string query = "EXEC SP_DEL_BANGDIEM @MASV, @MAHP";
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@MASV", maSV);
            cmd.Parameters.AddWithValue("@MAHP", maHP);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        public static void InsertDiem(string maSV, string maHP, string diem_cipher)
        {
            _conn.Open();
            string query = "EXEC SP_INS_PUBLIC_ENCRYPT_BANGDIEM @MASV, @MAHP, @DIEM";
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@MASV", maSV);
            cmd.Parameters.AddWithValue("@MAHP", maHP);
            cmd.Parameters.AddWithValue("@DIEM", diem_cipher);
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
