namespace MaquinaCafe.Core;

public class Cafetera
{
    public int CantidadCafe { get; private set; }

    public Cafetera(int cantidadCafe) => CantidadCafe = cantidadCafe;

    public bool HayCafe(int cantidad) => CantidadCafe >= cantidad;

    public void DarCafe(int cantidad) => CantidadCafe -= cantidad;
}
