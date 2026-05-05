using System;
using System.Drawing;
using System.Windows.Forms;

namespace FootballMatch
{
    public partial class MainForm : Form
    {
        private User currentUser;

        public MainForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            labelWelcome.Text = "Вітаємо, " + currentUser.Login + "!";

            if (currentUser.IsAdmin)
            {
                labelRole.Text = "👑 Адміністратор";
                labelRole.ForeColor = Color.DarkGoldenrod;
                labelRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
            else
            {
                labelRole.Text = "👤 Користувач";
                labelRole.ForeColor = Color.SteelBlue;
                labelRole.Font = new Font("Segoe UI", 9F, FontStyle.Regular);

                buttonTournaments.Visible = false;
                buttonTeams.Visible = false;
            }
        }

        private void buttonSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScheduleForm scheduleForm = new ScheduleForm(currentUser);
            scheduleForm.ShowDialog();
            this.Show();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            HistoryForm historyForm = new HistoryForm(currentUser);
            historyForm.ShowDialog();
            this.Show();
        }

        private void buttonTournaments_Click(object sender, EventArgs e)
        {
            this.Hide();
            TournamentsForm tournamentsForm = new TournamentsForm();
            tournamentsForm.ShowDialog();
            this.Show();
        }

        private void buttonTeams_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeamsForm teamsForm = new TeamsForm();
            teamsForm.ShowDialog();
            this.Show();
        }
    }
}
