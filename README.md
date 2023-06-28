# AZURE RESUME PAGE
# TRY IT [HERE](https://tomasaguirre.azureedge.net/)!

# How is this made?

The site is a static HTML page that contains a visitor count. It uses CosmosDB (in serverless mode, NoSQL) to store a "count" variable that keeps track of the number of page visits. This variable is accessed via an Azure Functions [API](
https://getresumecountertal.azurewebsites.net/api/GetResumeCounter?code=I6t2487diof_Mwdh9AtBIpodWFYHAt0NILdpjCD282viAzFuTZdAaQ==) (in C# / .NET). 
#
# Current issues
My current Azure Subscription does not allow me to use Azure CDN (due to organization policies), hence I can't apply a custom domain name. 
