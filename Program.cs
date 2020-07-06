using System;

namespace primeiropoo
{
    class Program
    {
        static void Main(string[] args)
        {

        Personagem Iron_Man = new Personagem();
        Iron_Man.nome = "Iron Man";
        Iron_Man.armadura = "Mark 1";
        Iron_Man.idade = 40; 

        Console.WriteLine(Iron_Man.nome);
        Console.WriteLine(Iron_Man.idade);

        Console.WriteLine(Iron_Man.armadura);

        Console.WriteLine(Iron_Man.Defender() );

        Console.WriteLine(Iron_Man.Atacar(50.9f, 50));
        }
    }
}