using Final_Juan_Pablo_Estrada_Rodríguez;

public class Program
{
    public static void Main(string[] args)
    {
        int opcion = 0;
do
{
Console.WriteLine("Bienvenido/a a la Biblioteca Libritos");
Console.WriteLine("");
Console.WriteLine(" 1. Datos Usuario");
Console.WriteLine(" 2. Mostrar datos");
Console.WriteLine(" 3. Salir ");
opcion = int.Parse(Console.ReadLine());

Biblioteca biblioteca = new Biblioteca();
switch (opcion)
{   
    case 1: do
            {
            Console.WriteLine(" 1. Ingrese Datos");
            Console.WriteLine(" 2. Prestar Libros");
            Console.WriteLine(" 3. Devolver Libros");
            Console.WriteLine(" 4. Salir ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: biblioteca.InformacionUsuario();
                break;
                case 2: biblioteca.PrestamoLibros();
                break;
                case 3: biblioteca.DevolverLibro();
                break;
            }
        } while (opcion != 4);
        break;

    case 2: do{
            Console.WriteLine(" 1. Listado de libros por usuario");
            Console.WriteLine(" 2. Consulta catálogo de libros");
            Console.WriteLine(" 3. Listado de usuarios activos ");
            Console.WriteLine(" 4. Salir ");
            opcion = int.Parse(Console.ReadLine());

            switch(opcion)
            {
                case 1: biblioteca.PrestamoLibros();
                break;
                case 2: 
                break;
                case 3: 
                break;
            }

            } while(opcion != 4);
    break;
}
} while (opcion != 3);
}
}
