Imports Microsoft.VisualBasic
Imports DevExpress.Data.Utils.ServiceModel
Imports DevExpress.XtraReports.Data
Imports DevExpress.XtraReports.Service
Imports System.Configuration
' ...

Namespace WebApplication1
	' NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReportService1" in code, svc and config file together.
	<SilverlightFaultBehavior> _
	Public Class ReportService1
		Inherits DevExpress.XtraReports.Service.ReportService
		Shared Sub New()
			DataProviderRepository.Current.Register("nwind", "Northwind", ConfigurationManager.ConnectionStrings("nwindConnectionString").ConnectionString)
		End Sub
	End Class

End Namespace
