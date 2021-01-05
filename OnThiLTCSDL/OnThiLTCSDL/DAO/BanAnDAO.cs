using OnThiLTCSDL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThiLTCSDL.DAO
{
    public class BanAnDAO
    {
      public  List<BanAnDTO> LayDSBanAn()
        {
            string query = String.Format("select * from [Table]").ToString();
            string connectionString = "server=.; database=RestaurantManagement; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = query;
            sqlConnection.Open();
            
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            sqlConnection.Close();
            sqlConnection.Dispose();

            List<BanAnDTO> dsBanAn = new List<BanAnDTO>();
            foreach (DataRow row in dataTable.Rows)
            {
                
                int id = Convert.ToInt32(row["ID"]);
                string name = row["Name"].ToString();
                int status = Convert.ToInt32(row["Status"]);             
                int capacity = Convert.ToInt32(row["Capacity"]);
                BanAnDTO banAn = new BanAnDTO(id,name,status,capacity);
                dsBanAn.Add(banAn);
            }
            return dsBanAn;
        }
        public bool ThemBanAn(string name, int status, int capacity)
        {
            string query = String.Format("insert into [Table] values ('{0}',{1},{2})", name, status, capacity).ToString();
            string connectionString = "server=.; database=RestaurantManagement; Integrated Security = true; ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = query;
            connection.Open();
            int kq = cmd.ExecuteNonQuery();
           
            connection.Close();
            connection.Dispose();
            if (kq > 0) return true;
            return false;
        }
        public bool SuaBanAn(int id, string name, int status, int capacity)
        {
            string query = String.Format("update [Table] set Name = N'{0}', Status = {1}, Capacity = {2} where ID = {3}",name,status,capacity,id);
            string connectionString = "server=.; database=RestaurantManagement; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = query;
            sqlConnection.Open();
            int kQ = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            sqlConnection.Dispose();
            if (kQ == 0) return false;
            return true;
        }
    }
   
}
