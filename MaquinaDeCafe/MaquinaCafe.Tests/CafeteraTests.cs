using MaquinaCafe.Core;

namespace MaquinaCafe.Tests;

public class CafeteraTests
{
    [Fact]
    public void DeberiaDevolverVerdaderoSiExisteCafe()
    {
        var cafetera = new Cafetera(10);
        Assert.True(cafetera.HayCafe(5));
    }

    [Fact]
    public void DeberiaDevolverFalsoSiNoExisteCafe()
    {
        var cafetera = new Cafetera(10);
        Assert.False(cafetera.HayCafe(11));
    }

    [Fact]
    public void DeberiaRestarCafeALaCafetera()
    {
        var cafetera = new Cafetera(10);
        cafetera.DarCafe(7);
        Assert.Equal(3, cafetera.CantidadCafe);
    }
}
