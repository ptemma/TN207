using System;
using System.Collections.Generic;
using System.Data;
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
            + "Integrated Security = false; UID = TN207User; PWD = TN207User";
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
        public static void openData(String strSelect, DataTable dtTable)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            try
            {
                if (conMyConnection.State == ConnectionState.Closed)
                    conMyConnection.Open();
                dataAdapter.SelectCommand = new SqlCommand(strSelect, conMyConnection);
                dataAdapter.Fill(dtTable);

                conMyConnection.Close();
            }
            catch (Exception e)
            {
            }
        }

        public static bool tonTaiKhoaChinh(String strGiaTri, String strTenTruong, String strTenBang)
        {
            bool blnTonTai = false ;
            try
            {
                String sqllect = "select 1 from " + strTenBang + " where " + strTenTruong + "='" + strGiaTri + "'";
                if (conMyConnection.State == ConnectionState.Closed)
                    conMyConnection.Open();

                SqlCommand cmdCommand = new SqlCommand(sqllect, conMyConnection);
                SqlDataReader drReader = cmdCommand.ExecuteReader();
                if (drReader.HasRows)
                    blnTonTai = true;
                drReader.Close();
                conMyConnection.Close();
            }
            catch(Exception)
            {

            }
            return blnTonTai;
        }


    }
}
