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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Test_System01
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(onePage));
            chooseRadioButton.IsChecked = true;

        }

        private void chooseRadioButton_Click(object sender, RoutedEventArgs e)
        {
            
            MyFrame.Navigate(typeof(onePage));
            checkButton.IsChecked = false;
            BlankButton.IsChecked = false;
           
            
        }

        private void checkButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(twoPage));
            chooseRadioButton.IsChecked = false;
            BlankButton.IsChecked = false;
        }

        private void BlankButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(threePage));
            chooseRadioButton.IsChecked = false;
            checkButton.IsChecked = false;
        }
    }
}
