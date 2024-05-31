using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LAB4_NHOM8
{
    public class RSAEncryption
    {
        private static RSACryptoServiceProvider csp;// = new RSACryptoServiceProvider(2048);
        private RSAParameters _privateKey;
        private RSAParameters _publicKey;

        public RSAEncryption()
        {
            csp = new RSACryptoServiceProvider(2048);
            _privateKey = csp.ExportParameters(true);
            _publicKey = csp.ExportParameters(false);
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

        public void SavePublicKey(string fileName)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                var xs = new XmlSerializer(typeof(RSAParameters));
                xs.Serialize(sw, _publicKey);
            }
        }

        public void LoadPrivateKey(string fileName)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            using (StreamReader sr = new StreamReader(filePath))
            {
                var xs = new XmlSerializer(typeof(RSAParameters));
                try
                {
                    _privateKey = (RSAParameters)xs.Deserialize(sr);
                }
                catch
                {
                    return;
                }
            }
        }

        public void LoadPublicKey(string fileName)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            using (StreamReader sr = new StreamReader(filePath))
            {
                var xs = new XmlSerializer(typeof(RSAParameters));
                _publicKey = (RSAParameters)xs.Deserialize(sr);
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

        public string Decrypt(string cypherText)
        {
            try
            {
                var dataBytes = Convert.FromBase64String(cypherText);
                csp.ImportParameters(_privateKey);
                var plainText = csp.Decrypt(dataBytes, false);
                return Encoding.Unicode.GetString(plainText);
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
