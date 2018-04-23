#region #MainUsings
using DevExpress.Xpf.ReportDesigner.Services;
using System.Windows;
using WpfApplication1.WizardCustomization;
// ...
#endregion #MainUsings

namespace WpfApplication1 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            RegisterCustomWizard();
        }

#region #RegisterCustomWizard
private void RegisterCustomWizard() {
    // Create and register a custom ReportWizardLauncherService.
    IReportWizardLauncherService launcher = new CustomReportWizardLauncherService() { 
        StartPage = typeof(CustomWelcomePage) 
    };
    reportDesigner1.Model.DesignServices.RegisterInstance<IReportWizardLauncherService>(launcher);
}
#endregion #RegisterCustomWizard
    }
}
