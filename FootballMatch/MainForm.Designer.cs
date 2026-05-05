namespace FootballMatch
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            labelWelcome = new Label();
            labelRole = new Label();
            labelSubtitle = new Label();
            buttonSchedule = new Button();
            buttonHistory = new Button();
            buttonTournaments = new Button();
            buttonTeams = new Button();
            SuspendLayout();

            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelWelcome.Location = new Point(20, 18);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Text = "label1";

            labelRole.AutoSize = true;
            labelRole.Location = new Point(22, 50);
            labelRole.Name = "labelRole";
            labelRole.Text = "";

            labelSubtitle.AutoSize = true;
            labelSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSubtitle.ForeColor = Color.Gray;
            labelSubtitle.Location = new Point(20, 72);
            labelSubtitle.Name = "labelSubtitle";
            labelSubtitle.Text = "Виберіть розділ:";

            buttonSchedule.Location = new Point(20, 105);
            buttonSchedule.Name = "buttonSchedule";
            buttonSchedule.Size = new Size(230, 60);
            buttonSchedule.TabIndex = 0;
            buttonSchedule.Text = "📅  Розклад змагань";
            buttonSchedule.BackColor = Color.SteelBlue;
            buttonSchedule.ForeColor = Color.White;
            buttonSchedule.FlatStyle = FlatStyle.Flat;
            buttonSchedule.FlatAppearance.BorderSize = 0;
            buttonSchedule.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonSchedule.UseVisualStyleBackColor = false;
            buttonSchedule.Click += buttonSchedule_Click;

            buttonHistory.Location = new Point(270, 105);
            buttonHistory.Name = "buttonHistory";
            buttonHistory.Size = new Size(230, 60);
            buttonHistory.TabIndex = 1;
            buttonHistory.Text = "📜  Історія матчів";
            buttonHistory.BackColor = Color.IndianRed;
            buttonHistory.ForeColor = Color.White;
            buttonHistory.FlatStyle = FlatStyle.Flat;
            buttonHistory.FlatAppearance.BorderSize = 0;
            buttonHistory.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonHistory.UseVisualStyleBackColor = false;
            buttonHistory.Click += buttonHistory_Click;

            buttonTournaments.Location = new Point(20, 185);
            buttonTournaments.Name = "buttonTournaments";
            buttonTournaments.Size = new Size(230, 60);
            buttonTournaments.TabIndex = 2;
            buttonTournaments.Text = "🏆  Турніри";
            buttonTournaments.BackColor = Color.DarkGoldenrod;
            buttonTournaments.ForeColor = Color.White;
            buttonTournaments.FlatStyle = FlatStyle.Flat;
            buttonTournaments.FlatAppearance.BorderSize = 0;
            buttonTournaments.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonTournaments.UseVisualStyleBackColor = false;
            buttonTournaments.Click += buttonTournaments_Click;

            buttonTeams.Location = new Point(270, 185);
            buttonTeams.Name = "buttonTeams";
            buttonTeams.Size = new Size(230, 60);
            buttonTeams.TabIndex = 3;
            buttonTeams.Text = "👥  Команди";
            buttonTeams.BackColor = Color.SeaGreen;
            buttonTeams.ForeColor = Color.White;
            buttonTeams.FlatStyle = FlatStyle.Flat;
            buttonTeams.FlatAppearance.BorderSize = 0;
            buttonTeams.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonTeams.UseVisualStyleBackColor = false;
            buttonTeams.Click += buttonTeams_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 500);
            Controls.Add(labelWelcome);
            Controls.Add(labelRole);
            Controls.Add(labelSubtitle);
            Controls.Add(buttonSchedule);
            Controls.Add(buttonHistory);
            Controls.Add(buttonTournaments);
            Controls.Add(buttonTeams);
            Name = "MainForm";
            Text = "⚽ Футбольні Змагання";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label labelWelcome;
        private Label labelRole;
        private Label labelSubtitle;
        private Button buttonSchedule;
        private Button buttonHistory;
        private Button buttonTournaments;
        private Button buttonTeams;
    }
}
