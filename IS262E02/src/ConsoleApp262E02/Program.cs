double baseRect = 5;
double alturaRect = 8;
double profundidad = 10;

double perimetro = Rectangulo262E02.Perimetro(baseRect, alturaRect);
double area = Rectangulo262E02.Area(baseRect, alturaRect);
double volumen = Rectangulo262E02.Volumen(baseRect, alturaRect, profundidad);

Console.WriteLine($"El perímetro de la base de un prisma rectangular de {baseRect}cm por {alturaRect}cm es {perimetro}cm");
Console.WriteLine($"El área de la base de un prisma rectangular de {baseRect}cm por {alturaRect}cm es {area}cm2");
Console.WriteLine($"El volumen de un prisma rectangular de {baseRect}cm por {alturaRect}cm y {profundidad}cm de profundidad es {volumen}cm3");