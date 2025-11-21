using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Navigation;

namespace hotel.view
{
    public partial class FloorPlanPage : Page
    {
        public FloorPlanPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            // 1. Play the Main Page Slide In
            var slideIn = this.Resources["SlideInRight"] as Storyboard;
            slideIn?.Begin();

            // 2. Play the Furniture Entrance (Staggered Pop-up)
            var furnitureIn = this.Resources["FurnitureEntrance"] as Storyboard;
            furnitureIn?.Begin();
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginPage());
        }

        private void PrevButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack) NavigationService.GoBack();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new IntroductionPage());
        }
    }
}