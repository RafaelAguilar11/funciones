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

//9. Sumar dos números utilizando una función SumarMostrar(int a, int b) y mostrar el resultado.

void SumarMostrar(int a, int b)
{
    int suma = a + b;
    Console.WriteLine($"la suma de {a} + {b} es: "+suma );
}

SumarMostrar(12, 23);

//10. Imprimir un texto varias veces utilizando una función ImprimirRepetido(string texto, int veces).

void ImprimirRepetido(string texto,int veces)
{

    for (int num1 = 1; num1 <= veces; num1++)
        Console.WriteLine($"{texto}");
}

ImprimirRepetido("Hola Mundo",5);


//11. Sumar dos números utilizando una función Sumar(int a, int b) que retorne el resultado.

int sumar(int a,int b)
{
    return a + b;
}

int g = sumar(10, 3);
Console.WriteLine(g);

//12. Restar dos números utilizando una función Restar(int a, int b) que retorne el resultado.
 int restar(int a1,int b1)
{
    return a1 - b1;
}

int g1 = restar(10, 3);
Console.WriteLine(g1);


//13. Multiplicar dos números utilizando una función Multiplicar(int a, int b) que retorne el resultado.

int multi(int a, int b)
{
    return a * b;
}

int res = multi(12, 3);
Console.WriteLine(res);

//14. Dividir dos números utilizando una función Dividir(double a, double b) que retorne el resultado.
double dividir(double a, double b)
{
    return a / b;
}

double res1 = dividir(12, 3);
Console.WriteLine(res1);

//15. Determinar si un número es par utilizando una función EsPar(int n) que retorne verdadero o falso.

bool EsPar(int n)
{
    return n % 2 ==0;
}
int res2 = EsPar(30);
Console.WriteLine(res);

