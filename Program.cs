namespace ZadCompiatoriOL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("count=");
            int count = int.Parse(Console.ReadLine());
            List<Olimpiada> olimpiada = new List<Olimpiada>();
            for(int i = 0; i < count; i++)
            {
                var danni = Console.ReadLine().Split();
                Olimpiada olimp = new Olimpiada(danni[0], int.Parse(danni[1]));
                olimpiada.Add(olimp);
            }
            foreach(var iteam in olimpiada)
            {
                iteam.Print();
            }
            //podrexdane az sym ne]o sravnimo
            olimpiada.Sort();
            Console.WriteLine(string.Join(Environment.NewLine,olimpiada.Select(x=>x.NameOlimp)));
            //podrexdane az sravnqvane
            ICompratorTochki comparator = new ICompratorTochki();
            olimpiada.Sort(comparator);
            Console.WriteLine(string.Join(Environment.NewLine, olimpiada.Select(x => x.Tochki)));



        }
    }
}