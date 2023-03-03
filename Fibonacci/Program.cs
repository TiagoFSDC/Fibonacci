internal class Program
{
    private static void Main(string[] args)
    {
        double ant, prox;
        int posicao;

        Console.WriteLine("Informe até qual posição da sequencia deseja ver: ");
        posicao = int.Parse(Console.ReadLine());

        ant = 1;
        prox = 0;
        if (posicao == 1)
        {
            Console.WriteLine(1);
        }
        else
        {
            for (; posicao > 0; posicao --)
            {
                Console.Write((ant + prox) + " ");
                prox = ant + prox;
                ant = prox - ant;
            }
        }
    }
}