using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using System.Data.Common;
using System.IO;

namespace RaspV2
{
    class DAL
    {
        static string connectionString = @"Data Source=LAPTOP-LOQI\SQLEXPRESS; Initial catalog=rasp;Integrated Security=True;";
        SqlConnection sql1 = new SqlConnection(connectionString);
        
        public void openConnection()
        {
            if (sql1.State == System.Data.ConnectionState.Closed)
                sql1.Open();
        }
        public void closedConnection()
        {
            if (sql1.State == System.Data.ConnectionState.Open)
                sql1.Close();
        }
        public SqlConnection getConnect()
        {
            return sql1;
        }

        public ArrayList GetSchedule(string weekType, string day)
        {
            ArrayList list = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = String.Format($"SELECT * FROM РасписаниеВ WHERE Неделя = '{weekType}' AND День = '{day}'", con);
                SqlCommand com = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            list.Add(result);
                }
                catch { }
                return list;
            }
        }
        public ArrayList GetV()
        {
            ArrayList ocnV = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = String.Format("SELECT * FROM РасписаниеВ", con);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            ocnV.Add(result);
                }
                catch
                {

                }
            }
            return ocnV;
        }

        public ArrayList GetN()
        {
            ArrayList ocnN = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = String.Format("SELECT * FROM РасписаниеН", con);
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            ocnN.Add(result);
                }
                catch
                {

                }
            }
            return ocnN;
        }

        public bool SaveC(string Предмет, string Преподаватель, string Кабинет)//сохранение
        {
            bool flagResult = false;
            string query = string.Format("UPDATE Расписание([Предмет], [Преподаватель], [Кабинет] VALUES ('{0}', '{1}', '{2}')", Предмет, Преподаватель, Кабинет);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1)
                        flagResult = true;
                }
                catch
                {

                }
            }
            return flagResult;
        }
    }
}
