using Microsoft.Data.Sqlite;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FootballMatch
{
    public partial class TournamentDetailsForm : Form
    {
        private string currentTournament;

        public TournamentDetailsForm(string tournamentName)
        {
            InitializeComponent();
            currentTournament = tournamentName;
            labelName.Text = "🏆 " + currentTournament;
            LoadTeamsIntoComboBoxes();
            LoadMatches();
        }

        private void LoadTeamsIntoComboBoxes()
        {
            comboBoxHome.Items.Clear();
            comboBoxAway.Items.Clear();

            DB db = new DB();
            db.openConnection();

            SqliteCommand cmd = new SqliteCommand("SELECT team_name FROM teams ORDER BY team_name", db.getConnection());
            using (SqliteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string team = reader["team_name"].ToString();
                    comboBoxHome.Items.Add(team);
                    comboBoxAway.Items.Add(team);
                }
            }

            db.closeConnection();

            if (comboBoxHome.Items.Count > 0)
            {
                comboBoxHome.SelectedIndex = 0;
                comboBoxAway.SelectedIndex = comboBoxAway.Items.Count > 1 ? 1 : 0;
            }
        }

        private void LoadMatches()
        {
            listBoxMatches.Items.Clear();

            DB db = new DB();
            db.openConnection();

            SqliteCommand cmd = new SqliteCommand(
                "SELECT team_home, team_away, match_date, score FROM planned_matches WHERE tournament = @t ORDER BY match_date",
                db.getConnection());
            cmd.Parameters.AddWithValue("@t", currentTournament);

            using (SqliteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string home = reader["team_home"].ToString();
                    string away = reader["team_away"].ToString();
                    string date = reader["match_date"].ToString();
                    string score = reader["score"]?.ToString() ?? "";
                    string scoreStr = score != "" ? score : "-:-";
                    listBoxMatches.Items.Add($"{home} {scoreStr} {away}  ({date})");
                }
            }

            cmd.Dispose();
            db.closeConnection();

            if (listBoxMatches.Items.Count == 0)
                listBoxMatches.Items.Add("Матчів у цьому турнірі ще немає.");
        }

        private void buttonAddMatch_Click(object sender, EventArgs e)
        {
            if (comboBoxHome.SelectedItem == null || comboBoxAway.SelectedItem == null)
            {
                MessageBox.Show("Оберіть обидві команди!");
                return;
            }

            string home = comboBoxHome.SelectedItem.ToString();
            string away = comboBoxAway.SelectedItem.ToString();

            if (home == away)
            {
                MessageBox.Show("Господарі і гості не можуть бути однією командою!");
                return;
            }

            DB db = new DB();
            db.openConnection();

            SqliteCommand insert = new SqliteCommand(
                "INSERT INTO planned_matches (user_id, tournament, stadium, match_date, team_home, team_away, ticket_category, notes, score) " +
                "VALUES (1, @t, '', @date, @home, @away, '', '', '')",
                db.getConnection());
            insert.Parameters.AddWithValue("@t", currentTournament);
            insert.Parameters.AddWithValue("@date", DateTime.Today.ToString("yyyy-MM-dd"));
            insert.Parameters.AddWithValue("@home", home);
            insert.Parameters.AddWithValue("@away", away);
            insert.ExecuteNonQuery();
            insert.Dispose();

            db.closeConnection();
            LoadMatches();
        }

        private void buttonUpdateScore_Click(object sender, EventArgs e)
        {
            if (listBoxMatches.SelectedIndex == -1 || textBoxScore.Text == "")
            {
                MessageBox.Show("Виберіть матч зі списку та введіть рахунок!");
                return;
            }

            string selected = listBoxMatches.SelectedItem.ToString();
            if (selected == "Матчів у цьому турнірі ще немає.") return;

            int parenIdx = selected.LastIndexOf('(');
            string date = parenIdx > 0 ? selected.Substring(parenIdx + 1).TrimEnd(')').Trim() : "";
            string matchPart = parenIdx > 0 ? selected.Substring(0, parenIdx).Trim() : selected;

            string[] parts = matchPart.Split(' ');
            if (parts.Length < 3) return;
            string home = parts[0];
            string away = parts[parts.Length - 1];

            DB db = new DB();
            db.openConnection();

            SqliteCommand update = new SqliteCommand(
                "UPDATE planned_matches SET score = @score WHERE tournament = @t AND team_home = @home AND team_away = @away AND match_date = @date",
                db.getConnection());
            update.Parameters.AddWithValue("@score", textBoxScore.Text.Trim());
            update.Parameters.AddWithValue("@t", currentTournament);
            update.Parameters.AddWithValue("@home", home);
            update.Parameters.AddWithValue("@away", away);
            update.Parameters.AddWithValue("@date", date);
            update.ExecuteNonQuery();
            update.Dispose();

            db.closeConnection();

            textBoxScore.Text = "";
            LoadMatches();
        }

        private void buttonEditTournamentName_Click(object sender, EventArgs e)
        {
            string newName = textBoxNewName.Text.Trim();

            if (newName == "")
            {
                MessageBox.Show("Введіть нову назву турніру!");
                return;
            }

            DB db = new DB();
            db.openConnection();

            SqliteCommand updateT = new SqliteCommand("UPDATE tournaments SET name = @newName WHERE name = @oldName", db.getConnection());
            updateT.Parameters.AddWithValue("@newName", newName);
            updateT.Parameters.AddWithValue("@oldName", currentTournament);
            updateT.ExecuteNonQuery();
            updateT.Dispose();

            SqliteCommand updateM = new SqliteCommand("UPDATE planned_matches SET tournament = @newName WHERE tournament = @oldName", db.getConnection());
            updateM.Parameters.AddWithValue("@newName", newName);
            updateM.Parameters.AddWithValue("@oldName", currentTournament);
            updateM.ExecuteNonQuery();
            updateM.Dispose();

            db.closeConnection();

            currentTournament = newName;
            labelName.Text = "🏆 " + currentTournament;
            textBoxNewName.Text = "";
            MessageBox.Show("Назву турніру успішно змінено!");
        }
    }
}
