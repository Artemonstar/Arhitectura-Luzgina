using System;
using System.Windows.Forms;

namespace Zada4a1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Создаем элементы управления
            Label label1 = new Label();
            label1.Text = "Введите сумму покупки:";
            label1.Location = new System.Drawing.Point(30, 30);
            label1.AutoSize = true;

            TextBox textBox1 = new TextBox();
            textBox1.Location = new System.Drawing.Point(30, 60);
            textBox1.Width = 200;

            Button button1 = new Button();
            button1.Text = "Рассчитать";
            button1.Location = new System.Drawing.Point(30, 100);
            button1.Width = 100;

            Label resultLabel = new Label();
            resultLabel.Text = "";
            resultLabel.Location = new System.Drawing.Point(30, 140);
            resultLabel.AutoSize = true;

            button1.Click += (sender, e) =>
            {
                if (double.TryParse(textBox1.Text, out double sum))
                {
                    double result = CalculateDiscount(sum);
                    resultLabel.Text = $"Итоговая сумма: {result} руб.";
                }
                else
                {
                    MessageBox.Show("Введите корректное число!");
                }
            };

            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(resultLabel);
        }

        double CalculateDiscount(double sum)
        {
            if (sum < 1000) return sum;
            if (sum <= 5000) return sum * 0.95;
            return sum * 0.9;
        }
    }
}