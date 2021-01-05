using phunz.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phunz.DAO
{
   public class BanAnDAO
    {
        
        public List<BanAnDTO> LayDanhSachBanAn()
        {
            string query = "select * from[Table]";

            string connectionString = "server=.; database=RestaurantManagement; Integrated Security = true;";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = query;

            connection.Open();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            connection.Close();
            connection.Dispose();

            List<BanAnDTO> danhsachban = new List<BanAnDTO>();
            foreach (DataRow row in table.Rows)
            {
                int id = Convert.ToInt32 (row["ID"]);
                string name = row["Name"].ToString();
                int status = Convert.ToInt32(row["Status"]);
                int capacity = Convert.ToInt32(row["Capacity"]);
                BanAnDTO phunz = new BanAnDTO(id, name, status, capacity);
                danhsachban.Add(phunz);
            }
            return danhsachban;
        }
        public bool ThemBanMoi(string name, int status, int capacity)
        {
            string query = String.Format("insert into [Table] values (N'{0}',{1},{2})",name,status,capacity);
            string connectionString = "server=.; database=RestaurantManagement; Integrated Security = true;";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = query;

            connection.Open();

            int ketQua = command.ExecuteNonQuery();

            connection.Close();
            connection.Dispose();

            if (ketQua > 0) return true;
            return false;

        }
        public bool SuaBanAn(int id, string name, int status, int capacity)  
        {
            string query = String.Format("update[Table] set Name = N'{0}' , Status = {1} , Capacity = {2} where ID = {3}",name,status,capacity,id);

            string connectionString = "server=.; database=RestaurantManagement; Integrated Security = true;";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = query;

            connection.Open();

            int ketQua = command.ExecuteNonQuery();

            connection.Close();
            connection.Dispose();
            if (ketQua > 0) return true;
            return false;
        }
    }
}
