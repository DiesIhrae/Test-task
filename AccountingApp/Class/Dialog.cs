using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingApp.Class
{   
    // класс для диалоговых окон
    internal class Dialog 
    {   
        // окно с ошибкой
        static public void Error(string str) 
        {
            MessageBox.Show(str, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // информирующее окно
        static public void Info(string str) 
        {
            MessageBox.Show(str, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // окно с подтверждением действия 
        static public bool AskYesNo(string str) 
        {
            return MessageBox.Show(str, "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}
