using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Threading;
using System.Threading.Tasks;

namespace hotel.view
{
    public partial class LoginPage : Page
    {
        private DispatcherTimer _idleTimer;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Loaded(object sender, RoutedEventArgs e)
        {
            BackgroundVideo.Play();
            _idleTimer = new DispatcherTimer();
            _idleTimer.Interval = TimeSpan.FromSeconds(5);
            _idleTimer.Tick += IdleTimer_Tick;
            _idleTimer.Start();

            // Optional: Add typewriting for the title here if you want
            TypewriteText(KazenoyaTitle, "Kazenoya", 150);
        }

        // The navigation logic
        private void LearnMore_Click(object sender, RoutedEventArgs e)
        {
            // 1. Stop the idle timer so screensaver doesn't appear while navigating
            _idleTimer.Stop();

            // 2. Find the Fade Out storyboard
            Storyboard fadeOut = (Storyboard)this.FindResource("PageFadeOut");

            // 3. When fade out finishes, Navigate to IntroductionPage
            fadeOut.Completed += (s, ev) =>
            {
                this.NavigationService.Navigate(new IntroductionPage());
            };

            // 4. Start the fade
            fadeOut.Begin();
        }

        public async void TypewriteText(TextBlock target, string textToType, int speed)
        {
            target.Text = "";
            foreach (char c in textToType)
            {
                target.Text += c;
                await Task.Delay(speed);
            }
        }

        private void IdleTimer_Tick(object sender, EventArgs e)
        {
            _idleTimer.Stop();
            BackgroundVideo.Pause();
            StandbyVideo.Position = TimeSpan.Zero;
            StandbyVideo.Play();

            Storyboard fadeOut = (Storyboard)this.FindResource("FadeOutStoryboard");
            fadeOut.Begin();
            Storyboard credits = (Storyboard)this.FindResource("CreditsScrollStoryboard");
            credits.Begin();
        }

        private void Page_MouseMove(object sender, MouseEventArgs e)
        {
            _idleTimer.Stop();
            _idleTimer.Start();

            if (StandbyPanel.Opacity == 1.0 || IntroPanel.Opacity == 1.0)
            {
                StandbyVideo.Pause();
                BackgroundVideo.Play();

                Storyboard fadeIn = (Storyboard)this.FindResource("FadeInStoryboard");
                fadeIn.Begin();
                Storyboard credits = (Storyboard)this.FindResource("CreditsScrollStoryboard");
                credits.Stop();
            }
        }

        private void BackgroundVideo_MediaEnded(object sender, RoutedEventArgs e)
        {
            BackgroundVideo.Position = TimeSpan.Zero;
            BackgroundVideo.Play();
        }

        private void StandbyVideo_MediaEnded(object sender, RoutedEventArgs e)
        {
            StandbyVideo.Position = TimeSpan.Zero;
            StandbyVideo.Play();
        }
    }
}