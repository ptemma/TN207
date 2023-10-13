using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_SinhVien
{
    public static class MyPublics
    {
        public static SqlConnection conMyConnection;
        public static string strMSSV, strLop, strQuyenSD, strHK, strNK;
        public static void ConnectDatabase()
        {
            string strConn = "Server = PTEMMA\\SQLEXSPRESS;  Database = QL_SinhVien; "
            +"Integrated Security = false; UID = TN207User; PWD = TN207User";
            conMyConnection = new SqlConnection();
            conMyConnection.ConnectionString = strConn;
            try
            {
                conMyConnection.Open();
            }
            catch (Exception)
            {
            }
        }
        public static string MaHoaPassword(string strPassword)
        {
            string strTemp1, strTemp2;
            int i, n;
            strTemp1 = "";
            strTemp2 = "";
            n = strPassword.Length;
            for (i = 0; i < n; i = i + 2)
            {
                strTemp1 += strPassword[i];
                if (n > i + 1)
                    strTemp2 += strPassword[i + 1];
            }
            return (strTemp1 + strTemp2);
        }

    }
}
