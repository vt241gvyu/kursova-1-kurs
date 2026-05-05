using FootballMatch;
using Microsoft.Data.Sqlite;
using System;
using System.Windows.Forms;

namespace FootballMatch {
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Введіть логін");
                return;
            }
            if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Введіть пароль");
                return;
            }

            DB db = new DB();
            db.openConnection();

            SqliteCommand command = new SqliteCommand("SELECT * FROM users WHERE login = @uL AND password = @uP", db.getConnection());
            command.Parameters.AddWithValue("@uL", textBoxName.Text);
            command.Parameters.AddWithValue("@uP", textBoxPassword.Text);

            User currentUser = null;

            using (SqliteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    int id = Convert.ToInt32(reader["id"]);
                    string login = reader["login"].ToString();
                    string email = reader["email"].ToString();
                    string role = login == "admin" ? "admin" : reader["role"]?.ToString();

                    currentUser = new User(id, login, email, role);
                }
                else
                {
                    MessageBox.Show("Неправильно введено логін або пароль!");
                }
            }

            db.closeConnection();

            if (currentUser != null)
            {
                this.Hide();
                MainForm mainForm = new MainForm(currentUser);
                mainForm.ShowDialog();
                this.Close();
            }
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Close();
        }
    }
}
