public class Rectangulo262E02
{
    public static double Perimetro(double baseRect, double alturaRect)
    {
        return (baseRect * 2) + (alturaRect * 2);
    }

    public static double Area(double baseRect, double alturaRect)
    {
        return baseRect * alturaRect;
    }

    public static double Volumen(double baseRect, double alturaRect, double profundidad)
    {
        return baseRect * alturaRect * profundidad;
    }
}