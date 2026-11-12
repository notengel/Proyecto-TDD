using MaquinaCafe.Core;

namespace MaquinaCafe.Tests;

public class AzucareroTests
{
    private readonly Azucarero azucarero;

    public AzucareroTests()
    {
        azucarero = new Azucarero(10);
    }

    [Fact]
    public void DeberiaDevolverVerdaderoSiHaySuficienteAzucar()
    {
        Assert.True(azucarero.HayAzucar(5));
        Assert.True(azucarero.HayAzucar(10));
    }

    [Fact]
    public void DeberiaDevolverFalsoSiNoHaySuficienteAzucar()
    {
        Assert.False(azucarero.HayAzucar(15));
    }

    [Fact]
    public void DeberiaRestarAzucarAlAzucarero()
    {
        azucarero.DarAzucar(5);
        Assert.Equal(5, azucarero.CantidadAzucar);

        azucarero.DarAzucar(2);
        Assert.Equal(3, azucarero.CantidadAzucar);
    }
}
