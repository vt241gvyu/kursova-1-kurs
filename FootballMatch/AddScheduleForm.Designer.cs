namespace FootballMatch
{
    partial class AddScheduleForm
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
            labelHome = new Label();
            comboBoxHome = new ComboBox();
            labelAway = new Label();
            comboBoxAway = new ComboBox();
            labelTournament = new Label();
            comboBoxTournament = new ComboBox();
            labelStadium = new Label();
            textBoxStadium = new TextBox();
            labelDate = new Label();
            datePickerMatch = new DateTimePicker();
            labelNotes = new Label();
            textBoxNotes = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();

            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle.Location = new Point(20, 15);
            labelTitle.Name = "labelTitle";
            labelTitle.Text = "📅 Новий матч у розкладі";

            labelHome.AutoSize = true;
            labelHome.Location = new Point(20, 58);
            labelHome.Name = "labelHome";
            labelHome.Text = "Команда господарів:";
            labelHome.Font = new Font("Segoe UI", 9F);

            comboBoxHome.Location = new Point(20, 78);
            comboBoxHome.Name = "comboBoxHome";
            comboBoxHome.Size = new Size(200, 28);
            comboBoxHome.TabIndex = 0;
            comboBoxHome.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHome.Font = new Font("Segoe UI", 9F);

            labelAway.AutoSize = true;
            labelAway.Location = new Point(240, 58);
            labelAway.Name = "labelAway";
            labelAway.Text = "Команда гостей:";
            labelAway.Font = new Font("Segoe UI", 9F);

            comboBoxAway.Location = new Point(240, 78);
            comboBoxAway.Name = "comboBoxAway";
            comboBoxAway.Size = new Size(200, 28);
            comboBoxAway.TabIndex = 1;
            comboBoxAway.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAway.Font = new Font("Segoe UI", 9F);

            labelTournament.AutoSize = true;
            labelTournament.Location = new Point(20, 120);
            labelTournament.Name = "labelTournament";
            labelTournament.Text = "Турнір / Ліга:";
            labelTournament.Font = new Font("Segoe UI", 9F);

            comboBoxTournament.Location = new Point(20, 140);
            comboBoxTournament.Name = "comboBoxTournament";
            comboBoxTournament.Size = new Size(200, 28);
            comboBoxTournament.TabIndex = 2;
            comboBoxTournament.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTournament.Font = new Font("Segoe UI", 9F);

            labelStadium.AutoSize = true;
            labelStadium.Location = new Point(240, 120);
            labelStadium.Name = "labelStadium";
            labelStadium.Text = "Стадіон:";
            labelStadium.Font = new Font("Segoe UI", 9F);

            textBoxStadium.Location = new Point(240, 140);
            textBoxStadium.Name = "textBoxStadium";
            textBoxStadium.Size = new Size(200, 27);
            textBoxStadium.TabIndex = 3;
            textBoxStadium.PlaceholderText = "Напр. Арена Львів";

            labelDate.AutoSize = true;
            labelDate.Location = new Point(20, 182);
            labelDate.Name = "labelDate";
            labelDate.Text = "Дата матчу:";
            labelDate.Font = new Font("Segoe UI", 9F);

            datePickerMatch.Location = new Point(20, 202);
            datePickerMatch.Name = "datePickerMatch";
            datePickerMatch.Size = new Size(200, 27);
            datePickerMatch.TabIndex = 4;
            datePickerMatch.Format = DateTimePickerFormat.Short;

            labelNotes.AutoSize = true;
            labelNotes.Location = new Point(20, 244);
            labelNotes.Name = "labelNotes";
            labelNotes.Text = "Нотатки (необов'язково):";
            labelNotes.Font = new Font("Segoe UI", 9F);

            textBoxNotes.Location = new Point(20, 264);
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.Size = new Size(420, 27);
            textBoxNotes.TabIndex = 5;
            textBoxNotes.PlaceholderText = "Будь-які нотатки про матч";

            buttonSave.Location = new Point(20, 312);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(200, 38);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "✔ Зберегти матч";
            buttonSave.BackColor = Color.SteelBlue;
            buttonSave.ForeColor = Color.White;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;

            buttonCancel.Location = new Point(240, 312);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(200, 38);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "✖ Скасувати";
            buttonCancel.BackColor = Color.LightGray;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.Font = new Font("Segoe UI", 10F);
            buttonCancel.Click += (s, e) => this.Close();

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 500);
            Controls.Add(labelTitle);
            Controls.Add(labelHome);
            Controls.Add(comboBoxHome);
            Controls.Add(labelAway);
            Controls.Add(comboBoxAway);
            Controls.Add(labelTournament);
            Controls.Add(comboBoxTournament);
            Controls.Add(labelStadium);
            Controls.Add(textBoxStadium);
            Controls.Add(labelDate);
            Controls.Add(datePickerMatch);
            Controls.Add(labelNotes);
            Controls.Add(textBoxNotes);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Name = "AddScheduleForm";
            Text = "Додати матч до розкладу";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label labelTitle;
        private Label labelHome;
        private ComboBox comboBoxHome;
        private Label labelAway;
        private ComboBox comboBoxAway;
        private Label labelTournament;
        private ComboBox comboBoxTournament;
        private Label labelStadium;
        private TextBox textBoxStadium;
        private Label labelDate;
        private DateTimePicker datePickerMatch;
        private Label labelNotes;
        private TextBox textBoxNotes;
        private Button buttonSave;
        private Button buttonCancel;
    }
}
