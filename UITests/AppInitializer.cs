using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Configuration;

using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            // environment variables are not working...
            //string installedApp = Environment.GetEnvironmentVariable("ANDROID_APP");
            //string installedApp = ConfigurationManager.AppSettings["ANDROID_APP"];

            //Console.WriteLine("GetEnvironmentVariables: SETTING: ", installedApp);
            //Console.WriteLine("GetEnvironmentVariables: androidApp: ", installedApp);

            //if (platform == Platform.Android)
            //{
            return ConfigureApp
                    .Android
                    // TODO: Update this path to point to your Android app and uncomment the
                    // code if the app is not included in the solution.
                    //.ApkFile ("../../../Droid/bin/Debug/xamarinforms.apk")
                    .InstalledApp("com.natashaosborne.xamarintesting.xamarintesting")
                    .StartApp();
            //}

            //return ConfigureApp
            //    .iOS
            //    // TODO: Update this path to point to your iOS app and uncomment the
            //    // code if the app is not included in the solution.
            //    //.AppBundle ("../../../iOS/bin/iPhoneSimulator/Debug/XamarinForms.iOS.app")
            //    .InstalledApp(installedApp)
            //    .StartApp();
        }
    }
}
