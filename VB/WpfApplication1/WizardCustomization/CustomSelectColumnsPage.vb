Imports Microsoft.VisualBasic
Imports DevExpress.Data.XtraReports.ServiceModel
Imports DevExpress.Data.XtraReports.Wizard
Imports DevExpress.Data.XtraReports.Wizard.Presenters
Imports DevExpress.Data.XtraReports.Wizard.Views
Imports System
' ...

Namespace WpfApplication1.WizardCustomization
	Friend Class CustomSelectColumnsPage
		Inherits DevExpress.Data.XtraReports.Wizard.Presenters.SelectColumnsPage(Of ReportModel)
		Public Sub New(ByVal view As ISelectColumnsPageView, ByVal client As IReportWizardServiceClient, ByVal cache As IColumnInfoCache)
			MyBase.New(view, client, cache)
		End Sub

		Public Overrides Function GetNextPageType() As Type
			Return GetType(ChooseReportLayoutPage(Of ReportModel))
		End Function
	End Class
End Namespace
