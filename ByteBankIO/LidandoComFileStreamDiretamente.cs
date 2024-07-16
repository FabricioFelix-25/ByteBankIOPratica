using System.Globalization;
using System.Text;
using ByteBankIO;

partial class Program
{
    static void LidandoComFileStreamDiretamente(string[] args)
    {

        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var numeroDeBytesLidos = -1;

            var buffer = new byte[1024]; //1KB      

            while (numeroDeBytesLidos != 0)
            {
                Console.WriteLine($"Bytes lidos: {numeroDeBytesLidos}");
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer, numeroDeBytesLidos);
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

    private static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {
        var utf8 = new UTF8Encoding();
        var texto = utf8.GetString(buffer, 0, bytesLidos);
        
        //public virtual string GetString(byte[] bytes, int index, int count);
        Console.WriteLine(texto);
    }
}
//aula 02