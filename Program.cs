

//create database if doesn't already exist


//Prompt user for input - options: insert, delete, update and view their logged habit.

//
//


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
}



if (!int.TryParse(userSelectionString, out int userSelectionInt))
{
    Console.Clear();
    Console.WriteLine("\n- Please enter a number between 0 and 4 -\n\n\n");
    GetUserInput();
}





if (userSelectionInt > 0 || userSelectionInt < 5)
{

}