using DevExpress.Data.XtraReports.ServiceModel;
using DevExpress.Data.XtraReports.Wizard;
using DevExpress.Data.XtraReports.Wizard.Presenters;
using DevExpress.Data.XtraReports.Wizard.Views;
using System;
// ...

namespace WpfApplication1.WizardCustomization {
    class CustomSelectColumnsPage : DevExpress.Data.XtraReports.Wizard.Presenters.SelectColumnsPage<ReportModel> {
        public CustomSelectColumnsPage(
            ISelectColumnsPageView view, 
            IReportWizardServiceClient client, 
            IColumnInfoCache cache)
            : base(view, client, cache) { }

        public override Type GetNextPageType() {
            return typeof(ChooseReportLayoutPage<ReportModel>);
        }
    }
}
