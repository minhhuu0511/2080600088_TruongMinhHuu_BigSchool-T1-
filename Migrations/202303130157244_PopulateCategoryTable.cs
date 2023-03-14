namespace _2080600088_TruongMinhHuu_BigSchool_T1_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (1,'DEVELOPMENT')");
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (2,'bussiness')");
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (3,'marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
