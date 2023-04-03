using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Sisbro_LIB
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;

        #region Constructors
        public Koneksi()
        {
            //buka konfigurasi App.Config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSectionGroup configGroup = config.SectionGroups["userSettings"];

            var configSections = configGroup.Sections["ProjectDB_DiBaApps.db"] as ClientSettingsSection;

            //ambil tiap variabel setting
            string host = configSections.Settings.Get("hostName").Value.ValueXml.InnerText;
            string db = configSections.Settings.Get("dbName").Value.ValueXml.InnerText;
            string uid = configSections.Settings.Get("uid").Value.ValueXml.InnerText;
            string pwd = configSections.Settings.Get("password").Value.ValueXml.InnerText;

            string strConn = "server=" + host + ";database=" + db + ";uid=" + uid + ";password=" + pwd;
            koneksiDB = new MySqlConnection();
            koneksiDB.ConnectionString = strConn;

            Connect();
        }

        public Koneksi(string hostName, string dbName, string username, string password)
        {
            string strConn = "server=" + hostName + ";database=" + dbName + ";uid=" + username + ";password=" + password;
            koneksiDB = new MySqlConnection();
            koneksiDB.ConnectionString = strConn;

            Connect();
        }
        #endregion

        #region Properties
        public MySqlConnection KoneksiDB { get => koneksiDB; set => koneksiDB = value; }
        #endregion

        #region Method
        public void Connect()
        {
            if (koneksiDB.State == System.Data.ConnectionState.Closed)
            {
                koneksiDB.Open();
            }
        }

        public void Disconnect()
        {
            if (koneksiDB.State == System.Data.ConnectionState.Open)
            {
                koneksiDB.Close();
            }
        }

        public static MySqlDataReader AmbilData(string sql)
        {
            Koneksi connection = new Koneksi();
            MySqlCommand command = new MySqlCommand(sql, connection.KoneksiDB);
            MySqlDataReader result = command.ExecuteReader();
            return result;
        }

        public static bool ExecuteDML(string sql)
        {
            Koneksi connection = new Koneksi();
            MySqlCommand command = new MySqlCommand(sql, connection.KoneksiDB);
            int result = command.ExecuteNonQuery();

            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
