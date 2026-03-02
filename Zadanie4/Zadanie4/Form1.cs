using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zadanie4
{
    public class Form1 : Form
    {
        private TextBox[] txtBoxes;
        private Button btnReverse;
        private Label lblOriginal;
        private Label lblReversed;
        private Label lblInPlace;

        public Form1()
        {
            txtBoxes = new TextBox[5];

            this.Text = "Задача 4: Реверс массива";
            this.Size = new Size(500, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblTitle = new Label();
            lblTitle.Text = "Реверс массива";
            lblTitle.Font = new Font("Arial", 12, FontStyle.Bold);
            lblTitle.Location = new Point(10, 10);
            lblTitle.AutoSize = true;
            this.Controls.Add(lblTitle);

            for (int i = 0; i < 5; i++)
            {
                Label lbl = new Label();
                lbl.Text = $"Число {i + 1}:";
                lbl.Location = new Point(10, 40 + i * 30);
                lbl.AutoSize = true;

                txtBoxes[i] = new TextBox();
                txtBoxes[i].Location = new Point(80, 40 + i * 30);
                txtBoxes[i].Width = 50;

                this.Controls.Add(lbl);
                this.Controls.Add(txtBoxes[i]);
            }

            btnReverse = new Button();
            btnReverse.Text = "Выполнить реверс";
            btnReverse.Location = new Point(10, 190);
            btnReverse.Size = new Size(120, 30);
            btnReverse.Click += BtnReverse_Click;
            this.Controls.Add(btnReverse);

            lblOriginal = new Label();
            lblOriginal.Text = "Исходный: ";
            lblOriginal.Location = new Point(150, 40);
            lblOriginal.AutoSize = true;
            lblOriginal.Font = new Font("Arial", 10);
            this.Controls.Add(lblOriginal);

            lblReversed = new Label();
            lblReversed.Text = "Реверсированный: ";
            lblReversed.Location = new Point(150, 70);
            lblReversed.AutoSize = true;
            lblReversed.Font = new Font("Arial", 10);
            this.Controls.Add(lblReversed);

            lblInPlace = new Label();
            lblInPlace.Text = "На месте: ";
            lblInPlace.Location = new Point(150, 100);
            lblInPlace.AutoSize = true;
            lblInPlace.Font = new Font("Arial", 10);
            this.Controls.Add(lblInPlace);
        }

        private void BtnReverse_Click(object sender, EventArgs e)
        {
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                int.TryParse(txtBoxes[i].Text, out arr[i]);
            }

            lblOriginal.Text = "Исходный: " + string.Join(" ", arr);

            int[] reversed = new int[5];
            for (int i = 0; i < 5; i++)
            {
                reversed[i] = arr[4 - i];
            }

            lblReversed.Text = "Реверсированный: " + string.Join(" ", reversed);

            for (int i = 0; i < 5 / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[4 - i];
                arr[4 - i] = temp;
            }

            lblInPlace.Text = "На месте: " + string.Join(" ", arr);
        }
    }
}