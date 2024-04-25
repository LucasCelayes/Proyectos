string  nombre;
nombre = "Lucas";
string apellido;
apellido = "Celayes";
Console.WriteLine("mi nombre es: " + nombre);
Console.WriteLine("mi apellido es: " + apellido);

int a;
int b;

a = 5;
b = 3;

Console.WriteLine(a+b);

int num1;
int num2;

Console.WriteLine("ingrese el primer numero");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ingrese el segundo numero");
num2 = Convert.ToInt32(Console.ReadLine());

int total = num1 + num2;

Console.WriteLine("el resultado es: " + total);


string mensaje = $"mi nombre es: {nombre} \"el mago\" {apellido}";
Console.WriteLine(mensaje);
Console.ReadKey();  