using Microsoft.Data.Sqlite;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FootballMatch
{
    public partial class TournamentsForm : Form
    {
        public TournamentsForm()
        {
            InitializeComponent();
            LoadTournaments();
        }

        private void LoadTournaments()
        {
            flowLayoutPanelTournaments.Controls.Clear();
            DB db = new DB();
            db.openConnection();

            SqliteCommand createCmd = new SqliteCommand("CREATE TABLE IF NOT EXISTS tournaments (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT); CREATE TABLE IF NOT EXISTS tournament_matches (id INTEGER PRIMARY KEY AUTOINCREMENT, tournament_name TEXT, match_info TEXT, score TEXT);", db.getConnection());
            createCmd.ExecuteNonQuery();
            createCmd.Dispose();

            SqliteCommand command = new SqliteCommand("SELECT name FROM tournaments", db.getConnection());

            using (SqliteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string tName = reader["name"].ToString();

                    Panel card = new Panel();
                    card.Width = 600;
                    card.Height = 60;
                    card.BorderStyle = BorderStyle.FixedSingle;
                    card.BackColor = Color.LightYellow;
                    card.Margin = new Padding(10);

                    Label lblName = new Label();
                    lblName.Text = "Турнір: " + tName;
                    lblName.Font = new Font("Arial", 14, FontStyle.Bold);
                    lblName.Location = new Point(10, 15);
                    lblName.AutoSize = true;

                    Button btnView = new Button();
                    btnView.Text = "Деталі";
                    btnView.Location = new Point(460, 10);
                    btnView.Size = new Size(120, 40);
                    btnView.Click += (s, ev) => { TournamentDetailsForm detailsForm = new TournamentDetailsForm(tName); detailsForm.ShowDialog(); LoadTournaments(); };

                    card.Controls.Add(lblName);
                    card.Controls.Add(btnView);
                    flowLayoutPanelTournaments.Controls.Add(card);
                }
            }
            command.Dispose();
            db.closeConnection();
        }

        private void buttonAddTournament_Click(object sender, EventArgs e)
        {
            AddTournamentForm addForm = new AddTournamentForm();
            addForm.ShowDialog();
            LoadTournaments();
        }
    }
}