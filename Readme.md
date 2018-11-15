<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml.cs](./CS/WpfApplication1/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication1/MainWindow.xaml.vb))
* [CustomReportDesignerWizardPageFactory.cs](./CS/WpfApplication1/WizardCustomization/CustomReportDesignerWizardPageFactory.cs) (VB: [CustomReportDesignerWizardPageFactory.vb](./VB/WpfApplication1/WizardCustomization/CustomReportDesignerWizardPageFactory.vb))
* [CustomReportWizardLauncherService.cs](./CS/WpfApplication1/WizardCustomization/CustomReportWizardLauncherService.cs) (VB: [CustomReportWizardLauncherService.vb](./VB/WpfApplication1/WizardCustomization/CustomReportWizardLauncherService.vb))
* [CustomSelectColumnsPage.cs](./CS/WpfApplication1/WizardCustomization/CustomSelectColumnsPage.cs) (VB: [CustomSelectColumnsPage.vb](./VB/WpfApplication1/WizardCustomization/CustomSelectColumnsPage.vb))
* [CustomSelectDataMemberPage.cs](./CS/WpfApplication1/WizardCustomization/CustomSelectDataMemberPage.cs) (VB: [CustomSelectDataMemberPage.vb](./VB/WpfApplication1/WizardCustomization/CustomSelectDataMemberPage.vb))
* [CustomSelectDataSourcePage.cs](./CS/WpfApplication1/WizardCustomization/CustomSelectDataSourcePage.cs) (VB: [CustomSelectDataSourcePage.vb](./VB/WpfApplication1/WizardCustomization/CustomSelectDataSourcePage.vb))
* [CustomSelectHierarchicalDataSourceColumnsPage.cs](./CS/WpfApplication1/WizardCustomization/CustomSelectHierarchicalDataSourceColumnsPage.cs) (VB: [CustomSelectHierarchicalDataSourceColumnsPage.vb](./VB/WpfApplication1/WizardCustomization/CustomSelectHierarchicalDataSourceColumnsPage.vb))
* [CustomWelcomePage.cs](./CS/WpfApplication1/WizardCustomization/CustomWelcomePage.cs) (VB: [CustomWelcomePage.vb](./VB/WpfApplication1/WizardCustomization/CustomWelcomePage.vb))
<!-- default file list end -->
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


