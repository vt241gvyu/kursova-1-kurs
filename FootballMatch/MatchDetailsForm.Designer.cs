namespace FootballMatch
{
    partial class MatchDetailsForm
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
            labelTitle = new Label();
            panelBanner = new Panel();
            labelTeams = new Label();
            labelScore = new Label();
            labelMeta = new Label();
            labelNotes = new Label();
            panelAdminScore = new Panel();
            labelAdminHint = new Label();
            textBoxScore = new TextBox();
            buttonSaveScore = new Button();
            panelBanner.SuspendLayout();
            panelAdminScore.SuspendLayout();
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

            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitle.Location = new Point(110, 17);
            labelTitle.Name = "labelTitle";
            labelTitle.Text = "Деталі матчу";

            panelBanner.Location = new Point(20, 60);
            panelBanner.Name = "panelBanner";
            panelBanner.Size = new Size(540, 180);
            panelBanner.BackColor = Color.FromArgb(30, 80, 140);
            panelBanner.BorderStyle = BorderStyle.None;

            labelTeams.AutoSize = false;
            labelTeams.Size = new Size(540, 50);
            labelTeams.Location = new Point(0, 20);
            labelTeams.Name = "labelTeams";
            labelTeams.Text = "";
            labelTeams.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelTeams.ForeColor = Color.White;
            labelTeams.TextAlign = ContentAlignment.MiddleCenter;

            labelScore.AutoSize = false;
            labelScore.Size = new Size(540, 60);
            labelScore.Location = new Point(0, 70);
            labelScore.Name = "labelScore";
            labelScore.Text = "—";
            labelScore.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            labelScore.ForeColor = Color.FromArgb(255, 220, 80);
            labelScore.TextAlign = ContentAlignment.MiddleCenter;

            labelMeta.AutoSize = false;
            labelMeta.Size = new Size(540, 30);
            labelMeta.Location = new Point(0, 138);
            labelMeta.Name = "labelMeta";
            labelMeta.Text = "";
            labelMeta.Font = new Font("Segoe UI", 9F);
            labelMeta.ForeColor = Color.FromArgb(200, 220, 255);
            labelMeta.TextAlign = ContentAlignment.MiddleCenter;

            panelBanner.Controls.Add(labelTeams);
            panelBanner.Controls.Add(labelScore);
            panelBanner.Controls.Add(labelMeta);

            labelNotes.AutoSize = false;
            labelNotes.Size = new Size(540, 30);
            labelNotes.Location = new Point(20, 252);
            labelNotes.Name = "labelNotes";
            labelNotes.Text = "";
            labelNotes.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelNotes.ForeColor = Color.SlateGray;

            panelAdminScore.Location = new Point(20, 295);
            panelAdminScore.Name = "panelAdminScore";
            panelAdminScore.Size = new Size(540, 70);
            panelAdminScore.BackColor = Color.FromArgb(245, 248, 255);
            panelAdminScore.BorderStyle = BorderStyle.FixedSingle;
            panelAdminScore.Visible = false;

            labelAdminHint.AutoSize = true;
            labelAdminHint.Location = new Point(10, 10);
            labelAdminHint.Name = "labelAdminHint";
            labelAdminHint.Text = "✏ Встановити / змінити рахунок:";
            labelAdminHint.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAdminHint.ForeColor = Color.DarkSlateBlue;

            textBoxScore.Location = new Point(10, 35);
            textBoxScore.Name = "textBoxScore";
            textBoxScore.Size = new Size(120, 27);
            textBoxScore.TabIndex = 0;
            textBoxScore.PlaceholderText = "напр. 2:1";
            textBoxScore.Font = new Font("Segoe UI", 10F);

            buttonSaveScore.Location = new Point(145, 34);
            buttonSaveScore.Name = "buttonSaveScore";
            buttonSaveScore.Size = new Size(160, 29);
            buttonSaveScore.Text = "💾 Зберегти рахунок";
            buttonSaveScore.BackColor = Color.SteelBlue;
            buttonSaveScore.ForeColor = Color.White;
            buttonSaveScore.FlatStyle = FlatStyle.Flat;
            buttonSaveScore.FlatAppearance.BorderSize = 0;
            buttonSaveScore.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSaveScore.UseVisualStyleBackColor = false;
            buttonSaveScore.Click += buttonSaveScore_Click;

            panelAdminScore.Controls.Add(labelAdminHint);
            panelAdminScore.Controls.Add(textBoxScore);
            panelAdminScore.Controls.Add(buttonSaveScore);

            panelBanner.ResumeLayout(false);
            panelAdminScore.ResumeLayout(false);
            panelAdminScore.PerformLayout();

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 500);
            Controls.Add(buttonBack);
            Controls.Add(labelTitle);
            Controls.Add(panelBanner);
            Controls.Add(labelNotes);
            Controls.Add(panelAdminScore);
            Name = "MatchDetailsForm";
            Text = "Деталі матчу";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Button buttonBack;
        private Label labelTitle;
        private Panel panelBanner;
        private Label labelTeams;
        private Label labelScore;
        private Label labelMeta;
        private Label labelNotes;
        private Panel panelAdminScore;
        private Label labelAdminHint;
        private TextBox textBoxScore;
        private Button buttonSaveScore;
    }
}
