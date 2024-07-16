﻿using System.Globalization;
using System.Text;
using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {

        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var numeroDeBytesLidos = -1;

            var buffer = new byte[1024]; //1KB      

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);
            }

            // Devoluções:
            //  O número total de bytes lidos do buffer. Isso poderá ser menor que o número de
            //  bytes solicitado se esse número de bytes não estiver disponível no momento, ou
            //  zero, se o final do fluxo for atingido


            // public override int Read(byte[] array, int offset, int count);
            fluxoDoArquivo.Close();

            Console.ReadLine();
        }
    }

    private static void EscreverBuffer(byte[] buffer)
    {
        var utf8 = new UTF8Encoding();
        var texto = utf8.GetString(buffer);
        Console.WriteLine(texto);
    }
}
//aula 02