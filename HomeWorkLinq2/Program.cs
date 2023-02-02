namespace HomeWorkLinq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arstocka arstocka = new();
            arstocka.ShowPrisoners();
            arstocka.Amnesty();
        }
    }

    class Arstocka
    {
        private List<Prisoner> _prisoners = new List<Prisoner>();

        public Arstocka()
        {
            _prisoners = new List<Prisoner>()
            {
                new Prisoner("Лаврентий", "Убийство"),
                new Prisoner("Исаак", "Антиправительственное"),
                new Prisoner("Айзек", "Антиправительственное"),
                new Prisoner("Георгий", "Мошенничество"),
                new Prisoner("Феликс", "Терроризм"),
            };
        }

        public void ShowPrisoners()
        {
            foreach (Prisoner prisoner in _prisoners)
            {
                Console.WriteLine($"{prisoner.Name}, статья: {prisoner.Article}");
            }
        }

        public void Amnesty()
        {
            var amnestied = _prisoners.Where(prisoner => prisoner.Article == "Антиправительственное");
            int index = 1;

            Console.WriteLine($"{new string('*', 25)}");

            foreach (Prisoner prisoner in amnestied)
            {
                Console.WriteLine($"{index}.{prisoner.Name}");
                index++;
            }
        }
    }

    class Prisoner
    {
        public Prisoner(string name, string article)
        {
            Name = name;
            Article = article;
        }

        public string Name { get; private set; }
        public string Article { get; private set; }
    }
}