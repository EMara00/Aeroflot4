﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aeroport.NewFolder1;

namespace Aeroport
{
    class AddPass
    {
    
        SqlConnection sqlConnection;

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lizam\OneDrive\Документы\OOPKursovik\Aeroport\DataBaseAeport.mdf;Integrated Security=True";

        public bool AddNotes(string familia, string name, string otchestvo, string document, string nomer, string grazdanstvo, string compania, string class_, string strOtpr, string dateTime, string strPrib, int userid)
        {


            sqlConnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand("INSERT INTO Information VALUES (@Familia, @Name, @Otchestvo, @Document, @Nomer, @Grazdanstvo, @Compania, @Class, @StrOtpr, @DateTime, @StrPrib, @UserId)", sqlConnection);

            command.Parameters.AddWithValue("@Familia", familia);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Otchestvo", otchestvo);
            command.Parameters.AddWithValue("@Document", document);
            command.Parameters.AddWithValue("@Nomer", nomer);
            command.Parameters.AddWithValue("@Grazdanstvo", grazdanstvo);
            command.Parameters.AddWithValue("@Compania", compania);
            command.Parameters.AddWithValue("@Class", class_);
            command.Parameters.AddWithValue("@StrOtpr", strOtpr);
            command.Parameters.AddWithValue("@DateTime", dateTime);
            command.Parameters.AddWithValue("@StrPrib", strPrib);

            command.Parameters.Add("@UserId", SqlDbType.Int).Value = userid;

            sqlConnection.Open();

            command.ExecuteNonQuery();

            return true;



        }

        public void AddPassajira(Passenger2DBContext db)
        {
            foreach (var pass in db.Passengers)
            {
                sqlConnection = new SqlConnection(connectionString);

                SqlCommand command = new SqlCommand("INSERT INTO Information VALUES (@Familia, @Name, @Otchestvo, @Document, @Nomer, @Grazdanstvo, @Compania, @Class, @StrOtpr, @DateTime, @StrPrib)", sqlConnection);

                command.Parameters.AddWithValue("@Id", pass.ID);
                command.Parameters.AddWithValue("@Familia", pass.Lastname);
                command.Parameters.AddWithValue("@Name", pass.Firstname);
                command.Parameters.AddWithValue("@Otchestvo", pass.Middlename);
                command.Parameters.AddWithValue("@Document", pass.Document);
                command.Parameters.AddWithValue("@Nomer", pass.SerialNumber);
                command.Parameters.AddWithValue("@Grazdanstvo", pass.Citizenship);
                command.Parameters.AddWithValue("@Compania", pass.Company);
                command.Parameters.AddWithValue("@Class", pass.Class);
                command.Parameters.AddWithValue("@StrOtpr", pass.ContryCityFrom);
                command.Parameters.AddWithValue("@DateTime", pass.DateTimeFrom);
                command.Parameters.AddWithValue("@StrPrib", pass.ContryCityTo);

                //command.Parameters.Add("@UserId", SqlDbType.Int).Value = pass.ID;

                sqlConnection.Open();

                command.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }

        public bool CheckPassExist(Passenger2 pass)
        {
            sqlConnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(
@"Select *
From Information
Where Familia = @Familia
and Name = @Name
and Otchestvo = @Otchestvo
and Document = @Document
and Nomer = @Nomer
and Grazdanstvo = @Grazdanstvo
and Compania = @Compania
and Class = @Class
and StrOtpr = @StrOtpr
and DateTime = @DateTime
and StrPrib = @StrPrib", sqlConnection);

            command.Parameters.AddWithValue("@Familia", pass.Lastname);
            command.Parameters.AddWithValue("@Name", pass.Firstname);
            command.Parameters.AddWithValue("@Otchestvo", pass.Middlename);
            command.Parameters.AddWithValue("@Document", pass.Document);
            command.Parameters.AddWithValue("@Nomer", pass.SerialNumber);
            command.Parameters.AddWithValue("@Grazdanstvo", pass.Citizenship);
            command.Parameters.AddWithValue("@Compania", pass.Company);
            command.Parameters.AddWithValue("@Class", pass.Class);
            command.Parameters.AddWithValue("@StrOtpr", pass.ContryCityFrom);
            command.Parameters.AddWithValue("@DateTime", pass.DateTimeFrom);
            command.Parameters.AddWithValue("@StrPrib", pass.ContryCityTo);

            //command.Parameters.Add("@UserId", SqlDbType.Int).Value = pass.ID;

            sqlConnection.Open();

            var result = command.ExecuteScalar();

            return Convert.ToBoolean(result);
        }
    }
}
