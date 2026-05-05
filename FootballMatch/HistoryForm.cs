using Microsoft.Data.Sqlite;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FootballMatch
{
    public partial class HistoryForm : Form
    {
        private User currentUser;

        public HistoryForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadHistory();
        }

        private void LoadHistory()
        {
            flowLayoutPanelHistory.Controls.Clear();

            DB db = new DB();
            db.openConnection();

            string today = DateTime.Today.ToString("yyyy-MM-dd");
            SqliteCommand command = new SqliteCommand(
                "SELECT * FROM planned_matches WHERE match_date < @today ORDER BY match_date DESC",
                db.getConnection());
            command.Parameters.AddWithValue("@today", today);

            bool hasMatches = false;

            using (SqliteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    hasMatches = true;
                    int id = Convert.ToInt32(reader["id"]);
                    string teamHome = reader["team_home"].ToString();
                    string teamAway = reader["team_away"].ToString();
                    string score = reader["score"]?.ToString() ?? "";
                    string tournament = reader["tournament"].ToString();
                    string stadium = reader["stadium"].ToString();
                    string matchDate = reader["match_date"].ToString();
                    string notes = reader["notes"].ToString();

                    string scoreDisplay = score != "" ? score : "—";

                    Panel card = new Panel();
                    card.Width = 740;
                    card.Height = 100;
                    card.BorderStyle = BorderStyle.FixedSingle;
                    card.BackColor = score != "" ? Color.FromArgb(232, 245, 232) : Color.FromArgb(245, 245, 245);
                    card.Margin = new Padding(5, 5, 5, 0);

                    Label lblTeams = new Label();
                    lblTeams.Text = teamHome + "  " + scoreDisplay + "  " + teamAway;
                    lblTeams.Font = new Font("Segoe UI", 13, FontStyle.Bold);
                    lblTeams.Location = new Point(12, 8);
                    lblTeams.AutoSize = true;
                    lblTeams.ForeColor = score != "" ? Color.DarkGreen : Color.DimGray;

                    Label lblMeta = new Label();
                    lblMeta.Text = "🏆 " + tournament + "   🏟 " + stadium + "   📅 " + matchDate;
                    lblMeta.Location = new Point(14, 40);
                    lblMeta.AutoSize = true;
                    lblMeta.Font = new Font("Segoe UI", 9F);
                    lblMeta.ForeColor = Color.DimGray;

                    Label lblStatus = new Label();
                    lblStatus.AutoSize = true;
                    lblStatus.Location = new Point(14, 68);
                    lblStatus.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
                    if (score != "")
                    {
                        lblStatus.Text = "✅ Рахунок зафіксовано";
                        lblStatus.ForeColor = Color.SeaGreen;
                    }
                    else
                    {
                        lblStatus.Text = "⏳ Рахунок не вказано";
                        lblStatus.ForeColor = Color.Gray;
                    }

                    Button btnView = new Button();
                    btnView.Text = "Переглянути";
                    btnView.Location = new Point(610, 30);
                    btnView.Size = new Size(115, 38);
                    btnView.FlatStyle = FlatStyle.Flat;
                    btnView.BackColor = Color.SteelBlue;
                    btnView.ForeColor = Color.White;
                    btnView.FlatAppearance.BorderSize = 0;
                    btnView.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    int matchId = id;
                    btnView.Click += (s, ev) =>
                    {
                        MatchDetailsForm details = new MatchDetailsForm(matchId, currentUser);
                        details.ShowDialog();
                        LoadHistory();
                    };

                    card.Controls.Add(lblTeams);
                    card.Controls.Add(lblMeta);
                    card.Controls.Add(lblStatus);
                    card.Controls.Add(btnView);
                    flowLayoutPanelHistory.Controls.Add(card);
                }
            }

            db.closeConnection();

            if (!hasMatches)
            {
                Label lblEmpty = new Label();
                lblEmpty.Text = "Зіграних матчів ще немає.";
                lblEmpty.Font = new Font("Segoe UI", 11F);
                lblEmpty.ForeColor = Color.Gray;
                lblEmpty.AutoSize = true;
                flowLayoutPanelHistory.Controls.Add(lblEmpty);
            }
        }
    }
}
