using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace Lab04_Nhom

{
    public class RsaEncryption
    {
        private static RSACryptoServiceProvider csp;
        private RSAParameters _privateKey;
        private RSAParameters _publicKey;

        public RsaEncryption()
        {
            csp = new RSACryptoServiceProvider();
            _privateKey = csp.ExportParameters(true);
            _publicKey = csp.ExportParameters(false);

        }
        public string GetPublicKey()
        {
            // Serialize RSAParameters to byte array
            using (MemoryStream ms = new MemoryStream())
            {
                var xs = new XmlSerializer(typeof(RSAParameters));
                xs.Serialize(ms, _publicKey);
                byte[] publicKeyBytes = ms.ToArray();

                // Convert byte array to Base64 string
                string publicKeyBase64 = Convert.ToBase64String(publicKeyBytes);
                return publicKeyBase64;
            }
        }

        public string Encrypt(string plainText)
        {
            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(_publicKey);
            var data = Encoding.Unicode.GetBytes(plainText);
            var cypher = csp.Encrypt(data, false);
            return Convert.ToBase64String(cypher);

        }
        public string Decrypt(string cipherText) 
        {
            var dataBytes = Convert.FromBase64String(cipherText);
            csp.ImportParameters(_privateKey);
            var plainText = csp.Decrypt(dataBytes, false);
            return Encoding.Unicode.GetString(plainText);

        }
        public void SavePrivateKey(string fileName)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                var xs = new XmlSerializer(typeof(RSAParameters));
                xs.Serialize(sw, _privateKey);
            }
        }

        public void LoadPrivateKey(string fileName)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            using (StreamReader sr = new StreamReader(filePath))
            {
                var xs = new XmlSerializer(typeof(RSAParameters));
                _privateKey = (RSAParameters)xs.Deserialize(sr);
            }
        }

    }
    public partial class ManagerStaffForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EO2BETF\YENVY;Initial Catalog=QLSVNhom;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt = new DataTable();
        // Generate RSA key pair and store public in in string
        RsaEncryption rsa = new RsaEncryption();

        public string username { get; set; }
        public string password { get; set; }
        bool isAdmin = false;

       

        public ManagerStaffForm()
        {
            InitializeComponent();


        }


        private bool isSysAdmin(string username, string password)
        {

            if (username == "ADMIN")
            {

                try
                {
                    conn.Open();

                    String querry = "SELECT * FROM NHANVIEN WHERE TENDN = 'ADMIN' AND MATKHAU = '" + password + "'";

                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        isAdmin = true;
                    }



                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                isAdmin = false;
            }
            return isAdmin;
        }
        public static string CalculateSHA1Hash(string input)
        {
            SHA1 sha1 = SHA1.Create();
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hash = sha1.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

       

        private void bnt_Save_Click(object sender, EventArgs e)
        {


            rsa = new RsaEncryption();

            if (txt_manv.Text != null && txt_hoten.Text != null && txt_email.Text != null && txt_luong.Text != null && txt_tendn.Text != null && txt_mk.Text != null)
            {
                try
                {
                    DialogResult res;

                    res = MessageBox.Show("Do you want to add and save this Staff's Information ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {

                        String pub = rsa.GetPublicKey();

                        // Encrypt Luong using the public key
                        String encryptLuong = rsa.Encrypt(txt_luong.Text);
                        String privateKeyFile = txt_tendn.Text + "_" + CalculateSHA1Hash(txt_mk.Text);

                        // Save private key in privateKey.pem
                        rsa.SavePrivateKey(privateKeyFile + ".pem");

                    

                     

                        conn.Open();

                        cmd = new SqlCommand("EXEC SP_INS_PUBLIC_ENCRYPT_NHANVIEN @manv, @hoten, @email, @luong, @tendn, @matkhau, @pub", conn);

                        cmd.Parameters.AddWithValue("@manv", txt_manv.Text);
                        cmd.Parameters.AddWithValue("@hoten", txt_hoten.Text);
                        cmd.Parameters.AddWithValue("@email", txt_email.Text);
                        cmd.Parameters.AddWithValue("@luong", encryptLuong);
                        cmd.Parameters.AddWithValue("@tendn", txt_tendn.Text);
                        cmd.Parameters.AddWithValue("@matkhau", CalculateSHA1Hash(txt_mk.Text));
                        cmd.Parameters.AddWithValue("@pub", pub);

                        cmd.ExecuteNonQuery();

                        conn.Close();

                        // Xóa dữ liệu trong DataTable
                        dt.Clear();

                        // Làm mới DataGridView
                        DisplayClassData();


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

       



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy giá trị của ô cell đầu tiên của dòng hiện tại
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Kiểm tra xem người dùng đã chọn một ô hợp lệ chưa
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                string nvID = selectedRow.Cells[0].Value.ToString();
                string nvName = selectedRow.Cells[1].Value.ToString();
                string nvEmail = selectedRow.Cells[2].Value.ToString();
                String tendn = "";
                String luong = "";
                String mk = "";

                txt_manv.Text = nvID;
                txt_hoten.Text = nvName;
                txt_email.Text = nvEmail;

                txt_luong.Text = "********";
                txt_tendn.Text = "********";
                txt_mk.Text = "********";

                try
                {
                    conn.Open();

                    // Execute query to get TENDN from NHANVIEN table
                    cmd = new SqlCommand("SELECT TENDN FROM NHANVIEN WHERE MANV = @nvID", conn);
                    cmd.Parameters.AddWithValue("@nvID", nvID);

                    // ExecuteScalar() to get the single value
                    tendn = cmd.ExecuteScalar()?.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                if (tendn == username)
                {

                    try
                    {
                        conn.Open();

                        // Execute query to get TENDN and PUB from NHANVIEN table
                        cmd = new SqlCommand("SELECT TENDN,LUONG, MATKHAU FROM NHANVIEN WHERE MANV = @nvID", conn);
                        cmd.Parameters.AddWithValue("@nvID", nvID);

                        // ExecuteReader to retrieve multiple columns
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            // Get TENDN
                            txt_tendn.Text = reader["TENDN"].ToString();

                            // Get TENDN
                            luong = reader["LUONG"].ToString();

                            // Get MATKHAU
                            mk = reader["MATKHAU"].ToString() ;


                            // Read private key from password.pem and decrypt Luong to check it 


                            String privateKeyFile = tendn + "_" + mk;
                            rsa = new RsaEncryption();

                            rsa.LoadPrivateKey(privateKeyFile + ".pem");
                            String decryptLuong = rsa.Decrypt(luong);
                            txt_luong.Text = decryptLuong;


                            reader.Close();
                        }
                        else
                        {
                            MessageBox.Show("Nhân viên không tồn tại trong cơ sở dữ liệu.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void bnt_Exit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ManagerStaffForm_Load(object sender, EventArgs e)
        {
            DisplayClassData();

            isAdmin = isSysAdmin(username, password);
         
            if (!isAdmin)
            {
                btn_Add.Enabled = false;
                btn_Save.Enabled = false;

            }
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);
        }
        public void DisplayClassData()
        {
            try
            {
                conn.Open();

                cmd = new SqlCommand("SELECT MANV, HOTEN, EMAIL FROM NHANVIEN ", conn);

                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);

     

                dataGridView1.DataSource = dt;
                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            txt_manv.Clear();
            txt_hoten.Clear();
            txt_email.Clear();
            txt_luong.Clear();
            txt_tendn.Clear();
            txt_mk.Clear();

            txt_manv.Focus();
        }
    }
}
