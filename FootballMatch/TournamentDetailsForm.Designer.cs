namespace FootballMatch
{
    partial class TournamentDetailsForm
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
            labelName = new Label();
            labelMatchesTitle = new Label();
            listBoxMatches = new ListBox();
            groupBoxRename = new GroupBox();
            labelNewNameHint = new Label();
            textBoxNewName = new TextBox();
            buttonEditTournamentName = new Button();
            groupBoxMatch = new GroupBox();
            labelHome = new Label();
            comboBoxHome = new ComboBox();
            labelAway = new Label();
            comboBoxAway = new ComboBox();
            buttonAddMatch = new Button();
            labelScore = new Label();
            textBoxScore = new TextBox();
            buttonUpdateScore = new Button();
            groupBoxRename.SuspendLayout();
            groupBoxMatch.SuspendLayout();
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

            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelName.Location = new Point(105, 15);
            labelName.Name = "labelName";
            labelName.Text = "Турнір";

            labelMatchesTitle.AutoSize = true;
            labelMatchesTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelMatchesTitle.ForeColor = Color.Gray;
            labelMatchesTitle.Location = new Point(12, 58);
            labelMatchesTitle.Name = "labelMatchesTitle";
            labelMatchesTitle.Text = "Матчі турніру:";

            listBoxMatches.FormattingEnabled = true;
            listBoxMatches.Location = new Point(12, 80);
            listBoxMatches.Name = "listBoxMatches";
            listBoxMatches.Size = new Size(255, 330);
            listBoxMatches.TabIndex = 1;
            listBoxMatches.Font = new Font("Segoe UI", 9F);

            groupBoxRename.Location = new Point(285, 55);
            groupBoxRename.Name = "groupBoxRename";
            groupBoxRename.Size = new Size(495, 85);
            groupBoxRename.Text = "Перейменувати турнір";
            groupBoxRename.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxRename.TabIndex = 2;

            labelNewNameHint.AutoSize = true;
            labelNewNameHint.Location = new Point(10, 25);
            labelNewNameHint.Name = "labelNewNameHint";
            labelNewNameHint.Text = "Нова назва:";
            labelNewNameHint.Font = new Font("Segoe UI", 9F);

            textBoxNewName.Location = new Point(10, 45);
            textBoxNewName.Name = "textBoxNewName";
            textBoxNewName.Size = new Size(240, 27);
            textBoxNewName.TabIndex = 0;
            textBoxNewName.PlaceholderText = "Введіть нову назву";

            buttonEditTournamentName.Location = new Point(260, 44);
            buttonEditTournamentName.Name = "buttonEditTournamentName";
            buttonEditTournamentName.Size = new Size(220, 29);
            buttonEditTournamentName.TabIndex = 1;
            buttonEditTournamentName.Text = "✏ Зберегти нову назву";
            buttonEditTournamentName.BackColor = Color.SteelBlue;
            buttonEditTournamentName.ForeColor = Color.White;
            buttonEditTournamentName.FlatStyle = FlatStyle.Flat;
            buttonEditTournamentName.FlatAppearance.BorderSize = 0;
            buttonEditTournamentName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonEditTournamentName.UseVisualStyleBackColor = false;
            buttonEditTournamentName.Click += buttonEditTournamentName_Click;

            groupBoxRename.Controls.Add(labelNewNameHint);
            groupBoxRename.Controls.Add(textBoxNewName);
            groupBoxRename.Controls.Add(buttonEditTournamentName);

            groupBoxMatch.Location = new Point(285, 155);
            groupBoxMatch.Name = "groupBoxMatch";
            groupBoxMatch.Size = new Size(495, 255);
            groupBoxMatch.Text = "Додати / оновити матч";
            groupBoxMatch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxMatch.TabIndex = 3;

            labelHome.AutoSize = true;
            labelHome.Location = new Point(10, 28);
            labelHome.Name = "labelHome";
            labelHome.Text = "Господарі:";
            labelHome.Font = new Font("Segoe UI", 9F);

            comboBoxHome.Location = new Point(10, 48);
            comboBoxHome.Name = "comboBoxHome";
            comboBoxHome.Size = new Size(200, 28);
            comboBoxHome.TabIndex = 0;
            comboBoxHome.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHome.Font = new Font("Segoe UI", 9F);

            labelAway.AutoSize = true;
            labelAway.Location = new Point(10, 88);
            labelAway.Name = "labelAway";
            labelAway.Text = "Гості:";
            labelAway.Font = new Font("Segoe UI", 9F);

            comboBoxAway.Location = new Point(10, 108);
            comboBoxAway.Name = "comboBoxAway";
            comboBoxAway.Size = new Size(200, 28);
            comboBoxAway.TabIndex = 1;
            comboBoxAway.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAway.Font = new Font("Segoe UI", 9F);

            buttonAddMatch.Location = new Point(220, 76);
            buttonAddMatch.Name = "buttonAddMatch";
            buttonAddMatch.Size = new Size(260, 38);
            buttonAddMatch.TabIndex = 2;
            buttonAddMatch.Text = "➕ Додати матч";
            buttonAddMatch.BackColor = Color.SeaGreen;
            buttonAddMatch.ForeColor = Color.White;
            buttonAddMatch.FlatStyle = FlatStyle.Flat;
            buttonAddMatch.FlatAppearance.BorderSize = 0;
            buttonAddMatch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAddMatch.UseVisualStyleBackColor = false;
            buttonAddMatch.Click += buttonAddMatch_Click;

            labelScore.AutoSize = true;
            labelScore.Location = new Point(10, 158);
            labelScore.Name = "labelScore";
            labelScore.Text = "Новий рахунок (напр. 2:1):";
            labelScore.Font = new Font("Segoe UI", 9F);

            textBoxScore.Location = new Point(10, 178);
            textBoxScore.Name = "textBoxScore";
            textBoxScore.Size = new Size(200, 27);
            textBoxScore.TabIndex = 3;
            textBoxScore.PlaceholderText = "0:0";

            buttonUpdateScore.Location = new Point(220, 176);
            buttonUpdateScore.Name = "buttonUpdateScore";
            buttonUpdateScore.Size = new Size(260, 38);
            buttonUpdateScore.TabIndex = 4;
            buttonUpdateScore.Text = "🔄 Оновити рахунок вибраного";
            buttonUpdateScore.BackColor = Color.DarkGoldenrod;
            buttonUpdateScore.ForeColor = Color.White;
            buttonUpdateScore.FlatStyle = FlatStyle.Flat;
            buttonUpdateScore.FlatAppearance.BorderSize = 0;
            buttonUpdateScore.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonUpdateScore.UseVisualStyleBackColor = false;
            buttonUpdateScore.Click += buttonUpdateScore_Click;

            groupBoxMatch.Controls.Add(labelHome);
            groupBoxMatch.Controls.Add(comboBoxHome);
            groupBoxMatch.Controls.Add(labelAway);
            groupBoxMatch.Controls.Add(comboBoxAway);
            groupBoxMatch.Controls.Add(buttonAddMatch);
            groupBoxMatch.Controls.Add(labelScore);
            groupBoxMatch.Controls.Add(textBoxScore);
            groupBoxMatch.Controls.Add(buttonUpdateScore);

            groupBoxRename.ResumeLayout(false);
            groupBoxRename.PerformLayout();
            groupBoxMatch.ResumeLayout(false);
            groupBoxMatch.PerformLayout();

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 500);
            Controls.Add(buttonBack);
            Controls.Add(labelName);
            Controls.Add(labelMatchesTitle);
            Controls.Add(listBoxMatches);
            Controls.Add(groupBoxRename);
            Controls.Add(groupBoxMatch);
            Name = "TournamentDetailsForm";
            Text = "Деталі турніру";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Button buttonBack;
        private Label labelName;
        private Label labelMatchesTitle;
        private ListBox listBoxMatches;
        private GroupBox groupBoxRename;
        private Label labelNewNameHint;
        private TextBox textBoxNewName;
        private Button buttonEditTournamentName;
        private GroupBox groupBoxMatch;
        private Label labelHome;
        private ComboBox comboBoxHome;
        private Label labelAway;
        private ComboBox comboBoxAway;
        private Button buttonAddMatch;
        private Label labelScore;
        private TextBox textBoxScore;
        private Button buttonUpdateScore;
    }
}
