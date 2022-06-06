using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cidades = new List<string>();

            cidades.Add("São Paulo");
            cidades.Add("Rio de Janeiro");
            cidades.Add("Salvador");
            cidades.Add("Natal"); 
            cidades.Add("Florianópolis");

            //Console.WriteLine(BuscarComForeach(cidades, "São Paulo"));
            //BuscarListaComLinq(cidades, "S").ForEach(x => Console.WriteLine(x));
            BuscarListaComLinqLambda(cidades, "S").ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }

        public static string BuscarComForeach(List<string> lista, string termo)
        {
            foreach (string item in lista)
            {
                if (item.Equals(termo))
                    return item;
            }
            return null;
        }

        public static List<string> BuscarListaComLinq(List<string> lista, string termo)
        {
            return (from item in lista where item.Contains(termo) select item).ToList();
        }

        public static List<string> BuscarListaComLinqLambda(List<string> lista, string termo)
        {
            return lista.Where(x => x.Contains(termo)).ToList();
        }
    }
}
