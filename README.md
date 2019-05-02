# Goat Store
This is a simple .NET Core web application for use with Azure App Services to demonstrate some of the networking features of App Service

There are two networking scenarios it covers
- It has a SQL Service database to display product information, this database is in Azure SQL (PaaS)
- It makes HTTP requests to a REST API to display order information. This API is hosted in another App Service webapp instance

There are two .NET Core projects.  
 - The main website is in the `main-site` directory
 - The API is in the `orders-api` directory

# ARM Template
ARM template is supplied to deploy the entire system, with two App Services, App Service Plan, and Azure SQL. Code is deployed with Kudu from this GitHub repo

A VNet is created for integration but no integration is setup in the template. Configuration of VNet integration with App Service is left as a post deployment manual task

[![deploy](https://raw.githubusercontent.com/benc-uk/azure-arm/master/etc/azuredeploy.png)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fbenc-uk%2Fgoat-store%2Fmaster%2Farm-template%2Fazuredeploy.json)