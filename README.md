Pre Requirements
The created solution requires;
******************************
1. Visual Studio 2019 (v16.3+)
2. .NET Core 3.0+
3. Node v12+
4. Yarn v1.19+

How to create project abp (.Net Core)
*************************************
Use CMD or PW shell or...
1.abp new <Projectname>
OR***********************************
1.Clone Project from https://github.com/aunsparrow/DataCenter.git
********************************************************************************************************************************
settting project (windown)
1.open src int project
2.find file appsettings.json 
3.setting (database yours local)

{
  "ConnectionStrings": {
    "Default": "Server=localhost;Database=BookStore;Trusted_Connection=True"
  }
}

4.Right click Project.web >> Choose  Set as  StartUp Ptoject
5.Package Manager Console >> Default project select .EntityFrameworkCore.DbMigrations >> run the <<Update-Database>> command:
