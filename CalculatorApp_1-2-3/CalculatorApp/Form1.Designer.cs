namespace CalculatorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDiscount = new System.Windows.Forms.TabPage();
            this.tabPassword = new System.Windows.Forms.TabPage();
            this.tabTemp = new System.Windows.Forms.TabPage();

            // === Вкладка 1: Калькулятор скидок ===
            this.lblPurchaseAmount = new System.Windows.Forms.Label();
            this.txtPurchaseAmount = new System.Windows.Forms.TextBox();
            this.btnCalculateDiscount = new System.Windows.Forms.Button();
            this.lblDiscountResult = new System.Windows.Forms.Label();
            this.lblRub = new System.Windows.Forms.Label();
            this.groupBoxRules = new System.Windows.Forms.GroupBox();
            this.lblRule1 = new System.Windows.Forms.Label();
            this.lblRule2 = new System.Windows.Forms.Label();
            this.lblRule3 = new System.Windows.Forms.Label();

            // === Вкладка 2: Проверка пароля ===
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblStrength = new System.Windows.Forms.Label();
            this.progressBarStrength = new System.Windows.Forms.ProgressBar();
            this.groupBoxChecks = new System.Windows.Forms.GroupBox();
            this.lblLengthCheck = new System.Windows.Forms.Label();
            this.lblDigitsCheck = new System.Windows.Forms.Label();
            this.lblRecommendation = new System.Windows.Forms.Label();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.btnClearPassword = new System.Windows.Forms.Button();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();

            // === Вкладка 3: Термометр ===
            this.groupBoxCtoF = new System.Windows.Forms.GroupBox();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.lblToF = new System.Windows.Forms.Label();
            this.btnCelsiusToFahrenheit = new System.Windows.Forms.Button();
            this.lblFahrenheitResult = new System.Windows.Forms.Label();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.lblTempFormula = new System.Windows.Forms.Label();

            this.groupBoxFtoC = new System.Windows.Forms.GroupBox();
            this.lblFahrenheit2 = new System.Windows.Forms.Label();
            this.txtFahrenheit2 = new System.Windows.Forms.TextBox();
            this.lblToC = new System.Windows.Forms.Label();
            this.btnFahrenheitToCelsius = new System.Windows.Forms.Button();
            this.lblCelsiusResult = new System.Windows.Forms.Label();
            this.txtCelsius2 = new System.Windows.Forms.TextBox();
            this.lblTempFormula2 = new System.Windows.Forms.Label();

            this.tabControl.SuspendLayout();
            this.tabDiscount.SuspendLayout();
            this.tabPassword.SuspendLayout();
            this.tabTemp.SuspendLayout();
            this.groupBoxRules.SuspendLayout();
            this.groupBoxChecks.SuspendLayout();
            this.groupBoxCtoF.SuspendLayout();
            this.groupBoxFtoC.SuspendLayout();
            this.SuspendLayout();

            // === tabControl ===
            this.tabControl.Controls.Add(this.tabDiscount);
            this.tabControl.Controls.Add(this.tabPassword);
            this.tabControl.Controls.Add(this.tabTemp);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(700, 500);
            this.tabControl.TabIndex = 0;

            // === Вкладка 1: Калькулятор скидок ===
            this.tabDiscount.Text = "💰 Калькулятор скидок";
            this.tabDiscount.BackColor = System.Drawing.Color.White;

            this.lblPurchaseAmount.Text = "Сумма покупки (₽):";
            this.lblPurchaseAmount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPurchaseAmount.Location = new System.Drawing.Point(30, 30);
            this.lblPurchaseAmount.Size = new System.Drawing.Size(150, 30);

            this.txtPurchaseAmount.Location = new System.Drawing.Point(180, 30);
            this.txtPurchaseAmount.Size = new System.Drawing.Size(150, 27);
            this.txtPurchaseAmount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPurchaseAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPurchaseAmount_KeyPress);

            this.lblRub.Text = "₽";
            this.lblRub.Location = new System.Drawing.Point(335, 33);
            this.lblRub.Size = new System.Drawing.Size(30, 23);

            this.btnCalculateDiscount.Text = "Рассчитать скидку";
            this.btnCalculateDiscount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCalculateDiscount.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnCalculateDiscount.ForeColor = System.Drawing.Color.White;
            this.btnCalculateDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateDiscount.Location = new System.Drawing.Point(180, 70);
            this.btnCalculateDiscount.Size = new System.Drawing.Size(200, 40);
            this.btnCalculateDiscount.Click += new System.EventHandler(this.btnCalculateDiscount_Click);

            this.lblDiscountResult.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDiscountResult.Location = new System.Drawing.Point(30, 130);
            this.lblDiscountResult.Size = new System.Drawing.Size(630, 100);
            this.lblDiscountResult.Text = "Введите сумму покупки и нажмите \"Рассчитать\"";
            this.lblDiscountResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDiscountResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiscountResult.BackColor = System.Drawing.Color.White;

            // Правила скидок
            this.groupBoxRules.Text = "Правила скидок";
            this.groupBoxRules.Location = new System.Drawing.Point(30, 250);
            this.groupBoxRules.Size = new System.Drawing.Size(630, 120);
            this.groupBoxRules.Font = new System.Drawing.Font("Segoe UI", 10F);

            this.lblRule1.Text = "• До 1000 ₽ → скидка 0%";
            this.lblRule1.Location = new System.Drawing.Point(20, 30);
            this.lblRule1.Size = new System.Drawing.Size(250, 25);

            this.lblRule2.Text = "• От 1000 до 5000 ₽ → скидка 5%";
            this.lblRule2.Location = new System.Drawing.Point(20, 60);
            this.lblRule2.Size = new System.Drawing.Size(300, 25);

            this.lblRule3.Text = "• Свыше 5000 ₽ → скидка 10%";
            this.lblRule3.Location = new System.Drawing.Point(20, 90);
            this.lblRule3.Size = new System.Drawing.Size(300, 25);

            this.groupBoxRules.Controls.Add(this.lblRule1);
            this.groupBoxRules.Controls.Add(this.lblRule2);
            this.groupBoxRules.Controls.Add(this.lblRule3);

            this.tabDiscount.Controls.Add(this.lblPurchaseAmount);
            this.tabDiscount.Controls.Add(this.txtPurchaseAmount);
            this.tabDiscount.Controls.Add(this.lblRub);
            this.tabDiscount.Controls.Add(this.btnCalculateDiscount);
            this.tabDiscount.Controls.Add(this.lblDiscountResult);
            this.tabDiscount.Controls.Add(this.groupBoxRules);

            // === Вкладка 2: Проверка пароля ===
            this.tabPassword.Text = "🔒 Проверка пароля";
            this.tabPassword.BackColor = System.Drawing.Color.White;

            this.lblPassword.Text = "Введите пароль:";
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPassword.Location = new System.Drawing.Point(30, 30);
            this.lblPassword.Size = new System.Drawing.Size(150, 30);

            this.txtPassword.Location = new System.Drawing.Point(180, 30);
            this.txtPassword.Size = new System.Drawing.Size(300, 27);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);

            this.chkShowPassword.Text = "Показать пароль";
            this.chkShowPassword.Location = new System.Drawing.Point(490, 32);
            this.chkShowPassword.Size = new System.Drawing.Size(120, 24);
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);

            this.lblStrength.Text = "Не введен";
            this.lblStrength.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblStrength.Location = new System.Drawing.Point(180, 70);
            this.lblStrength.Size = new System.Drawing.Size(300, 30);

            this.progressBarStrength.Location = new System.Drawing.Point(180, 110);
            this.progressBarStrength.Size = new System.Drawing.Size(300, 25);
            this.progressBarStrength.Style = System.Windows.Forms.ProgressBarStyle.Continuous;

            this.groupBoxChecks.Text = "Проверки";
            this.groupBoxChecks.Location = new System.Drawing.Point(30, 150);
            this.groupBoxChecks.Size = new System.Drawing.Size(450, 100);

            this.lblLengthCheck.Text = "✗ Минимум 8 символов";
            this.lblLengthCheck.Location = new System.Drawing.Point(20, 30);
            this.lblLengthCheck.Size = new System.Drawing.Size(200, 25);

            this.lblDigitsCheck.Text = "✗ Добавьте цифру";
            this.lblDigitsCheck.Location = new System.Drawing.Point(20, 60);
            this.lblDigitsCheck.Size = new System.Drawing.Size(200, 25);

            this.groupBoxChecks.Controls.Add(this.lblLengthCheck);
            this.groupBoxChecks.Controls.Add(this.lblDigitsCheck);

            this.lblRecommendation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRecommendation.Location = new System.Drawing.Point(30, 270);
            this.lblRecommendation.Size = new System.Drawing.Size(450, 40);
            this.lblRecommendation.Text = "Введите пароль для проверки";

            this.btnGeneratePassword.Text = "Сгенерировать пароль";
            this.btnGeneratePassword.Location = new System.Drawing.Point(500, 150);
            this.btnGeneratePassword.Size = new System.Drawing.Size(150, 40);
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);

            this.btnClearPassword.Text = "Очистить";
            this.btnClearPassword.Location = new System.Drawing.Point(500, 200);
            this.btnClearPassword.Size = new System.Drawing.Size(150, 40);
            this.btnClearPassword.Click += new System.EventHandler(this.btnClearPassword_Click);

            this.tabPassword.Controls.Add(this.lblPassword);
            this.tabPassword.Controls.Add(this.txtPassword);
            this.tabPassword.Controls.Add(this.chkShowPassword);
            this.tabPassword.Controls.Add(this.lblStrength);
            this.tabPassword.Controls.Add(this.progressBarStrength);
            this.tabPassword.Controls.Add(this.groupBoxChecks);
            this.tabPassword.Controls.Add(this.lblRecommendation);
            this.tabPassword.Controls.Add(this.btnGeneratePassword);
            this.tabPassword.Controls.Add(this.btnClearPassword);

            // === Вкладка 3: Термометр ===
            this.tabTemp.Text = "🌡️ Термометр";
            this.tabTemp.BackColor = System.Drawing.Color.White;

            // Конвертация Цельсий → Фаренгейт
            this.groupBoxCtoF.Text = "Цельсий → Фаренгейт";
            this.groupBoxCtoF.Location = new System.Drawing.Point(30, 20);
            this.groupBoxCtoF.Size = new System.Drawing.Size(620, 150);

            this.lblCelsius.Text = "°C:";
            this.lblCelsius.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCelsius.Location = new System.Drawing.Point(20, 30);
            this.lblCelsius.Size = new System.Drawing.Size(50, 30);

            this.txtCelsius.Location = new System.Drawing.Point(80, 30);
            this.txtCelsius.Size = new System.Drawing.Size(120, 27);
            this.txtCelsius.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCelsius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelsius_KeyPress);

            this.lblToF.Text = "→";
            this.lblToF.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblToF.Location = new System.Drawing.Point(210, 28);
            this.lblToF.Size = new System.Drawing.Size(40, 35);

            this.txtFahrenheit.Location = new System.Drawing.Point(260, 30);
            this.txtFahrenheit.Size = new System.Drawing.Size(120, 27);
            this.txtFahrenheit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFahrenheit.ReadOnly = true;
            this.txtFahrenheit.BackColor = System.Drawing.Color.WhiteSmoke;

            this.lblFahrenheitResult.Text = "°F";
            this.lblFahrenheitResult.Location = new System.Drawing.Point(390, 33);
            this.lblFahrenheitResult.Size = new System.Drawing.Size(30, 23);

            this.btnCelsiusToFahrenheit.Text = "Конвертировать";
            this.btnCelsiusToFahrenheit.Location = new System.Drawing.Point(80, 70);
            this.btnCelsiusToFahrenheit.Size = new System.Drawing.Size(150, 35);
            this.btnCelsiusToFahrenheit.Click += new System.EventHandler(this.btnCelsiusToFahrenheit_Click);

            this.lblTempFormula.Location = new System.Drawing.Point(80, 115);
            this.lblTempFormula.Size = new System.Drawing.Size(500, 25);
            this.lblTempFormula.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTempFormula.ForeColor = System.Drawing.Color.Gray;

            this.groupBoxCtoF.Controls.Add(this.lblCelsius);
            this.groupBoxCtoF.Controls.Add(this.txtCelsius);
            this.groupBoxCtoF.Controls.Add(this.lblToF);
            this.groupBoxCtoF.Controls.Add(this.txtFahrenheit);
            this.groupBoxCtoF.Controls.Add(this.lblFahrenheitResult);
            this.groupBoxCtoF.Controls.Add(this.btnCelsiusToFahrenheit);
            this.groupBoxCtoF.Controls.Add(this.lblTempFormula);

            // Конвертация Фаренгейт → Цельсий
            this.groupBoxFtoC.Text = "Фаренгейт → Цельсий";
            this.groupBoxFtoC.Location = new System.Drawing.Point(30, 190);
            this.groupBoxFtoC.Size = new System.Drawing.Size(620, 150);

            this.lblFahrenheit2.Text = "°F:";
            this.lblFahrenheit2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFahrenheit2.Location = new System.Drawing.Point(20, 30);
            this.lblFahrenheit2.Size = new System.Drawing.Size(50, 30);

            this.txtFahrenheit2.Location = new System.Drawing.Point(80, 30);
            this.txtFahrenheit2.Size = new System.Drawing.Size(120, 27);
            this.txtFahrenheit2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFahrenheit2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFahrenheit2_KeyPress);

            this.lblToC.Text = "→";
            this.lblToC.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblToC.Location = new System.Drawing.Point(210, 28);
            this.lblToC.Size = new System.Drawing.Size(40, 35);

            this.txtCelsius2.Location = new System.Drawing.Point(260, 30);
            this.txtCelsius2.Size = new System.Drawing.Size(120, 27);
            this.txtCelsius2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCelsius2.ReadOnly = true;
            this.txtCelsius2.BackColor = System.Drawing.Color.WhiteSmoke;

            this.lblCelsiusResult.Text = "°C";
            this.lblCelsiusResult.Location = new System.Drawing.Point(390, 33);
            this.lblCelsiusResult.Size = new System.Drawing.Size(30, 23);

            this.btnFahrenheitToCelsius.Text = "Конвертировать";
            this.btnFahrenheitToCelsius.Location = new System.Drawing.Point(80, 70);
            this.btnFahrenheitToCelsius.Size = new System.Drawing.Size(150, 35);
            this.btnFahrenheitToCelsius.Click += new System.EventHandler(this.btnFahrenheitToCelsius_Click);

            this.lblTempFormula2.Location = new System.Drawing.Point(80, 115);
            this.lblTempFormula2.Size = new System.Drawing.Size(500, 25);
            this.lblTempFormula2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTempFormula2.ForeColor = System.Drawing.Color.Gray;

            this.groupBoxFtoC.Controls.Add(this.lblFahrenheit2);
            this.groupBoxFtoC.Controls.Add(this.txtFahrenheit2);
            this.groupBoxFtoC.Controls.Add(this.lblToC);
            this.groupBoxFtoC.Controls.Add(this.txtCelsius2);
            this.groupBoxFtoC.Controls.Add(this.lblCelsiusResult);
            this.groupBoxFtoC.Controls.Add(this.btnFahrenheitToCelsius);
            this.groupBoxFtoC.Controls.Add(this.lblTempFormula2);

            this.tabTemp.Controls.Add(this.groupBoxCtoF);
            this.tabTemp.Controls.Add(this.groupBoxFtoC);

            // === Form1 ===
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Калькулятор скидок | Проверка пароля | Термометр";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.tabControl.ResumeLayout(false);
            this.tabDiscount.ResumeLayout(false);
            this.tabDiscount.PerformLayout();
            this.tabPassword.ResumeLayout(false);
            this.tabPassword.PerformLayout();
            this.tabTemp.ResumeLayout(false);
            this.groupBoxRules.ResumeLayout(false);
            this.groupBoxChecks.ResumeLayout(false);
            this.groupBoxCtoF.ResumeLayout(false);
            this.groupBoxCtoF.PerformLayout();
            this.groupBoxFtoC.ResumeLayout(false);
            this.groupBoxFtoC.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDiscount;
        private System.Windows.Forms.TabPage tabPassword;
        private System.Windows.Forms.TabPage tabTemp;

        // Элементы вкладки 1
        private System.Windows.Forms.Label lblPurchaseAmount;
        private System.Windows.Forms.TextBox txtPurchaseAmount;
        private System.Windows.Forms.Label lblRub;
        private System.Windows.Forms.Button btnCalculateDiscount;
        private System.Windows.Forms.Label lblDiscountResult;
        private System.Windows.Forms.GroupBox groupBoxRules;
        private System.Windows.Forms.Label lblRule1;
        private System.Windows.Forms.Label lblRule2;
        private System.Windows.Forms.Label lblRule3;

        // Элементы вкладки 2
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.ProgressBar progressBarStrength;
        private System.Windows.Forms.GroupBox groupBoxChecks;
        private System.Windows.Forms.Label lblLengthCheck;
        private System.Windows.Forms.Label lblDigitsCheck;
        private System.Windows.Forms.Label lblRecommendation;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.Button btnClearPassword;

        // Элементы вкладки 3
        private System.Windows.Forms.GroupBox groupBoxCtoF;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Label lblToF;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Label lblFahrenheitResult;
        private System.Windows.Forms.Button btnCelsiusToFahrenheit;
        private System.Windows.Forms.Label lblTempFormula;

        private System.Windows.Forms.GroupBox groupBoxFtoC;
        private System.Windows.Forms.Label lblFahrenheit2;
        private System.Windows.Forms.TextBox txtFahrenheit2;
        private System.Windows.Forms.Label lblToC;
        private System.Windows.Forms.TextBox txtCelsius2;
        private System.Windows.Forms.Label lblCelsiusResult;
        private System.Windows.Forms.Button btnFahrenheitToCelsius;
        private System.Windows.Forms.Label lblTempFormula2;
    }
}