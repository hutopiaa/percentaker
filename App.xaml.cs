using Percentaker.Resources;
using System.Windows;

namespace Percentaker
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            StringResourceManager.Instance.Load(this);

            base.OnStartup(e);
        }
    }
}
