using DevExpress.Data.XtraReports.ServiceModel;
using DevExpress.Data.XtraReports.Wizard;
using DevExpress.Data.XtraReports.Wizard.Presenters;
using DevExpress.Data.XtraReports.Wizard.Views;
using System;
// ...

namespace WpfApplication1.WizardCustomization {
    class CustomSelectDataMemberPage : SelectDataMemberPage<ReportModel> {
        public CustomSelectDataMemberPage(ISelectDataMemberPageView view, IReportWizardServiceClient client) 
            : base(view, client) { }

        public override Type GetNextPageType() {
            return typeof(CustomSelectColumnsPage);
        }
    }
}
