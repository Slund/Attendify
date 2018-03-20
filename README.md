In order to run and develop on this project, you need Visual Studio to be installed.

Furthermore, you have to install this Expansion for it:
- [Web Essentials](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.WebExtensionPack2017)

Logins for the different types of users:
Admin: admin@admin.dk // Pass123!
Teacher: teacher@teacher.dk // Pass123!
Student: student@student.dk // Pass123!

To open your MDF file in SSMS, DELETE the log file it created after you ran update-database, then make a new query in SSMS

CAUTION!!!! MAKE SURE YOU HAE ENOUGH RIGHTS TO ENTER THIS FOLDER  

CREATE DATABASE <database_name>
    ON (FILENAME = 'PATH TO MDF') 
    FOR ATTACH;  