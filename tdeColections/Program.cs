using System;
using System.Collections.Generic;

namespace tdeColecoes
{
    class Program
    {
        public static void menu()
        {
            int option;
            do
            {
                option = 1;
                try
                {
                    Console.WriteLine("**Escolha uma opção***");
                    Console.WriteLine("");
                    Console.WriteLine("1 LinkedList<T>");
                    Console.WriteLine("2 Stack<T>");
                    Console.WriteLine("3-Queue<T>");
                    Console.WriteLine("4-List<T>");
                    Console.WriteLine("5-Dictonary<TKey,TValue>");
                    Console.WriteLine("6-HashSet<T>");
                    Console.WriteLine("7-SortedList<T>");
                    Console.WriteLine("0 sair");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            listaDupla();
                            break;
                        case 2:
                            pilha();
                            break;
                        case 3:
                            queue();
                            break;
                        case 4:
                            List();
                            break;
                        case 5:
                            dictionary();
                            break;
                        case 6:
                            hashSet();
                            break;
                        case 7:
                            sortedList();
                            break;
                        case 0:
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Caractere inválido nesta etapa, digite apenas numeros, dâmica reiniciada!");
                }
            } while (option != 0);
        }
        public static void sortedList()
        {
            Console.Clear();
            SortedList<int, string> alunos = new SortedList<int, string>();
            Console.Clear();
            Console.WriteLine("Opção do tipo SortedList<TKey, TValue> ");
            Console.WriteLine("");

            alunos.Add(3, "Lucas");
            alunos.Add(5, "Aluno2");
            alunos.Add(4, "João");
            alunos.Add(2, "Ana");

            Console.Write("[");
            foreach (var number in alunos)
            {
                Console.Write(number + " ");
            }
            Console.Write("]");
            try
            {
                alunos.Add(1, "Joaquin");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("SortedList ordenada:");
            Console.Write("[");
            foreach (var number in alunos)
            {
                Console.Write(number + " ");
            }
            Console.Write("]");
            Console.WriteLine("");
            int options;
            do
            {
                options = 0;
                Console.WriteLine("");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1-Adcionar id(chave) e valor(nome) para lista de alunos");
                Console.WriteLine("2-Remover todas chaves e valores do SortedList");
                Console.WriteLine("3-Verificar se SortedList contem chave");
                Console.WriteLine("4-Verificar se SortedList contem valor");
                Console.WriteLine("5-Remover o valor com a chave");
                Console.WriteLine("0-Menu Principal");
                options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        Console.WriteLine("Entre com um id para o SortedList de alunos ");
                        int key = Convert.ToInt32(Console.ReadLine());
                        while (alunos.ContainsKey(key))
                        {
                            Console.WriteLine("Chave ja existente, digite outra chave:");
                            key = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Entre com um nome para o aluno");
                        string value = Console.ReadLine();
                        alunos.Add(key, value);
                        Console.Clear();
                        Console.Write("[ ");
                        foreach (var number in alunos)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 2:
                        alunos.Clear();
                        Console.Write("[ ");
                        foreach (var number in alunos)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 3:
                        Console.WriteLine("Entre com um id para ser buscado: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        if (alunos.ContainsKey(id))
                        {
                            Console.Clear();
                            Console.WriteLine("Id(chave) {0} existente ", id);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Chave não encontrada ");
                        }

                        Console.Write("[ ");
                        foreach (var number in alunos)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 4:
                        Console.WriteLine("Entre com um nome para ser buscado: ");
                        string name = Console.ReadLine();
                        if (alunos.ContainsValue(name))
                        {
                            Console.Clear();
                            Console.WriteLine("Nome(valor) {0} existente ", name);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Valor não encontrado ");
                        }

                        Console.Write("[ ");
                        foreach (var number in alunos)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 5:
                        Console.WriteLine("Entre com uma chave para remover valor");
                        int chave = Convert.ToInt32(Console.ReadLine());
                        while (!alunos.ContainsKey(chave))
                        {
                            Console.WriteLine("Chave não existe, tente outra");
                            chave = Convert.ToInt32(Console.ReadLine());
                        }
                        alunos.Remove(chave);
                        Console.Clear();
                        Console.Write("[ ");
                        foreach (var number in alunos)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 6:

                        Console.Write("[ ");
                        foreach (var number in alunos)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 7:
                        Console.Clear();
                        Console.Write("[ ");
                        foreach (var number in alunos)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 0:
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            } while (options != 0);
        }

        public static void hashSet()
        {
            Console.Clear();
            Console.WriteLine("Opção do tipo HashSet<T> ");

            HashSet<int> numbers = new HashSet<int>();
            HashSet<int> imparNumbers = new HashSet<int>();

            Console.WriteLine("Entre com o tamanho do HashSet<T>:");
            int list = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= list; i++)
            {
                numbers.Add(i * 2);
                imparNumbers.Add((i * 2) + 1);
            }
            Console.Clear();
            int options;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1-Ver HashSet com {0} elementos pares", list);
                Console.WriteLine("2-Ver HashSet com {0} elementos impares", list);
                Console.WriteLine("3-Popular Hashset com todos os numeros");
                Console.WriteLine("4-Remover todos");
                Console.WriteLine("0-Voltar ao menu Principal");
                options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Valores pares: ");
                        Console.Write("[");
                        foreach (var number in numbers)
                        {
                            Console.Write(number + " ");
                        }
                        Console.WriteLine("]");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Valores impares: ");
                        Console.Write("[");
                        foreach (var number in imparNumbers)
                        {
                            Console.Write(number + " ");
                        }
                        Console.WriteLine("]");
                        break;
                    case 3:
                        HashSet<int> newNumbers = new HashSet<int>(imparNumbers);
                        newNumbers.UnionWith(numbers);
                        Console.Clear();
                        Console.WriteLine("HashSet contêm {0} elementos", newNumbers.Count);
                        Console.Write("[");
                        foreach (var number in newNumbers)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        Console.WriteLine("");
                        break;
                    case 4:
                        numbers.Clear();
                        Console.Clear();
                        Console.WriteLine("HashSet vazia");
                        Console.Write("[");
                        foreach (var number in numbers)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 0:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Valor não permitido");
                        break;
                }
            } while (options != 0);
        }
        public static void dictionary()
        {
            Console.Clear();
            Console.WriteLine("Opção do tipo Dictionary<TKey,TValue>");
            Console.WriteLine("");
            Console.WriteLine("Dicionário de Alunos");
            Dictionary<int, string> dicionario = new Dictionary<int, string>();
            dicionario.Add(1, "Lucas");
            dicionario.Add(2, "Aluno2");
            dicionario.Add(3, "João");
            dicionario.Add(4, "Ana");

            Console.Write("[");
            foreach (var number in dicionario)
            {
                Console.Write(number + " ");
            }
            Console.Write("]");
            Console.WriteLine("");
            int options;
            do
            {
                options = 0;
                Console.WriteLine("");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1-Adcionar id(chave) e valor(nome) para lista de alunos");
                Console.WriteLine("2-Remover todas chaves e valores do dicionário");
                Console.WriteLine("3-Verificar se dicionário contem chave");
                Console.WriteLine("4-Verificar se dicionário contem valor");
                Console.WriteLine("5-Remover o valor com a chave");
                Console.WriteLine("0-Menu Principal");


                options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        Console.WriteLine("Entre com um id para o dicionario de alunos ");
                        int key = Convert.ToInt32(Console.ReadLine());
                        while (dicionario.ContainsKey(key))
                        {
                            Console.WriteLine("Chave ja existente, digite outra chave:");
                            key = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Entre com um nome para o aluno");
                        string value = Console.ReadLine();
                        dicionario.Add(key, value);
                        Console.Clear();
                        Console.Write("[ ");

                        foreach (var number in dicionario)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 2:
                        dicionario.Clear();
                        Console.Clear();
                        Console.Write("[ ");
                        foreach (var number in dicionario)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 3:
                        Console.WriteLine("Entre com um id para ser buscado: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        if (dicionario.ContainsKey(id))
                        {
                            Console.Clear();
                            Console.WriteLine("Id(chave) {0} existente ", id);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Chave não encontrada ");
                        }

                        Console.Write("[ ");
                        foreach (var number in dicionario)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 4:
                        Console.WriteLine("Entre com um nome para ser buscado: ");
                        string name = Console.ReadLine();
                        if (dicionario.ContainsValue(name))
                        {
                            Console.Clear();
                            Console.WriteLine("Nome(valor) {0} existente ", name);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Valor não encontrado ");
                        }

                        Console.Write("[ ");
                        foreach (var number in dicionario)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 5:
                        Console.WriteLine("Entre com uma chave para remover valor");
                        int chave = Convert.ToInt32(Console.ReadLine());
                        while (!dicionario.ContainsKey(chave))
                        {
                            Console.WriteLine("Chave não existe, tente outra");
                            chave = Convert.ToInt32(Console.ReadLine());
                        }
                        dicionario.Remove(chave);
                        Console.Clear();
                        Console.Write("[ ");
                        foreach (var number in dicionario)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 6:

                        Console.Write("[ ");
                        foreach (var number in dicionario)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 7:

                        Console.Clear();
                        Console.Write("[ ");
                        foreach (var number in dicionario)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 0:
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            } while (options != 0);
        }
        public static void listaDupla()
        {

            Console.Clear();
            Console.WriteLine("Opção do tipo LinkedList<T> ");

            LinkedList<int> numbers = new LinkedList<int>();

            Console.WriteLine("Entre com o tamanho da Lista dupla:");
            int list = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= list; i++)
            {
                Console.WriteLine("Entre com o " + (i) + "ª valor:");
                int value = Convert.ToInt32(Console.ReadLine());
                numbers.AddLast(value);
            }
            Console.Clear();
            Console.Write("[ ");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.Write("]");
            int options;
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1-Adicionar elemento no inicio da LinkedList");
                Console.WriteLine("2-Adcionar no fim da LinkedList");
                Console.WriteLine("3-Adicionar elemento antes do nó");
                Console.WriteLine("4-Adicionar elemento depois do nó");
                Console.WriteLine("5-Remover todos elementos");
                Console.WriteLine("6-Remover elemento pelo seu valor");
                Console.WriteLine("7-Remover primeiro elemento");
                Console.WriteLine("8-Remover ultimo elemento");
                Console.WriteLine("0-Voltar ao menu principal");

                options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        Console.WriteLine("Entre com o valor no início:");
                        int valueadd = Convert.ToInt32(Console.ReadLine());
                        numbers.AddFirst(valueadd);
                        Console.Clear();
                        Console.Write("[ ");
                        foreach (var number in numbers)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 2:
                        Console.WriteLine("Entre com um valor no fim :");
                        int valueadd1 = Convert.ToInt32(Console.ReadLine());
                        numbers.AddLast(valueadd1);
                        Console.Clear();
                        Console.Write("[ ");

                        foreach (var number in numbers)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 3:
                        Console.WriteLine("Entre com um valor da LinkedList para ser o nó");
                        int valNo = Convert.ToInt32(Console.ReadLine());
                        LinkedListNode<int> node = numbers.Find(valNo);
                        while (!numbers.Contains(valNo))
                        {
                            Console.WriteLine("Valor não encontrado na LinkedList, entre com um valor existente");
                            valNo = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Entre com o valor que deseja adicionar");
                        int numBefore = Convert.ToInt32(Console.ReadLine());
                        numbers.AddBefore(node, numBefore);
                        Console.Clear();
                        Console.Write("[ ");
                        foreach (var number in numbers)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 4:
                        Console.WriteLine("Entre com um valor da LinkedList para ser o nó");
                        int valNo1 = Convert.ToInt32(Console.ReadLine());
                        numbers.Find(valNo1);
                        while (!numbers.Contains(valNo1))
                        {
                            Console.WriteLine("Valor não encontrado na LinkedList, entre com um valor existente na lista:");
                            valNo1 = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Entre com o valor que deseja adicionar");
                        int numAfter = Convert.ToInt32(Console.ReadLine());
                        LinkedListNode<int> node1 = numbers.Find(valNo1);
                        numbers.AddAfter(node1, numAfter);
                        Console.Clear();
                        Console.Write("[ ");
                        foreach (var number in numbers)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 5:
                        numbers.Clear();
                        Console.Clear();
                        Console.Write("[ ");
                        foreach (var number in numbers)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 6:
                        Console.WriteLine("Digite o valor que deseja remover");
                        int value2 = Convert.ToInt32(Console.ReadLine());
                        while (!numbers.Contains(value2))
                        {
                            Console.WriteLine("Numero não existe na lista, tente outro valor:");
                            value2 = Convert.ToInt32(Console.ReadLine());
                        }
                        numbers.Remove(value2);
                        Console.Clear();
                        Console.Write("[ ");
                        foreach (var number in numbers)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 7:
                        numbers.RemoveFirst();
                        Console.Clear();
                        Console.Write("[ ");
                        foreach (var number in numbers)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 8:
                        numbers.RemoveLast();
                        Console.Clear();
                        Console.Write("[ ");
                        foreach (var number in numbers)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 0:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção inválida:");
                        break;
                }

            } while (options != 0);

        }
        public static void queue()
        {
            Console.Clear();
            Console.WriteLine("Opção do tipo Queue<T> (fila)");
            Queue<int> numbers = new Queue<int>();
            Console.WriteLine("Entre com um tamanho para a fila");
            int filaIn = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= filaIn; i++)
            {
                Console.WriteLine("Entre com o " + (i) + "ª valor:");
                int value = Convert.ToInt32(Console.ReadLine());
                numbers.Enqueue(value);
            }
            Console.Clear();
            Console.Write("[");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.Write("]");
            int options;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1-Adicionar elemento na fila");
                Console.WriteLine("2-Remover elemento da fila");
                Console.WriteLine("3-Ver o Proximo elemento a ser removido");
                Console.WriteLine("4-Remover todos");
                Console.WriteLine("5-Ver a quantidade de elementos");
                Console.WriteLine("6-Buscar elemento na fila");
                Console.WriteLine("0-Voltar ao menu Principal");
                options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        Console.WriteLine("Entre com o valor:");
                        int valueadd = Convert.ToInt32(Console.ReadLine());
                        numbers.Enqueue(valueadd);
                        Console.Clear();
                        Console.Write("[");
                        foreach (var number in numbers)
                        {
                            Console.Write(number + " ");
                        }
                        Console.WriteLine("]");
                        break;
                    case 2:
                        numbers.Dequeue();
                        Console.Clear();
                        Console.WriteLine("Fila após remover");
                        Console.Write("[");
                        foreach (var number in numbers)
                        {
                            Console.Write(number + " ");
                        }
                        Console.WriteLine("]");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("O proximo elemento a ser removido da fila é {0}", numbers.Peek());
                        Console.Write("[");
                        foreach (var number in numbers)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 4:
                        numbers.Clear();
                        Console.Clear();
                        Console.WriteLine("Fila vazia");
                        Console.Write("[");
                        foreach (var number in numbers)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("A fila contem {0} elementos", numbers.Count);
                        Console.Write("[");
                        foreach (var number in numbers)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 6:
                        Console.WriteLine("Entre com o valor para ser buscado na fila");
                        int valueF = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (numbers.Contains(valueF))
                        {
                            Console.WriteLine("Valor " + valueF + " encontrado no fila ");
                        }
                        else
                        {
                            Console.WriteLine("Elemento não encontrado");
                        }
                        Console.Write("[");
                        foreach (var number in numbers)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 0:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;

                }
            } while (options != 0);
        }
        public static void pilha()
        {
            Console.Clear();
            Console.WriteLine("Opção do tipo Stack<T> (pilha)");
            Stack<int> numbers = new Stack<int>();
            Console.WriteLine("Entre com um tamanho para a pilha");
            int pilhaIn = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= pilhaIn; i++)
            {
                Console.WriteLine("Entre com o " + (i) + "ª valor:");
                int value = Convert.ToInt32(Console.ReadLine());
                numbers.Push(value);
            }
            Console.Clear();
            Console.WriteLine("==========");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("==========");
            int options;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1-Adcionar elemento na pilha");
                Console.WriteLine("2-Remover elemento da pilha");
                Console.WriteLine("3-Veja o proximo elemento da pilha");
                Console.WriteLine("4-Remover todos");
                Console.WriteLine("5-Ver a quantidade de elementos");
                Console.WriteLine("0-Voltar ao menu Principal");
                options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        Console.WriteLine("Entre com o valor:");
                        int valueadd = Convert.ToInt32(Console.ReadLine());
                        numbers.Push(valueadd);
                        Console.Clear();
                        Console.WriteLine("====");
                        foreach (var number in numbers)
                        {
                            Console.WriteLine(number);
                        }
                        Console.WriteLine("====");
                        break;
                    case 2:
                        numbers.Pop();
                        Console.Clear();
                        Console.WriteLine("Pilha após remover");
                        Console.WriteLine("=========");
                        foreach (var number in numbers)
                        {
                            Console.WriteLine(number);
                        }
                        Console.WriteLine("======== ");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("O proximo elemento é {0}", numbers.Peek());
                        Console.WriteLine("=========");
                        foreach (var number in numbers)
                        {
                            Console.WriteLine(number);
                        }
                        Console.WriteLine("======== ");
                        break;
                    case 4:
                        numbers.Clear();
                        Console.Clear();
                        Console.WriteLine("Pilha Limpa");
                        foreach (var number in numbers)
                        {
                            Console.WriteLine(number);
                        }
                        Console.WriteLine("=============");
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("A pilha contem {0} elementos", numbers.Count);
                        Console.WriteLine("=========");
                        foreach (var number in numbers)
                        {
                            Console.WriteLine(number);
                        }
                        Console.WriteLine("======== ");
                        break;
                    case 0:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
            } while (options != 0);
        }
        public static void List()
        {
            Console.Clear();
            Console.WriteLine("Opção List<T>");
            List<int> numbers = new List<int>();

            Console.WriteLine("Entre com o tamanho da Lista:");
            int list = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= list; i++)
            {
                Console.WriteLine("Entre com o " + (i) + "ª valor:");
                int value = Convert.ToInt32(Console.ReadLine());
                numbers.Add(value);
            }
            Console.Clear();
            Console.Write("[ ");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.Write("]");
            int options;
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1-Adicionar elemento no fim da lista");
                Console.WriteLine("2-Inserir elemento pelo indice");
                Console.WriteLine("3-Ordenar e buscar indice do elemento");
                Console.WriteLine("4-Remover todos elementos");
                Console.WriteLine("5-Para remover um elemento");
                Console.WriteLine("6-Para remover elemento pelo indice");
                Console.WriteLine("7-Ordenar em ordem reversa");
                Console.WriteLine("0-Voltar ao menu principal");

                options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        Console.WriteLine("Entre com o valor:");
                        int valueadd = Convert.ToInt32(Console.ReadLine());
                        numbers.Add(valueadd);
                        Console.Clear();
                        Console.Write("[ ");
                        foreach (var number in numbers)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 2:
                        Console.WriteLine("Entre com a posição que deseja inserir:");
                        int position = Convert.ToInt32(Console.ReadLine());
                        while (!numbers.Contains(position))
                        {
                            Console.WriteLine("Posição não existe na lista, entre com posição existente");
                            position = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Entre com um valor para adicionar:");
                        int valueadd1 = Convert.ToInt32(Console.ReadLine());
                        numbers.Insert(position, valueadd1);
                        Console.Clear();
                        Console.Write("[ ");
                        foreach (var number in numbers)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 3:
                        Console.WriteLine("Entre com um elemento para ser buscado");
                        int elem = Convert.ToInt32(Console.ReadLine());
                        numbers.Sort();
                        int result = numbers.BinarySearch(elem);
                        Console.Clear();
                        if (result < 0)
                        {
                            Console.WriteLine("Elemento não encontrado");
                        }
                        else
                        {
                            Console.WriteLine("Elemento " + elem + " encontrado no indice " + numbers.IndexOf(elem) + " da lista");
                            Console.Clear();
                            Console.Write("[ ");
                            foreach (var number in numbers)
                            {
                                Console.Write(number + " ");
                            }
                            Console.Write("]");
                        }
                        break;
                    case 4:
                        numbers.Clear();
                        Console.Clear();
                        Console.Write("[ ");
                        foreach (var number in numbers)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 5:
                        Console.WriteLine("Digite o valor que deseja remover");
                        int value2 = Convert.ToInt32(Console.ReadLine());
                        while (!numbers.Contains(value2))
                        {
                            Console.WriteLine("Numero não existe na lista, digite valor existente");
                            value2 = Convert.ToInt32(Console.ReadLine());
                        }
                        numbers.Remove(value2);
                        Console.Clear();
                        Console.Write("[ ");
                        foreach (var number in numbers)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 6:
                        Console.WriteLine("Digite o indice que deseja remover");
                        int value3 = Convert.ToInt32(Console.ReadLine());
                        while (!numbers.Contains(value3))
                        {
                            Console.WriteLine("Indice não encontrado na lista, digite valor existente:");
                            value3 = Convert.ToInt32(Console.ReadLine());
                        }
                        numbers.RemoveAt(value3);
                        Console.Clear();
                        Console.Write("[ ");
                        foreach (var number in numbers)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 7:
                        numbers.Reverse();
                        Console.Clear();
                        Console.WriteLine("Lista reversa");
                        Console.Write("[ ");
                        foreach (var number in numbers)
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("]");
                        break;
                    case 0:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção inválida:");
                        break;
                }
            } while (options != 0);
        }

        public static void Main(string[] args)
        {
            menu();

        }

    }
}
