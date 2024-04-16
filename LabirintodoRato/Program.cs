
class LabirintodoRato
{
    private const int limit = 15;


    static void mostrarLabirinto(char[,] array, int l, int c)
    {
        for (int i = 0; i < l; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < c; j++)
            {
                Console.Write($" {array[i, j]} ");
            }
        }
        Console.WriteLine();
    }


    static void criaLabirinto(char[,] meuLab)
    {
        Random random = new Random();
        for (int i = 0; i < limit; i++)
        {
            for (int j = 0; j < limit; j++)
            {
                meuLab[i, j] = random.Next(4) == 1 ? '|' : '.';
            }
        }


        for (int i = 0; i < limit; i++)
        {
            meuLab[0, i] = '*';
            meuLab[limit - 1, i] = '*';
            meuLab[i, 0] = '*';
            meuLab[i, limit - 1] = '*';
        }


        int x = random.Next(limit);
        int y = random.Next(limit);
        meuLab[x, y] = 'Q';
    }




}