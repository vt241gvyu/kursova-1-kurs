using Microsoft.Data.Sqlite;
using System;
using System.Windows.Forms;

namespace FootballMatch
{
    public partial class AddScheduleForm : Form
    {
        public AddScheduleForm()
        {
            InitializeComponent();
            LoadTeams();
            LoadTournaments();
        }

        private void LoadTeams()
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

        private void LoadTournaments()
        {
            comboBoxTournament.Items.Clear();

            DB db = new DB();
            db.openConnection();

            SqliteCommand cmd = new SqliteCommand("SELECT name FROM tournaments ORDER BY name", db.getConnection());
            using (SqliteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                    comboBoxTournament.Items.Add(reader["name"].ToString());
            }

            db.closeConnection();

            if (comboBoxTournament.Items.Count > 0)
                comboBoxTournament.SelectedIndex = 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
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

            if (comboBoxTournament.SelectedItem == null)
            {
                MessageBox.Show("Оберіть турнір!");
                return;
            }

            string matchDate = datePickerMatch.Value.ToString("yyyy-MM-dd");

            DB db = new DB();
            db.openConnection();

            SqliteCommand cmd = new SqliteCommand(
                "INSERT INTO planned_matches (user_id, tournament, stadium, match_date, team_home, team_away, ticket_category, notes) " +
                "VALUES (1, @tournament, @stadium, @date, @home, @away, '', @notes)",
                db.getConnection());

            cmd.Parameters.AddWithValue("@tournament", comboBoxTournament.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@stadium", textBoxStadium.Text);
            cmd.Parameters.AddWithValue("@date", matchDate);
            cmd.Parameters.AddWithValue("@home", home);
            cmd.Parameters.AddWithValue("@away", away);
            cmd.Parameters.AddWithValue("@notes", textBoxNotes.Text);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            db.closeConnection();

            MessageBox.Show("Матч успішно додано до розкладу!");
            this.Close();
        }
    }
}
