# How to customize a Report Wizard for WPF


<p>This example illustrates the legacy API that was used to customize the older version of the Report Designer for WPF.</p>
<p>This control was discontinued, and starting with version 15.2, we recommend you use the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument114104">newer Report Designer version</a> instead.</p>
<p> </p>
<p>To provide a custom report wizard to the older Report Designer version, do the following.</p>
<p>- Create a descendant class for each page to be included in the wizard. For each custom page class, override the <strong>ReportWizardPage.GetNextPageType</strong> method to define the order in which the pages will appear in the wizard.</p>
<p>- Create a descendant class for <strong>ReportWizardPageFactory<ReportModel></strong> and override its <strong>ReportWizardPageFactory</strong>.<strong>RegisterDependencies</strong> method to register the custom wizard pages.</p>
<p>- Create a descendant class for <strong>ReportWizardLauncherService<ReportModel></strong> and override its <strong>ReportWizardLauncherService.CreatePageFactory</strong> method so that it returns a new instance of the previously defined custom factory.</p>
<p>To register a custom wizard launcher service for the <strong>Report Designer,</strong> create a new instance of the custom wizard launcher service and pass it to the <strong>ReportDesigner.Model.DesignServices.RegisterInstance<IReportWizardLauncherService></strong> method.</p>

<br/>


