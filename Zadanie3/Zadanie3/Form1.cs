using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zadanie3
{
    public class Form1 : Form
    {
        private Button btnGenerate;
        private Label lblArray;
        private Label lblResult;
        private Random rand;

        public Form1()
        {
            rand = new Random();

            this.Text = "Задача 3: Подсчет четных и нечетных";
            this.Size = new Size(600, 200);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblTitle = new Label();
            lblTitle.Text = "Подсчет четных и нечетных чисел";
            lblTitle.Font = new Font("Arial", 12, FontStyle.Bold);
            lblTitle.Location = new Point(10, 10);
            lblTitle.AutoSize = true;
            this.Controls.Add(lblTitle);

            btnGenerate = new Button();
            btnGenerate.Text = "Сгенерировать массив";
            btnGenerate.Location = new Point(10, 40);
            btnGenerate.Size = new Size(150, 30);
            btnGenerate.Click += BtnGenerate_Click;
            this.Controls.Add(btnGenerate);

            lblArray = new Label();
            lblArray.Text = "Массив: ";
            lblArray.Location = new Point(10, 80);
            lblArray.AutoSize = true;
            lblArray.Font = new Font("Arial", 10);
            this.Controls.Add(lblArray);

            lblResult = new Label();
            lblResult.Text = "Результат: ";
            lblResult.Location = new Point(10, 110);
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Arial", 12, FontStyle.Bold);
            this.Controls.Add(lblResult);
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            int[] arr = new int[15];
            for (int i = 0; i < 15; i++)
            {
                arr[i] = rand.Next(10, 51);
            }

            lblArray.Text = "Массив: " + string.Join(" ", arr);

            int even = 0;
            int odd = 0;
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            lblResult.Text = $"Четных: {even}, Нечетных: {odd}";
        }
    }
}