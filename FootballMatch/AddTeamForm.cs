using Microsoft.Data.Sqlite;
using System;
using System.Windows.Forms;

namespace FootballMatch
{
    public partial class AddTeamForm : Form
    {
        public AddTeamForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string teamName = textBoxTeamName.Text.Trim();

            if (teamName == "")
            {
                MessageBox.Show("Введіть назву команди!");
                return;
            }

            DB db = new DB();
            db.openConnection();

            SqliteCommand insertTeam = new SqliteCommand("INSERT INTO teams (team_name) VALUES (@name)", db.getConnection());
            insertTeam.Parameters.AddWithValue("@name", teamName);
            insertTeam.ExecuteNonQuery();

            db.closeConnection();

            MessageBox.Show("Команду успішно створено!");
            this.Close();
        }
    }
}
