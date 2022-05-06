# PharmaProject
This project is used to update data table seller products table  in database  through uploading excel sheet data  
<br/>
#**Technology**<br/>
Backend:
c# , asp.net core wep api,entity framework (code first from database) ,
library Browse from nuget manager:<br/>
ExcelDataReader, system.text.encoding.codespages, system.text.encoding.codes   for  reading excel sheet <br/>
Frontend:<br/>
angular 7, bootstrap 4
Database:<br/>
sql server 2016<br/>

IDE:<br/>
visual studio 2017<br/>
visual studio code<br/>

#**steps to run:**<br/>
 after downloading project<br/>
 1-restore PharamaDB.bak  in sql server
 2-open  backend project  using visual studio <br/> 
 3-update  appsettings.json  file   (update (Server) at sqlcon in connection string  with sql server instance)<br/>
 4-run project <br/>
 5-open front end project with visual studio code<br/>
 6-run project  using command  (ng serve -o)  in terminal<br/>
 7- after run angular project    will display simple form  
 it contains  browse  file , upload button  and update button <br/>
  browse  update file  then  click on upload<br/>
   then  update to update data of discount column in sellers products table
  
