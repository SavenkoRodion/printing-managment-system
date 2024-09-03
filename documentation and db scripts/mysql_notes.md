Connection string to MySQL database: Server=localhost;Port=3308;Database=pms;uid=root;pwd=root;

Query to scaffold mysql database: Scaffold-DbContext "Server=localhost;Port=3308;Database=pms;uid=root;pwd=root;" MySql.EntityFrameworkCore -OutputDir Model/Scaffold -f

(For future reference, you will need to have installed: EntityFramework.Core, EntityFramework.Design, EntityFramework.Tools, MySql.EntityFrameworkCore)