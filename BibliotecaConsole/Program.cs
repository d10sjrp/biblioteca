using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClassLibrary.Entity;



namespace BibliotecaConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            // INSTANCIANDO OBJETOS
            Categoria objcategoria = new Categoria();
            Autor objautor = new Autor();
            Livro objlivro = new Livro();
            Usuario objusuario = new Usuario();


            // AÇÕES DE CADASTTRO
            Console.WriteLine("Nome da Categoria:");
            objcategoria.Nome = Console.ReadLine();

            Console.WriteLine("Categoria:" + objcategoria.Nome);

            Console.WriteLine("Nome do Autor:");
            objautor.Nome = Console.ReadLine();

            Console.WriteLine("Autor:" + objautor.Nome);

            Console.WriteLine("Nome do Livro:");
            objlivro.Titulo = Console.ReadLine();

            Console.WriteLine("Titulo:" + objlivro.Titulo);

            Console.WriteLine("Nome do Usuario :");
            objusuario.Nome = Console.ReadLine();

            Console.WriteLine("Nome:" + objusuario.Nome);

            
        }
    }
}
