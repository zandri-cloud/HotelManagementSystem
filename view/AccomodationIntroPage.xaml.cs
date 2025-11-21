using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Navigation;

namespace hotel.view
{
    public partial class AccomodationIntroPage : Page
    {
        public AccomodationIntroPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            // Play Slide In Animation immediately on load
            var sb = this.Resources["SlideInRight"] as Storyboard;
            sb?.Begin();
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginPage());
        }

        private void PrevButton_Click(object sender, RoutedEventArgs e)
        {
            var sb = this.Resources["SlideOutRight"] as Storyboard;

            if (sb != null)
            {
                sb.Completed += (s, _) => NavigationService.Navigate(new IntroductionPage());
                sb.Begin();
            }
            else
            {
                NavigationService.Navigate(new IntroductionPage());
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            // Slide Out, then Navigate
            var sb = this.Resources["SlideOutLeft"] as Storyboard;
            if (sb != null)
            {
                sb.Completed += (s, _) => NavigationService.Navigate(new FloorPlanPage());
                sb.Begin();
            }
            else
            {
                NavigationService.Navigate(new FloorPlanPage());
            }
        }
    }
}