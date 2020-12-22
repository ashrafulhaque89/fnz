# A Simple Customer Management CRUD API built with NET 5 (.NET Core 5) C#

You will need Microsoft Visual Studio to run this solution project or you can use any editor of your choice if you have NET 5 (.net core 5, .net core 3.1 for the console app) installed in your Windows/MAC/Linux machine. The API uses SQL Lite Database which will be built automatically upon running the application for the first time and some data will be seeded automatically.

This API has full CRUD functionalities with 3 endpoints: 
1. api/customers : Shows list of Customers
2. api/customers/id : Shows customer by Customer's Id
3. api/customers/report : Shows a breakdown of average customer ages by Genders

- To run the app, use - dotnet run - command in the CLI
- Get List of Customers http://localhost:5000/api/customers/
- View Customer by Customer http://localhost:5000/api/customers/5
- To delete a Customer by Customer Id, send HttpDelete request to http://localhost:5000/api/customers/5
- To add new Customer, copy following **JSON** structure and make HttpPost request to http://localhost:5000/api/customers/

JSON
----

```json
{
    "First_name" : "First Name",
    "Last_name" : "Last Name",
    "DOB" : "2000-06-12",
    "Gender" : "Male"
}
```
- To update Customers list, take above sturcture and make HttpPut call to http://localhost:5000/api/customers/
- The list shows AGE of each customer which is dynamically calculated from the Customer's Date of Birth
- To see the average age breakdown by Customers' gender, head towards http://localhost:5000/api/customers/report


You can find a working demo here : https://fnz.azurewebsites.net/api/customers/
To see an average age breakdown by genders :  https://fnz.azurewebsites.net/api/customers/report

# Console Application version of the API above 
![Console App output](https://github.com/ashrafulhaque89/fnz/blob/master/Console%20Application/ConsoleApp.png)
