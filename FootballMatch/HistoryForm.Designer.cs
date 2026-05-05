namespace FootballMatch
{
    partial class HistoryForm
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
            flowLayoutPanelHistory = new FlowLayoutPanel();
            SuspendLayout();

            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle.Location = new Point(100, 18);
            labelTitle.Name = "labelTitle";
            labelTitle.Text = "📜 Історія матчів";

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

            flowLayoutPanelHistory.AutoScroll = true;
            flowLayoutPanelHistory.Location = new Point(14, 55);
            flowLayoutPanelHistory.Name = "flowLayoutPanelHistory";
            flowLayoutPanelHistory.Size = new Size(774, 433);
            flowLayoutPanelHistory.TabIndex = 1;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 500);
            Controls.Add(labelTitle);
            Controls.Add(buttonBack);
            Controls.Add(flowLayoutPanelHistory);
            Name = "HistoryForm";
            Text = "Історія матчів";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }
        #endregion

        private Label labelTitle;
        private Button buttonBack;
        private FlowLayoutPanel flowLayoutPanelHistory;
    }
}
