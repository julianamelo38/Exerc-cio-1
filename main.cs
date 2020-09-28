using System;

class MainClass {
  public static void Main (string[] args) {
   double celsius, fahreinheit;
    Console.WriteLine("\n Exercício A");
    Console.WriteLine("Temperatura em graus Celsius, convertida em Fahreinheit");
    
   Console.WriteLine("Digite a temperatura em graus Celsius"); 
   celsius = double.Parse(Console.ReadLine());
   //F ← (C * 1.8 + 32)
   fahreinheit = (celsius * 1.8 + 32);
   Console.WriteLine("A temperatura convertida em Fahreinheit é:" + fahreinheit);

  }
}