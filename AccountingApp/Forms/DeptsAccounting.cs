using AccountingApp.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingApp.Forms
{
    using Class;
    using System.Collections;
    using System.Data.SqlClient;
    using System.Globalization;
    using System.Security.Cryptography;

    public partial class DeptsAccounting : Form
    {
        public DeptsAccounting()
        {
            InitializeComponent();
        }

       private int id;

        private void UpdateGridDepartments()
        {
            // Запрос на получение информации о департаментах
            string sqlText = @"SELECT PK_department, name_department AS [Название департамента] FROM Departments";

            // Выполнение запроса и получение результата в виде таблицы
            DataTable table = SQLCore.ExecuteQueryToDataTable(sqlText);

            // Привязка таблицы к элементу DataGridView
            dgvDepts.DataSource = table;

            // Скрытие столбца с идентификатором департамента
            dgvDepts.Columns["PK_department"].Visible = false;

        }


        private void DeptsAccounting_Load(object sender, EventArgs e)
        {
            UpdateGridDepartments();
        }

        private void ExitCLick_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }


        private void InsertButton_Click(object sender, EventArgs e)
        {
            // проверка, действительно ли пользователь хочет добавить новую запись
            if (!Dialog.AskYesNo("Вы действительно хотите добавить новую запись?"))
                return;

            // SQL-запрос для вставки новой записи в таблицу Departments
            string sqlText = @"insert into Departments (name_department) values (@Name_department)";

            // параметры для подстановки в SQL-запрос
            SqlParameter[] parameters =
            {
              new SqlParameter("@Name_department", textName.Text)
            };

            // выполнить SQL-запрос с подставленными параметрами и получить количество добавленных строк
            int insertedRows = SQLCore.ExecuteNonQueryWithParameters(sqlText, parameters);

            // если была добавлена одна запись, то показать сообщение об успешном добавлении, иначе - сообщение о неудаче
            if (insertedRows == 1)
            {
                Dialog.Info("Запись была успешно добавлена");
            }
            else
            {
                Dialog.Info("Добавить запись не удалось");
            }

            // обновить таблицу dgvDepts
            UpdateGridDepartments();
        }


        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // SQL запрос на обновление записи с указанным ID

            string sqlText = @"UPDATE Departments SET name_department = @Name_department WHERE PK_department = @PK_department";

            // параметры для SQL запроса
            SqlParameter[] parameters =
            {

             new SqlParameter("@PK_department", id),
             new SqlParameter("@Name_department", textName.Text)
           
            };

            // выполнение SQL запроса на обновление записи с указанными параметрами
            int UsingRows = SQLCore.ExecuteNonQueryWithParameters(sqlText, parameters);

            // вывод информации об успешном или неуспешном выполнении запроса
            if (UsingRows == 1)
            {
                Dialog.Info("Запись была успешно изменена");
            }
            else
            {
                Dialog.Info("Запись не была найдена в базе данных");
            }

            // обновление таблицы после изменения записи
            UpdateGridDepartments();
        }


        // обработчик события двойного щелчка на ячейке таблицы dgvDept
        private void dgvDepts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // получение id выбранного отдела из ячейки PK_department
            id = Convert.ToInt32(dgvDepts.Rows[e.RowIndex].Cells["PK_department"].Value);
            textName.Text = dgvDepts.Rows[e.RowIndex].Cells["Название департамента"].Value.ToString();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!Dialog.AskYesNo("Вы действительно хотите удалить запись?"))
                return;

            // SQL запрос на удаление записи с указанным ID
            string sqlText = @"DELETE FROM Departments WHERE PK_department = @PK_department";

            // параметры для SQL запроса
            SqlParameter[] parameters =
            {
             new SqlParameter("@PK_department", id)
            };

            // выполнение SQL запроса на удаление записи с указанными параметрами
            int UsingRows = SQLCore.ExecuteNonQueryWithParameters(sqlText, parameters);

            if (UsingRows == 1)
            {
                Dialog.Info("Запись была успешно удалена");
            }
            else
            {
                Dialog.Info("Запись не была найдена в базе данных");
            }

            UpdateGridDepartments();
        }

        private void pictureClear_Click(object sender, EventArgs e)
        {
             // очистка полей ввода
             textName.Clear();
             textSearch.Clear();
             UpdateGridDepartments();
           
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // SQL запрос на поиск записей в таблице Employers, содержащих заданный текст
            string sqlText = "SELECT PK_department, name_department AS [Название департамента] FROM Departments WHERE name_department LIKE @Name_department; ";

            // задание параметров запроса, в которых используется заданный текст для поиска
            SqlParameter[] parameters =
            {
             new SqlParameter("@Name_department", "%" + textSearch.Text + "%"),
            };
            DataTable table = SQLCore.ExecuteQueryToDataTable(sqlText, parameters);
            dgvDepts.DataSource = table;
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
