using Microsoft.Data.Sqlite;

namespace Habit_Logger_Application;

internal class DatabaseServices
{
    public void CreateDatabaseAndTable()
    {
        var connectionString = "Data Source=habits.db;";

        //need to clear any delayed queries. Had multiple entries when creating.


        using var connection = new SqliteConnection(connectionString);
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText =
        @"
                        CREATE TABLE IF NOT EXISTS habits (
                            id INTEGER PRIMARY KEY, 
                            habitcount INTEGER,     
                            habitname TEXT
                            );  
        ";
        command.ExecuteNonQuery();
    }




    public void PostToDatabase(UserHabit habit)
    {
        using var connection = new SqliteConnection("Data Source=habits.db");
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText =
            @"
                INSERT INTO habits (habitcount, habitname)
                VALUES ($habitcount, $habitname)
            ";
        command.Parameters.AddWithValue("$habitcount", habit.HabitCounter);
        command.Parameters.AddWithValue("$habitname", habit.HabitName);

        command.ExecuteNonQuery();
    }

    public void GetFromDatabase(UserHabit habit)
    {
        using var connection = new SqliteConnection("Data Source=habits.db");
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM habits";

        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            var number = reader.GetInt32(0);
            var name = reader.GetString(1);
            var description = reader.GetString(2);
        }
    }

    public void UpdateToDatabase(UserHabit habit)
    {

    }

    public void DeleteFromDatabase(int id)
    {

    }

}
