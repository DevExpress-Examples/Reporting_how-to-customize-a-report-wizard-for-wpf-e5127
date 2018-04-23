Imports Microsoft.VisualBasic
Imports DevExpress.Data.XtraReports.Wizard
Imports DevExpress.Data.XtraReports.Wizard.Presenters
Imports DevExpress.Data.XtraReports.Wizard.Views
Imports System
' ...

Namespace WpfApplication1.WizardCustomization
	Friend Class CustomWelcomePage
		Inherits WelcomePage(Of ReportModel)
		Public Sub New(ByVal view As IWelcomePageView)
			MyBase.New(view)
		End Sub

		Public Overrides Function GetNextPageType() As Type
			Return GetType(CustomSelectDataSourcePage)
		End Function
	End Class
End Namespace
