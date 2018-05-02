using System;
using System.Data.Entity;
using Demo.Model;

namespace Demo.Dal
{
    public class DemoInitializer : DropCreateDatabaseAlways<DemoContext>
    {
        protected override void Seed(DemoContext context)
        {

            #region Documentos de Identidad

            context.Documentos.Add(new Documento()
            {
                Id = 1,
                Nombre = "DNI",
                Descripcion = "LIBRETA ELECTORAL O DNI",
                Activo = true
            });
            context.Documentos.Add(new Documento()
            {
                Id = 2,
                Nombre = "CE",
                Descripcion = "CARNET DE EXTRANJERIA",
                Activo = true
            });
            context.Documentos.Add(new Documento()
            {
                Id = 3,
                Nombre = "PASAPORTE",
                Descripcion = "PASAPORTE",
                Activo = true
            });
            context.Documentos.Add(new Documento()
            {
                Id = 4,
                Nombre = "OTROS",
                Descripcion = "OTROS",
                Activo = true
            });

            #endregion

            #region Clientes

            context.Clientes.Add(new Cliente()
            {
                Codigo = "CLIE001",
                Nombres = "Jian Carlos",
                Apellidos = "Soto Perez",
                DocumentoId = 1,
                NroDocumento = "12345678",
                FechaNacimiento = new DateTime(1985, 12, 23),
                Sexo = "M",
                Activo = true
            });
            context.Clientes.Add(new Cliente()
            {
                Codigo = "CLIE002",
                Nombres = "Stefannie",
                Apellidos = "Gamboa Diaz",
                Documento = context.Documentos.Find(2),
                NroDocumento = "07654321",
                FechaNacimiento = new DateTime(1990, 6, 1),
                Sexo = "F",
                Activo = true
            });
            context.Clientes.Add(new Cliente()
            {
                Codigo = "CLIE003",
                Nombres = "Hector",
                Apellidos = "Godoy Martinez",
                Documento = context.Documentos.Find(1),
                NroDocumento = "71236548",
                FechaNacimiento = new DateTime(1992, 11, 1),
                Sexo = "M",
                Activo = true
            });
            context.Clientes.Add(new Cliente()
            {
                Codigo = "CLIE004",
                Nombres = "Jean Franco",
                Apellidos = "Garcia Lima",
                Documento = context.Documentos.Find(1),
                NroDocumento = "15975328",
                FechaNacimiento = new DateTime(1988, 8, 8),
                Sexo = "M",
                Activo = true
            });

            #endregion

            #region Usuarios

            context.Usuarios.Add(new Usuario()
            {
                Name = "ADMIN",
                Password = "1234",
                Nombre = "Administrador",
                Email = "admin@email.net",
                Bloqueado = false
            });

            #endregion

            base.Seed(context);
        }
    }
}
