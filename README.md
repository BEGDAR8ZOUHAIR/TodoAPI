# TodoAPI

This tutorial teaches the basics of building a controller-based web API that uses a database. Another approach to creating APIs in ASP.NET Core is to create minimal APIs. For help in choosing between minimal APIs and controller-based APIs, see APIs overview. For a tutorial on creating a minimal API, see Tutorial: Create a minimal API with ASP.NET Core.

```
GET /api/todoitems	Get all to-do items	None	Array of to-do items
```
```
GET /api/todoitems/{id}	Get an item by ID	None	To-do item
```
```
POST /api/todoitems	Add a new item	To-do item	To-do item
```
```
PUT /api/todoitems/{id}	Update an existing item  	To-do item	None
```
```
DELETE /api/todoitems/{id}
```
