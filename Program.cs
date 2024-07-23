//create database if doesn't already exist


//Prompt user for input - options: insert, delete, update and view their logged habit.

//
//

using Habit_Logger_Application;

UserHabit userHabit = new();
DatabaseServices databaseServices = new();
databaseServices.CreateDatabaseAndTable();
GetUserInput();


string userSelectionString;
void GetUserInput()
{
    Console.WriteLine("MAIN MENU\n\nWhat would you like to do?\n");
    Console.WriteLine(
        "Type 0 to Close Application.\n" +
        "Type 1 to View All Records.\n" +
        "Type 2 to Insert Record.\n" +
        "Type 3 to Delete Record.\n" +
        "Type 4 to Update Record.\n" +
        "------------------------------------------------\n\n"
        );
    userSelectionString = Console.ReadLine();
    ValidateUserInput(userSelectionString);
}



void ValidateUserInput(string userSelectionString)
{
    if (!int.TryParse(userSelectionString, out int userSelectionInt))
    {
        Console.Clear();
        Console.WriteLine("\n- Please enter a number between 0 and 4 -\n\n\n");
        GetUserInput();
    }
    else if (userSelectionInt > 0 || userSelectionInt < 5)
    {
        switch (userSelectionInt)
        {
            case 0: Console.Clear(); break;
            case 1: Console.WriteLine(); ; break;
            case 2: InsertRecord(); break;
            case 3: Console.WriteLine(); break;
            case 4: Console.WriteLine(); break;
        }
    }
    else { GetUserInput(); }
}

//when user selects 1
void ViewRecord()
{
    //if no record?
}

//when user selects 2
void InsertRecord()
{
    string habitNameInput;
    do
    {
        Console.WriteLine("Please enter a Name for your habit");
        habitNameInput = Console.ReadLine();

    } while (string.IsNullOrWhiteSpace(habitNameInput));

    userHabit.HabitName = habitNameInput;
    userHabit.HabitCounter = 0;

    databaseServices.PostToDatabase(userHabit);

}

//when user selects 3
void DeleteRecord()
{
    //if no record?
}

//when user selects 4
void UpdateRecord()
{
    //if no record?
}