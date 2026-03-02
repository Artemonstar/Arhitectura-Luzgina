using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zadanie5
{
    public class Form1 : Form
    {
        private Button btnShift;
        private Label lblResult;

        public Form1()
        {
            this.Text = "Задача 5: Сдвиг элементов вправо";
            this.Size = new Size(400, 150);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblTitle = new Label();
            lblTitle.Text = "Циклический сдвиг элементов вправо";
            lblTitle.Font = new Font("Arial", 12, FontStyle.Bold);
            lblTitle.Location = new Point(10, 10);
            lblTitle.AutoSize = true;
            this.Controls.Add(lblTitle);

            Label lblArray = new Label();
            lblArray.Text = "Исходный массив: [1, 2, 3, 4, 5]";
            lblArray.Location = new Point(10, 40);
            lblArray.AutoSize = true;
            lblArray.Font = new Font("Arial", 11);
            this.Controls.Add(lblArray);

            btnShift = new Button();
            btnShift.Text = "Выполнить сдвиг";
            btnShift.Location = new Point(10, 70);
            btnShift.Size = new Size(120, 30);
            btnShift.Click += BtnShift_Click;
            this.Controls.Add(btnShift);

            lblResult = new Label();
            lblResult.Text = "Результат: ";
            lblResult.Location = new Point(150, 75);
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Arial", 11, FontStyle.Bold);
            this.Controls.Add(lblResult);
        }

        private void BtnShift_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            int last = arr[arr.Length - 1];
            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = last;

            lblResult.Text = "Результат: " + string.Join(" ", arr);
        }
    }
}