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



    public void GetFromDatabase(int habitId) // cut parameters: UserHabit habit
    {
        using (var connection = new SqliteConnection("Data Source=habits.db"))
        {
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText =
                @"
                SELECT habitname, habitcount 
                FROM habits
                WHERE id = $id
                ";
            command.Parameters.AddWithValue("$id", habitId);

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var habitName = reader.GetString(0);
                    var habitCount = reader.GetString(1);
                    Console.WriteLine($"For {habitName} your current Count is - {habitCount}");
                }

                //look to simplify this to just one entry. User wouldn't know the id.
            }
        }
    }




    public void UpdateToDatabase(UserHabit habit)
    {

    }

    public void DeleteFromDatabase(int id)
    {

    }

}
