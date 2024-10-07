using static System.Console;

class AulaRef
{
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
    static void Main()
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
}