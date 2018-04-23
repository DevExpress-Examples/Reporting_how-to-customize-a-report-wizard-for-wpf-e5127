#region #SelectDataSourcePage
using DevExpress.Data.Utils.ServiceModel;
using DevExpress.Data.XtraReports.DataProviders;
using DevExpress.Data.XtraReports.ServiceModel;
using DevExpress.Data.XtraReports.Wizard;
using DevExpress.Data.XtraReports.Wizard.Presenters;
using DevExpress.Data.XtraReports.Wizard.Views;
using System;
using System.Collections.Generic;
using System.Linq;
// ...

namespace WpfApplication1.WizardCustomization {
    class CustomSelectDataSourcePage : SelectDataSourcePage<ReportModel> {
        IEnumerable<DataSourceInfo> datasources;
        public CustomSelectDataSourcePage(
            ISelectDataSourcePageView view, 
            IReportWizardServiceClient client)
            : base(view, client) {
            client.GetDataSourcesCompleted += client_GetDataSourcesCompleted;
        }

        void client_GetDataSourcesCompleted(object sender, ScalarOperationCompletedEventArgs<IEnumerable<DataSourceInfo>> e) {
            // Obtain the available data sources.
            this.Client.GetDataSourcesCompleted -= client_GetDataSourcesCompleted;
            datasources = e.Result;
        }

        public override Type GetNextPageType() {
            // The type of the next wizard page is chosen based on the type of the selected data source.
            var info = datasources.First(x => x.Name == View.SelectedDataSourceName);
            return info.TablesOrViewsSupported ? typeof(CustomSelectDataMemberPage) : typeof(CustomSelectHierarchicalDataSourceColumnsPage);
        }
    }
}
#endregion #SelectDataSourcePage