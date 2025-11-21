using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Data.SqlClient;

// 1. Notice the namespace is now hotel.viewmodel
namespace hotel.viewmodel
{
    public class DatabaseStatusViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _statusText;
        private Brush _statusBrush;

        // --- Brushes (loaded from XAML resources) ---
        private readonly Brush _onlineBrush = (Brush)Application.Current.FindResource("Green500Brush");
        private readonly Brush _offlineBrush = (Brush)Application.Current.FindResource("Red500Brush");

        // --- Public Properties (What the XAML binds to) ---
        public string StatusText
        {
            get { return _statusText; }
            set
            {
                _statusText = value;
                OnPropertyChanged(); // Tells the UI to update
            }
        }

        public Brush StatusBrush
        {
            get { return _statusBrush; }
            set
            {
                _statusBrush = value;
                OnPropertyChanged(); // Tells the UI to update
            }
        }

        // --- Constructor ---
        public DatabaseStatusViewModel()
        {
            StatusText = "Checking Status...";
            StatusBrush = (Brush)Application.Current.FindResource("Slate500Brush");
        }

        // --- The "Void" / "Event" ---
        public async Task CheckDatabaseConnectionAsync()
        {
            try
            {
                // --- TODO: Put your actual SQL connection logic here ---
                // string connectionString = "YOUR_CONNECTION_STRING";
                // using (var connection = new SqlConnection(connectionString))
                // {
                //     await connection.OpenAsync();
                //     // If it gets here, connection is good!
                // }

                // --- Simulating a successful connection ---
                // REMOVE THIS SIMULATION when you add real code above
                await Task.Delay(1500); // Simulate network latency

                // --- Update UI Properties on Success ---
                StatusText = "System Online";
                StatusBrush = _onlineBrush;
            }
            catch (Exception ex)
            {
                // If connection.OpenAsync() fails, it will throw an exception.
                // --- Update UI Properties on Failure ---
                StatusText = "System Offline";
                StatusBrush = _offlineBrush;
                Console.WriteLine($"Database connection failed: {ex.Message}");
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}