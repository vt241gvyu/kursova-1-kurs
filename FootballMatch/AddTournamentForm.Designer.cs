namespace FootballMatch
{
    partial class AddTournamentForm
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
            label1 = new Label();
            textBoxName = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();

            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle.Location = new Point(30, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Text = "🏆 Новий турнір";

            label1.AutoSize = true;
            label1.Location = new Point(30, 65);
            label1.Name = "label1";
            label1.Text = "Назва турніру:";
            label1.Font = new Font("Segoe UI", 9F);

            textBoxName.Location = new Point(30, 87);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(240, 27);
            textBoxName.TabIndex = 0;
            textBoxName.PlaceholderText = "Введіть назву турніру";

            buttonSave.Location = new Point(30, 132);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(115, 35);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "✔ Зберегти";
            buttonSave.BackColor = Color.DarkGoldenrod;
            buttonSave.ForeColor = Color.White;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;

            buttonCancel.Location = new Point(155, 132);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(115, 35);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "✖ Скасувати";
            buttonCancel.BackColor = Color.LightGray;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.Font = new Font("Segoe UI", 9F);
            buttonCancel.Click += (s, e) => this.Close();

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(400, 280);
            Controls.Add(labelTitle);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Name = "AddTournamentForm";
            Text = "Додати турнір";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label labelTitle;
        private Label label1;
        private TextBox textBoxName;
        private Button buttonSave;
        private Button buttonCancel;
    }
}
