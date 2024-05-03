string categoria;

Console.WriteLine("ingrese el puesto que ocupa en Orofino : Reponer,Pickeador,Embalador,Repartidor");

categoria = Console.ReadLine();

switch (categoria)
{
    case "Reponedor":
        Console.WriteLine("Su labor es llevar los articulos a las ubicaciones y mantener el orden y la limpieza");
        break;

    case "Pickeador":
        Console.WriteLine("Su labor es sacar los articulos de las ubicaciones y llevarlos a la mesa, todo esto en tiempo y forma");
        break;
    case "Embalador":
        Console.WriteLine("Su labor es controlar lo que trae el pickeador, y la vez embalarlo para que el repartidor lo lleve al cliente");
        break;
    case "Repartidor":
        Console.WriteLine("Su labor es llevar el pedido al cliente, el bulto tiene que llegar en optimas condiciones y lo antes posible");
        break;
    default:
        Console.WriteLine("Su labor aun no se conoce, presentarse con Dario y consultar tarea a realizar");
        break;
}
