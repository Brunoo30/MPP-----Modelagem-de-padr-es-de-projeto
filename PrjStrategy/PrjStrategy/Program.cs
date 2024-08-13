using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjStrategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            CompressaoContext ctx = new CompressaoContext(new CompressaoRar());
            Console.WriteLine("Informe o nome do arquivo a comprimir: ");
            var nomeArquivo = Console.ReadLine();

            Console.WriteLine("\nInforme o tipo de compressão a ser usada");
            Console.WriteLine("1-Rar(Padrão) \n2-Zip \n3-Gzip\n");
            var opcao = Convert.ToInt32(Console.ReadLine());
            if (opcao == 2)
            {
                ctx.DefineStrategy(new CompressaoZip());    
            }
            else if (opcao == 3)
            {
                ctx.DefineStrategy(new CompressaoGZip());
            }
            ctx.CriarArquivoCompactado(nomeArquivo);
            Console.Read();
        }
    }
}
