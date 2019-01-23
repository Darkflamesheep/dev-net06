using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;
using Projeto01.Interfaces;
using System.IO;

namespace Projeto01.Control
{
    class AutorControle : IAutorControle
    {
        public void ExportarParaCsv(Autor autor)
        {

            using (StreamWriter sw = new StreamWriter("\\c:temp\\Autor.Csv", true))
            { 
                sw.WriteLine($"{autor.IdAutor}; {autor.Nome}");


            }


        }
    }
}
