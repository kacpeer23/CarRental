## Opis projektu
Aplikacja służąca do zarządzania wypożyczalnią samochodów. Umożliwia niezalogowanym użytkownikom podgląd na dostępne samochody. Administrator ma dostęp do dodawania klientów, dodawania samochodów oraz podgląd aktualnych klientów. Aplikacja wykorzystuje ASP.NET MVC oraz Microsoft SQL Server Managment Studio. Wykorzystuje także moduł identity do autoryzacji użytkowników.
## Instrukcja instalacji
1. Aby skonfigurować połączenie z bazą danych należy w pliku **appsettings.json** zamienić **localhost\\SQLEXPRESS** na własny łańcuch połączenia z bazą danych wykorzystywany w Microsot SQL Server Management Studio
2. Po otwarciu projektu w terminalu należy wykonać następujące komendy:  
    `update-database -context CarDbContext`
3. W przypadku gdy wystąpił błąd i folder "migrations" jest pusty należy wykonać następujące komendy:  
   `add-migration initial -context CarDbContext`            
   Następnie ponownie wykonać komendy z punktu 2  
4. Aplikacja jest gotowa do uruchomienia  
## Konto administratora:    
 - Login: **kacper.kowalski@gmail.com**  
 - Hasło: **Admin123!** 
