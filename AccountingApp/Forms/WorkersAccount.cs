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
    using System.Security.Cryptography;

    public partial class WorkersAccount : Form
    {
        
        private int id;

        public WorkersAccount()
        {
            InitializeComponent();
        }

        // обновление таблицы сотрудников
        private void UpdateGridWorkers()
        {
            // заполнение выпадающего списка департаментов
            cbDepart.DataSource = SQLCore.ExecuteQueryToDataTable(@"SELECT PK_department, name_department AS [Название департамента] FROM Departments");
            cbDepart.ValueMember = "PK_department";
            cbDepart.DisplayMember = "Название департамента";

            // Запрос на получение информации о сотрудниках и их департаментах
            string sqlText = @"SELECT Employers.PK_employee, Employers.FIO AS ФИО, Employers.post AS Должность, Employers.birth_date AS [Дата рождения], 
            Employers.remote_work AS [Удаленная работа], Employers.adress AS Адрес, 
            Employers.card_number AS [Табельный №], Departments.PK_department, Departments.name_department AS Департамент
            FROM Employers INNER JOIN
            Departments ON Employers.fk_department = Departments.PK_department";

            // получение данных и заполнение таблицы сотрудников
            DataTable table = SQLCore.ExecuteQueryToDataTable(sqlText);
            dgvTabel.DataSource = table;
            dgvTabel.Columns["PK_employee"].Visible = false;
            dgvTabel.Columns["PK_department"].Visible = false;
            dgvTabel.Columns["PK_department"].Visible = false;
        }


        private void TabelWork_Load(object sender, EventArgs e)
        {
            UpdateGridWorkers();
        }

        private void ExitCLick_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // обработчик события нажатия на кнопку "Добавить запись"

        private void InsertButton_Click(object sender, EventArgs e)
        {
            // проверка, действительно ли пользователь хочет добавить новую запись
            if (!Dialog.AskYesNo("Вы действительно хотите добавить новую запись?"))
                return;

            // формироание текст SQL-запроса на добавление новой записи
            string sqlText = $@"insert into Employers (FIO, post, birth_date, remote_work, adress, fk_department, card_number) 
                        values (@FIO, @Post, @Birth_date, @Remote_work, @Adress, @fk_department, @Сard_number)";

            // получение значения флага "Удаленная работа" из элемента управления
            bool remoteWorkValue = chekRemote.Checked;

            // создание массива параметров для SQL-запроса
            SqlParameter[] parameters =
            {
            new SqlParameter("@FIO", textFio.Text),
            new SqlParameter("@Post", textPost.Text),
            new SqlParameter("@Birth_date", textBirth.Text),
            new SqlParameter("@Remote_work", remoteWorkValue),
            new SqlParameter("@Adress", textAdres.Text),
            new SqlParameter("@fk_department", cbDepart.SelectedValue),
            new SqlParameter("@Сard_number", textTabel.Text)
            };

            // выполние SQL-запроса на добавление записи
            int rowsAffected = SQLCore.ExecuteNonQueryWithParameters(sqlText, parameters);

            // проверка количества обработанных строк
            if (rowsAffected == 1)
            {
                Dialog.Info("Запись была успешно добавлена");
            }
            else
            {
                Dialog.Info("Добавить запись не удалось");
            }

            // обновление данных в таблице сотрудников
            UpdateGridWorkers();
        }
        // обработчик события двойного щелчка на ячейке таблицы dgvTabel
        private void dgvTabel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // получение id выбранного отдела из ячейки PK_department
            id = Convert.ToInt32(dgvTabel.Rows[e.RowIndex].Cells["PK_employee"].Value);
            textFio.Text = dgvTabel.Rows[e.RowIndex].Cells["ФИО"].Value.ToString();
            textPost.Text = dgvTabel.Rows[e.RowIndex].Cells["Должность"].Value.ToString();
            textTabel.Text = dgvTabel.Rows[e.RowIndex].Cells["Табельный №"].Value.ToString();
            textBirth.Text = dgvTabel.Rows[e.RowIndex].Cells["Дата рождения"].Value.ToString();
            chekRemote.Checked = (bool)dgvTabel.Rows[e.RowIndex].Cells["Удаленная работа"].Value;
            cbDepart.Text = dgvTabel.Rows[e.RowIndex].Cells["Департамент"].Value.ToString();
            textAdres.Text = dgvTabel.Rows[e.RowIndex].Cells["Адрес"].Value.ToString();
            
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // SQL запрос на обновление записи с указанным ID
            string sqlText = @"UPDATE Employers SET FIO = @FIO, post = @Post, birth_date = @Birth_date, remote_work = @Remote_work,  
            adress = @Adress, fk_department = @fk_department, card_number = @Card_number WHERE PK_employee = @PK_employee";

            // параметры для SQL запроса
            SqlParameter[] parameters =
            {
             new SqlParameter("@FIO", textFio.Text),
             new SqlParameter("@Post", textPost.Text),
             new SqlParameter("@Birth_date", textBirth.Text),
             new SqlParameter("@Remote_work", chekRemote.Checked),
             new SqlParameter("@Adress", textAdres.Text),
             new SqlParameter("@fk_department", cbDepart.SelectedValue),
             new SqlParameter("@Card_number", textTabel.Text),
             new SqlParameter("@PK_employee", id)
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
            UpdateGridWorkers();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!Dialog.AskYesNo("Вы действительно хотите удалить запись?"))
                return;

            // SQL запрос на удаление записи с указанным ID

            string sqlText = @"DELETE FROM Employers WHERE PK_employee = @PK_employee";

            // параметры для SQL запроса
            SqlParameter[] parameters =
            {
             new SqlParameter("@PK_employee", id)
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

            // обновление таблицы с данными после удаления
            UpdateGridWorkers();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // SQL запрос на поиск записей в таблице Employers, содержащих заданный текст
            string sqlText = "SELECT FIO AS [ФИО], post AS [Должность],birth_date AS [Дата рождения],adress AS [Адрес], card_number AS [Табельный №]" +
                " FROM Employers WHERE FIO LIKE @FIO " +
                "OR post LIKE @Post " +
                "OR birth_date LIKE @Birth_date " +
                "OR adress LIKE @Adress " +
                "OR card_number LIKE @Card_number ";

            // задание параметров запроса, в которых используется заданный текст для поиска
            SqlParameter[] parameters =
            {
             new SqlParameter("@FIO", "%" + textSearch.Text + "%"),
             new SqlParameter("@Post", "%" + textSearch.Text + "%"),
             new SqlParameter("@Birth_date", "%" + textSearch.Text + "%"),
             new SqlParameter("@Adress", "%" + textSearch.Text + "%"),
             new SqlParameter("@Card_number", "%" + textSearch.Text + "%")
            };

            // выполнение запроса и получение результата в виде таблицы данных
            DataTable table = SQLCore.ExecuteQueryToDataTable(sqlText, parameters);

            // заполнение таблицы на форме полученными данными
            dgvTabel.DataSource = table;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // очистка полей ввода и снятие флажка "Удаленная работа"
            textAdres.Clear();
            textFio.Clear();
            textBirth.Clear();
            textPost.Clear();
            textSearch.Clear();
            textTabel.Clear();
            chekRemote.Checked = false;

            // обновление таблицы с данными
            UpdateGridWorkers();
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
    

