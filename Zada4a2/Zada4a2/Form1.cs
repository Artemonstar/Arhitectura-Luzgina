using System;
using System.Linq;
using System.Windows.Forms;

namespace Zada4a2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Создаем элементы управления
            Label label1 = new Label();
            label1.Text = "Введите пароль:";
            label1.Location = new System.Drawing.Point(30, 30);
            label1.AutoSize = true;

            TextBox textBox1 = new TextBox();
            textBox1.Location = new System.Drawing.Point(30, 60);
            textBox1.Width = 200;

            Button button1 = new Button();
            button1.Text = "Проверить";
            button1.Location = new System.Drawing.Point(30, 100);
            button1.Width = 100;

            Label resultLabel = new Label();
            resultLabel.Text = "";
            resultLabel.Location = new System.Drawing.Point(30, 140);
            resultLabel.AutoSize = true;

            button1.Click += (sender, e) =>
            {
                string password = textBox1.Text;
                string strength = ShowPasswordStrength(password);
                resultLabel.Text = strength;
            };

            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(resultLabel);
        }

        string ShowPasswordStrength(string password)
        {
            bool lengthOk = CheckPasswordLength(password);
            bool digitsOk = CheckPasswordDigits(password);

            if (lengthOk && digitsOk)
                return "Надёжный";
            else if (lengthOk || digitsOk)
                return "Средний";
            else
                return "Слабый";
        }

        bool CheckPasswordLength(string password)
        {
            return password.Length >= 8;
        }

        bool CheckPasswordDigits(string password)
        {
            return password.Any(char.IsDigit);
        }
    }
}