// capturar por consola los datos de un empleado para ccalcular el salario neto a pagar
// nombre,Mes a pagar, salario base, descuento seguro, descuento prestamos, bonificaciones
// salario neto a pagar  = salario nase + bonificaciones - descuento seguro - descuento prestamo
// mostrar mensaje: señor su salario es para el mes tal es: salario neto


// Console.WriteLine("Ingrese su nombre:");
// string nombre = Console.ReadLine();

// Console.WriteLine("Ingrese mes a pagar:");
// string mes = Console.ReadLine();

// Console.WriteLine("Ingrese salario base:");
// int salarioBase = int.Parse(Console.ReadLine());

// Console.WriteLine("ingrese descuento seguro:");
// int descuentoSeguro = int.Parse(Console.ReadLine());

// Console.WriteLine("ingrese descuento prestamos:");
// int descuentoPrestamos = int.Parse(Console.ReadLine());

// Console.WriteLine("ingrese bonificaciones:");
// int bonificaciones = int.Parse(Console.ReadLine());

// int salarioNeto = salarioBase + bonificaciones - descuentoSeguro - descuentoPrestamos;

// Console.WriteLine($"señor {nombre}, su salario para el mes de {mes} es {salarioNeto}");

// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Alumno 
// {
//     public string Nombre{get; set;}

//     public int Nota{get; set;}
// }


// public class Program 
// {
//     public static void Main()
//     {

// var alumnos = new List<Alumno>
// {
//     new Alumno {Nombre = "Deivy", Nota = 5},
//     new Alumno {Nombre = "juan", Nota = 3},
//     new Alumno {Nombre = "juana", Nota = 2}
// };


//     // foreach(var alumno in alumnos)
//     // {
//     //     Console.WriteLine(alumno.Nombre);
//     // }


//   var alumnosConNotasAltas = alumnos.Where(x => x.Nota >= 3)
//                                    .Select(x => $"{x.Nombre} ({x.Nota})")
//                                    .ToList();

// Console.WriteLine(string.Join(", ", alumnosConNotasAltas));

//     }
// }



// int[] numeros = [1,2,3,4,5,6,7];

// int mayor = numeros[0];

// for(int i = 0; i < numeros.Length;i++){
//     if(numeros[i] > mayor) {
//         mayor = numeros[i];
//     }
// }

// Console.WriteLine(mayor);


// List<int> sample = [10,2,44,80,200,100];
// var numerosMayores50 = from numero in sample where numero > 50 select numero;
// foreach(int item in numerosMayores50)
// {
//     Console.WriteLine(item);
// }




// List<int> numbersArray =[1,2,3,4,5,6,7,8,9,10];

// var numerosPares = numbersArray.Where(x => x % 2 == 0);

// foreach(int item in numerosPares) {
//     Console.WriteLine(item);
// }



 using HelperLib;
 using System.Text.Json;

 Person person1 = new Person();

person1.Name = "deivy";
 person1.Age = 17;
 person1.City = "Medellin";
 person1.IntroduceOneSelf();



// using HelperLib;

// Vehicle vehicle1 = new Vehicle();

// vehicle1.Marca = "Ferrari";
// vehicle1.Modelo = "2017";
// vehicle1.Valor = 1000;
// vehicle1.Datos();


// // Contructor

// PersonWithContructor person1 = new("deivy", 17);
// person1.IntroduceOneSelf();


// using HelperLib;

// PersonWithProperties person = new PersonWithProperties();
//         person.Name = "deivy";
//         person.Age = 17;
//         person.IntroduceOneSelf();



//herencia

Dog firulais =new();
firulais.Bark();
firulais.Eat();



// polimorfismo


AnimalWithPolymorphin[] animals =  new AnimalWithPolymorphin[2];

animals[0] = new DogWithPolymorphism();
animals[1] = new CatWithPolymorphism();

foreach(AnimalWithPolymorphin animal in animals) {
    animal.Sound();
}


string json = JsonSerializer.Serialize(person1);
Console.WriteLine(json);


//deserializar

string jsonString = @"{
    ""Name"": ""Deivy"",
    ""Age"": ""Deivy"",
    ""City"": ""City"",
}";

var personFromJSON = JsonSerializer.Deserialize<Person>(jsonString);
Console.WriteLine($"{personFromJSON?.Name}");


//l leer un archivo.json  que contenga la representacion de objetos SaleOrder. (crear clase orden de venta)
// crear minimo 5 obejtos de esta clase
// lista de esas clases 

// propiedades: orderId(int), OrderDate(datetime), orderAmount(float), Customername(string), customerAdrees(string), customerEmail(string), Taxes(IVA 19%)(float), discounts(float)
// delivaryDate(date time), createBy(string)


// 1 - crear una consoleApp que lea una ruta del PC , el archivo  .json
// 2 -  crear metodo  para Aplicar el calculo del total a pagar  por orden para cada cliente
// 3- crear un metodo  que permita obtener, las ordenes con delivarydate de los ultimos dias
// 4 - el archivo json, debe tener minimo 10 items(objeto saleOrder)


//vamos a deserializar 

// aplicar encapsulamiento
