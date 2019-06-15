# LUXOFT-JulioMoncisbays
This repository contains:
- DB Scripts
- A Visual Studio 2017 solution
- An Angular 8 project

Following are the instructions to set up the SQL Server DB, back-end and front-end projects:

## DB-Scripts
1. Run the script file **1 - CREATE DB.sql**. It will create a DB named Luxoft_JMoncisbays containing two tables: Companies, and Transactions.
2. Run the script file **2 - INSERT Companies.sql**. It will populate the Companies data table.
3. Run the script file **3 - INSERT Transactions.sql**. It will populate the Transactions data table.

## Luxoft_JMoncisbays_WebAPI
This is the back-end solution. By default, it will try to connect to the DB **Luxoft_JMoncisbays** located in **(local)\SQLEXPRESS** DB server using windows authentication.
If you created the DB in a DB server with a different instance name, please modify the connection string located in \Luxoft_JMoncisbays_WebAPI\appsettings.json:
```
...
   "ConnectionString": "Server=.\\SQLEXPRESS;Database=Luxoft_JMoncisbays;Trusted_Connection=True;"
...
```
Verify that the project runs as expected: Open it in VS 2017 (or newer) and Start it. It should open an a browser and load the URL http://localhost:52004/api/transactions then some JSON data should be displayed.
Also, when running the project, you might want to use Postman to send the following http requests:
- GET: http://localhost:52004/api/transactions?filter=&pagesize=5&page=1
- GET: http://localhost:52004/api/companies


## luxoft-jmoncisbays-angular
This is the front-end project, created with Angular 8.
1. Open the project in VS Code
2. Open the terminal (menu View | Terminal)
3. Run the following command:
```
npm install
```
4. Wait a couple of minutes until the NPM packages are intalled and the prompt is available again.
5. Since this project depends on the back-end project to get DB records, please be sure to run the latter at this point.
6. Run the following command:
```
npm start
```
7. Wait until the project is compiled. The message "webpack: Compiled successfully." will be displaye. It means that the SPA (Single Page Application) is ready to be opened in a web broser.
8. Navigate to `http://localhost:4200/`
9. If everything is okay, a web page should be displayed as per the mockup of the coding exercise.
