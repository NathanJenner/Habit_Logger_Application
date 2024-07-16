using Microsoft.Data.Sqlite;

namespace Habit_Logger_Application;

internal class DatabaseServices
{

    public void CreateDatabaseAndTable()
    {
        //CREATE TABLE habits (
        //HabitCount int,
        //HabitName string,
        //HabitDescription string,
        //);
    }




    public void PostToDatabase()
    {
        //INSERT INTO (HabitCount, HabitName, HabitDescription)
        //VALUES (2, Running, Count of how many times i've run)
    }

    public void GetFromDatabase()
    {
        using var connection = new SqliteConnection("Data Source=Blogs.db");
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = "SELECT Url FROM Blogs";

        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            var number = reader.GetInt32(0);
            var name = reader.GetString(1);
            var description = reader.GetString(2);
        }
    }

    public void UpdateToDatabase()
    {

    }

    public void DeleteFromDatabase()
    {

    }

}
