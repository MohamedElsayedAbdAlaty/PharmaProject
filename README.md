# PharmaProject
This project used to update data table in database  through   upload excel sheet data  
#Technology
Backend:
c# , asp.net core wep api,entity framework ,
library Browse from nuget manager:
ExcelDataReader, system.text.encoding.codespages, system.text.encoding.codes
Frontend:
angular 7, bootstrap 4
Database:
sql server 2016

IDE:
visual studio 2017
visual studio code

#steps to run:
 after downloading project
 1-open  backend project  using visual studio 2017 or 2019 
 2-update  appsettings.json  file   (update (Server) at sqlcon in connection string  with sql server instance)
 3-run project 
 4-open front end project with visual studio code
 5-run project  using command  (ng serve -o)  in terminal
 6- after run angular project    will display simple form  
 it contains  browse  file , upload button  and update button 
  browse  update file  then  click on upload
   then  update to update data of discount column in sellers products
  
