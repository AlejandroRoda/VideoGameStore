using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VideoGameStore.Properties;
using VideoGameStore.Translator;

namespace VideoGameStore
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       TranslateMainWindow traducir;

        public MainWindow()
        {
            InitializeComponent();

            TranslateMainWindow.TranslateLeftBarButtons(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("UserControlClockIn.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        // Start: MenuLeft PopupButton //
        private void btnHome_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.Name = "Home";
                Popup.PlacementTarget = btnHome;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                TranslateMainWindow.TranslatePopUp(Header, Popup);
            }
        }

        private void btnHome_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnProducts_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.Name = "Product";
                Popup.PlacementTarget = btnProducts;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                TranslateMainWindow.TranslatePopUp(Header, Popup);
            }
        }

        private void btnProducts_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnClockIn_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.Name = "ClockIn";
                Popup.PlacementTarget = btnClockIn;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                TranslateMainWindow.TranslatePopUp(Header, Popup);
            }
        }

        private void btnClockIn_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnOrder_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.Name = "Order";
                Popup.PlacementTarget = btnOrder;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                TranslateMainWindow.TranslatePopUp(Header, Popup);
            }
        }

        private void btnOrder_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnSale_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.Name = "Sale";
                Popup.PlacementTarget = btnSale;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                TranslateMainWindow.TranslatePopUp(Header, Popup);
            }
        }

        private void btnSale_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnCustomers_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.Name = "Customer";
                Popup.PlacementTarget = btnCustomers;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                TranslateMainWindow.TranslatePopUp(Header, Popup);
            }
        }

        private void btnCustomers_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnInfo_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.Name = "Info";
                Popup.PlacementTarget = btnInfo;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                TranslateMainWindow.TranslatePopUp(Header, Popup);
            }
        }

        private void btnInfo_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnReports_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.Name = "Report";
                Popup.PlacementTarget = btnReports;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                TranslateMainWindow.TranslatePopUp(Header, Popup);
            }
        }

        private void btnReports_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }
        private void btnSetting_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.Name = "Settings";
                Popup.PlacementTarget = btnSetting;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                TranslateMainWindow.TranslatePopUp(Header, Popup);
            }
        }

        private void btnSetting_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }
        // End: MenuLeft PopupButton //

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Pages/Home.xaml", UriKind.RelativeOrAbsolute));
        }


        private void btnProducts_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Pages/Dashboard.xaml", UriKind.RelativeOrAbsolute));
        }  
    }
}
