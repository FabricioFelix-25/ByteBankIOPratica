
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        UsarStreamDeEntrada();

        Console.WriteLine("Aplicação Finalizada ...");

        Console.ReadLine();
    }
}




// var caminhoNovoArquivo = "TestaEscrita.txt";
//
// using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
// using (var escritor = new StreamWriter(fluxoDoArquivo))
// {
//     escritor.WriteLine(true);
//     escritor.WriteLine(false);
//     escritor.WriteLine(454545454545);
//     
// }
//
// Console.WriteLine("aplicação finalizada");
//
// Console.ReadLine();