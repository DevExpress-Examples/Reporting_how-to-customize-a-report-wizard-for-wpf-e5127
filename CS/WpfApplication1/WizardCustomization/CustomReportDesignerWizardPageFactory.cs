#region #Factory
using DevExpress.Data.XtraReports.ServiceModel;
using DevExpress.Data.XtraReports.Wizard;
using DevExpress.Xpf.ReportDesigner.ReportWizard;
// ...

namespace WpfApplication1.WizardCustomization {
    class CustomReportDesignerWizardPageFactory : ReportWizardPageFactory<ReportModel> {
        public CustomReportDesignerWizardPageFactory(IReportWizardServiceClient client) : base(client) { }

        protected override void RegisterDependencies() {
            base.RegisterDependencies();            
            // Register custom wizard pages.
            Container.RegisterType<CustomWelcomePage>();
            Container.RegisterType<CustomSelectDataSourcePage>();
            Container.RegisterType<CustomSelectDataMemberPage>();
            Container.RegisterType<CustomSelectColumnsPage>();
            Container.RegisterType<CustomSelectHierarchicalDataSourceColumnsPage>();
        }
    }
}
#endregion #Factory