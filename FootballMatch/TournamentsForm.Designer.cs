namespace FootballMatch
{
    partial class TournamentsForm
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
            labelTitle = new Label();
            buttonBack = new Button();
            buttonAddTournament = new Button();
            flowLayoutPanelTournaments = new FlowLayoutPanel();
            SuspendLayout();

            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle.Location = new Point(100, 18);
            labelTitle.Name = "labelTitle";
            labelTitle.Text = "🏆 Турніри";

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

            buttonAddTournament.Location = new Point(640, 12);
            buttonAddTournament.Name = "buttonAddTournament";
            buttonAddTournament.Size = new Size(150, 30);
            buttonAddTournament.TabIndex = 1;
            buttonAddTournament.Text = "+ Додати турнір";
            buttonAddTournament.BackColor = Color.DarkGoldenrod;
            buttonAddTournament.ForeColor = Color.White;
            buttonAddTournament.FlatStyle = FlatStyle.Flat;
            buttonAddTournament.FlatAppearance.BorderSize = 0;
            buttonAddTournament.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAddTournament.UseVisualStyleBackColor = false;
            buttonAddTournament.Click += buttonAddTournament_Click;

            flowLayoutPanelTournaments.AutoScroll = true;
            flowLayoutPanelTournaments.Location = new Point(12, 55);
            flowLayoutPanelTournaments.Name = "flowLayoutPanelTournaments";
            flowLayoutPanelTournaments.Size = new Size(776, 383);
            flowLayoutPanelTournaments.TabIndex = 2;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 500);
            Controls.Add(labelTitle);
            Controls.Add(buttonBack);
            Controls.Add(buttonAddTournament);
            Controls.Add(flowLayoutPanelTournaments);
            Name = "TournamentsForm";
            Text = "Турніри";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }
        #endregion

        private Label labelTitle;
        private Button buttonBack;
        private FlowLayoutPanel flowLayoutPanelTournaments;
        private Button buttonAddTournament;
    }
}
