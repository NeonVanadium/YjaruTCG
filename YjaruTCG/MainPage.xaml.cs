using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace YjaruTCG
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(MainMenu));
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void BattleButton_Click(object sender, RoutedEventArgs e)
        {
            navigateAway();
            MainFrame.Navigate(typeof(Game));
        }

        private void navigateAway()
        {
            BattleButton.Visibility = Visibility.Collapsed;
            ExitButton.Visibility = Visibility.Collapsed;
            MenuButton.Visibility = Visibility.Visible;
        }

        private void navigateTo()
        {

            BattleButton.Visibility = Visibility.Visible;
            ExitButton.Visibility = Visibility.Visible;
            MenuButton.Visibility = Visibility.Collapsed;
        }

        private void MenuReturnButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(MainMenu));
            navigateTo();
        }
    }
}
