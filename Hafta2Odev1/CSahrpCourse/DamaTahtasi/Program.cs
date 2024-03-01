// Dama tahtası boyutunu tanımla
const int BOARD_SIZE = 8;

// Renkleri tanımla
ConsoleColor WHITE = ConsoleColor.White;
ConsoleColor BLACK = ConsoleColor.Black;

// Tahtanın karelerini saklamak için dizi
ConsoleColor[,] board = new ConsoleColor[BOARD_SIZE, BOARD_SIZE];

// Taşların konumlarını ve renklerini saklamak için veri yapıları (örneğin, List)

// Tahtanın ilk halini oluştur
for (int i = 0; i < BOARD_SIZE; i++)
{
    for (int j = 0; j < BOARD_SIZE; j++)
    {
        board[i, j] = (i + j) % 2 == 0 ? WHITE : BLACK;
    }
}

// Tahtanın konsolda görüntüsünü oluştur
for (int i = 0; i < BOARD_SIZE; i++)
{
    for (int j = 0; j < BOARD_SIZE; j++)
    {
        Console.SetCursorPosition(j * 2, i);
        Console.BackgroundColor = board[i, j];
        Console.Write(" ");
    }
}



//MySolution();


static void MySolution()
{
    for (int i = 1; i <= 8; i++)
    {
        for (int j = 1; j <= 8; j++)
        {
            if (j % 2 == 0)
            {
                Console.Write("0");
            }
            else
            {
                Console.Write("1");
            }
        }
        Console.WriteLine();
    }
}