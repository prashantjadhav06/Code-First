namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEmps : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Emps",
                c => new
                    {
                        empId = c.Int(nullable: false, identity: true),
                        empName = c.String(),
                        empAge = c.Int(nullable: false),
                        empPh = c.Long(nullable: false),
                        empAddress = c.String(),
                    })
                .PrimaryKey(t => t.empId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Emps");
        }
    }
}
