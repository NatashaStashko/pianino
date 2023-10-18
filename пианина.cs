  internal class program
    {
        static void Main(string[] args)
        {
            Octavii();
        }
        static void Octavii()
        {
            Console.WriteLine("\nВыберите октаву. зависит от клавиш F1,F2,F3,F4,F5,F6,F7");
            int[] fir = new int[] { 67, 71, 73, 77, 84, 87, 98, 98, 113, 115, 116, 133 };
            int[] sec = new int[] { 120, 128, 135, 145, 154, 167, 173, 186, 197, 210, 226, 236 };
            int[] thi = new int[] { 241, 257, 263, 281, 329, 349, 370, 392, 415, 440, 466, 493 };
            int[] fou = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
            int[] fiv = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            int[] six = new int[] { 2094, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3952 };
            int[] sev = new int[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };

            ConsoleKeyInfo Clavisha = Console.ReadKey();
            if (Clavisha.Key == ConsoleKey.F1)
            {
                outi(fir);
            }
            if (Clavisha.Key == ConsoleKey.F2)
            {
                outi(sec);
            }
            if (Clavisha.Key == ConsoleKey.F3)
            {
                outi(thi);
            }
            if (Clavisha.Key == ConsoleKey.F4)
            {
                outi(fou);
            }
            if (Clavisha.Key == ConsoleKey.F5)
            {
                outi(fiv);
            }
            if (Clavisha.Key == ConsoleKey.F6) //stashko
            {
                outi(six);
            }
            if (Clavisha.Key == ConsoleKey.F7)
            {
                outi(sev);
            }
        }
        static void outi(int[] sound)
        {
            Console.WriteLine("Для возвращения к выбору октав нажмите backspace. \n белые клавиши: ASDFGH \n черные клавиши:QWERT");
            for (ConsoleKeyInfo zvuk = Console.ReadKey(); zvuk.Key != ConsoleKey.Backspace;)
            {
                if (zvuk.Key == ConsoleKey.A)/* C White* 1*/
                {
                    Console.Beep(sound[0], 200);

                }
                if (zvuk.Key == ConsoleKey.Q)/* C# black1*/
                {
                    Console.Beep(sound[1], 200);

                }
                if (zvuk.Key == ConsoleKey.S) /* D White2*/
                {
                    Console.Beep(sound[2], 200);

                }
                if (zvuk.Key == ConsoleKey.W)/*eb black2*/
                {
                    Console.Beep(sound[3], 200);

                }
                if (zvuk.Key == ConsoleKey.D)/*E white3*/ //stashko
                {
                    Console.Beep(sound[4], 200);

                }
                if (zvuk.Key == ConsoleKey.F)/*F white4*/
                {
                    Console.Beep(sound[5], 200);

                }
                if (zvuk.Key == ConsoleKey.E)/*F# black3*/
                {
                    Console.Beep(sound[6], 200);

                }
                if (zvuk.Key == ConsoleKey.G)/*G white5*/
                {
                    {
                        Console.Beep(sound[8], 200);

                    }
                    if (zvuk.Key == ConsoleKey.H)/*A White6*/
                    {
                        Console.Beep(sound[9], 200);

                    }
                    if (zvuk.Key == ConsoleKey.T)/*Bb black5*/
                    {
                        Console.Beep(sound[10], 200);

                    }
                    if (zvuk.Key == ConsoleKey.T)/*B White7*/
                    {
                        Console.Beep(sound[11], 200);

                    }
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Для возвращения к выбору октав нажмите backspace.");
                    Console.SetCursorPosition(100, 20);
                    zvuk = Console.ReadKey();
                    Console.Clear();
                }
                Octavii();
            }

        }
    }