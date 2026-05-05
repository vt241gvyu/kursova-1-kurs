using Microsoft.Data.Sqlite;
using System;
using System.Windows.Forms;

namespace FootballMatch
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSignIn formSignIn = new FormSignIn();
            formSignIn.ShowDialog();
            this.Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "" || textBoxLogin.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Заповніть всі поля!");
                return;
            }

            DB db = new DB();
            db.openConnection();

            SqliteCommand checkCmd = new SqliteCommand("SELECT * FROM users WHERE login = @uL", db.getConnection());
            checkCmd.Parameters.AddWithValue("@uL", textBoxLogin.Text);

            using (SqliteDataReader reader = checkCmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    MessageBox.Show("Такий логін вже зайнятий. Спробуйте інший.");
                    db.closeConnection();
                    return;
                }
            }

            SqliteCommand command = new SqliteCommand(
                "INSERT INTO users (login, password, email, role) VALUES (@login, @pass, @email, 'user')",
                db.getConnection());
            command.Parameters.AddWithValue("@login", textBoxLogin.Text);
            command.Parameters.AddWithValue("@pass", textBoxPassword.Text);
            command.Parameters.AddWithValue("@email", textBoxEmail.Text);

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Акаунт успішно створено! Тепер увійдіть.");
                this.Hide();
                FormSignIn loginForm = new FormSignIn();
                loginForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Помилка! Акаунт не створено.");
            }

            db.closeConnection();
        }
    }
}
