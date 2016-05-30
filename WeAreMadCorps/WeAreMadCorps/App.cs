using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeAreMadCorps.Dashboard;
using Xamarin.Forms;

namespace WeAreMadCorps
{
    public class App : Application
    {
        public App()
        {
            
            // The root page of your application
            MallDashApp DashApp = new MallDashApp();
            MainPage = DashApp.GetMainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
