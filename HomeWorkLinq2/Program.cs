namespace Linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arstocka arstocka = new();
            arstocka.ShowPrisoners();
            arstocka.Amnesty();
            arstocka.ShowPrisoners();
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
            int index = 1;
            string article = "Антиправительственное";

            var amnestied = _prisoners.Where(prisoner => prisoner.Article == article).ToList();

            Console.WriteLine($"{new string('*', 25)}");

            foreach (var amnesty in amnestied)
            {
                Console.WriteLine($"{index}.{amnesty.Name}");
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