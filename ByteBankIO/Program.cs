using System.Globalization;
using System.Text;
using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";
        var numeroDeBytesLidos = -1;

        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

        var buffer = new byte[1024]; //1KB

        while (numeroDeBytesLidos != 0)
        {
            numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
            EscreverBuffer(buffer);
        }

        // Devoluções:
        // 0 número total de bytes lidos do buffer. Isso poderá ser menor que o número de
        // bytes solicitado se esse número de bytes não estiver disponível no momento, ou
        //zero, se o final do fluxo for atingido

        // public override int Read(byte[] array, int offset, int count)

        Console.ReadLine();
    }

    private static void EscreverBuffer(byte[] buffer)
    {
        var utf8 = new UTF8Encoding();
        {
            foreach (var meuByte in buffer)
            {
                Console.Write(meuByte);
                Console.Write(" ");
            }
        }
    }
}