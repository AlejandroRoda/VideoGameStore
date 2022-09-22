using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
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

namespace VideoGameWarehouse
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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
                Popup.PlacementTarget = btnHome;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = ResourceEs.btnHome;
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
                Popup.PlacementTarget = btnProducts;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = ResourceEs.btnProduct;
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
                Popup.PlacementTarget = btnClockIn;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = ResourceEs.btnClockIn;
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
                Popup.PlacementTarget = btnOrder;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = ResourceEs.btnOrder;
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
                Popup.PlacementTarget = btnSale;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = ResourceEs.btnSale;
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
                Popup.PlacementTarget = btnCustomers;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = ResourceEs.btnCustomer;
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
                Popup.PlacementTarget = btnInfo;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = ResourceEs.btnInfo;
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
                Popup.PlacementTarget = btnReports;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = ResourceEs.btnReport;
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
                Popup.PlacementTarget = btnSetting;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = ResourceEs.btnSettings;
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
