# RiaInstantFeedbackDataSource - How to show data from dependent tables


<p>This example shows how to create a new custom View that will include data from two dependent data tables.</p><br />
<p>One way to solve this task is to create a custom data base View that will include required fields on the server side.  It is shown in the <a href="https://www.devexpress.com/Support/Center/p/E3951">RiaInstantFeedbackDataSource - How to show included entity field data in DXGrid using custom DB View</a> Code Central example.</p><br />
<p>The other way to accomplish this task is to join required data from two tables at the Domain Service level using a custom GetCustomersOrders query implementation.</p><br />
<p>First, it is necessary to set RiaInstantFeedbackDataSource <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfCoreServerModeWcfInstantFeedbackDataSource_UseExtendedDataQuerytopic"><u>UseExtendedDataQuery</u></a> to 'True'. Then, implement the custom GetCustomerOrders and GetCustomerOrdersExtendedData methods. The latter is required to provide the correct RiaInstantFeedbackDataSource work in the extended query mode.</p>

<br/>


