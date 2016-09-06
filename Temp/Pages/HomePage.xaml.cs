using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Temp.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Temp.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        
        public HomePage()
        {
            this.InitializeComponent();
            //flipview.ItemsSource = users;
            //Models.User user = new Models.User();
            flipview.SelectedIndex = 3;
        }

        private void flipview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private async void ButtonShowContentDialog3_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var result = await MyContentDialog.ShowAsync();
            btn.Content = "Result: " + result;
        }

        private void PivotPage_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PivotPage));
        }

        private void LessonPlayerButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(LessonPlayerTestPage));
        }
    }
}
