using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Control;
using Projeto01.Entities;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Autor autor1 = new Autor();
            autor1.Livros = new List<Livro>();

            Livro livro1 = new Livro();
            livro1.Autor = new Autor();


            autor1.IdAutor = 1;
            autor1.Nome = "Tolkien";


            livro1.IdLivro = 1;
            livro1.Titulo  = "Senhor dos Aneis";
            livro1.Resumo  = "Livro da trilogia senhor dos aneis";
            livro1.Autor = autor1;

            // ja vou setar os valores do livro2
            Livro livro2 = new Livro(2,"O hobbit", "Livro da saga do Hobbit");
            livro2.Autor = autor1;



            //relacionando o autor aos livros
            autor1.Livros.Add(livro1);
            autor1.Livros.Add(livro2);


            Console.WriteLine("\nDados do Autor:\n");
            Console.WriteLine("\tId.....:"+ autor1.IdAutor);
            Console.WriteLine("\tNome...:" + autor1.Nome);

            foreach (Livro livro in autor1.Livros)
            {
                Console.WriteLine("\nDados do Livro:\n");
                Console.WriteLine("\tId.........:" + livro.IdLivro);
                Console.WriteLine("\tTitulo.....:" + livro.Titulo);
                Console.WriteLine("\tResumo.....:" + livro.Resumo);
                Console.WriteLine("\tAutor......:" + livro.Autor.Nome);

                
            }




            try
            {
                AutorControle autorControle = new AutorControle();
                autorControle.ExportarParaCsv(autor1);

                Console.WriteLine("\ndados de autor gravado com sucesso!");
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro ao exportar autor" + e.Message);
            }


            try
            {
                LivroControle livroControle = LivroControle);
                livroControle.ExportarParaTxt(livro1);
                livroControle.ExportarParaTxt(livro2);

                Console.WriteLine("\ndados de livros gravado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao exportar livros" + e.Message);
            }

            Console.ReadKey();
        }
    }
}
