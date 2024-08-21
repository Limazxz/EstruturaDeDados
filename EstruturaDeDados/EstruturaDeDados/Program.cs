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
        Console.WriteLine("===========================");
        Console.WriteLine();

        /* imprimir elemento da indice específica */
        Console.WriteLine("Fruta no indice 2: " + frutas[2]);

        Console.WriteLine(); //pula linha em branco
        Console.WriteLine("===========================");
        Console.WriteLine();

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
        Console.WriteLine(); //pula linha em branco
        Console.WriteLine("===========================");
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
        Console.WriteLine(); //pula linha em branco
        Console.WriteLine("===========================");
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
        Console.WriteLine();
        Console.WriteLine("===========================");
        Console.WriteLine();

        // trabalhando com fila //
        /* criar uma fila (Queue) */
        Queue<string> filaBanco = new Queue<string>();

        /* adicionar elementos em uma fila */
        filaBanco.Enqueue("André");
        filaBanco.Enqueue("João");
        filaBanco.Enqueue("Maria");
        filaBanco.Enqueue("José");

        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        /* retirar o primeiro elemento de uma fila */
        filaBanco.Dequeue();

        Console.WriteLine(); //pula linha em branco
        Console.WriteLine("===========================");
        Console.WriteLine();
        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        /* verificar se existe um elemento na fila */

        bool encontrou = filaBanco.Contains("José");

        if (encontrou == true)
        {
            Console.WriteLine("A pessoa está na fila");
        }
        else
        {
            Console.WriteLine("A pessoa NÃO está na fila");
        }
        Console.WriteLine(); //pula linha em branco
        Console.WriteLine("===========================");
        Console.WriteLine();
        // trabalhando com pilha (stack)
        /* criando uma pilha */
        Stack<string> livros = new Stack<string>();

        /* adicionar elementos em uma pilha */
        livros.Push("Chapeuzinho Vermelho");
        livros.Push("BRanca de Neve e os Sete Anões");
        livros.Push("Princesa e o Sapo");

        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }
        Console.WriteLine(); //pula linha em branco
        Console.WriteLine("===========================");
        Console.WriteLine();

    }
}