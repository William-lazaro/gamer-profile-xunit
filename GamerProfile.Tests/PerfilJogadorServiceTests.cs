using GamerProfile.App;

namespace GamerProfile.Tests;

public class PerfilJogadorServiceTests
{
    [Fact]
    public void GerarTagUsuario_DeveRetornarTagCorreta()
    {
        var service = new PerfilJogadorService();

        var resultado = service.GerarTagUsuario("Nickname", "0000");

        Assert.Equal("Nickname#0000", resultado);
    }

    [Fact]
    public void CalcularXPTotal_DeveSomarXPComBonus()
    {
        var service = new PerfilJogadorService();

        var resultado = service.CalcularXPTotal(200, 300);

        Assert.Equal(600, resultado);
    }

    [Fact]
    public void EEligivelParaRanked_DeveValidarNivelCorretamente()
    {
        var service = new PerfilJogadorService();

        Assert.True(service.EEligivelParaRanked(15));
        Assert.True(service.EEligivelParaRanked(20));
        Assert.False(service.EEligivelParaRanked(14));
    }
}