namespace Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
			#region CONSOLE
			Console.BackgroundColor = ConsoleColor.Magenta; //цвет фона
            Console.CursorLeft = 22;                        //Положение слево
            Console.CursorTop = 5;                          //Положение сверху
            Console.Write("Привет, Мир!\n");
            Console.Write("Привет, Мир!\n");

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;     //Цвет шрифта 
            Console.Write("Привет, Мир!\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Beep(1000, 700);                        // Сигнал БИП! (Частота + продолжительность)
			#endregion CONSOLE

		}
	}
}