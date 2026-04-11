public class Rectangulo262E02Tests
{
    // PRUEBA 1: PERÍMETRO
    [Theory]
    [InlineData(2, 8)] // Lado 2 -> Perímetro 8
    [InlineData(5, 20)] // Lado 5 -> Perímetro 20
    [InlineData(10, 40)] // Lado 10 -> Perímetro 40
    public void Perimetro(double lado, double expected)
    {

        double actual = Rectangulo262E02.Perimetro(lado);

        Assert.Equal(expected, actual);
    }

    // PRUEBA 2: ÁREA
    [Theory]
    [InlineData(2, 4)] // Lado 2 -> Área 4
    [InlineData(5, 25)] // Lado 5 -> Área 25
    [InlineData(10, 100)] // Lado 10 -> Área 100
    public void Area(double lado, double expected)
    {
    
        double actual = Rectangulo262E02.Area(lado);
        
        Assert.Equal(expected, actual);
    }

    // PRUEBA 3: VOLUMEN (CUBO)
    [Theory]
    [InlineData(4, 2, 8)] // Área 4, Altura 2 -> Volumen 8
    [InlineData(9, 3, 27)] // Área 9, Altura 3 -> Volumen 27
    [InlineData(25, 5, 125)] // Área 25, Altura 5 -> Volumen 125
    public void Volumen(double area, double altura, double expected)
    {
    
        double actual = Rectangulo262E02.Volumen(area, altura);
        
        Assert.Equal(expected, actual);
    }
}