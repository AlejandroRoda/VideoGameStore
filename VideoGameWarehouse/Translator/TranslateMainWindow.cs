using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using VideoGameStore.Controls;
using VideoGameStore.Properties;

namespace VideoGameStore.Translator
{
    public class TranslateMainWindow
    {
    
        public static void TranslateLeftBarButtons(MainWindow mainWindow)
        {
           
            Settings settings = new Settings();
            if (settings.Language == 1)
            {
                mainWindow.menuItemHome.Text = ResourceEs.btnHome;
                mainWindow.menuItemClockIn.Text = ResourceEs.btnClockIn;
                mainWindow.menuItemProducts.Text = ResourceEs.btnProduct;
                mainWindow.menuItemCustomers.Text = ResourceEs.btnCustomer;
                mainWindow.menuItemSale.Text = ResourceEs.btnSale;
                mainWindow.menuItemSettings.Text = ResourceEs.btnSettings;
                mainWindow.menuItemInfo.Text = ResourceEs.btnInfo;
                mainWindow.menuItemOrder.Text = ResourceEs.btnOrder;
                mainWindow.menuItemReports.Text = ResourceEs.btnReport;
            }

            if (settings.Language == 2)
            {
                mainWindow.menuItemHome.Text = ResourceEn.btnHome;
                mainWindow.menuItemClockIn.Text = ResourceEn.btnClockIn;
                mainWindow.menuItemProducts.Text = ResourceEn.btnProduct;
                mainWindow.menuItemCustomers.Text = ResourceEn.btnCustomer;
                mainWindow.menuItemSale.Text = ResourceEn.btnSale;
                mainWindow.menuItemSettings.Text = ResourceEn.btnSettings;
                mainWindow.menuItemInfo.Text = ResourceEn.btnInfo;
                mainWindow.menuItemOrder.Text = ResourceEn.btnOrder;
                mainWindow.menuItemReports.Text = ResourceEn.btnReport;
            }
        }

        public static void TranslatePopUp(UserPopup popUp, Popup placementTarget)
        {
            Settings settings = new Settings();
            if (settings.Language ==1)
            {

                if (placementTarget.Name == "Home")
                {
                    popUp.PopupText.Text = ResourceEs.btnHome;
                }

                if (placementTarget.Name == "ClockIn")
                {
                    popUp.PopupText.Text = ResourceEs.btnClockIn;
                }

                if (placementTarget.Name == "Product")
                {
                    popUp.PopupText.Text = ResourceEs.btnProduct;
                }

                if (placementTarget.Name == "Customer")
                {
                    popUp.PopupText.Text = ResourceEs.btnCustomer;
                }

                if (placementTarget.Name == "Sale")
                {
                    popUp.PopupText.Text = ResourceEs.btnSale;
                }

                if (placementTarget.Name == "Settings")
                {
                    popUp.PopupText.Text = ResourceEs.btnSettings;
                }

                if (placementTarget.Name == "Info")
                {
                    popUp.PopupText.Text = ResourceEs.btnInfo;
                }

                if (placementTarget.Name == "Order")
                {
                    popUp.PopupText.Text = ResourceEs.btnOrder;
                }

                if (placementTarget.Name == "Report")
                {
                    popUp.PopupText.Text = ResourceEs.btnReport;
                }
            }

            if (settings.Language == 2)
            {

                if (placementTarget.Name == "Home")
                {
                    popUp.PopupText.Text = ResourceEn.btnHome;
                }

                if (placementTarget.Name == "ClockIn")
                {
                    popUp.PopupText.Text = ResourceEn.btnClockIn;
                }

                if (placementTarget.Name == "Product")
                {
                    popUp.PopupText.Text = ResourceEn.btnProduct;
                }

                if (placementTarget.Name == "Customer")
                {
                    popUp.PopupText.Text = ResourceEn.btnCustomer;
                }

                if (placementTarget.Name == "Sale")
                {
                    popUp.PopupText.Text = ResourceEn.btnSale;
                }

                if (placementTarget.Name == "Settings")
                {
                    popUp.PopupText.Text = ResourceEn.btnSettings;
                }

                if (placementTarget.Name == "Info")
                {
                    popUp.PopupText.Text = ResourceEn.btnInfo;
                }

                if (placementTarget.Name == "Order")
                {
                    popUp.PopupText.Text = ResourceEn.btnOrder;
                }

                if (placementTarget.Name == "Report")
                {
                    popUp.PopupText.Text = ResourceEn.btnReport;
                }
            }

        }
    }
}
