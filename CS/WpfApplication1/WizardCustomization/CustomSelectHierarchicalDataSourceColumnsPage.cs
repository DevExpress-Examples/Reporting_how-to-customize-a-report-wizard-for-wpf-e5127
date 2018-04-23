using DevExpress.Data.Browsing.Design;
using DevExpress.Data.XtraReports.Wizard;
using DevExpress.Data.XtraReports.Wizard.Presenters;
using DevExpress.Data.XtraReports.Wizard.Views;
using System;
// ...

namespace WpfApplication1.WizardCustomization {
    class CustomSelectHierarchicalDataSourceColumnsPage : SelectHierarchicalDataSourceColumnsPage<ReportModel> {
        public CustomSelectHierarchicalDataSourceColumnsPage(
            ISelectHierarchicalDataSourceColumnsPageView view, 
            PickManagerBase pickManager, 
            IColumnInfoCache cache) 
            : base(view, pickManager, cache) { }

        public override Type GetNextPageType() {
            return typeof(ChooseReportLayoutPage<ReportModel>);
        }
    }
}