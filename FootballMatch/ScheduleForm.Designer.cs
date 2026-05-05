namespace FootballMatch
{
    partial class ScheduleForm
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
            buttonAddMatch = new Button();
            flowLayoutPanelSchedule = new FlowLayoutPanel();
            SuspendLayout();

            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle.Location = new Point(100, 18);
            labelTitle.Name = "labelTitle";
            labelTitle.Text = "📅 Розклад матчів";

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

            buttonAddMatch.Location = new Point(630, 12);
            buttonAddMatch.Name = "buttonAddMatch";
            buttonAddMatch.Size = new Size(160, 30);
            buttonAddMatch.TabIndex = 1;
            buttonAddMatch.Text = "+ Додати матч";
            buttonAddMatch.BackColor = Color.SteelBlue;
            buttonAddMatch.ForeColor = Color.White;
            buttonAddMatch.FlatStyle = FlatStyle.Flat;
            buttonAddMatch.FlatAppearance.BorderSize = 0;
            buttonAddMatch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAddMatch.UseVisualStyleBackColor = false;
            buttonAddMatch.Visible = false;
            buttonAddMatch.Click += buttonAddMatch_Click;

            flowLayoutPanelSchedule.AutoScroll = true;
            flowLayoutPanelSchedule.Location = new Point(12, 55);
            flowLayoutPanelSchedule.Name = "flowLayoutPanelSchedule";
            flowLayoutPanelSchedule.Size = new Size(776, 433);
            flowLayoutPanelSchedule.TabIndex = 2;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 500);
            Controls.Add(labelTitle);
            Controls.Add(buttonBack);
            Controls.Add(buttonAddMatch);
            Controls.Add(flowLayoutPanelSchedule);
            Name = "ScheduleForm";
            Text = "Розклад матчів";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label labelTitle;
        private Button buttonBack;
        private Button buttonAddMatch;
        private FlowLayoutPanel flowLayoutPanelSchedule;
    }
}
