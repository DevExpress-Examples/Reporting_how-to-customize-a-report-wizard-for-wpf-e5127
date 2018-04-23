#Region "#MainUsings"
Imports Microsoft.VisualBasic
Imports DevExpress.Xpf.ReportDesigner.Services
Imports System.Windows
Imports WpfApplication1.WizardCustomization
' ...
#End Region ' #MainUsings

Namespace WpfApplication1
    Partial Public Class MainWindow
        Inherits Window
        Public Sub New()
            InitializeComponent()
            RegisterCustomWizard()
        End Sub

#Region "#RegisterCustomWizard"
Private Sub RegisterCustomWizard()
    ' Create and register a custom ReportWizardLauncherService.
    Dim launcher As IReportWizardLauncherService = New CustomReportWizardLauncherService() _
        With {.StartPage = GetType(CustomWelcomePage)}
    reportDesigner1.Model.DesignServices.RegisterInstance(Of IReportWizardLauncherService)(launcher)
End Sub
#End Region ' #RegisterCustomWizard

    End Class
End Namespace
