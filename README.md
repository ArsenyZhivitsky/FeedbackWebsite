## How to run this app:

First of all, you need to clone this repo)

Then you need to creat all necessary databases. 
Open the solution in Visual Studio and open the package manager console (Tools -> NuGet Package Manager -> Package Manger Console)
Run the following commands one by one:
```
update-database -context "IdentityContext"
update-database -context "FeedbackWebsiteContext"
```

You can create a default *admin* user. In order to do that, you need to run an SQL script. But before that, you need to generate a passwordHash. 
To do that: 
- Open PasswordHashGenerator project (located in *Tools* folder in the repository)
- Insert the password that you will use to login into the `password` variable. (Note that the password should contain at least one upper and one lowercase character, at least one digit, and have at least 6 character length)
- Run the project and copy a generated passwordHash from the output console
- Open the `Insert_usersstoredb.sql` script (located in *FeedbackWebsite\DbScripts* folder in the repository)
- Insert the value into the `@passwordHash` variable
- Run this script on the UsersStore database. (Connect to your localDb using Microsoft SSMS. The server will be '(localdb)\\mssqllocaldb')

Also, you need to insert some questions text into the DB.
To do that: 
- Run the `Insert_FeedbackWebsite.sql` script on the FeedbackWebsite database. (located in *FeedbackWebsite\DbScripts* folder in the reppsitory)

Before the first run, make sure that .net Core 2.2 is installed on your machine.

Now you can make the first run.
