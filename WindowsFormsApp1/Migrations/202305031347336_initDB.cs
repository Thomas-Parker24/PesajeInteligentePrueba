namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empresa",
                c => new
                    {
                        EmpresaID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Codigo = c.Int(nullable: false),
                        Direccion = c.String(nullable: false),
                        Telefono = c.String(nullable: false),
                        Ciudad = c.String(nullable: false),
                        Departamento = c.String(nullable: false),
                        Pais = c.String(nullable: false),
                        Creacion = c.DateTime(nullable: false),
                        Modificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EmpresaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Empresa");
        }
    }
}
