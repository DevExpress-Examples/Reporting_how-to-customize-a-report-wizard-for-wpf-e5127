Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Data.XtraReports.ServiceModel
Imports DevExpress.Data.XtraReports.Wizard
Imports DevExpress.Xpf.ReportDesigner.ReportWizard
' ...

#Region "#Factory"
Namespace WpfApplication1.WizardCustomization
	Friend Class CustomReportDesignerWizardPageFactory
		Inherits ReportWizardPageFactory(Of ReportModel)
		Public Sub New(ByVal client As IReportWizardServiceClient)
			MyBase.New(client)
		End Sub

		Protected Overrides Sub RegisterDependencies()
			MyBase.RegisterDependencies()
			' Register custom wizard pages.
			Container.RegisterType(Of CustomWelcomePage)()
			Container.RegisterType(Of CustomSelectDataSourcePage)()
			Container.RegisterType(Of CustomSelectDataMemberPage)()
			Container.RegisterType(Of CustomSelectColumnsPage)()
			Container.RegisterType(Of CustomSelectHierarchicalDataSourceColumnsPage)()
		End Sub
	End Class
End Namespace
#End Region ' #Factory