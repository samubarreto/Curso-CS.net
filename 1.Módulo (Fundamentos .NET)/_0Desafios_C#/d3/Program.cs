using System;

class DIO
{

  static void Main(string[] args)
  {

    double pi, raio, volume;
    pi = 3.14159;

    raio = double.Parse(Console.ReadLine());
    volume = (pi * 4 * (Math.Pow(raio, 3)) / 3.0);

    Console.WriteLine($"VOLUME = {volume.ToString("F3")}");
  }
}