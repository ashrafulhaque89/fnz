# A Simple CRUD API built with in NET5 (.NET Core 5)
1. To update send HttpPut request to http://localhost:5001/api/customers/
2. View list by id http://localhost:5001/api/customers/5
3. Delete item by http://localhost:5001/api/customers/5
4. Get List http://localhost:5001/api/customers/
5. Add new item to list

{
    "First_name" : "Suomi",
    "Last_name" : "Finland",
    "DOB" : "1918-06-12",
    "Gender" : "Male"
}

and make HttpPost request to http://localhost:5001/api/customers/

You can find a working demo here : https://fnz.azurewebsites.net/api/customers/
