namespace FootballMatch
{
    partial class TeamsForm
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
            buttonAddNewTeam = new Button();
            flowLayoutPanelTeams = new FlowLayoutPanel();
            SuspendLayout();

            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle.Location = new Point(100, 18);
            labelTitle.Name = "labelTitle";
            labelTitle.Text = "👥 Команди";

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

            buttonAddNewTeam.Location = new Point(640, 12);
            buttonAddNewTeam.Name = "buttonAddNewTeam";
            buttonAddNewTeam.Size = new Size(150, 30);
            buttonAddNewTeam.TabIndex = 1;
            buttonAddNewTeam.Text = "+ Додати команду";
            buttonAddNewTeam.BackColor = Color.SeaGreen;
            buttonAddNewTeam.ForeColor = Color.White;
            buttonAddNewTeam.FlatStyle = FlatStyle.Flat;
            buttonAddNewTeam.FlatAppearance.BorderSize = 0;
            buttonAddNewTeam.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAddNewTeam.UseVisualStyleBackColor = false;
            buttonAddNewTeam.Click += buttonAddNewTeam_Click;

            flowLayoutPanelTeams.AutoScroll = true;
            flowLayoutPanelTeams.Location = new Point(9, 55);
            flowLayoutPanelTeams.Name = "flowLayoutPanelTeams";
            flowLayoutPanelTeams.Size = new Size(779, 433);
            flowLayoutPanelTeams.TabIndex = 2;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 500);
            Controls.Add(labelTitle);
            Controls.Add(buttonBack);
            Controls.Add(buttonAddNewTeam);
            Controls.Add(flowLayoutPanelTeams);
            Name = "TeamsForm";
            Text = "Команди";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }
        #endregion

        private Label labelTitle;
        private Button buttonBack;
        private FlowLayoutPanel flowLayoutPanelTeams;
        private Button buttonAddNewTeam;
    }
}
