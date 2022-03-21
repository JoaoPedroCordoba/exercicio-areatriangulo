// A = Area b = Base H = altura

double A, b, h;

Console.WriteLine("digite a base do triangulo, por favor:");
b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("digite a altura do triangulo, por favor:");
h = Convert.ToDouble(Console.ReadLine());

A = (b * h) /2;

Console.WriteLine($"A Area do triangulo é:{A:N3}");