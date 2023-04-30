using AccountingApp.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingApp.Forms
{
    public partial class Tabel : Form
    {

        private int selectedId;

        public Tabel()
        {
            InitializeComponent();
        }

        private void ExitCLick_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateGridDepart();
        }

        // обновление таблицы отделов в dataGridView4
        private void UpdateGridDepart()
        {
            // SQL-запрос на выборку данных из таблицы Departments
            string sqlText = @"SELECT PK_department, name_department FROM Departments";

            // выполнение запроса и получение результата в виде таблицы DataTable
            DataTable table = SQLCore.ExecuteQueryToDataTable(sqlText);

            // привязка таблицы к dataGridView4
            dataGridView4.DataSource = table;

            // скрытие столбца PK_department
            dataGridView4.Columns["PK_department"].Visible = false;
        }

        // обновление таблицы сотрудников в dataGridView1, принадлежащих выбранному отделу
        private void UpdateGridEmployee(int id)
        {
            // SQL-запрос на выборку данных из таблицы Employers с подстановкой id отдела
            string sqlText = $@"SELECT Employers.FIO AS [ФИО], Employers.post AS [Должность], Employers.card_number AS [Табельный номер], 
              Employers.fk_department, Departments.PK_department, Employers.PK_employee
              FROM Employers INNER JOIN
              Departments ON Employers.fk_department = Departments.PK_department WHERE Employers.fk_department = @id";

            // создание параметра для подстановки в запрос id отдела
            SqlParameter[] parameters = { new SqlParameter("@id", id) };

            // выполнение запроса и получение результата в виде таблицы DataTable
            DataTable table = SQLCore.ExecuteQueryToDataTable(sqlText, parameters);

            // привязка таблицы к dataGridView1
            dataGridView1.DataSource = table;

            // скрытие столбцов PK_department, FK_department и PK_employee
            dataGridView1.Columns["PK_department"].Visible = false;
            dataGridView1.Columns["FK_department"].Visible = false;
            dataGridView1.Columns["PK_employee"].Visible = false;
        }
       

        // обработчик события двойного щелчка на ячейке таблицы dataGridView4
        private void dataGridView4_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // получение id выбранного отдела из ячейки PK_department
            selectedId = Convert.ToInt32(dataGridView4.Rows[e.RowIndex].Cells["PK_department"].Value);
            UpdateGridEmployee(selectedId);
            // обновление таблицы сотрудников в dataGridView1, пр

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            // закрытие текущей формы и открытие формы авторизации
            this.Hide();
            AutorizationForm au = new AutorizationForm();
            au.Show();
        }

      
    }
}
