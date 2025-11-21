using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Navigation;

namespace hotel.view
{
    public partial class IntroductionPage : Page
    {
        public IntroductionPage()
        {
            InitializeComponent();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            // 1. Type the first line
            await TypewriteText(TitleText1, "Inspired by tradition, ", 50);
            await Task.Delay(300);

            // 2. Type the second line
            await TypewriteText(TitleText2, "perfected for your stay.", 50);
            await Task.Delay(800);

            // 3. Subtext
            await TypewriteText(Subtext, "Experience a sanctuary designed to calm your senses and elevate your stay.", 30);
            await Task.Delay(300);

            // 4. Instructions
            await TypewriteText(SubtextTwo, "(Press left key to go to previous page and right for next page!)", 20);
        }

        private async Task TypewriteText(TextBlock textBlock, string text, int delay)
        {
            textBlock.Text = "";
            foreach (var c in text)
            {
                textBlock.Text += c;
                await Task.Delay(delay);
            }
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            // Replace with your actual Login Page
            NavigationService.Navigate(new LoginPage());
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            var sb = this.Resources["SlideOutLeft"] as Storyboard;
            if (sb != null)
            {
                sb.Completed += (s, _) => NavigationService.Navigate(new AccomodationIntroPage());
                sb.Begin();
            }
            else
            {
                NavigationService.Navigate(new AccomodationIntroPage());
            }
        }
    }
}