# Service Manual CRUD API in Asp.Net-Core 

<b>Required SDK:</b> .Net 6.0 

<b>Required Database Server:</b> SQL Server 2022

<b>IDE:</b> Visual Studio 2022

<b>How to run project:</b>
1. Clone this project to your local device.

2. Run dotnet build in console (alternatively in Visual Studio: Build -> Build Solution) 

3. Amend ServiceManualConnection string in appsettings.json file accordingly to match your own local SQL server.

4. Navigate to EtteplanMORE.ServiceManual.ApplicationCore project in console.

5. Run the following command: 
     
   - dotnet ef database update --startup-project ../EtteplanMORE.ServiceManual.Web

   This creates the database in your server, as well as automatically seeding factory device data from the file "seeddata.csv" included in the project solution.

6. Ensure EtteplanMORE.ServiceManual.Web is set as the startup project.

6. Run the project. The API will automatically open in Swagger within your browser. All routes are displayed thus: 

![Screenshot 2023-04-18 112848](https://user-images.githubusercontent.com/62894074/232719425-80fc4623-8188-4994-b3cf-7c3c44ba104e.png)

API can be tested by navigating to the desired route, clicking on the "try it out" button in the top right-hand corner, entering the request data if required, and clicking "Execute"

![Screenshot 2023-04-18 113328](https://user-images.githubusercontent.com/62894074/232720544-6b9ad272-25fe-4262-ba73-800df9008113.png)

<b>API functionality</b> 

<ins>Factory Device</ins>
![image](https://user-images.githubusercontent.com/62894074/232714795-cdff2150-ac81-4b76-83b2-856e6221d657.png)

<ins>Maintenance Task</ins>
![image](https://user-images.githubusercontent.com/62894074/232713674-01fd0844-c6fc-415d-95c4-e6fd1bb2c6ad.png)

<b>Class properties</b> 

<ins>FactoryDevice</ins>:

- Id (int) - Primary Key.

- Name (string)

- Year (int)

- Type (string)

- Maintenance Tasks (ICollection of Maintenance Task entity)
 
 <ins>MaintenanceTask</ins>

- Id (int) - Primary Key. Autogenerated upon creation.

- TimeRegistered (DateTimeOffset)

- Description (string)

- SeverityLevel (enum) 
     
     Critical = 1,
     Important = 2,
     Unimportant = 3

- CurrentStatus (enum)
     
     Open = 0, 
     Closed = 1

- TargetDeviceId (int)- Foreign Key. Id of FactoryDevice targeted by task. 
