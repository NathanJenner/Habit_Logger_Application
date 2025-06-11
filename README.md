# Habit Logger Application

A simple and intuitive application for tracking, managing, and analyzing your daily habits. The Habit Logger Application helps users build positive routines by making it easy to log activities, monitor progress, and visualize habit-building streaks.

---

## Features

- **User-friendly Interface:** Clean and responsive command-line design for easy habit logging.
- **Custom Habit Creation:** Add, edit, or remove your tracked habit.
- **Progress Visualization:** View your current habit count and habit name.
- **Data Persistence:** Habits and logs are saved in a local SQLite database, so your progress is always available.
- **Robust Error Handling:** Application is designed to never crash, regardless of user input.
- **Single Habit Tracking:** Focuses on logging a single habit, tracked by quantity (not time).

---

## Requirements (from project spec)

- Register and track one habit (by quantity, e.g., number of water glasses per day).
- Cannot track habits by time (e.g., hours of sleep).
- Stores and retrieves data from a real SQLite database (created automatically if absent).
- Interacts with the database using raw SQL only (no ORMs/mappers like Entity Framework).
- On startup, creates the database and required table if not present.
- Menu-driven: users can insert, delete, update, and view their logged habit.
- Application handles all possible errors gracefully.
- Only terminates when the user selects the exit option (0).

---

## Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/NathanJenner/Habit_Logger_Application.git
   cd Habit_Logger_Application
   ```

2. **Build the application:**
   ```bash
   dotnet build
   ```

3. **Run the application:**
   ```bash
   dotnet run
   ```

---

## Usage

- On launch, the menu provides options to:
  - View your habit and current count
  - Create a new habit
  - Delete the habit
  - Update your habit count
  - Exit the application

- All data is stored in `habits.db` in the project directory.

---

## Technologies Used

- C#
- .NET
- SQLite (via `Microsoft.Data.Sqlite`)
- Raw SQL for all database operations

---

## Contributing

Contributions are welcome! To contribute:

1. Fork this repository.
2. Create a new branch: `git checkout -b feature/your-feature-name`
3. Make your changes and commit: `git commit -am 'Add new feature'`
4. Push to the branch: `git push origin feature/your-feature-name`
5. Create a Pull Request.

Please review the [CONTRIBUTING.md](CONTRIBUTING.md) if available.

---

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---

## Contact

For questions, suggestions, or support, open an issue or contact [NathanJenner](https://github.com/NathanJenner).

---

_Track your habits, achieve your goals!_
