using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Threading;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.WPFUIItems;
using TestStack.White.WindowsAPI;

namespace TestAutomationScan3D
{
    public class StackWhiteTest
    {
        //paths
        private const string PATH_FOLDER = "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\CloudCompare\\";

        //variables
        private static Application applicationCloudCompare;
        private static Window mainWindow;


        //Open CloudCompare.exe
        private void CloudCompare(String action)
        {

            if (action == "open")
            {
                applicationCloudCompare = Application.Launch(PATH_FOLDER + "CloudCompare");
                mainWindow = applicationCloudCompare.GetWindow(SearchCriteria.ByClassName("Qt5QWindowIcon"), TestStack.White.Factory.InitializeOption.WithCache);
                mainWindow.WaitWhileBusy();

            }
            else if (action == "close")
            {
                applicationCloudCompare.Close();
            }
        }

        public void ClickCamera()
        {
            CloudCompare("open");
            //Aguardar 5 segundos
            Thread.Sleep(5000);
            CloudCompare("close");
            //var buttonFile = mainWindow.Get<Button>(SearchCriteria.ByText("Camera settings"));
            //buttonFile.Click();

        }
    }
}