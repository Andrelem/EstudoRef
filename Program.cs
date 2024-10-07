using System.ComponentModel;
using static System.Console;

class AulaRef
{
    static void Demoperso()
    {
        var nome = new string []{"Andre","Pedro","Joao","Felipe"};
        WriteLine($"A lista é {string.Join(", \n",nome)}");
    }
    static void Demo2()
    {
        var nomes = new string []{"Jose","Maria","Ricardo","Lucas"};
        
         WriteLine($@"A lista de nomes alterados é:
         {string.Join(", \n",nomes)}");
        
        WriteLine("Digite o nome a se mudado!:");
        var nome = ReadLine();
        WriteLine("Digite um nome novo!:");
        var nomeNovo = ReadLine();

        AlterarNome(nomes,nome,nomeNovo);

        WriteLine($@"A lista de nomes alterados é:
        {string.Join(", \n",nomes)}");
    }
    static void Demo1()
    {
         int a = 5;
        Adicionar20(ref a);
        WriteLine($"O valor sera {a}!");
    }
    static void Adicionar20(ref int a)
    {
        a += 20;
    }

    static void AlterarNome(string[] nomes,string nome, string nomeNovo)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            if(nomes[i] == nome)
            {
                nomes[i] = nomeNovo;
            }
        }
    }

    static ref string LocalizarNome(string[] nomes,string nome)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            if(nomes[i] == nome)
                return ref nomes[i];
        }
        throw new Exception("Nome não encontrado");
    }
    static void Main()
    {
    var nomes = new string []{"Jose","Maria","Ricardo","Lucas"};
        
        WriteLine($@"A lista de nomes alterados é:
            {string.Join(", \n",nomes)}
            ");
        
        WriteLine("Digite o nome a se mudado!:");
        var nome = ReadLine();
        WriteLine("Digite um nome novo!:");
        var nomeNovo = ReadLine();

        ref var NomeAchado = ref LocalizarNome(nomes, nome);

        if(!string.IsNullOrWhiteSpace(NomeAchado))
        {
            NomeAchado = nomeNovo;

            WriteLine($@"A lista de nomes alterados é:
            {string.Join(", \n",nomes)}
            ");
        }
        else
        {
            WriteLine("Nome não encontrado");
        }

    }
}