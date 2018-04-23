using DevExpress.Data.XtraReports.Wizard;
using DevExpress.Data.XtraReports.Wizard.Presenters;
using DevExpress.Data.XtraReports.Wizard.Views;
using System;
// ...

namespace WpfApplication1.WizardCustomization {
    class CustomWelcomePage : WelcomePage<ReportModel> {
        public CustomWelcomePage(IWelcomePageView view) : base(view) { }

        public override Type GetNextPageType() {
            return typeof(CustomSelectDataSourcePage);
        }
    }
}
