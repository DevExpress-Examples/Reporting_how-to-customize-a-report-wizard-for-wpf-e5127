#Region "#SelectDataSourcePage"
Imports Microsoft.VisualBasic
Imports DevExpress.Data.Utils.ServiceModel
Imports DevExpress.Data.XtraReports.DataProviders
Imports DevExpress.Data.XtraReports.ServiceModel
Imports DevExpress.Data.XtraReports.Wizard
Imports DevExpress.Data.XtraReports.Wizard.Presenters
Imports DevExpress.Data.XtraReports.Wizard.Views
Imports System
Imports System.Collections.Generic
Imports System.Linq
' ...

Namespace WpfApplication1.WizardCustomization
	Friend Class CustomSelectDataSourcePage
		Inherits SelectDataSourcePage(Of ReportModel)
		Private datasources As IEnumerable(Of DataSourceInfo)
		Public Sub New(ByVal view As ISelectDataSourcePageView, ByVal client As IReportWizardServiceClient)
			MyBase.New(view, client)
			AddHandler client.GetDataSourcesCompleted, AddressOf client_GetDataSourcesCompleted
		End Sub

		Private Sub client_GetDataSourcesCompleted(ByVal sender As Object, ByVal e As ScalarOperationCompletedEventArgs(Of IEnumerable(Of DataSourceInfo)))
			' Obtain the available data sources.	
			RemoveHandler Me.Client.GetDataSourcesCompleted, AddressOf client_GetDataSourcesCompleted
			datasources = e.Result
		End Sub

		Public Overrides Function GetNextPageType() As Type
			' The type of the next wizard page is chosen based on the type of the selected data source.
			Dim info = datasources.First(Function(x) x.Name = View.SelectedDataSourceName)
			Return If(info.TablesOrViewsSupported, GetType(CustomSelectDataMemberPage), GetType(CustomSelectHierarchicalDataSourceColumnsPage))
		End Function
	End Class
End Namespace
#End Region ' #SelectDataSourcePage