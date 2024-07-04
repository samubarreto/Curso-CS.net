using Calculadora.services;

CalculadoraImp c = new CalculadoraImp();

int num1 = 5;
int num2 = 10;

System.Console.WriteLine($"{num1} + {num2} = {c.Somar(num1, num2)}");