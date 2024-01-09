using System;

class Pessoa
{
    private string nome;
    private int idade;

    public Pessoa(string _nome, int _idade)
    {
        nome = _nome;
        idade = _idade;
    }

    public string GetNome()
    {
        return nome;
    }

    public int GetIdade()
    {
        return idade;
    }
    
    public void SetNome(string _nome)
    {
      nome = _nome;
    }
    
    public void SetIdade(int _idade)
    {
      idade = _idade;
    }
}

class Program
{
    static void Main()
    {
       Pessoa p1 = new Pessoa("",0);
       p1.SetNome(Console.ReadLine());
       p1.SetIdade(int.Parse(Console.ReadLine()));
       Console.WriteLine("Nome: " + p1.GetNome() + ", Idade: " + p1.GetIdade());
    }
}
