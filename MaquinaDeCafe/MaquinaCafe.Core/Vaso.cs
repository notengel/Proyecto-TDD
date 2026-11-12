namespace MaquinaCafe.Core;

public class Vaso
{
    public int CantidadVasos { get; private set; }
    public int Contenido { get; }

    public Vaso(int cantidadVasos, int contenido)
    {
        CantidadVasos = cantidadVasos;
        Contenido = contenido;
    }

    public bool HayVasos(int cantidad) => CantidadVasos >= cantidad;

    public void DarVasos(int cantidad) => CantidadVasos -= cantidad;
}
