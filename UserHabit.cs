namespace Habit_Logger_Application;

public class UserHabit
{
    public static int IdCounter { get; set; }
    public int Id { get; set; }
    public int HabitCounter { get; set; }
    public string HabitName { get; set; }


    public UserHabit()
    {
        UserHabit.IdCounter++;
        this.Id = IdCounter;

    }


}