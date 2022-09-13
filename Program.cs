// See https://aka.ms/new-console-template for more information
﻿using System;
using Classes;
namespace Calc{
  
  class Program {
    public static void Main (string[] args) {
    Calculadora calc = new Calculadora();
    CalcSE calculadora = new CalcSE();

      Console.WriteLine("A Subtração É: ");
      Console.WriteLine(calculadora.subtrair(5,5));
      Console.WriteLine("");
      Console.WriteLine("A Soma É: ");
      Console.WriteLine(calculadora.somar(5,5));
      Console.WriteLine("");
      Console.WriteLine("A Multiplicação É: ");
      Console.WriteLine(calculadora.multiplicar(5,5));
      Console.WriteLine("");
      Console.WriteLine("A Divisão É: ");
      Console.WriteLine(calculadora.divisao(5,5));
      Console.WriteLine("");
      Console.WriteLine("A Subtração É: ");
      Console.WriteLine(calc.subtrair(5,5));
      Console.WriteLine("");
      Console.WriteLine("A Soma É: ");
      Console.WriteLine(calc.somar(10,5));
      Console.WriteLine("");
      Console.WriteLine("A Multiplicação É: ");
      Console.WriteLine(calc.multiplicar(5,2));
      Console.WriteLine("");
      Console.WriteLine("A Divisão É: ");
      Console.WriteLine(calc.divisao(10,5));
    }
  }
}
/*1- Termine a implementação do projeto Calculadora. Implemente os métodos faltantes das operações aritméticas 
básicas: multiplicação, adição, subtração. Essas implementações devem ser feitas para a classe Calculadora e a classe CalSE. 
Teste as duas classes instânciando um objeto de cada classe e invocando os quatro métodos (operações).*/