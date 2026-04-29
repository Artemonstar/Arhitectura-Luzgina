using System;
using System.Linq;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Калькулятор скидок | Проверка пароля | Термометр";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #region Задача 1: Калькулятор скидок

        private void btnCalculateDiscount_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPurchaseAmount.Text, out double amount))
            {
                double finalAmount = CalculateDiscount(amount);
                double discount = amount - finalAmount;
                double discountPercent = GetDiscountPercent(amount);

                lblDiscountResult.Text = $"Сумма покупки: {amount:F2} руб.\n" +
                                        $"Скидка: {discountPercent:F0}% ({discount:F2} руб.)\n" +
                                        $"Итого к оплате: {finalAmount:F2} руб.";

                // Анимация подсветки результата
                lblDiscountResult.BackColor = System.Drawing.Color.LightGreen;
                Timer timer = new Timer();
                timer.Interval = 500;
                timer.Tick += (s, ev) => { lblDiscountResult.BackColor = System.Drawing.Color.White; timer.Stop(); };
                timer.Start();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректную сумму покупки!",
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPurchaseAmount.Focus();
            }
        }

        private double GetDiscountPercent(double amount)
        {
            if (amount < 1000) return 0;
            if (amount <= 5000) return 5;
            return 10;
        }

        private double CalculateDiscount(double amount)
        {
            if (amount < 1000) return amount;
            if (amount <= 5000) return amount * 0.95; // Скидка 5%
            return amount * 0.90; // Скидка 10%
        }

        private void txtPurchaseAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем только цифры, запятую и Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // Запятую можно ввести только один раз
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Задача 2: Проверка пароля

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            CheckPasswordStrength(password);
        }

        private void CheckPasswordStrength(string password)
        {
            bool isLengthOk = CheckPasswordLength(password);
            bool hasDigits = CheckPasswordDigits(password);
            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasSpecialChar = false;

            // Дополнительные проверки для более точной оценки
            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpperCase = true;
                if (char.IsLower(c)) hasLowerCase = true;
                if (!char.IsLetterOrDigit(c)) hasSpecialChar = true;
            }

            // Обновляем индикаторы
            lblLengthCheck.Text = isLengthOk ? "✓ 8+ символов" : "✗ Минимум 8 символов";
            lblLengthCheck.ForeColor = isLengthOk ? System.Drawing.Color.Green : System.Drawing.Color.Red;

            lblDigitsCheck.Text = hasDigits ? "✓ Есть цифра" : "✗ Добавьте цифру";
            lblDigitsCheck.ForeColor = hasDigits ? System.Drawing.Color.Green : System.Drawing.Color.Red;

            // Оценка надежности
            int strengthScore = 0;
            if (isLengthOk) strengthScore++;
            if (hasDigits) strengthScore++;
            if (hasUpperCase && hasLowerCase) strengthScore++;
            if (hasSpecialChar) strengthScore++;

            ShowPasswordStrength(strengthScore, isLengthOk, hasDigits);
        }

        private bool CheckPasswordLength(string password)
        {
            return password.Length >= 8;
        }

        private bool CheckPasswordDigits(string password)
        {
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                    return true;
            }
            return false;
        }

        private void ShowPasswordStrength(int score, bool isLengthOk, bool hasDigits)
        {
            progressBarStrength.Value = Math.Min(score * 25, 100);

            if (!isLengthOk || !hasDigits || score <= 1)
            {
                lblStrength.Text = "Слабый";
                lblStrength.ForeColor = System.Drawing.Color.Red;
                progressBarStrength.ForeColor = System.Drawing.Color.Red;
            }
            else if (score == 2)
            {
                lblStrength.Text = "Средний";
                lblStrength.ForeColor = System.Drawing.Color.Orange;
                progressBarStrength.ForeColor = System.Drawing.Color.Orange;
            }
            else
            {
                lblStrength.Text = "Надёжный";
                lblStrength.ForeColor = System.Drawing.Color.Green;
                progressBarStrength.ForeColor = System.Drawing.Color.Green;
            }

            // Дополнительные рекомендации
            if (!isLengthOk)
                lblRecommendation.Text = "Рекомендация: Используйте минимум 8 символов";
            else if (!hasDigits)
                lblRecommendation.Text = "Рекомендация: Добавьте хотя бы одну цифру";
            else if (score < 3)
                lblRecommendation.Text = "Рекомендация: Используйте заглавные и строчные буквы";
            else
                lblRecommendation.Text = "✓ Отличный пароль!";
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            // Генерация надежного пароля
            string generated = GenerateStrongPassword();
            txtPassword.Text = generated;
            MessageBox.Show($"Сгенерирован надёжный пароль:\n{generated}\n\nСкопируйте его и сохраните!",
                          "Генератор паролей", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GenerateStrongPassword()
        {
            const string upper = "ABCDEFGHJKLMNPQRSTUVWXYZ";
            const string lower = "abcdefghijkmnpqrstuvwxyz";
            const string digits = "23456789";
            const string special = "!@#$%^&*";

            Random rand = new Random();
            char[] password = new char[12];

            // Гарантируем наличие всех типов символов
            password[0] = upper[rand.Next(upper.Length)];
            password[1] = lower[rand.Next(lower.Length)];
            password[2] = digits[rand.Next(digits.Length)];
            password[3] = special[rand.Next(special.Length)];

            // Заполняем остальные символы
            string allChars = upper + lower + digits + special;
            for (int i = 4; i < 12; i++)
            {
                password[i] = allChars[rand.Next(allChars.Length)];
            }

            // Перемешиваем
            for (int i = 0; i < password.Length; i++)
            {
                int j = rand.Next(password.Length);
                char temp = password[i];
                password[i] = password[j];
                password[j] = temp;
            }

            return new string(password);
        }

        private void btnClearPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            lblStrength.Text = "Не введен";
            lblStrength.ForeColor = System.Drawing.Color.Gray;
            progressBarStrength.Value = 0;
            lblLengthCheck.Text = "✗ Минимум 8 символов";
            lblLengthCheck.ForeColor = System.Drawing.Color.Red;
            lblDigitsCheck.Text = "✗ Добавьте цифру";
            lblDigitsCheck.ForeColor = System.Drawing.Color.Red;
            lblRecommendation.Text = "Введите пароль для проверки";
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        #endregion

        #region Задача 3: Термометр

        private void btnCelsiusToFahrenheit_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCelsius.Text, out double celsius))
            {
                double fahrenheit = CelsiusToFahrenheit(celsius);
                txtFahrenheit.Text = fahrenheit.ToString("F2");
                lblTempFormula.Text = $"Формула: {celsius}°C × 9/5 + 32 = {fahrenheit:F2}°F";

                // Анимация
                AnimateResult(lblFahrenheitResult);
            }
            else
            {
                MessageBox.Show("Введите корректное значение температуры в градусах Цельсия!",
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFahrenheitToCelsius_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtFahrenheit2.Text, out double fahrenheit))
            {
                double celsius = FahrenheitToCelsius(fahrenheit);
                txtCelsius2.Text = celsius.ToString("F2");
                lblTempFormula2.Text = $"Формула: ({fahrenheit}°F - 32) × 5/9 = {celsius:F2}°C";

                // Анимация
                AnimateResult(lblCelsiusResult);
            }
            else
            {
                MessageBox.Show("Введите корректное значение температуры в градусах Фаренгейта!",
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private double CelsiusToFahrenheit(double celsius)
        {
            return celsius * 9 / 5 + 32;
        }

        private double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        private void AnimateResult(Label label)
        {
            label.BackColor = System.Drawing.Color.LightYellow;
            Timer timer = new Timer();
            timer.Interval = 800;
            timer.Tick += (s, ev) => { label.BackColor = System.Drawing.Color.White; timer.Stop(); };
            timer.Start();
        }

        private void txtCelsius_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtFahrenheit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}