using System;
class Robo
{
    public int VelocidadeAtual { get; set; } = 0;
    public int VelocidadeMaxima { get; }
    public int VelocidadeMinima { get; }

    public Robo(int vmin, int vmax)
    {
        VelocidadeMinima = vmin;
        VelocidadeMaxima = vmax;
        VelocidadeAtual = vmin;
    }

    public void Acelerar()
    {
        if (VelocidadeAtual < VelocidadeMaxima)
        {
            VelocidadeAtual++;
        }
    }

    public void Desacelerar()
    {
        if (VelocidadeAtual > VelocidadeMinima)
        {
            VelocidadeAtual--;
        }
    }
}

class Program
{
    static void Main()
    {
        string[] velocidades = Console.ReadLine().Split(' ');
        
        int velMin = int.Parse(velocidades[0]);
        int velMax = int.Parse(velocidades[1]);

        Robo robo = new Robo(velMin, velMax);

        string comandos = Console.ReadLine();

        foreach (char valor in comandos)
        {
            if (valor == 'A')
            {
                robo.Acelerar();
            }
            else if (valor == 'D')
            {
                robo.Desacelerar();
            }
        }

        Console.WriteLine(robo.VelocidadeAtual);
    }
}