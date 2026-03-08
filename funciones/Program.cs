//1. Mostrar un saludo en pantalla utilizando una función Saludar() que imprima “Hola, bienvenido”.
void saludar()
{
    Console.WriteLine("Hola, bienvenido");
}

saludar();



//2. Mostrar un nombre en pantalla utilizando una función MostrarNombre().
void MostrarNombre()
{
    Console.WriteLine("Rafael");
}

MostrarNombre();


//3. Mostrar un mensaje en pantalla utilizando una función MostrarMensaje() que imprima “Programación en C#”.
void MostrarMensaje()
{
    Console.WriteLine("Programación en C#");
}

MostrarMensaje();

//4. Imprimir una línea separadora utilizando una función Linea() que muestre “----------------”.
void linea()
{
    Console.WriteLine("----------------");
}

linea();

//5. Mostrar un menú simple utilizando una función MostrarMenu() con tres opciones.

void MostrarMenu()
{
    Console.WriteLine("Elegir opcion ");
    Console.WriteLine("Ingresar contraseña ");
    Console.WriteLine("salir ");
}

MostrarMenu();

//6. Saludar a una persona utilizando una función Saludar(string nombre) que imprima “Hola + nombre”.

void Saludar1(string nombre)
{
    Console.WriteLine("Hola " + nombre);
}

Saludar1("Carlos");

//7. Mostrar el doble de un número utilizando una función MostrarDoble(int n).

void MostrarDoble(int n)
{
    int res = n * 2;
    Console.WriteLine("el doble es " + res);
}

MostrarDoble(5);

//8. Mostrar el cuadrado de un número utilizando una función MostrarCuadrado(int n).

void MostrarCuadrado(int n)
{
    int num1 = n * n;
    Console.WriteLine($"el cuadrado de {n} es:" + num1);
}

MostrarCuadrado(4);