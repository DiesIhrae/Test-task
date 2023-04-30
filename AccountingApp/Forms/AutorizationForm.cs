using AccountingApp.Connection;
using AccountingApp.Forms;
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

namespace AccountingApp
{
    using Class;
    public partial class AutorizationForm : Form
    {

        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void ExitCLick_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Обработчик нажатия на кнопку "вход"
        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                // запрос на выборку роли пользователя из таблицы Users по логину и паролю
                string sqlText = "SELECT role FROM Users WHERE Login = @Login AND Password = @Password";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@Login", LoginTextBox.Text),
                     new SqlParameter("@Password", PasswordTextBox.Text)
                };

                DataTable table = SQLCore.ExecuteQueryToDataTable(sqlText, parameters);

                // проверка,содержит таблица содержит хотя бы одну строку
                if (table.Rows.Count > 0)
                {
                    // получение роли пользователя из первой строки таблицы
                    string role = table.Rows[0]["role"].ToString();

                    // скрытие формы авторизации
                    this.Hide();

                    // в зависимости от роли пользователя открытие соответствующей формы
                    if (role == "Табельщик")
                    {
                        Tabel mf = new Tabel();
                        mf.Show();
                    }
                    else if (role == "Администратор справочников департамента")
                    {
                        DeptsAccounting da = new DeptsAccounting();
                        da.Show();
                    }
                    else if (role == "Администратор справочников работников")
                    {
                        WorkersAccount da = new WorkersAccount();
                        da.Show();
                    }
                }
                else // если таблица пустая
                {
                    // вывод сообщения об ошибке и очистка полей логина и пароля
                    Dialog.Error("Введенные данные неверны, попробуйте еще раз!");
                    LoginTextBox.Clear();
                    PasswordTextBox.Clear();

                }
  
            }
            catch (Exception ex)
            {
                Dialog.Error("Ошибка при выполнении запроса: " + ex.Message);
            }
        }

        // этот метод вызывается, когда пользователь нажимает на CheckBox для отображения/скрытия пароля
        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            // если пользователь отметил CheckBox, то используется обычный режим ввода текста для поля пароля
            if (cbShowPass.Checked)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            // если CheckBox не отмечен, то используется специальный режим ввода текста для поля пароля (скрывает символы)
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        // этот метод вызывается, когда пользователь нажимает на символ "Очистить" для поля логина и пароля
        private void ClearPassField_Click(object sender, EventArgs e)
        {
            LoginTextBox.Clear();
            PasswordTextBox.Clear();
        }
    }
}

