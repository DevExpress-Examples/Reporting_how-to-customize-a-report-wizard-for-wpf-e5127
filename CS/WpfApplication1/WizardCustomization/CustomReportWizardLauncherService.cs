#region #ReportWizardLauncherService
using DevExpress.Data.WizardFramework;
using DevExpress.Data.XtraReports.ServiceModel;
using DevExpress.Data.XtraReports.Wizard;
using DevExpress.Xpf.ReportDesigner.Services;
// ...

namespace WpfApplication1.WizardCustomization {
    class CustomReportWizardLauncherService : ReportWizardLauncherService<ReportModel> {
        protected override IWizardPageFactory<ReportModel> CreatePageFactory(IReportWizardServiceClient client) {
            return new CustomReportDesignerWizardPageFactory(client);
        }
    }
}
#endregion #ReportWizardLauncherService