using System;
using System.Windows.Forms;

namespace Zada4a3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Создаем элементы управления
            Label label1 = new Label();
            label1.Text = "Выберите направление:";
            label1.Location = new System.Drawing.Point(30, 30);
            label1.AutoSize = true;

            ComboBox comboBox1 = new ComboBox();
            comboBox1.Location = new System.Drawing.Point(30, 60);
            comboBox1.Width = 150;
            comboBox1.Items.Add("Цельсий -> Фаренгейт");
            comboBox1.Items.Add("Фаренгейт -> Цельсий");
            comboBox1.SelectedIndex = 0;

            Label label2 = new Label();
            label2.Text = "Введите температуру:";
            label2.Location = new System.Drawing.Point(30, 100);
            label2.AutoSize = true;

            TextBox textBox1 = new TextBox();
            textBox1.Location = new System.Drawing.Point(30, 130);
            textBox1.Width = 150;

            Button button1 = new Button();
            button1.Text = "Конвертировать";
            button1.Location = new System.Drawing.Point(30, 170);
            button1.Width = 150;

            Label resultLabel = new Label();
            resultLabel.Text = "";
            resultLabel.Location = new System.Drawing.Point(30, 210);
            resultLabel.AutoSize = true;

            button1.Click += (sender, e) =>
            {
                if (double.TryParse(textBox1.Text, out double temp))
                {
                    double result;
                    if (comboBox1.SelectedIndex == 0)
                        result = CelsiusToFahrenheit(temp);
                    else
                        result = FahrenheitToCelsius(temp);

                    resultLabel.Text = $"Результат: {result:F2}";
                }
                else
                {
                    MessageBox.Show("Введите корректное число!");
                }
            };

            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(resultLabel);
        }

        double CelsiusToFahrenheit(double c)
        {
            return c * 9 / 5 + 32;
        }

        double FahrenheitToCelsius(double f)
        {
            return (f - 32) * 5 / 9;
        }
    }
}