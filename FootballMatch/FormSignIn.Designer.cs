namespace FootballMatch
{
    partial class FormSignIn
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
            labelUsername = new Label();
            textBoxName = new TextBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            buttonSignIn = new Button();
            labelRegister = new Label();
            SuspendLayout();

            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle.Location = new Point(60, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Text = "⚽ Вхід до системи";

            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(30, 68);
            labelUsername.Name = "labelUsername";
            labelUsername.Text = "Логін:";

            textBoxName.Location = new Point(30, 90);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 27);
            textBoxName.TabIndex = 0;
            textBoxName.PlaceholderText = "Введіть логін";

            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(30, 130);
            labelPassword.Name = "labelPassword";
            labelPassword.Text = "Пароль:";

            textBoxPassword.Location = new Point(30, 152);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(200, 27);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.PlaceholderText = "Введіть пароль";

            buttonSignIn.Location = new Point(30, 200);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(200, 35);
            buttonSignIn.TabIndex = 2;
            buttonSignIn.Text = "Увійти";
            buttonSignIn.BackColor = Color.SteelBlue;
            buttonSignIn.ForeColor = Color.White;
            buttonSignIn.FlatStyle = FlatStyle.Flat;
            buttonSignIn.FlatAppearance.BorderSize = 0;
            buttonSignIn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonSignIn.UseVisualStyleBackColor = false;
            buttonSignIn.Click += buttonSignIn_Click;

            labelRegister.AutoSize = true;
            labelRegister.Location = new Point(45, 252);
            labelRegister.Name = "labelRegister";
            labelRegister.ForeColor = Color.SteelBlue;
            labelRegister.Text = "Немає акаунту? Зареєструватися";
            labelRegister.Cursor = Cursors.Hand;
            labelRegister.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            labelRegister.Click += labelRegister_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(400, 300);
            Controls.Add(labelTitle);
            Controls.Add(labelUsername);
            Controls.Add(textBoxName);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonSignIn);
            Controls.Add(labelRegister);
            Name = "FormSignIn";
            Text = "Вхід";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label labelTitle;
        private Label labelUsername;
        private TextBox textBoxName;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Button buttonSignIn;
        private Label labelRegister;
    }
}
