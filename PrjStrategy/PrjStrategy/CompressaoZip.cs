using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjStrategy
{
    public class CompressaoZip : ICompressao
    {
        public void ComprimirArquivo(string nomeArquivo)
        {
            Console.WriteLine($"\n  O arquivo '{nomeArquivo}' foi compactado. Um arquivo com extensão .zip foi criado!");
        }
    }
}
