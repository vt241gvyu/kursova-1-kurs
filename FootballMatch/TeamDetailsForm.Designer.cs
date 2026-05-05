namespace FootballMatch
{
    partial class TeamDetailsForm
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
            buttonBack = new Button();
            labelTeamName = new Label();
            labelPlayersTitle = new Label();
            listBoxPlayers = new ListBox();
            groupBoxActions = new GroupBox();
            labelNewPlayer = new Label();
            textBoxNewPlayer = new TextBox();
            buttonAddPlayer = new Button();
            buttonRemovePlayer = new Button();
            buttonDeleteTeam = new Button();
            groupBoxActions.SuspendLayout();
            SuspendLayout();

            buttonBack.Location = new Point(12, 12);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(80, 30);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "← Назад";
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.BackColor = Color.LightGray;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.Font = new Font("Segoe UI", 9F);
            buttonBack.Click += (s, e) => this.Close();

            labelTeamName.AutoSize = true;
            labelTeamName.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTeamName.Location = new Point(105, 15);
            labelTeamName.Name = "labelTeamName";
            labelTeamName.Text = "Команда";

            labelPlayersTitle.AutoSize = true;
            labelPlayersTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelPlayersTitle.ForeColor = Color.Gray;
            labelPlayersTitle.Location = new Point(12, 58);
            labelPlayersTitle.Name = "labelPlayersTitle";
            labelPlayersTitle.Text = "Склад команди:";

            listBoxPlayers.FormattingEnabled = true;
            listBoxPlayers.Location = new Point(12, 80);
            listBoxPlayers.Name = "listBoxPlayers";
            listBoxPlayers.Size = new Size(255, 264);
            listBoxPlayers.TabIndex = 1;
            listBoxPlayers.Font = new Font("Segoe UI", 10F);

            groupBoxActions.Location = new Point(285, 55);
            groupBoxActions.Name = "groupBoxActions";
            groupBoxActions.Size = new Size(280, 300);
            groupBoxActions.Text = "Дії";
            groupBoxActions.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxActions.TabIndex = 2;

            labelNewPlayer.AutoSize = true;
            labelNewPlayer.Location = new Point(10, 30);
            labelNewPlayer.Name = "labelNewPlayer";
            labelNewPlayer.Text = "Ім'я нового гравця:";
            labelNewPlayer.Font = new Font("Segoe UI", 9F);

            textBoxNewPlayer.Location = new Point(10, 52);
            textBoxNewPlayer.Name = "textBoxNewPlayer";
            textBoxNewPlayer.Size = new Size(255, 27);
            textBoxNewPlayer.TabIndex = 0;
            textBoxNewPlayer.PlaceholderText = "Введіть ім'я гравця";

            buttonAddPlayer.Location = new Point(10, 90);
            buttonAddPlayer.Name = "buttonAddPlayer";
            buttonAddPlayer.Size = new Size(255, 32);
            buttonAddPlayer.TabIndex = 1;
            buttonAddPlayer.Text = "➕ Додати гравця";
            buttonAddPlayer.BackColor = Color.SeaGreen;
            buttonAddPlayer.ForeColor = Color.White;
            buttonAddPlayer.FlatStyle = FlatStyle.Flat;
            buttonAddPlayer.FlatAppearance.BorderSize = 0;
            buttonAddPlayer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAddPlayer.UseVisualStyleBackColor = false;
            buttonAddPlayer.Click += buttonAddPlayer_Click;

            buttonRemovePlayer.Location = new Point(10, 135);
            buttonRemovePlayer.Name = "buttonRemovePlayer";
            buttonRemovePlayer.Size = new Size(255, 32);
            buttonRemovePlayer.TabIndex = 2;
            buttonRemovePlayer.Text = "➖ Видалити вибраного гравця";
            buttonRemovePlayer.BackColor = Color.OrangeRed;
            buttonRemovePlayer.ForeColor = Color.White;
            buttonRemovePlayer.FlatStyle = FlatStyle.Flat;
            buttonRemovePlayer.FlatAppearance.BorderSize = 0;
            buttonRemovePlayer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonRemovePlayer.UseVisualStyleBackColor = false;
            buttonRemovePlayer.Click += buttonRemovePlayer_Click;

            buttonDeleteTeam.Location = new Point(10, 240);
            buttonDeleteTeam.Name = "buttonDeleteTeam";
            buttonDeleteTeam.Size = new Size(255, 32);
            buttonDeleteTeam.TabIndex = 3;
            buttonDeleteTeam.Text = "🗑 Видалити всю команду";
            buttonDeleteTeam.BackColor = Color.IndianRed;
            buttonDeleteTeam.ForeColor = Color.White;
            buttonDeleteTeam.FlatStyle = FlatStyle.Flat;
            buttonDeleteTeam.FlatAppearance.BorderSize = 0;
            buttonDeleteTeam.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonDeleteTeam.UseVisualStyleBackColor = false;
            buttonDeleteTeam.Click += buttonDeleteTeam_Click;

            groupBoxActions.Controls.Add(labelNewPlayer);
            groupBoxActions.Controls.Add(textBoxNewPlayer);
            groupBoxActions.Controls.Add(buttonAddPlayer);
            groupBoxActions.Controls.Add(buttonRemovePlayer);
            groupBoxActions.Controls.Add(buttonDeleteTeam);
            groupBoxActions.ResumeLayout(false);
            groupBoxActions.PerformLayout();

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 500);
            Controls.Add(buttonBack);
            Controls.Add(labelTeamName);
            Controls.Add(labelPlayersTitle);
            Controls.Add(listBoxPlayers);
            Controls.Add(groupBoxActions);
            Name = "TeamDetailsForm";
            Text = "Деталі команди";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Button buttonBack;
        private Label labelTeamName;
        private Label labelPlayersTitle;
        private ListBox listBoxPlayers;
        private GroupBox groupBoxActions;
        private Label labelNewPlayer;
        private TextBox textBoxNewPlayer;
        private Button buttonAddPlayer;
        private Button buttonRemovePlayer;
        private Button buttonDeleteTeam;
    }
}
