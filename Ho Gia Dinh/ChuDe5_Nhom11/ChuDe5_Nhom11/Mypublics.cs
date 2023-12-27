using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuDe5_Nhom11
{
    public static class MyPublics
    {
        public static SqlDataAdapter daDataAdapter;
        public static SqlConnection conMyConnection;
        public static string strSTT, strQuyenSD, strDoiTuong,strMaTrinhDo, strMaHo,strMaAp, strMangheNghiep, strMaDoiTuong;

        public static void ConnectDatabase()
        {
            string strConn = "Server = PTEMMA\\SQLEXSPRESS;" +
               "Database = QL_HoGiaDinh; Integrated Security = false;" +
               "UID = TN207User; PWD = TN207User";
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

        public static void OpenData1(string strSelect,
            DataTable dtTable, SqlDataAdapter daDataAdapter)
        {
            try
            {
                if (conMyConnection.State == ConnectionState.Closed)
                    conMyConnection.Open();
                daDataAdapter.SelectCommand =
                    new SqlCommand(strSelect, conMyConnection);
                SqlCommandBuilder cmdCommanBuilder =
                    new SqlCommandBuilder(daDataAdapter);
                daDataAdapter.Fill(dtTable);
                conMyConnection.Close();
            }
            catch (Exception)
            {

            }
        }

        public static void OpenData(string strSelect, DataTable dtTable)
        {
            SqlDataAdapter daDataAdapter = new SqlDataAdapter();
            try
            {
                if (conMyConnection.State == ConnectionState.Closed)
                    conMyConnection.Open();
                daDataAdapter.SelectCommand =
                    new SqlCommand(strSelect, conMyConnection);
                daDataAdapter.Fill(dtTable);
                conMyConnection.Close();
            }
            catch (Exception)
            {
            }
        }

        public static bool TonTaiKhoaChinh(string strGiaTri, 
            string strTenTruong, string strTable)
        {
            bool blnRessult = false;
            try
            {
                string sqlSelect = "Select 1 From "
                    + strTable + " Where " + strTenTruong
                    + "='" + strGiaTri + "'";
                if (conMyConnection.State == ConnectionState.Closed)
                    conMyConnection.Open();
                SqlCommand cmdCommand = new SqlCommand(sqlSelect, conMyConnection);
                SqlDataReader drReader = cmdCommand.ExecuteReader();
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

        public static bool TonTaiKhoaChinh2(string strGiaTri1,
            string strTenTruong1, string strGiaTri2,
            string strTenTruong2, string strTable)
        {
            bool blnRessult = false;
            try
            {
                string sqlSelect = "Select 1 From "
                    + strTable + " Where " + strTenTruong1
                    + "='" + strGiaTri1 + "' and " + strTenTruong2
                    + "='" + strGiaTri2 + "'";
                if (conMyConnection.State == ConnectionState.Closed)
                    conMyConnection.Open();
                SqlCommand cmdCommand = new SqlCommand(sqlSelect, conMyConnection);
                SqlDataReader drReader = cmdCommand.ExecuteReader();
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

        //public static bool TonTaiKhoaChinh(int strGiaTri,
        //  string strTenTruong, string strTable)
        //{
        //    bool blnRessult = false;
        //    try
        //    {
        //        string sqlSelect = "Select 1 From "
        //            + strTable + " Where " + strTenTruong
        //            + "='" + strGiaTri + "'";
        //        if (conMyConnection.State == ConnectionState.Closed)
        //            conMyConnection.Open();
        //        SqlCommand cmdCommand = new SqlCommand(sqlSelect, conMyConnection);
        //        SqlDataReader drReader = cmdCommand.ExecuteReader();
        //        if (drReader.HasRows)
        //            blnRessult = true;
        //        drReader.Close();
        //        conMyConnection.Close();
        //    }
        //    catch (Exception)
        //    {

        //    }
        //    return blnRessult;
        //}

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
        public static bool TonTaiKhoaChinh(string[] strGiaTri, string[] strTenTruong, string strTable)
        {
            bool blnRessult = false;
            try
            {
                string sqlSelect = "Select 1 From "
                    + strTable + " Where ";
                int i = 0;
                string strTemp = "";
                for(; i < strGiaTri.Length; i++)
                {
                    strTemp = strTemp + strTenTruong[i] + "='" + strGiaTri[i] + "'";
                    if (i != strGiaTri.Length - 1) strTemp += " and ";
                }
                sqlSelect += strTemp;
                if (conMyConnection.State == ConnectionState.Closed)
                    conMyConnection.Open();
                SqlCommand cmdCommand = new SqlCommand(sqlSelect, conMyConnection);
                SqlDataReader drReader = cmdCommand.ExecuteReader();
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
    }
}
