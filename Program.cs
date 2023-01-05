using Humanizer;//hace referencia al paquete de Humanizer
//var - cualquier tipo de dato
#region Cadenas
//PRIMERA FORMA PARA CONCATENAR CADENAS
string primerNombre = "Diana";
string apellido= "Renteria";
//Console.WriteLine(primerNombre + " " + apellido);

string mensaje = "Hola, me llamo " + primerNombre + " " + apellido + " y vivo en Mexico.";
Console.WriteLine(mensaje);

//SEGUNDA FORMA PARA CONCATENAR CADENAS - Interpolacion de cadenas
//$ se coloca afuera de la cadena
//{} se manda a llamar a las variables usando llaves
string mensajeInterpolado = $"Hola, me llamo {primerNombre} {apellido} \ny vivo en Mexico.";
Console.WriteLine(mensajeInterpolado);

string carpeta = @"C:\Users\ejemplo.txt";//@ ignora caracteres de escape \ para tomarlo como una cadena
Console.WriteLine(carpeta);

//podemos fusionar @$ en cadenas para invocar variables y usar caracteres de escape como cadena
string mensajeCarpeta =  @$"Hola, me llamo {primerNombre} {apellido} y mi archivo es C:\Users\ejemplo.txt";
Console.WriteLine(mensajeCarpeta);
#endregion

#region Numeros

int num1 = 10;
int num2 = 5;

//num1+num2
//num1+=num2;
//Console.WriteLine(num1);

int resultado = num1 + num2 * num1 + num1 * num2;
Console.WriteLine(resultado);

/*  OPERACIONES ARTIMETICAS   l
P - Parentesis                l
E - Exponentes                l
M - Multiplicacion            l
D - Division                  l
A - Adicion                   l
S - Sustraccion               v
*/                            

//Division decimal, opc1: declarar una var decimal y otra var decimal donde se guarda la operacion
decimal numero1= 22;
int numero2= 5;

decimal resultadoDecimal = numero1/numero2;
Console.WriteLine(resultadoDecimal);

//Division decimal, opc2: Hacer cast en la division a decimal
int newNum1=22;
int newNum2=5;

decimal newDivision = (decimal) newNum1/newNum2; //cast 
Console.WriteLine(newDivision);

//Console.Write imprime sin usar toda la linea la informacion
//Console WriteLine imprime en una linea lo que esta dentro del parentesis en la consola

int number1=0;
int number2=0;
Console.Write("Escribe el primer numero: ");
//number1 = Console.ReadLine(); obtiene la info que el usuario escriba dentro de una linea en la terminal
                              //ReadLine regresa String, como estamos usando int en number1, debemos hacer un parseo
number1 = int.Parse(Console.ReadLine());

Console.Write("Escribe el segundo numero: ");
number2 = int.Parse(Console.ReadLine());

decimal resultadoNumbers= (decimal) number1/number2;

Console.WriteLine(resultadoNumbers);
//usando interpolacion en la impresion
Console.WriteLine($"El resultado de la operacion es : {resultadoNumbers}");


#endregion

//SENTENCIAS CONDICIONALES
#region if

/* OPERADORES RELACIONALES
X == Z  X igual a Z
X!=Z    X diferente a Z
X<Z     X menor a Z
X>Z     X mayor a Z
X<=Z    X menor o igual a Z
X>=Z    X mayor o igual a Z
*/

int x = 20;
int z= 20;

if (x==z){
    Console.WriteLine($"{x} es igual a {z}");
}else{
     Console.WriteLine($"{x} no es igual a {z}");
}

int x1 = 20;
int z1= 21;
if (x1!=z1){
    Console.WriteLine($"{x1} no es igual a {z1}");
}else{
     Console.WriteLine($"{x1} es igual a {z1}");
}


int x2 = 25;
int z2 = 25;
string mensajeIf = "";

if (x2 > z2){//si el bloque/cuerpo del if es de una linea, podemos omitir llaves pero respetar la identacion (quité llaves y marcó sugerencia)
    mensajeIf = $"{x2} es mayor a {z2}";
}else if (x2 < z2){
    mensajeIf = $"{x2} es menor a {z2}";
}else{
    mensajeIf = $"{x2} es igual a {z2}";
}
Console.WriteLine(mensajeIf);
#endregion

#region switch

string ciudad = "CDMX";
string mensajeSwitch = "";

//switch(condicion o elemento)
switch(ciudad)
{
    case "Monterrey" : 
    case "CDMX":
        mensajeSwitch = "Eres de Mexico";
        break;
    case "Miami":
        mensajeSwitch = "Eres de EEUU.";
        break;
    default:
        mensajeSwitch = "Eres de otro pais.";
        break;
}
Console.WriteLine(mensajeSwitch);
#endregion

#region Metodos
//decimal CalcularIVA(decimal precio){...}
//valor de retorno:decimal, Nombre:CalcularIVA, Parametro:precio, {Bloque/cuerpo}

//OPC 1 para definir metodos
decimal CalcularIVA(decimal precio)
{
    decimal iva = precio * 0.16m; //se agrega la letra "m" despues del numero para representar decimal

    return iva;
}

decimal precio= 5000;
Console.WriteLine(CalcularIVA(precio));

//OPC 2 para metodos con una linea de codigo o que realizan operaciones pequeñas
decimal CalcularIVA_2(decimal precio)=> precio * 0.16m; 
Console.WriteLine((CalcularIVA_2(50)));
#endregion

#region Arreglos y bucles(for, while)
//Arreglo: variables que contiene multiples elementos del mismo tipo
//una vez que se define su tamaño, no se puede modificar

//definicion de elementos en la misma definicion del arreglo
int[] numeros = { 20, 34, 5 };

Console.WriteLine($"Primer numero: {numeros[0]}");
Console.WriteLine($"ultimo numero: {numeros[2]}");

//asignar valores haciendo referencia a la posicion
numeros[0]=50;
Console.WriteLine($"Primer numero: {numeros[0]}");

//declaramos un arreglo de numbers con 3 elementos
int[] numbers = new int [3];
//definicion de valores
numbers[0]=100;
numbers[1]=200;
numbers[2]=300;
Console.WriteLine($"Primer numero: {numbers[0]}");

//contador i que empieza en 0, condicion de paro (i para cuando es menor a 3), incrementador/decrementador del contador
//FOR PARA PEDIR LA INFORMACION DE UN ARREGLO
/*for (int i = 0 ; i < numbers.Length ; i++)
{
    Console.WriteLine($"Escribe el elmento en la posicion {i+1}: ");
    numbers[i] = int.Parse(Console.ReadLine()); //ReadLine devuelve cadena, usamos int.Parse para convertir la cadena que el usuario ingresa en un int
}
*/
Console.WriteLine("Elementos en el arreglo: ");

//FOR PARA MOSTRAR LA INFORMACION QUE EL USUARIO INGRESO
for (int i = 0 ; i < numbers.Length ; i++)
{
    Console.WriteLine($"Elemento en la posicion {i+1}: {numbers[i]}");
}

//OJO: El while tiene los mismos elementos que el for(contador,condicion,incrementador)
Console.WriteLine("ESTAMOS USANDO EL WHILE");
int j=0; //inicializacion del contador
/*while(j < numbers.Length) //while(condicion) //hasta que la condicion sea falsa nos salimos del cuerpo del while
{
    Console.WriteLine($"Elemento en la posicion {j+1}: {numbers[j]}");
    j++;//incrementador dentro del cuerpo del while
}*/

//While y Do-While son similares, pero la diferencia entre estos es:
//El contenido en el cuerpo del do se ejecuta al menos una vez aunque la condicion sea falsa, si es falso no entra al while
Console.WriteLine("ESTAMOS EN EL DO-WHILE");
do{
    Console.WriteLine($"Posicion {j+1}: {numbers[j]}");
    j++;
}while(j<numbers.Length);




#endregion

#region Lista y bucle (forEach)
//Lista: variable que contiene una coleccion de elementos del mismo tipo
//A diferencia del arreglo, su tamaño es dinamico

//inicializamos/definimos lista
List<string> nombres = new List<string>();

//Agregamos elementos con Add
nombres.Add("Julio Perez"); //0
nombres.Add("James Aranda"); //1
nombres.Add("Andres Aguirre"); //2
nombres.Add("Hector");

//Quitar elemtos de lista
nombres.Remove("Andres Aguirre"); 
//nombres.RemoveAt(1);//remover por indice

Console.WriteLine($"Primer nombre: {nombres[0]}");//mostramos elementos a traves del indice

Console.WriteLine("Nombres en la lista: ");
//foreach para iterar elementos en una lista
foreach(string nombre in nombres)
{
    if(Char.IsUpper(nombre,0)&& nombre.Contains(" "))//si el nombre contiene una mayuscula en la primera posicion de la letra del nombre y contiene un espacio lo imprime, sino no imprime el nombre
        Console.WriteLine(nombre);
}

/*OPERADORES LOGICOS
AND X && Z      Verdadero cuando ambos son verdaderos
OR X || Z V     Verdadero cuando por lo menos uno es verdadero
NOT !X          Modifica al valor opuesto
*/

#endregion

#region Directorios y archivos
string docsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
Console.WriteLine(docsPath);
string holaDir = Path.Combine(docsPath,"Hola");

if(!Directory.Exists(holaDir))
    Directory.CreateDirectory(holaDir);

string holaFile = Path.Combine(holaDir,"hola.txt");

if(!File.Exists(holaFile))
    File.WriteAllText(holaFile,"Hola mundo,");

string texto = File.ReadAllText(holaFile);

//Console.WriteLine(texto);
//File.AppendAllText(holaFile," Este es mi primer archivo desde C#. ");

texto = File.ReadAllText(holaFile);
Console.WriteLine(texto);
File.Delete(holaFile);

#endregion

#region Excepciones
//try: bloque a "probar"; se espera algun tipo de excepcion
//catch: bloque que se ejecuta para tratar con un tipo de excepcion
//finally:bloque que se ejecuta siempre, si ocurre una excepcion o no (se utiliza en casos muy expecificos)

/*ignorar
int IngresarNumero(){
    Console.WriteLine("Ingresa un numero");
    return int.Parse(Console.ReadLine());
}
int numero= IngresarNumero();
Console.WriteLine($"Numero ingresado: {numero}");
*/

int IngresarNumero()
{
    int numero=0;
    bool numeroValido = false;

    while(!numeroValido)
    {
        try
        {
            Console.WriteLine("Ingresa un numero");
            numero = int.Parse(Console.ReadLine());
            numeroValido = true;//para salir del while
        }
        catch(FormatException)
        {
            Console.WriteLine("El formato del valor ingresado es incorrecto. Vuelve a ingresarlo. ");
        }
        catch(OverflowException)
        {
            Console.WriteLine("El valor ingresado es demasiado grande o demasiado pequeño. Vuelve a ingresarlo ");
        }
       /* finally
        {
            Console.WriteLine("Se ingresó un valor. ");
        }*/
    }
    return numero;    
}

int numero= IngresarNumero();
Console.WriteLine($"Numero ingresado: {numero}");

//opc 2 para no ser explicitos en los tipos de excepciones
int IngresarNumeroV2()
{
    int numero = 0;
    bool numeroValido=false;

    while(!numeroValido)
    {
        Console.WriteLine("Ingresa un numero: ");
        if(int.TryParse(Console.ReadLine(), out numero))
            numeroValido=true;
        else
            Console.WriteLine("El valor ingresado es invalido. Vuelve a ingresarlo. ");
    } 
    return numero;
}

int numerov2= IngresarNumeroV2();
Console.WriteLine($"Numero ingresado: {numerov2} ({numerov2.ToWords()})");//toWords viene del paquete de Humanizer
#endregion

#region Referencias y dependencias
//using: palabra clave para referenciar la libreria de clases ->paquetes
//nuget: es el admin de paquetes de .net
//dotnet add package Humanizer.Core.es --version 2.14.1


#endregion
