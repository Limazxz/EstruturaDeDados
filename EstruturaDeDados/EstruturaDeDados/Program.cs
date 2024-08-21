internal class Program
{
    private static void Main(string[] args)
    {
        //trabalhando com lista (list)
        /* criando uma lista */
        List<string> frutas = new List<string>();

        /* adicionar itens na lista */
        frutas.Add("Morango");
        frutas.Add("Manga");
        frutas.Add("Goiaba");
        frutas.Add("Uva");

        /* imprmir os itens da lista */
        frutas.ForEach(Console.WriteLine);

        Console.WriteLine(); //pula linha em branco

        /* imprimir elemento da indice específica */
        Console.WriteLine("Fruta no indice 2: " + frutas[2]);

        /* iserir um elemento no indice específico */
        frutas.Insert(1, "Maracujá");

        /* imprimindo a lista novamente */
        Console.WriteLine();

        Console.WriteLine("Minha Lista de Frutas");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        /* alterar um elemento no indice específico */

        frutas[4] = "Pêra";
        /* imprimindo a lista novamente */
        Console.WriteLine();

        Console.WriteLine("Minha Lista de Frutas");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        /* remover elementos da lista */

        frutas.RemoveAt(3);
        /* remover elementos pelo valor do contúudo */
        frutas.Remove("Morango");
        /* imprimindo a lista novamente */
        Console.WriteLine();

        Console.WriteLine("Minha Lista de Frutas");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        /* apagar todos os elementos da lista */
        frutas.Clear();

        Dictionary<int, string> carros = new Dictionary<int, string>();
        /* adicionar dados a um dicionário */
        carros.Add(5, "Corsa");
        carros.Add(10, "Fusca");
        carros.Add(2, "Ford Ka");

        Console.WriteLine();
        Console.WriteLine("===========================");
        Console.WriteLine();

        Console.WriteLine("Meu Dicionário de Carros");
        /* imprimir um sicionário de dados */
        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Key} - {carro.Value}");
        }
    }
}