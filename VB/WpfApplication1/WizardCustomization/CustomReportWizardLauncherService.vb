#Region "#ReportWizardLauncherService"
Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Data.WizardFramework
Imports DevExpress.Data.XtraReports.ServiceModel
Imports DevExpress.Data.XtraReports.Wizard
Imports DevExpress.Xpf.ReportDesigner.Services
' ...

Namespace WpfApplication1.WizardCustomization
	Friend Class CustomReportWizardLauncherService
		Inherits ReportWizardLauncherService(Of ReportModel)
        Protected Overrides Function CreatePageFactory(ByVal client As IReportWizardServiceClient) As IWizardPageFactory(Of ReportModel)
            Return New CustomReportDesignerWizardPageFactory(client)
        End Function
	End Class
End Namespace
#End Region ' #ReportWizardLauncherService