using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zadanie1
{
    public class Form1 : Form
    {
        private TextBox[] txtBoxes;
        private Button btnCalc;
        private Label lblResult;

        public Form1()
        {
            txtBoxes = new TextBox[10];

            this.Text = "Задача 1: Сумма элементов массива";
            this.Size = new Size(400, 400);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblTitle = new Label();
            lblTitle.Text = "Введите 10 чисел:";
            lblTitle.Location = new Point(10, 10);
            lblTitle.Font = new Font("Arial", 10, FontStyle.Bold);
            lblTitle.AutoSize = true;
            this.Controls.Add(lblTitle);

            for (int i = 0; i < 10; i++)
            {
                Label lbl = new Label();
                lbl.Text = $"Элемент {i + 1}:";
                lbl.Location = new Point(10, 40 + i * 30);
                lbl.AutoSize = true;

                txtBoxes[i] = new TextBox();
                txtBoxes[i].Location = new Point(100, 40 + i * 30);
                txtBoxes[i].Width = 50;

                this.Controls.Add(lbl);
                this.Controls.Add(txtBoxes[i]);
            }

            btnCalc = new Button();
            btnCalc.Text = "Вычислить сумму";
            btnCalc.Location = new Point(10, 350);
            btnCalc.Size = new Size(120, 30);
            btnCalc.Click += BtnCalc_Click;
            this.Controls.Add(btnCalc);

            lblResult = new Label();
            lblResult.Text = "Сумма: ";
            lblResult.Location = new Point(150, 355);
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Arial", 10);
            this.Controls.Add(lblResult);
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                if (int.TryParse(txtBoxes[i].Text, out int value))
                {
                    sum += value;
                }
            }
            lblResult.Text = $"Сумма: {sum}";
        }
    }
}