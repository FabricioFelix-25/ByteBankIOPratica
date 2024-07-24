using System.Text;

namespace ByteBankIO;

public class Program {

    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contaExportadas.csv";
        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "456, 7895,4785.40 gustavo santos";
            var encoding = Encoding.UTF8;

            var bytes = encoding.GetBytes(contaComoString);
            fluxoDeArquivo.Write(bytes, 0, bytes.Length);
        }
    }
}