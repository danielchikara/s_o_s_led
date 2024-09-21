// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Escriba su nombre:");
  string nombre = Console.ReadLine();

  Console.WriteLine("Cual es su apellido? ");
  string apellido = Console.ReadLine();
  
  string nombre_Completo = nombre + " " + apellido;
  
  Console.WriteLine("cual es us edad:? ");
 
  int edad = Int32.Parse(Console.ReadLine());
  int año_nacimiento = 2024 - edad;
  
  Console.WriteLine(nombre_Completo);
  Console.WriteLine("Nacio en el : " + año_nacimiento);
  if (edad<18)
  {
    
     int fecha_ingreso = 18 -edad + 2024;
     Console.WriteLine("Eres menor de edad no podemos darte de alta fecha_ingreso" + fecha_ingreso);
}
 else if (edad < 25 ){
     
     Console.WriteLine("Tienes un 10% de descuento");
     
 }
else if ( edad ==18 |edad == 25 ){
Console.WriteLine("premio tienes un descuento especial del 20%");
}
else if (edad >25 & edad < 30){
     Console.WriteLine(" Lo sentimos pero no tienes descuento  ");
     
} 
else{
    Console.WriteLine(" ponte en contacto con nosotros ");
}
   }      
     
    
}
