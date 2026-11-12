using MaquinaCafe.Core;

namespace MaquinaCafe.Tests;

public class MaquinaDeCafeTests
{
    private readonly Cafetera cafetera;
    private readonly Vaso vasosPequeno;
    private readonly Vaso vasosMediano;
    private readonly Vaso vasosGrande;
    private readonly Azucarero azucarero;
    private readonly MaquinaDeCafe maquina;

    public MaquinaDeCafeTests()
    {
        cafetera = new Cafetera(50);
        vasosPequeno = new Vaso(5, 10);
        vasosMediano = new Vaso(5, 20);
        vasosGrande = new Vaso(5, 30);
        azucarero = new Azucarero(20);

        maquina = new MaquinaDeCafe(cafetera, vasosPequeno, vasosMediano, vasosGrande, azucarero);
    }

    [Fact]
    public void DeberiaDevolverUnVasoPequeno()
    {
        var vaso = maquina.GetTipoDeVaso("pequeno");
        Assert.Same(maquina.VasosPequeno, vaso);
    }

    [Fact]
    public void DeberiaDevolverUnVasoMediano()
    {
        var vaso = maquina.GetTipoDeVaso("mediano");
        Assert.Same(maquina.VasosMediano, vaso);
    }

    [Fact]
    public void DeberiaDevolverUnVasoGrande()
    {
        var vaso = maquina.GetTipoDeVaso("grande");
        Assert.Same(maquina.VasosGrande, vaso);
    }

    [Fact]
    public void DeberiaDevolverNoHayVasos()
    {
        var vaso = maquina.GetTipoDeVaso("pequeno");
        var resultado = maquina.GetVasoDeCafe(vaso, 10, 2);
        Assert.Equal("No hay Vasos", resultado);
    }

    [Fact]
    public void DeberiaDevolverNoHayCafe()
    {
        var maquinaSinCafe = new MaquinaDeCafe(new Cafetera(5), vasosPequeno, vasosMediano, vasosGrande, azucarero);
        var vaso = maquinaSinCafe.GetTipoDeVaso("pequeno");
        var resultado = maquinaSinCafe.GetVasoDeCafe(vaso, 1, 2);
        Assert.Equal("No hay Cafe", resultado);
    }

    [Fact]
    public void DeberiaDevolverNoHayAzucar()
    {
        var maquinaSinAzucar = new MaquinaDeCafe(cafetera, vasosPequeno, vasosMediano, vasosGrande, new Azucarero(2));
        var vaso = maquinaSinAzucar.GetTipoDeVaso("pequeno");
        var resultado = maquinaSinAzucar.GetVasoDeCafe(vaso, 1, 3);
        Assert.Equal("No hay Azucar", resultado);
    }

    [Fact]
    public void DeberiaRestarCafe()
    {
        var vaso = maquina.GetTipoDeVaso("pequeno");
        maquina.GetVasoDeCafe(vaso, 1, 3);
        Assert.Equal(40, maquina.Cafetera.CantidadCafe);
    }

    [Fact]
    public void DeberiaRestarVaso()
    {
        var vaso = maquina.GetTipoDeVaso("pequeno");
        maquina.GetVasoDeCafe(vaso, 1, 3);
        Assert.Equal(4, maquina.VasosPequeno.CantidadVasos);
    }

    [Fact]
    public void DeberiaRestarAzucar()
    {
        var vaso = maquina.GetTipoDeVaso("pequeno");
        maquina.GetVasoDeCafe(vaso, 1, 3);
        Assert.Equal(17, maquina.Azucarero.CantidadAzucar);
    }

    [Fact]
    public void DeberiaDevolverFelicitaciones()
    {
        var vaso = maquina.GetTipoDeVaso("pequeno");
        var resultado = maquina.GetVasoDeCafe(vaso, 1, 3);
        Assert.Equal("Felicitaciones", resultado);
    }
}
