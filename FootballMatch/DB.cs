using Microsoft.Data.Sqlite;

namespace FootballMatch
{
    class DB
    {
        SqliteConnection connection = new SqliteConnection("Data Source=football.db;Pooling=False;Default Timeout=5;");

        public void CreateDB()
        {
            openConnection();

            string createTables = @"
                CREATE TABLE IF NOT EXISTS users (id INTEGER PRIMARY KEY AUTOINCREMENT, login TEXT, password TEXT, email TEXT, role TEXT DEFAULT 'user');
                CREATE TABLE IF NOT EXISTS planned_matches (id INTEGER PRIMARY KEY AUTOINCREMENT, user_id INTEGER, tournament TEXT, stadium TEXT, match_date TEXT, team_home TEXT, team_away TEXT, ticket_category TEXT, notes TEXT, score TEXT DEFAULT '');
                CREATE TABLE IF NOT EXISTS teams (id INTEGER PRIMARY KEY AUTOINCREMENT, team_name TEXT);
                CREATE TABLE IF NOT EXISTS players (id INTEGER PRIMARY KEY AUTOINCREMENT, team_name TEXT, player_name TEXT);
                CREATE TABLE IF NOT EXISTS tournaments (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT);
                CREATE TABLE IF NOT EXISTS tournament_matches (id INTEGER PRIMARY KEY AUTOINCREMENT, tournament_name TEXT, match_info TEXT, score TEXT);
                CREATE TABLE IF NOT EXISTS match_history (id INTEGER PRIMARY KEY AUTOINCREMENT, user_id INTEGER, tournament TEXT, stadium TEXT, match_date TEXT, team_home TEXT, team_away TEXT, final_score TEXT, comment TEXT);
                CREATE TABLE IF NOT EXISTS photos (id INTEGER PRIMARY KEY AUTOINCREMENT, history_id INTEGER, photo BLOB);
                CREATE TABLE IF NOT EXISTS key_players (id INTEGER PRIMARY KEY AUTOINCREMENT, match_id INTEGER, player_name TEXT);
                CREATE TABLE IF NOT EXISTS expected_events (id INTEGER PRIMARY KEY AUTOINCREMENT, match_id INTEGER, event_name TEXT);
                CREATE TABLE IF NOT EXISTS match_stats (id INTEGER PRIMARY KEY AUTOINCREMENT, match_id INTEGER, total_expected_goals INTEGER);
                CREATE TABLE IF NOT EXISTS stats_details (id INTEGER PRIMARY KEY AUTOINCREMENT, stats_id INTEGER, category TEXT, amount INTEGER);
            ";
            SqliteCommand cmdTables = new SqliteCommand(createTables, connection);
            cmdTables.ExecuteNonQuery();

            TryAlterTable("ALTER TABLE users ADD COLUMN role TEXT DEFAULT 'user'");
            TryAlterTable("ALTER TABLE planned_matches ADD COLUMN score TEXT DEFAULT ''");

            SqliteCommand checkUsers = new SqliteCommand("SELECT COUNT(*) FROM users", connection);
            long userCount = (long)checkUsers.ExecuteScalar();

            if (userCount == 0)
            {
                string insertData = @"
                    INSERT INTO users (login, password, email, role) VALUES ('admin', 'admin', 'admin@test.com', 'admin');

                    INSERT INTO teams (team_name) VALUES ('Динамо'), ('Шахтар'), ('Полісся'), ('Рух'), ('Кривбас'), ('Ворскла');

                    INSERT INTO tournaments (name) VALUES ('УПЛ'), ('Ліга Чемпіонів'), ('АПЛ'), ('Серія А');

                    INSERT INTO planned_matches (user_id, tournament, stadium, match_date, team_home, team_away, ticket_category, notes, score) VALUES
                    (1, 'УПЛ', 'Центральний стадіон', '2026-04-15', 'Полісся', 'Динамо', 'Стандарт', 'Взяти теплі речі', ''),
                    (1, 'Ліга Чемпіонів', 'Сантьяго Бернабеу', '2026-05-20', 'Реал Мадрид', 'Манчестер Сіті', 'VIP', 'Матч року!', ''),
                    (1, 'УПЛ', 'Арена Львів', '2026-03-10', 'Шахтар', 'Ворскла', 'Стандарт', 'Крутий матч!', '2:0'),
                    (1, 'УПЛ', 'Центральний стадіон', '2026-03-05', 'Полісся', 'Кривбас', 'Стандарт', 'Бойова нічия', '1:1'),
                    (1, 'АПЛ', 'Емірейтс', '2026-04-22', 'Арсенал', 'Челсі', 'Фан-зона', 'Зустрічаємось за годину', ''),
                    (1, 'Серія А', 'Сан-Сіро', '2026-05-02', 'Мілан', 'Інтер', 'Стандарт', 'Міланське дербі', '');
                ";
                SqliteCommand cmdData = new SqliteCommand(insertData, connection);
                cmdData.ExecuteNonQuery();
            }
            else
            {
                SqliteCommand fixAdmin = new SqliteCommand("UPDATE users SET role = 'admin' WHERE login = 'admin' AND (role IS NULL OR role = '')", connection);
                fixAdmin.ExecuteNonQuery();
            }

            closeConnection();
        }

        private void TryAlterTable(string sql)
        {
            try { new SqliteCommand(sql, connection).ExecuteNonQuery(); }
            catch { }
        }

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public SqliteConnection getConnection() => connection;
    }
}
