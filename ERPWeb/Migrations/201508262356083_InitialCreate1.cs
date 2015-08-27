namespace ERPWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Perfils", newName: "Perfis");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Perfis", newName: "Perfils");
        }
    }
}
