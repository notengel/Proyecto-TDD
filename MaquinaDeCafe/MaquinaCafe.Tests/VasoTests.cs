using MaquinaCafe.Core;

namespace MaquinaCafe.Tests;

public class VasoTests
{
    [Fact]
    public void DeberiaDevolverVerdaderoSiExistenVasos()
    {
        var vasosPequenos = new Vaso(2, 10);
        Assert.True(vasosPequenos.HayVasos(1));
    }

    [Fact]
    public void DeberiaDevolverFalsoSiNoExistenVasos()
    {
        var vasosPequenos = new Vaso(1, 10);
        Assert.False(vasosPequenos.HayVasos(2));
    }

    [Fact]
    public void DeberiaRestarCantidadDeVaso()
    {
        var vasosPequenos = new Vaso(5, 10);
        vasosPequenos.DarVasos(1);
        Assert.Equal(4, vasosPequenos.CantidadVasos);
    }
}
