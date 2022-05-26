/* Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente:

1) Pedir al usuario la longitud de un vector
2) Crear el vector del tamaño ingresado.
3) Llenar el mismo con datos aleatorios
4) Mostrar el vector por pantalla
5) Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero; el segundo en anteúltimo, 
	el anteúltimo en el segundo y así sucesivamente. En otra palabras si el vector es de 5 posiciones y el usuario ingresó: 
	10, 20, 30, 40, 50, una vez invertido, el vector debe quedar así: 50, 40, 30, 20, 10.  
	Se debe usar solo lo visto en clase hasta ahora y no los métodos que trae C# para estas cuestiones. Tampoco se debe 
	crear un vector nuevo o auxiliar para realizar el ejercicio. 
6) Mostrar el vector nuevamente. */

Console.WriteLine("Ingrese la longitud del vector: ");
var dato = Console.ReadLine();
int n = int.Parse(dato);

int[] vector = new int[n];

Random aleatorio = new Random();

for (int i = 0; i < n; i++)
{
    vector[i] = aleatorio.Next(200); // elijo que los numeros aleatorios sean menores a 200
}

Console.WriteLine();
Console.WriteLine("El vector generado es: ");
Console.WriteLine();

foreach (var i in vector)
{
	Console.WriteLine(i);
}

int aux = 0;
int indiceX = 0;		// el indice inicial del vector
int indiceY = n - 1;	// el indice final del vector

while (indiceX < indiceY) // mientras el indice inicial sea mayor al indice final (para que al llegar a la mitad deje de invertir el vector)
{
	aux = vector[indiceY];				// coloco el valor del ulimo indice en una var auxiliar
	vector[indiceY] = vector[indiceX];	// paso el valor del primer indice al ultimo lugar
	vector[indiceX] = aux;              // paso lo del auxiliar al lugar del primer indice
	indiceX++;		// aumento en 1 el primer indice para pasar al segundo lugar
	indiceY--;		// disminuyo el ultimo indice para pasar al penultimo lugar
}

Console.WriteLine();
Console.WriteLine("**********************************");
Console.WriteLine();
Console.WriteLine("El vector invertido es: ");
Console.WriteLine();

foreach (var i in vector)
{
	Console.WriteLine(i);
}