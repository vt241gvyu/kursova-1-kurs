using Microsoft.Data.Sqlite;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FootballMatch
{
    public partial class TeamsForm : Form
    {
        public TeamsForm()
        {
            InitializeComponent();
            LoadTeams();
        }

        private void LoadTeams()
        {
            flowLayoutPanelTeams.Controls.Clear();
            DB db = new DB();
            db.openConnection();

            SqliteCommand command = new SqliteCommand("SELECT team_name AS team FROM teams", db.getConnection());

            using (SqliteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string team = reader["team"].ToString();

                    Panel card = new Panel();
                    card.Width = 600;
                    card.Height = 60;
                    card.BorderStyle = BorderStyle.FixedSingle;
                    card.BackColor = Color.LightGreen;
                    card.Margin = new Padding(10);

                    Label lblName = new Label();
                    lblName.Text = "Команда: " + team;
                    lblName.Font = new Font("Arial", 14, FontStyle.Bold);
                    lblName.Location = new Point(10, 15);
                    lblName.AutoSize = true;

                    Button btnView = new Button();
                    btnView.Text = "Склад";
                    btnView.Location = new Point(460, 10);
                    btnView.Size = new Size(120, 40);
                    btnView.Click += (s, ev) => { TeamDetailsForm detailsForm = new TeamDetailsForm(team); detailsForm.ShowDialog(); };

                    card.Controls.Add(lblName);
                    card.Controls.Add(btnView);
                    flowLayoutPanelTeams.Controls.Add(card);
                }
            }

            command.Dispose();
            db.closeConnection();
        }

        private void buttonAddNewTeam_Click(object sender, EventArgs e)
        {
            AddTeamForm addForm = new AddTeamForm(); addForm.ShowDialog(); LoadTeams();
        }
    }
}