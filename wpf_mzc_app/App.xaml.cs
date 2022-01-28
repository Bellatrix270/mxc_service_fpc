using System.Windows;

namespace wpf_mzc_app
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            using (wpf_mzc_app.Models.ModelDB.MZCServicePC db = new Models.ModelDB.MZCServicePC())
            {
                db.Database.Initialize(false);
            }
        }
    }
}