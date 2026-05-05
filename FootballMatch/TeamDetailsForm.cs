using Microsoft.Data.Sqlite;
using System;
using System.Windows.Forms;

namespace FootballMatch
{
    public partial class TeamDetailsForm : Form
    {
        private string currentTeam;

        public TeamDetailsForm(string teamName)
        {
            InitializeComponent();
            currentTeam = teamName;
            labelTeamName.Text = "Команда: " + currentTeam;
            LoadPlayers();
        }

        private void LoadPlayers()
        {
            listBoxPlayers.Items.Clear();
            DB db = new DB();
            db.openConnection();

            SqliteCommand cmd = new SqliteCommand("SELECT player_name FROM players WHERE team_name = @team", db.getConnection());
            cmd.Parameters.AddWithValue("@team", currentTeam);

            using (SqliteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    listBoxPlayers.Items.Add(reader["player_name"].ToString());
                }
            }

            cmd.Dispose();
            db.closeConnection();

            if (listBoxPlayers.Items.Count == 0)
            {
                listBoxPlayers.Items.Add("Склад команди поки порожній.");
            }
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            if (textBoxNewPlayer.Text == "")
            {
                MessageBox.Show("Введіть ім'я гравця!");
                return;
            }

            DB db = new DB();
            db.openConnection();

            SqliteCommand insertPlayer = new SqliteCommand("INSERT INTO players (team_name, player_name) VALUES (@team, @player)", db.getConnection());
            insertPlayer.Parameters.AddWithValue("@team", currentTeam);
            insertPlayer.Parameters.AddWithValue("@player", textBoxNewPlayer.Text);
            insertPlayer.ExecuteNonQuery();

            db.closeConnection();

            textBoxNewPlayer.Text = "";
            LoadPlayers();
        }

        private void buttonRemovePlayer_Click(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedIndex == -1)
            {
                MessageBox.Show("Виберіть гравця зі списку для видалення!");
                return;
            }

            string selectedPlayer = listBoxPlayers.SelectedItem.ToString();

            if (selectedPlayer == "Склад команди поки порожній.")
            {
                return;
            }

            DB db = new DB();
            db.openConnection();

            SqliteCommand delPlayer = new SqliteCommand("DELETE FROM players WHERE team_name = @team AND player_name = @player", db.getConnection());
            delPlayer.Parameters.AddWithValue("@team", currentTeam);
            delPlayer.Parameters.AddWithValue("@player", selectedPlayer);
            delPlayer.ExecuteNonQuery();

            db.closeConnection();

            LoadPlayers();
        }

        private void buttonDeleteTeam_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();

            SqliteCommand delTeam = new SqliteCommand("DELETE FROM teams WHERE team_name = @team", db.getConnection());
            delTeam.Parameters.AddWithValue("@team", currentTeam);
            delTeam.ExecuteNonQuery();

            SqliteCommand delPlayers = new SqliteCommand("DELETE FROM players WHERE team_name = @team", db.getConnection());
            delPlayers.Parameters.AddWithValue("@team", currentTeam);
            delPlayers.ExecuteNonQuery();

            db.closeConnection();
            MessageBox.Show("Команду повністю видалено з бази.");
            this.Close();
        }

      
        
    }
}