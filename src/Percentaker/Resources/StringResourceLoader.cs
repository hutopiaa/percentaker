using System.Threading;
using System.Windows;
using System;

namespace Percentaker.Resources
{
    public sealed class StringResourceManager
    {
        public const string OpenSystemTrayMenuString = "OpenSystemTrayMenu";
        public const string MainWindowTitle = "MainWindowTitle";
        public const string FinanceCalculationTool = "FinanceCalculationTool";
        private const string CouldNotLoadResourceStringError = "error: could not load resource string";
        private static readonly StringResourceManager instance = new();

        static StringResourceManager()
        {
        }

        private StringResourceManager()
        {
        }

        public static StringResourceManager Instance
        {
            get
            {
                return instance;
            }
        }

        public void Load(Application app)
        {
            ResourceDictionary dict = new ResourceDictionary();
            string currentCultureString = Thread.CurrentThread.CurrentCulture.ToString().ToLower();

            if (currentCultureString.StartsWith("fr-"))
            {
                dict.Source = new Uri("..\\Resources\\StringResources.fr.xaml", UriKind.Relative);
            }
            else
            {
                dict.Source = new Uri("..\\Resources\\StringResources.xaml", UriKind.Relative);
            }
            app.Resources.MergedDictionaries.Add(dict);
        }

        public string ReadString(string key)
        {
            try
            {
                return Application.Current.Resources[key].ToString() ?? CouldNotLoadResourceStringError;
            }
            catch
            {
                return CouldNotLoadResourceStringError;
            }
        }
    }
}
