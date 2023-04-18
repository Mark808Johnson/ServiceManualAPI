# Service Manual CRUD API in Asp.Net-Core 

<b>Required SDK:</b> .Net 6.0 

<b>Required Database Server:</b> SQL Server 2022


<b>How to run project:</b>
1. Clone this project to your local device.
2. Amend ServiceManualConnection string in appsettings.json file accordingly to match your own local SQL server 
3. Run the following in the command line: 
     
   - dotnet ef database update --startup-project ../EtteplanMORE.ServiceManual.Web

   This command creates the database in your server, as well as seeding factory device data from the file "seeddata.csv".
4. Run the project. The API will automatically open in Swagger within your browser.

