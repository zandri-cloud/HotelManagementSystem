using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace hotel.view
{
    /// <summary>
    /// Interaction logic for LoginStandbyPage.xaml
    /// </summary>
    public partial class LoginStandbyPage : Page
    {
        public LoginStandbyPage()
        {
            InitializeComponent();
        }

        // This event starts the video when the page is loaded
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            BackgroundVideo.Play();
        }

        // This event loops the video when it finishes
        private void BackgroundVideo_MediaEnded(object sender, RoutedEventArgs e)
        {
            // Reset the video's position to the beginning
            BackgroundVideo.Position = TimeSpan.Zero;
            // Play it again
            BackgroundVideo.Play();
        }
    }
}
