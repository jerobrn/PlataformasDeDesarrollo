using System;
using System.Linq;


namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {

            //Insert();
            //Consulta();
           // Update();
           // Delete();



        }



        static void Insert()
        {
            var context = new DBCon();

            context.Usuario.Add(new Usuario
            {
                User = "usuario1",
                Clave = "1234"
            });
            context.SaveChanges();
            Console.WriteLine("Usuario Insertado");

        }

        static void Consulta()
        {
            var context = new DBCon();

            var list = context.Usuario.ToList();
            foreach (var item in list)
            {
                Console.WriteLine($"Usuario: {item.User} ID: {item.IDUser}");
            }
        }

        static void Update()
        {
            var context = new DBCon();
            var lista = context.Usuario.Where(i => i.IDUser == 1).ToList();
            lista[0].User = "UsuarioActualizado";
            context.SaveChanges();
            Console.WriteLine("Usuario Actualizado");
        }

        static void Delete()
        {
            var context = new DBCon();
            var usuario = context.Usuario.Where(i => i.IDUser == 1).Single();
            context.Usuario.Remove(usuario);
            context.SaveChanges();
            Console.WriteLine("Usuario Borrado");
        }















    }
}
