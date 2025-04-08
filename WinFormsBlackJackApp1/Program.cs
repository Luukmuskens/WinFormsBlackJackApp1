namespace WinFormsBlackJackApp1
{
    internal class Card
    {
        public string Rank { get; }
        public string Suit { get; }
        public int Value { get; private set; }
        public bool IsHidden { get; private set; }

        public Card(string rank, string suit)

        {
            Rank = rank;
            Suit = suit;
            Value = rank switch;
            IsHidden = false;


            "2" => 2,
                "3" => 3,
                "4" => 4,
                "5" => 5,
                "6" => 6,
                "7" => 7,
                "8" => 8,
                "9" => 9,
               "10" or "jack" or "queen" or "king" => 10,
                "ace" => 11,
                _ => 0


        };


        public void ToggleHidden() => IsHidden = !IsHidden;

        public void SetAceValueToOne()
        {
            if (Rank == "ace") Value = 1;
        }


    }
}


internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
       
            static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            string hello = Console.ReadLine();
            Console.WriteLine(hello);
        }
}
