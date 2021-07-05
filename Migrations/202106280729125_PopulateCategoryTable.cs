namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (1, 'MATH')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (2, 'PHYSICS')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (3, 'BIOLOGY')");
        }
        
        public override void Down()
        {
        }
    }
}
