Connection string to MySQL database: Server=localhost;Port=3307;Database=veraprint;uid=root;pwd=root;  

Query to scaffold mysql database: Scaffold-DbContext "Server=localhost;Port=3307;Database=veraprint;uid=root;pwd=root;" MySql.EntityFrameworkCore -OutputDir Model -f
(For future reference, you will need to have installed: EntityFramework.Core, EntityFramework.Design, EntityFramework.Tools, MySql.EntityFrameworkCore)