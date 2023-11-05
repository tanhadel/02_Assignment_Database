Console.WriteLine("");

/*
  steg 1 
 installer nuget package 
Microsoft.EntityFrameworkCore.aqlServer 
Microsoft.EntityFrameworkCore.Tools

steg 2 
Gör entiteter (klass/ model / objcet / tabeller 

steg 3 
skapa database och hänmta Connectionstring för att den databasen 
Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Taha the one\OneDrive\Skrivbord\Databas\02_Assignment_Database\02_Assignment_Database\ConTexts\Vd_Database.mdf';Integrated Security=True;Connect Timeout=30

steg 4 
skapa en Conetext som ärver ifrån Dbcontext 

VD_Database            = en conetext som hanterar kopplingen till databasen.

 steg 5 
Gör en add migration för att kontrallera alla (måste götas i package manager Console )
Add-migration ang ett lämligt migrationnamn , börja med stor bokstav.


steg 6 kontrollera så att vår Migration stämmer om den för en update-Datebase annars Remove-Migrion
Update-Database          = spara och skapa alla tabeller i database


  */