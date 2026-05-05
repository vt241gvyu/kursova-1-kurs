namespace FootballMatch
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            labelLogin_R = new Label();
            textBoxLogin = new TextBox();
            label2 = new Label();
            textBoxPassword = new TextBox();
            buttonCreate = new Button();
            labelLogin = new Label();
            SuspendLayout();

            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle.Location = new Point(55, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Text = "⚽ Реєстрація";

            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(30, 68);
            labelEmail.Name = "labelEmail";
            labelEmail.Text = "Електронна адреса:";

            textBoxEmail.Location = new Point(30, 90);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(220, 27);
            textBoxEmail.TabIndex = 0;
            textBoxEmail.PlaceholderText = "example@email.com";

            labelLogin_R.AutoSize = true;
            labelLogin_R.Location = new Point(30, 132);
            labelLogin_R.Name = "labelLogin_R";
            labelLogin_R.Text = "Логін:";

            textBoxLogin.Location = new Point(30, 154);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(220, 27);
            textBoxLogin.TabIndex = 1;
            textBoxLogin.PlaceholderText = "Введіть логін";

            label2.AutoSize = true;
            label2.Location = new Point(30, 196);
            label2.Name = "label2";
            label2.Text = "Пароль:";

            textBoxPassword.Location = new Point(30, 218);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(220, 27);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.PlaceholderText = "Введіть пароль";

            buttonCreate.Location = new Point(30, 262);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(220, 35);
            buttonCreate.TabIndex = 3;
            buttonCreate.Text = "Зареєструватися";
            buttonCreate.BackColor = Color.SeaGreen;
            buttonCreate.ForeColor = Color.White;
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.FlatAppearance.BorderSize = 0;
            buttonCreate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;

            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(30, 314);
            labelLogin.Name = "labelLogin";
            labelLogin.ForeColor = Color.SteelBlue;
            labelLogin.Text = "Вже є акаунт? Увійти";
            labelLogin.Cursor = Cursors.Hand;
            labelLogin.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            labelLogin.Click += labelLogin_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(400, 300);
            Controls.Add(labelTitle);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(labelLogin_R);
            Controls.Add(textBoxLogin);
            Controls.Add(label2);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonCreate);
            Controls.Add(labelLogin);
            Name = "RegisterForm";
            Text = "Реєстрація";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label labelTitle;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelLogin_R;
        private TextBox textBoxLogin;
        private Label label2;
        private TextBox textBoxPassword;
        private Button buttonCreate;
        private Label labelLogin;
    }
}
