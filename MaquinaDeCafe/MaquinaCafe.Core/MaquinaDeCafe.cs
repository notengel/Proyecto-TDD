namespace MaquinaCafe.Core;

public class MaquinaDeCafe
{
    public Cafetera Cafetera { get; }
    public Vaso VasosPequeno { get; }
    public Vaso VasosMediano { get; }
    public Vaso VasosGrande { get; }
    public Azucarero Azucarero { get; }

    public MaquinaDeCafe(Cafetera cafetera, Vaso vasosPequeno, Vaso vasosMediano,
                         Vaso vasosGrande, Azucarero azucarero)
    {
        Cafetera = cafetera;
        VasosPequeno = vasosPequeno;
        VasosMediano = vasosMediano;
        VasosGrande = vasosGrande;
        Azucarero = azucarero;
    }

    public Vaso GetTipoDeVaso(string tipoDeVaso) => tipoDeVaso.ToLower() switch
    {
        "pequeno" => VasosPequeno,
        "mediano" => VasosMediano,
        "grande" => VasosGrande,
        _ => throw new ArgumentException("Tipo de vaso no válido")
    };

    public string GetVasoDeCafe(Vaso vaso, int cantidadDeVasos, int cantidadDeAzucar)
    {
        var cafeNecesario = vaso.Contenido * cantidadDeVasos;

        if (!vaso.HayVasos(cantidadDeVasos)) return "No hay Vasos";
        if (!Cafetera.HayCafe(cafeNecesario)) return "No hay Cafe";
        if (!Azucarero.HayAzucar(cantidadDeAzucar)) return "No hay Azucar";

        vaso.DarVasos(cantidadDeVasos);
        Cafetera.DarCafe(cafeNecesario);
        Azucarero.DarAzucar(cantidadDeAzucar);
        return "Felicitaciones";
    }
}
