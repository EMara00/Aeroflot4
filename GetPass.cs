using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroport
{
    public static class GetPass
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataBaseAeport.mdf;Integrated Security=True";
        public static DataTable getNotes(int userid)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("SELECT Id, Familia, Name, Otchestvo, Document, Nomer, Grazdanstvo, Compania, Class, StrOtpr, DateTime, StrPrib FROM Information", sqlConnection);

            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);
            sqlConnection.Close();

            return table;

            //DataSet ds2 = new DataSet();
            //SqlConnection dataBaseConnection = new SqlConnection(connectionString);
            //SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Id, Familia, Name, Otchestvo, Document, Nomer, Grazdanstvo, Compania, Class, StrOtpr, DateTime, StrPrib FROM Information", dataBaseConnection);
            ////Вторым параметром ты присваиваешь имя для текущей таблицы в датасете
            //dataAdapter.Fill(ds2, "Information");
            ////Здесь указываешь имя нужной таблицы            
            //dataGridView1.DataSource = ds2.Tables["Information"];
        }

    }
}
