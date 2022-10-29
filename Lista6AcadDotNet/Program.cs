namespace Lista6AcadDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1
            /*
            List<string> listaNome = new List<string>();
            string nome;
            int sair = 2;

            string[] dadosNome;

            do
            {

                do
                {
                    Console.Write("Digite um nome completo válido: ");
                    nome = Console.ReadLine().ToUpper();
                    dadosNome = nome.Split(' ');
                } while (dadosNome.Length <= 1);
                if (listaNome.Contains(nome))
                {
                    Console.WriteLine("Nome já cadastrado.");
                }
                else
                {
                    listaNome.Add(nome);
                    listaNome.Sort();
                }

                Console.Write("Deseja sair? 1 - Sim, 2 - Não: ");
                sair = int.Parse(Console.ReadLine());
            } while (sair != 1);
            Console.WriteLine("\n--------Pessoas cadastradas--------\n");

            foreach (string item in listaNome)
            {
                Console.WriteLine(item);
            }
            */


            //Exercício 2
            /*
            List<int> numerosInteiros = new List<int>();
            Random random = new Random();
            int qntdNumero = 0, sair = 2;

            do
            {
                Console.Write("Digite a quantidade de números para sorteio: ");
                qntdNumero = int.Parse(Console.ReadLine());

                for (int i = 0; i < qntdNumero; i++)
                {
                    numerosInteiros.Add(random.Next(0, 1000));
                }

                foreach (int item in numerosInteiros)
                {
                    Console.WriteLine(item);
                }

                Console.Write("Deseja sair? 1 - Sim, 2 - Não: ");
                sair = int.Parse(Console.ReadLine());
            } while (sair != 1);
            */


            //Exercício 3
            /**/

        }
    }
}