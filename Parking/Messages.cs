using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Parking
{
    public static class Messages
    {
        public static void sendErrorInputMessage(string attr)
        {
            string message = "Вы не указали " + attr + ".\nОперация отменена.";
            string caption = "Ошибка ввода данных";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Error;
            MessageBox.Show(message, caption, button, icon);
        }

        public static void sendSuccsessMessage()
        {
            string message = "Операция выполнена.";
            string caption = "Получилось!";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBox.Show(message, caption, button, icon);
        }

        public static void sendFailedMessage(Exception ex)
        {
            string message = "Операция провалена.\nОшибка: " + ex.Message;
            string caption = "Не получилось.";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Error;
            MessageBox.Show(message, caption, button, icon);
        }

        public static void Debug(string text)
        {
            string caption = "Debug";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBox.Show(text, caption, button, icon);
        }

        public static void Debug(int val)
        {
            Debug(val.ToString());
        }

        internal static void sendErrorMessage(string text)
        {
            string caption = "Ошибка ввода данных";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Error;
            MessageBox.Show(text, caption, button, icon);
        }
    }
}
