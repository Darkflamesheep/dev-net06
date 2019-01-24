using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities;
using Projeto02.Interfaces;
using System.IO;
using System.Xml;


namespace Projeto02.Controls
{
    public class ProdutoControle : IControle<Produtos>
    {
        public void ExportarParaCsv(Produtos obj)
        {
          
            
        }

        public void ExportarParaTxt(Produtos obj)
        {

        }

        public void ExportarParaXml(Produtos obj)
        {
            using (XmlWriter xml = XmlWriter.Create("\\c:temp\\produtos.xml"))
            {
                xml.WriteStartElement("produtos");

                xml.WriteElementString("idcliente", obj.IdProduto.ToString());
                xml.WriteElementString("nome", obj.Nome);
                xml.WriteElementString("preco", obj.Preco.ToString());

                xml.WriteEndElement();



            }


        }
    }
}
