namespace MaquinaCafe.Core;

public class Azucarero
{
    public int CantidadAzucar { get; private set; }

    public Azucarero(int cantidadAzucar) => CantidadAzucar = cantidadAzucar;

    public bool HayAzucar(int cantidad) => CantidadAzucar >= cantidad;

    public void DarAzucar(int cantidad) => CantidadAzucar -= cantidad;
}
