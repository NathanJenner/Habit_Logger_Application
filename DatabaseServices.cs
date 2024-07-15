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
    }




    public void PostToDatabase()
    {

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
            var url = reader.GetString(0);
        }
    }

    public void UpdateToDatabase()
    {

    }

    public void DeleteFromDatabase()
    {

    }

}
