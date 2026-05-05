using Microsoft.Data.Sqlite;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FootballMatch
{
    public partial class ScheduleForm : Form
    {
        private User currentUser;

        public ScheduleForm(User user)
        {
            InitializeComponent();
            currentUser = user;

            buttonAddMatch.Visible = currentUser.IsAdmin;

            LoadSchedule();
        }

        private void LoadSchedule()
        {
            flowLayoutPanelSchedule.Controls.Clear();
            DB db = new DB();
            db.openConnection();

            SqliteCommand command = new SqliteCommand("SELECT * FROM planned_matches", db.getConnection());

            using (SqliteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string teamHome = reader["team_home"].ToString();
                    string teamAway = reader["team_away"].ToString();
                    string matchDate = reader["match_date"].ToString();
                    string tournament = reader["tournament"].ToString();
                    string stadium = reader["stadium"].ToString();
                    string notes = reader["notes"].ToString();

                    Panel card = new Panel();
                    card.Width = 740;
                    card.Height = 90;
                    card.BorderStyle = BorderStyle.FixedSingle;
                    card.BackColor = Color.LightCyan;
                    card.Margin = new Padding(5, 5, 5, 0);

                    Label lblTeams = new Label();
                    lblTeams.Text = teamHome + " — " + teamAway;
                    lblTeams.Font = new Font("Segoe UI", 13, FontStyle.Bold);
                    lblTeams.Location = new Point(12, 8);
                    lblTeams.AutoSize = true;

                    Label lblMeta = new Label();
                    lblMeta.Text = "🏆 " + tournament + "   🏟 " + stadium + "   📅 " + matchDate;
                    lblMeta.Location = new Point(14, 38);
                    lblMeta.AutoSize = true;
                    lblMeta.Font = new Font("Segoe UI", 9F);
                    lblMeta.ForeColor = Color.DimGray;

                    Label lblNotes = new Label();
                    lblNotes.Text = notes != "" ? "📝 " + notes : "";
                    lblNotes.Location = new Point(14, 62);
                    lblNotes.AutoSize = true;
                    lblNotes.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
                    lblNotes.ForeColor = Color.SlateGray;

                    card.Controls.Add(lblTeams);
                    card.Controls.Add(lblMeta);
                    card.Controls.Add(lblNotes);
                    flowLayoutPanelSchedule.Controls.Add(card);
                }
            }

            if (flowLayoutPanelSchedule.Controls.Count == 0)
            {
                Label lblEmpty = new Label();
                lblEmpty.Text = "Немає запланованих матчів.";
                lblEmpty.Font = new Font("Segoe UI", 11F);
                lblEmpty.ForeColor = Color.Gray;
                lblEmpty.Location = new Point(10, 10);
                lblEmpty.AutoSize = true;
                flowLayoutPanelSchedule.Controls.Add(lblEmpty);
            }

            db.closeConnection();
        }

        private void buttonAddMatch_Click(object sender, EventArgs e)
        {
            AddScheduleForm addForm = new AddScheduleForm();
            addForm.ShowDialog();
            LoadSchedule();
        }
    }
}
