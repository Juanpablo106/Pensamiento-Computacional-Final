using System.Diagnostics;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Final_Juan_Pablo_Estrada_Rodríguez;

public class Biblioteca:Usuario
{
        public void PrestamoLibros()
    {
        Console.WriteLine (" ");
        Console.WriteLine("Ingrese el número del libro que desea ingresar: ");
        for (int i = 0; i< Libro.Length; i++)
        {
            Console.WriteLine((i+1) + "." + " " + Libro[i].Titulo);
        }
        int indice = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine("");
        Libros LibroPrestado = Libro[indice];
        if(LibroPrestado.usuario != null)
        {
            Console.WriteLine($"El libro que quiere está prestado por: {LibroPrestado.usuario.Nombre}");
        }
        else
        {
            Console.WriteLine("");
            
            Console.WriteLine("A qué persona se lo desea prestar: ");
            for (int i = 0; i< Personas.Length; i++)
            {
                Console.WriteLine((i+1) + "." + " " + Personas[i].Nombre);
            }
            int indiceP = int.Parse(Console.ReadLine()) - 1;
            LibroPrestado.usuario = Personas[indiceP];
        }
        Console.WriteLine(" ");
   
    }
        public void DevolverLibro()
    {
        Console.WriteLine (" ");
        Console.WriteLine("Ingrese el número del libro que desea devolver: ");
        for (int i = 0; i< Libro.Length; i++)
        {
            Console.WriteLine((i+1) + "." + " " + Libro[i].Titulo);
        }
        int indice = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine("");
        Libros libroPrestado = Libro[indice];
        if(libroPrestado.usuario == null)
        {
            Console.WriteLine($"El libro que quiere devolver no esta prestado");
        }
        else
        {
            libroPrestado.usuario = null; 
            Console.WriteLine("El libro se ha devuelto exitosamente");
        }

    }
    public void InformacionUsuario()
    {
        string TelefonoValido;
        string CarneValido;
        Usuario usuario = new Usuario(); 

        Console.WriteLine("Ingrese su Nombre");
        usuario.Nombre = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Ingrese su Apellido");
        usuario.Apellido = Console.ReadLine();
        Console.WriteLine();

        do
        {
        Console.WriteLine("Ingrese su Carné");
        usuario.Carne = Console.ReadLine();
        CarneValido = usuario.Carne;
        Console.WriteLine();
        if (CarneValido.Length <= 7)
        {
            Console.WriteLine("Su carne es válido");
        }
        else
        {
            Console.WriteLine("Su carne no es válido");
        }
        }while (CarneValido.Length > 7);

        do
        {
        Console.WriteLine("Ingrese su Teléfono");
        usuario.Telefono = Console.ReadLine();
        TelefonoValido = usuario.Telefono;
        if (TelefonoValido.Length <= 8)
        {
            Console.WriteLine("Su teléfono es válido");
        }
        else
        {
            Console.WriteLine("El número de telefono no es válido");
        }
        Console.WriteLine();
        } while (TelefonoValido.Length > 8);
    }
        public void Usuarios()
    {
        for (int i = 0; i < Libro.Length; i++)
        {
        Libros libroprestado = Libro[i];
        if (libroprestado.usuario != null)
        {
            Console.WriteLine($"El usuario activo que pidio un libro es: {libroprestado.usuario.Nombre}");
        }
        }
        Console.WriteLine(" ");
    }

        public Libros [] Libro = new Libros [5];
        public Usuario [] Personas = new Usuario [5];
        public string [] PrestadosPersona = new string [5];

        public Biblioteca()
    {
        Libro[0] = new Libros ("Pinocho");
        Libro[1] = new Libros("Peter Pan");
        Libro[2] = new Libros("Blanca Nieves");
        Libro[3] = new Libros("Cenicienta");
        Libro[4] = new Libros("El mago de Oz");
    }

     public void Catalogo()
    {
        Console.WriteLine("");
        for (int i = 0; i < Libro.Length; i++)
        {
        Console.WriteLine((i+1) + "." + " " + Libro[i].Titulo);
        }
    Console.WriteLine("");
    }

    public void ImprimirPrestados()
    {

        for (int i = 0; i < Libro.Length; i++)
        {
        Libros libroprestado = Libro[i];
        if (libroprestado.usuario != null)
        {
            Console.WriteLine($"{libroprestado.usuario.Nombre} {libroprestado.usuario.Apellido}, con un número de Carnet de: {libroprestado.usuario.Carne} y telefono: {libroprestado.usuario.Telefono}; reservó el libro: {libroprestado.Titulo}");
        }
        }
        Console.WriteLine(" ");
    }
}