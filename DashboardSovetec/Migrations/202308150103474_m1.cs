namespace DashboardSovetec.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BitacoraEmpleado",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Observaciones = c.String(),
                        Fecha = c.Int(nullable: false),
                        EmpleadoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Empleado", t => t.EmpleadoID, cascadeDelete: true)
                .Index(t => t.EmpleadoID);
            
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Correo = c.String(),
                        Contraseña = c.String(),
                        Estatus = c.Boolean(nullable: false),
                        TipoEmpleadoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TipoEmpleado", t => t.TipoEmpleadoID, cascadeDelete: true)
                .Index(t => t.TipoEmpleadoID);
            
            CreateTable(
                "dbo.EmpleadoMedidor",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Estatus = c.Boolean(nullable: false),
                        UsuarioID = c.Int(nullable: false),
                        MedidorID = c.Int(nullable: false),
                        Empleado_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Empleado", t => t.Empleado_ID)
                .ForeignKey("dbo.Medidor", t => t.MedidorID, cascadeDelete: true)
                .Index(t => t.MedidorID)
                .Index(t => t.Empleado_ID);
            
            CreateTable(
                "dbo.Medidor",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NumeroSerie = c.String(),
                        FechaResgistro = c.Int(nullable: false),
                        Estatus = c.Boolean(nullable: false),
                        Longitud = c.Double(nullable: false),
                        Latitud = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Dispositivo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NumeroSerie = c.Int(nullable: false),
                        FechaRegistro = c.Int(nullable: false),
                        Estatus = c.Boolean(nullable: false),
                        EmpresaID = c.Int(nullable: false),
                        MedidorID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Empresa", t => t.EmpresaID, cascadeDelete: true)
                .ForeignKey("dbo.Medidor", t => t.MedidorID)
                .Index(t => t.EmpresaID)
                .Index(t => t.MedidorID);
            
            CreateTable(
                "dbo.Empresa",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FechaRegistro = c.Int(nullable: false),
                        RFC = c.String(),
                        Nombre = c.String(),
                        PersonaContacto = c.String(),
                        TelefonoContacto = c.Long(nullable: false),
                        Correo = c.String(),
                        Estatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Registros",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Fecha = c.Int(nullable: false),
                        Contenido = c.String(),
                        MedidorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Medidor", t => t.MedidorID, cascadeDelete: true)
                .Index(t => t.MedidorID);
            
            CreateTable(
                "dbo.TipoEmpleado",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Rol = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BitacoraUsuarios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Observaciones = c.String(),
                        Fecha = c.Int(nullable: false),
                        UsuarioID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Usuario", t => t.UsuarioID, cascadeDelete: true)
                .Index(t => t.UsuarioID);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Correo = c.String(),
                        Contraseña = c.String(),
                        TipoUsuarioID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TipoUsuario", t => t.TipoUsuarioID, cascadeDelete: true)
                .Index(t => t.TipoUsuarioID);
            
            CreateTable(
                "dbo.TipoUsuario",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Rol = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuario", "TipoUsuarioID", "dbo.TipoUsuario");
            DropForeignKey("dbo.BitacoraUsuarios", "UsuarioID", "dbo.Usuario");
            DropForeignKey("dbo.Empleado", "TipoEmpleadoID", "dbo.TipoEmpleado");
            DropForeignKey("dbo.Registros", "MedidorID", "dbo.Medidor");
            DropForeignKey("dbo.EmpleadoMedidor", "MedidorID", "dbo.Medidor");
            DropForeignKey("dbo.Dispositivo", "MedidorID", "dbo.Medidor");
            DropForeignKey("dbo.Dispositivo", "EmpresaID", "dbo.Empresa");
            DropForeignKey("dbo.EmpleadoMedidor", "Empleado_ID", "dbo.Empleado");
            DropForeignKey("dbo.BitacoraEmpleado", "EmpleadoID", "dbo.Empleado");
            DropIndex("dbo.Usuario", new[] { "TipoUsuarioID" });
            DropIndex("dbo.BitacoraUsuarios", new[] { "UsuarioID" });
            DropIndex("dbo.Registros", new[] { "MedidorID" });
            DropIndex("dbo.Dispositivo", new[] { "MedidorID" });
            DropIndex("dbo.Dispositivo", new[] { "EmpresaID" });
            DropIndex("dbo.EmpleadoMedidor", new[] { "Empleado_ID" });
            DropIndex("dbo.EmpleadoMedidor", new[] { "MedidorID" });
            DropIndex("dbo.Empleado", new[] { "TipoEmpleadoID" });
            DropIndex("dbo.BitacoraEmpleado", new[] { "EmpleadoID" });
            DropTable("dbo.TipoUsuario");
            DropTable("dbo.Usuario");
            DropTable("dbo.BitacoraUsuarios");
            DropTable("dbo.TipoEmpleado");
            DropTable("dbo.Registros");
            DropTable("dbo.Empresa");
            DropTable("dbo.Dispositivo");
            DropTable("dbo.Medidor");
            DropTable("dbo.EmpleadoMedidor");
            DropTable("dbo.Empleado");
            DropTable("dbo.BitacoraEmpleado");
        }
    }
}
