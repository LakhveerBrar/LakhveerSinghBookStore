2023-10-23
1540
Created a new Web App Name LakhveerBookStore
Add readme Text file 
Then Add Readme md file.

2023-10-30
Continue the work by using slides 
First of all 1.1 Review the project Like the things work and how it goes on
1420
continouing work with debugging 
In home controller from index to privacy making a debug to look how it works
All the work going same with the slides 
1435
Moving to Bootstrap from bootswatch 
I chose slate theme for my project
And download its css files
Now i make some change in wwwroot
Also in Layout
And make some chnages in nav class to make text white
1515
Add the  scripts from the CSS_JS.txt file
Now i move to add Dropdown  
I work succsefully 
now as per instrustion
Changes its name from Dropdown to Content Managment 
1603
Its time to Add (.NET Core class library)
LakhveersBooks.DataAccess
LakhveersBooks.Models
LakhveersBooks.Utility
then i work with database and paste it to in DataAccess
Then i install the next commands
Microsoft.EntityFrameworkCore.Relational 
Core.SqlServer packages
After it all I move to Install NuGet package
Identity.EntityFrameworkCore
after that The new Projects build 
Now i moving the folders
But when i working with that i found some problems wit my project that i could,t Handel

2023-11-06
I strated the project again and using all the steps 


started Assignment part 2.0
First build the ALL NEW NEccessary cmads like build the application
Next step i review the urgent steps in appsetting.json 
In the appsetting we change the databse to our name like my file name is LakhveerSinghBookStore
then we update the migration and working with the NuGet package Manager Console and using the new commands
(add-migration AddDefaultIdentityMigration)
And now there are some problems here

Your target project 'LakhveerSinghBookStore' doesn't match your migrations assembly 'LakhveerSinghBooks.DataAccess'. Either change your target project or change your migrations assembly.
Change your migrations assembly by using DbContextOptionsBuilder. E.g. options.UseSqlServer(connection, b => b.MigrationsAssembly("LakhveerSinghBookStore")). By default, the migrations assembly is the assembly containing the DbContext.
Change your target project to the migrations project by using the Package Manager Console's Default project drop-down list, or by executing "dotnet ef" from the directory containing the migrations project.
Beacaue there are named file LakhveerSinghBookStore and we have to change it to in LakhveerSinghBooks.DataAccess
Now we are adding the migration file name:
(20231106221347_AddDefaultIdentityMigration)




add-migration AddCategoryToDb


The name 'AddCategoryToDb' is used by an existing migration.