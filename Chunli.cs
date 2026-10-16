// Clase hija de Luchador: Ryu
// Sobrescribe EjecutarEspecial() lanzando un Hadoken que gasta 25 de Ki.
public class ChunLi : Luchador
{
    private const int CostoKikoken = 25;

    public ChunLi(string nombre, int barraSalud, int barraKi)
        : base(nombre, barraSalud, barraKi)
    {
    }

    public override void EjecutarEspecial()
    {
        if (barraKi >= CostoKikoken)
        {
            barraKi -= CostoKikoken;
            System.Console.WriteLine(nombre + " lanza: ¡KIKOKEN! (Ki restante: " + barraKi + ")");
        }
        else
        {
            System.Console.WriteLine(nombre + " no tiene Ki suficiente para el Kikoken (Ki actual: " + barraKi + ", necesita " + CostoKikoken + ")");
        }
    }
}
