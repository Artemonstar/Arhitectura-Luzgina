using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zadanie6
{
    public class Form1 : Form
    {
        private TextBox[] txtBoxes;
        private Button btnCount;
        private ListBox listBox;

        public Form1()
        {
            txtBoxes = new TextBox[10];

            this.Text = "Задача 6: Подсчет дубликатов";
            this.Size = new Size(500, 400);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblTitle = new Label();
            lblTitle.Text = "Подсчет дубликатов в массиве";
            lblTitle.Font = new Font("Arial", 12, FontStyle.Bold);
            lblTitle.Location = new Point(10, 10);
            lblTitle.AutoSize = true;
            this.Controls.Add(lblTitle);

            for (int i = 0; i < 10; i++)
            {
                Label lbl = new Label();
                lbl.Text = $"{i + 1}:";
                lbl.Location = new Point(10 + (i % 5) * 80, 40 + (i / 5) * 30);
                lbl.AutoSize = true;

                txtBoxes[i] = new TextBox();
                txtBoxes[i].Location = new Point(35 + (i % 5) * 80, 40 + (i / 5) * 30);
                txtBoxes[i].Width = 40;

                this.Controls.Add(lbl);
                this.Controls.Add(txtBoxes[i]);
            }

            btnCount = new Button();
            btnCount.Text = "Подсчитать дубликаты";
            btnCount.Location = new Point(10, 120);
            btnCount.Size = new Size(150, 30);
            btnCount.Click += BtnCount_Click;
            this.Controls.Add(btnCount);

            listBox = new ListBox();
            listBox.Location = new Point(10, 160);
            listBox.Size = new Size(450, 180);
            this.Controls.Add(listBox);
        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                int.TryParse(txtBoxes[i].Text, out arr[i]);
            }

            listBox.Items.Clear();
            bool[] processed = new bool[10];

            for (int i = 0; i < 10; i++)
            {
                if (processed[i]) continue;

                int count = 1;
                for (int j = i + 1; j < 10; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        processed[j] = true;
                    }
                }
                listBox.Items.Add($"Число {arr[i]} встречается {count} раз(а)");
            }
        }
    }
}