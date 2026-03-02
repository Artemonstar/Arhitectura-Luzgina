using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zadanie2
{
    public class Form1 : Form
    {
        private TextBox txtSize;
        private Button btnGenerate;
        private Label lblArray;
        private Label lblResult;
        private Random rand;

        public Form1()
        {
            rand = new Random();

            this.Text = "Задача 2: Поиск максимума и минимума";
            this.Size = new Size(600, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblTitle = new Label();
            lblTitle.Text = "Поиск максимума и минимума в массиве";
            lblTitle.Font = new Font("Arial", 12, FontStyle.Bold);
            lblTitle.Location = new Point(10, 10);
            lblTitle.AutoSize = true;
            this.Controls.Add(lblTitle);

            Label lblSize = new Label();
            lblSize.Text = "Размер массива N:";
            lblSize.Location = new Point(10, 50);
            lblSize.AutoSize = true;
            this.Controls.Add(lblSize);

            txtSize = new TextBox();
            txtSize.Location = new Point(150, 47);
            txtSize.Width = 50;
            this.Controls.Add(txtSize);

            btnGenerate = new Button();
            btnGenerate.Text = "Сгенерировать";
            btnGenerate.Location = new Point(220, 45);
            btnGenerate.Size = new Size(100, 25);
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
            lblResult.Font = new Font("Arial", 11, FontStyle.Bold);
            this.Controls.Add(lblResult);
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSize.Text, out int N) && N > 0)
            {
                int[] arr = new int[N];
                for (int i = 0; i < N; i++)
                {
                    arr[i] = rand.Next(1, 101);
                }

                lblArray.Text = "Массив: " + string.Join(" ", arr);

                int max = arr[0];
                int min = arr[0];
                int maxIdx = 0;
                int minIdx = 0;

                for (int i = 1; i < N; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                        maxIdx = i;
                    }
                    if (arr[i] < min)
                    {
                        min = arr[i];
                        minIdx = i;
                    }
                }

                lblResult.Text = $"Максимум: {max} (индекс {maxIdx}), Минимум: {min} (индекс {minIdx})";
            }
            else
            {
                MessageBox.Show("Введите корректное положительное число");
            }
        }
    }
}