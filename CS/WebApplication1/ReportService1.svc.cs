using DevExpress.Data.Utils.ServiceModel;
using DevExpress.XtraReports.Data;
using DevExpress.XtraReports.Service;
using System.Configuration;
// ...

namespace WebApplication1 {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReportService1" in code, svc and config file together.
    [SilverlightFaultBehavior]
    public class ReportService1 : DevExpress.XtraReports.Service.ReportService {
        static ReportService1() {
            DataProviderRepository.Current.Register(
                "nwind", 
                "Northwind", 
                ConfigurationManager.ConnectionStrings["nwindConnectionString"].ConnectionString);
        }
    }
  
}
