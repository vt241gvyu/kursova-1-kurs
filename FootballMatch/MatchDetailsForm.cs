using Microsoft.Data.Sqlite;
using System;
using System.Windows.Forms;

namespace FootballMatch
{
    public partial class MatchDetailsForm : Form
    {
        private int matchId;
        private User currentUser;

        public MatchDetailsForm(int id, User user)
        {
            InitializeComponent();
            matchId = id;
            currentUser = user;

            if (currentUser.IsAdmin)
                panelAdminScore.Visible = true;

            LoadMatch();
        }

        private void LoadMatch()
        {
            DB db = new DB();
            db.openConnection();

            SqliteCommand cmd = new SqliteCommand(
                "SELECT * FROM planned_matches WHERE id = @id", db.getConnection());
            cmd.Parameters.AddWithValue("@id", matchId);

            using (SqliteDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string home = reader["team_home"].ToString();
                    string away = reader["team_away"].ToString();
                    string score = reader["score"]?.ToString() ?? "";
                    string tournament = reader["tournament"].ToString();
                    string stadium = reader["stadium"].ToString();
                    string date = reader["match_date"].ToString();
                    string notes = reader["notes"].ToString();

                    labelTeams.Text = home + "  vs  " + away;
                    labelScore.Text = score != "" ? score : "—";
                    labelMeta.Text = "🏆 " + tournament + "   🏟 " + stadium + "   📅 " + date;
                    labelNotes.Text = notes != "" ? "📝 " + notes : "";

                    if (score != "")
                        textBoxScore.Text = score;
                }
            }

            db.closeConnection();
        }

        private void buttonSaveScore_Click(object sender, EventArgs e)
        {
            if (textBoxScore.Text.Trim() == "")
            {
                MessageBox.Show("Введіть рахунок!");
                return;
            }

            DB db = new DB();
            db.openConnection();

            SqliteCommand cmd = new SqliteCommand(
                "UPDATE planned_matches SET score = @score WHERE id = @id",
                db.getConnection());
            cmd.Parameters.AddWithValue("@score", textBoxScore.Text.Trim());
            cmd.Parameters.AddWithValue("@id", matchId);
            cmd.ExecuteNonQuery();

            db.closeConnection();

            LoadMatch();
            MessageBox.Show("Рахунок збережено!");
        }
    }
}
