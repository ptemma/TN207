using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapTN207
{
    public static class MyPublics
    {
        public static SqlConnection conMyConnection;
        public static string strMaCB, strQuyenSD, strDonVi, strChuongTrinh, strTietMuc;
        public static void ConnectDatabase()
        {
            string strConn = "Server = PTEMMA\\SQLEXSPRESS; Database = QL_HoiDienVanNghe; Integrated Security = false; UID = TN207User; PWD = TN207User";
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

        public static void OpenData(string strSelect, DataTable dtTable)
        {
            SqlDataAdapter daDataAdapter;
            try
            {
                if (conMyConnection.State == ConnectionState.Closed)
                    conMyConnection.Open();
                daDataAdapter = new SqlDataAdapter(strSelect, conMyConnection);
                daDataAdapter.Fill(dtTable);
                conMyConnection.Close();
            }
            catch (Exception)
            {
            }
        }

        public static bool TonTaiKhoaChinh(string strGiaTri, string strTenTruong, string strTable)
        {
            SqlCommand cmdCommand;
            SqlDataReader drReader;
            string sqlSelect;
            bool blnRessult = false;
            try
            {
                sqlSelect = "Select 1 From " + strTable + " Where " + strTenTruong + "='" + strGiaTri + "'";
                if (conMyConnection.State == ConnectionState.Closed)
                    conMyConnection.Open();
                cmdCommand = new SqlCommand(sqlSelect, conMyConnection);
                drReader = cmdCommand.ExecuteReader();
                if (drReader.HasRows)
                    blnRessult = true;
                drReader.Close();
                conMyConnection.Close();
            }
            catch (Exception)
            {
            }
            return blnRessult;
        }

        public static string MaHoaPassword(string strPassword)
        {
            string strTemp1 = "", strTemp2 = "";
            int i, n;
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
