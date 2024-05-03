int cantidadProductosVendidos;
int cantidadProductoDeposito = 50;
int stock;


Console.WriteLine("Ingrese la cantidad de electrodos que vendio Cain Rodriguez a Spinneti");

cantidadProductosVendidos = Convert.ToInt32(Console.ReadLine());

stock = cantidadProductosVendidos - cantidadProductoDeposito;

if (stock == 0)


{
    Console.WriteLine("Que Rodrigo visiedo reponga los electrodos correspondientes en su ubicacion para seguir vendiendo...");
    cantidadProductoDeposito = cantidadProductoDeposito + 10;
    Console.WriteLine("Reponiendo...");
}
else
{
    if (stock <=5)
    {
        Console.WriteLine("stock minimo, reponer stock de productos");
        cantidadProductoDeposito = cantidadProductoDeposito +5;
        Console.WriteLine("Visiedo repuso, Nahuel bertolini ya puede empezar a pickearlos");            
            
    }
    else
    {
        Console.WriteLine("informar a ventas {0} productos sin vender.", stock);
    }
}
