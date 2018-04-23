Imports Microsoft.VisualBasic
Imports DevExpress.Data.Browsing.Design
Imports DevExpress.Data.XtraReports.Wizard
Imports DevExpress.Data.XtraReports.Wizard.Presenters
Imports DevExpress.Data.XtraReports.Wizard.Views
Imports System
' ...

Namespace WpfApplication1.WizardCustomization
	Friend Class CustomSelectHierarchicalDataSourceColumnsPage
		Inherits SelectHierarchicalDataSourceColumnsPage(Of ReportModel)
		Public Sub New(ByVal view As ISelectHierarchicalDataSourceColumnsPageView, ByVal pickManager As PickManagerBase, ByVal cache As IColumnInfoCache)
			MyBase.New(view, pickManager, cache)
		End Sub

		Public Overrides Function GetNextPageType() As Type
			Return GetType(ChooseReportLayoutPage(Of ReportModel))
		End Function
	End Class
End Namespace