using System.Xml;

namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public int Nota { get; }
    public Avaliacao(int nota) { 
    
        if(nota <0 || nota > 10)
        {
        Console.WriteLine("nota invalida");
        }
        else { Nota = nota; }
    }
    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}
