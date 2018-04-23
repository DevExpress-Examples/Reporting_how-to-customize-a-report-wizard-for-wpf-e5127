Imports Microsoft.VisualBasic
Imports DevExpress.Data.XtraReports.ServiceModel
Imports DevExpress.Data.XtraReports.Wizard
Imports DevExpress.Data.XtraReports.Wizard.Presenters
Imports DevExpress.Data.XtraReports.Wizard.Views
Imports System
' ...

Namespace WpfApplication1.WizardCustomization
	Friend Class CustomSelectDataMemberPage
		Inherits SelectDataMemberPage(Of ReportModel)
		Public Sub New(ByVal view As ISelectDataMemberPageView, ByVal client As IReportWizardServiceClient)
			MyBase.New(view, client)
		End Sub

		Public Overrides Function GetNextPageType() As Type
			Return GetType(CustomSelectColumnsPage)
		End Function
	End Class
End Namespace
