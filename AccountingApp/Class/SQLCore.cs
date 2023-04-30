using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingApp.Class;
using System.Configuration;

namespace AccountingApp.Connection
{
    internal class SQLCore
    {
        // строка подключения к базе данных которая извлекается из файла конфигурации

        public static readonly string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        // метод для выполнения запросов SELECT
        public static DataTable ExecuteQueryToDataTable(string sql, SqlParameter[] parameters = null)
        {
            try
            {
                using (var connection = new SqlConnection(connStr))
                {
                    connection.Open(); // открытие соединения с базой данных

                    using (var command = new SqlCommand(sql, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters); // добавление параметров к запросу, если они есть
                        }

                        var dataTable = new DataTable(); // создание таблицы для хранения результата запроса

                        var dataAdapter = new SqlDataAdapter(command); // создание адаптера для заполнения таблицы результатом запроса

                        dataAdapter.Fill(dataTable); // заполнение таблицы данными из запроса

                        return dataTable; // возвращение таблицы с результатами запроса
                    }
                }
            }
            catch (Exception ex)
            {
                Dialog.Error("Ошибка при выполнении запроса: " + ex.Message); // вывод сообщения об ошибке
                return null;
            }
        }

        // метод для выполнения запросов INSERT, UPDATE, DELETE
        public static int ExecuteNonQueryWithParameters(string sql, SqlParameter[] parameters = null)
        {
            try
            {
                using (var connection = new SqlConnection(connStr))
                {
                    connection.Open(); // открытие соединения с базой данных

                    using (var command = new SqlCommand(sql, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters); // добавление параметров к запросу, если они есть
                        }

                        return command.ExecuteNonQuery(); // выполнение запроса и возвращение количества измененных строк в базе данных
                    }
                }
            }
            catch (Exception ex)
            {
                Dialog.Error("Ошибка при выполнении запроса: " + ex.Message); // вывод сообщения об ошибке
                return -1;
            }
        }

    }


}

