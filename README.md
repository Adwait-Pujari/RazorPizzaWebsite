# RazorPizzaWebsite


### <b>For the use of Entity Framework <b> 

I made a new folder called Data.
Created a new model named PizzaOrder which will contain our attributes
Downloaded required Entity Framework packages from Nuget Package manager


Once the setup is done. 

We require
	a class in our data which is called ApplicationDBContext.
	Extending that class to DbContext (from the package Microsoft.EntityFrameworkCore).
	Including an DbSet list.
	Requires a constructor

	Next step is adding the connection string to Appsettings.json

	In the appsettings.json
		For the connection string we require the name of our sql conenction. 
		Which can be found via View --> SQL Serve Object Explorer --> Under the SQL Server.
		And also we require the name of the database to connect to. In this case it is the PizzaApp.
	
	The next step is to go inside the Program.cs
		And add a builder to connect to the sql server
		In simple words it will try to use an sql server and connect to the default connection which is mentioned inside the appsettings.json.
	
	Lastly we to make changes in two componenets
		As we update our data we also need to update our Database and this process is called Migration.
		Creating our first migration
			Opening Tools --> NuGet Packages --> Package manager console.
			writing the command add-migration addedPizzaOrder in our Pm Console.

			addedPizzaOrder : Migration
				Up method : This will create the table with given columns.
				Down method : This will simply drop table

			Finally inside the PM Console we create our data base which would be 
				update-database

With this the connection to the sql server is complete and we proceed in adding values to our database.

To access the database in the required pages we need dependency injection.


<hr>
## Credentials

This project was developed based on a tutorial by [Complete ASP.NET 6.0 and Entity Framework free course](https://www.youtube.com/watch?v=7d2UMAIgOLQ), created by [tutorialsEU](https://www.youtube.com/@tutorialsEU).

Please note that this project is not entirely my original creation, and it was built by following the steps and guidance provided in the tutorial. The purpose of this project is for learning and educational purposes, and I have made modifications and additions based on my requirements and understanding.

If you're interested in the tutorial that inspired this project, I highly recommend checking it out [here](https://www.youtube.com/watch?v=7d2UMAIgOLQ). It provides a comprehensive guide on building a similar Razor application and has been a valuable resource in my learning journey.
