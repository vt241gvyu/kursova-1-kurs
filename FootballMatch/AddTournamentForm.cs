using Microsoft.Data.Sqlite;
using System;
using System.Windows.Forms;

namespace FootballMatch
{
    public partial class AddTournamentForm : Form
    {
        public AddTournamentForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Введіть назву турніру!");
                return;
            }

            DB db = new DB();
            db.openConnection();

            SqliteCommand insertT = new SqliteCommand("INSERT INTO tournaments (name) VALUES (@name)", db.getConnection());
            insertT.Parameters.AddWithValue("@name", textBoxName.Text);
            insertT.ExecuteNonQuery();
            insertT.Dispose();

            db.closeConnection();

            MessageBox.Show("Турнір успішно створено!");
            this.Close();
        }
    }
}