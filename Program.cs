//Ejercicio 1
string myName = "Jorge";
string myLastName = "Torres";
int myAge = 35;
bool knowDevelop = false;
string message = $"Mi nombre: {myName}, mi apellido: {myLastName}, mi edad: {myAge}, sabe programar {knowDevelop}";
Console.WriteLine(message);

//Ejercicio 2
//Coche:
int doors = 4;
int wheels = 4;
string model = "Subaru";
bool isItvVigente =  true;
Console.WriteLine($"Coche puertas: {doors}, ruedas: {wheels}, marca: {model}, ITV vigente: {isItvVigente}");
//mesa:
float weight = 10f;
float length = 5f;
string material = "wood";
string color = "white";
Console.WriteLine($"Mesa peso: {weight}, longitud: { length}, material: {material}, color: {color}");

//Ejercicio 3

int num1 = 5;
int num2 = 6;
char char1 = 'b';
Console.WriteLine("Un número es mayor o igual a 18 " + (num1 >= num2));
Console.WriteLine("Un char es ‘a’ " +  (char1 == 'a'));
Console.WriteLine("Se cumplen dos conciones a la vez (ambas verdaderas) " + (num1 != num2 && num1 < num2));
Console.WriteLine("Se cumple una de dos condiciones a la vez (una true y otra false) " + (num1 == num2 || num1 < num2));

