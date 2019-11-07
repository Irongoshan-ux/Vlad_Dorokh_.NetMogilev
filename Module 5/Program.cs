using System;

namespace Module_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] field = new int[12, 12];

            int playerPositionX = 1, playerPositionY = 1;
            int finishPositionX = 10, finishPositionY = 10;

            int damage = 0, lives = 10;

            bool isPlaying = true;

            Console.WriteLine("Управление в игре производится с помощью клавиш 2, 4, 6, 8 на Num-клавиатуре.");

            SetTrap(field);

            DrawField(field);

            field[playerPositionY, playerPositionX] = 1;
            field[finishPositionY, finishPositionX] = 2;

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (field[i, j] == -1)
                    {
                        Console.Write('#');
                    }
                    else if (field[i, j] == 0 || field[i, j] == 3)
                    {
                        Console.Write('*');
                    }
                    else if (field[i, j] == 1)
                    {
                        Console.Write('P');
                    }
                    else if (field[i, j] == 2)
                    {
                        Console.Write('F');
                    }
                }

                Console.WriteLine();
            }

            while (isPlaying)
            {
                Console.WriteLine("Получено урона: " + damage + " из 100");
                Console.WriteLine("Осталось жизней: " + lives);

                DrawField(field);

                if ((playerPositionX == finishPositionX) && (playerPositionY == finishPositionY))
                {
                    Console.WriteLine("Вы победили! / You WIN!");
                    isPlaying = false;
                }

                MovePlayer(field, ref playerPositionX, ref playerPositionY, out int oldPositionX, out int oldPositionY, ref damage, ref lives);

                Console.Clear();

                field[oldPositionY, oldPositionX] = 0;
                field[playerPositionY, playerPositionX] = 1;

                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        if (field[i, j] == -1)
                        {
                            Console.Write('#');
                        }
                        else if ((field[i, j] == 0) || (field[i, j] == 3))
                        {
                            Console.Write('*');
                        }
                        else if (field[i, j] == 1)
                        {
                            Console.Write('P');
                        }
                        else if (field[i, j] == 2)
                        {
                            Console.Write('F');
                        }
                    }

                    Console.WriteLine();
                }

                if ((damage >= 100) || (lives == 0))
                {
                    Console.WriteLine("Вы проиграли. / You LOSE.");

                    isPlaying = false;
                }

                if (isPlaying == false)
                {
                    Console.WriteLine("Хотите еще раз сыграть?\nДля этого введите \"y\", иначе - любой другой символ.");

                    if (Console.ReadLine() == "y")
                    {
                        isPlaying = true;

                        Start(field, ref playerPositionX, ref playerPositionY, ref finishPositionX, ref finishPositionY, ref damage, ref lives);
                    }
                    else
                    {
                        isPlaying = false;
                    }
                }
            }
        }

        static void Start(int[,] field, ref int playerPositionX, ref int playerPositionY, ref int finishPositionX, ref int finishPositionY, ref int damage, ref int lives)
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    field[i, j] = 0;
                }
            }

            playerPositionX = 1;
            playerPositionY = 1;

            finishPositionX = 10;
            finishPositionY = 10;

            damage = 0;
            lives = 10;

            SetTrap(field);

            DrawField(field);

            field[playerPositionY, playerPositionX] = 1;
            field[finishPositionY, finishPositionX] = 2;
        }

        static void DrawField(int[,] field)
        {
            for (int i = 0; i < 12; i++)
            {
                field[0, i] = -1;
                field[11, i] = -1;
                field[i, 0] = -1;
                field[i, 11] = -1;

                for (int j = 0; j < 12; j++)
                {
                    if ((i != 0) && (i != 11) && (j != 0) && (j != 11) && (field[i, j] != 3) && (field[i, j] != 1) && (field[i, j] != 2))
                    {
                        field[i, j] = 0;
                    }
                }
            }
        }

        static void SetTrap(int[,] field)
        {
            int trapCoordinateX;

            Random random = new Random();

            for (int trapCoordinateY = 1; trapCoordinateY < 11; trapCoordinateY++)
            {
                if (trapCoordinateY == 1)
                {
                    trapCoordinateX = random.Next(2, 10);
                }
                else if (trapCoordinateY == 11)
                {
                    trapCoordinateX = random.Next(1, 9);
                }
                else
                {
                    trapCoordinateX = random.Next(1, 10);
                }

                field[trapCoordinateY, trapCoordinateX] = 3;
            }
        }

        static void MovePlayer(int[,] field, ref int playerPositionX, ref int playerPositionY, out int oldPositionX, out int oldPositionY, ref int damage, ref int lives)
        {
            oldPositionX = playerPositionX;
            oldPositionY = playerPositionY;

            ConsoleKeyInfo button;
            button = Console.ReadKey();

            if (button.KeyChar == '4')
            {
                playerPositionX -= 1;
            }
            else if (button.KeyChar == '6')
            {
                playerPositionX += 1;
            }
            else if (button.KeyChar == '8')
            {
                playerPositionY -= 1;
            }
            else if (button.KeyChar == '2')
            {
                playerPositionY += 1;
            }

            if ((playerPositionX == 0) || (playerPositionX == 11))
            {
                playerPositionX = oldPositionX;
            }
            else if ((playerPositionY == 0) || (playerPositionY == 11))
            {
                playerPositionY = oldPositionY;
            }

            if (field[playerPositionY, playerPositionX] == 3)
            {
                damage += ReceiveDamage();
                lives--;
            }
            else field[playerPositionY, playerPositionX] = 1;
        }

        static int ReceiveDamage()
        {
            Random random = new Random();
            return random.Next(1, 10);
        }
    }
}