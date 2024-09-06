using System;
using System.Linq;

namespace productSearch
{
    struct NoteBook
    {
        public string models { get; set; }
        public string manufactor { get; set; }
        public decimal price { get; set; }

        public NoteBook(string model, string manufactor, decimal price)
        {
            this.models = model;
            this.manufactor = manufactor;
            this.price = price;
        }
        public override string ToString()
        {
            return $"Model: {models}, Manufactor: {manufactor}, price: {price}";
        }
    }
    class Program
    {
        static void Main()
        {
            const int models = 4;

            NoteBook[] notebook = new NoteBook[models];

            for (int i = 0; i < models; i++)
            {
                Console.WriteLine($"Enter details for model {i + 1}: ");
                Console.Write("Model: ");
                string model = Console.ReadLine();
                Console.Write("Manufactor: ");
                string manufactor = Console.ReadLine();
                Console.Write("Price: ");
                decimal price = Convert.ToDecimal(Console.ReadLine());

                notebook[i] = new NoteBook(model, manufactor, price);
            }
            Array.Sort(notebook, (notebook1, notebook2) => notebook1.models.CompareTo(notebook2.models));
            while (true)
            {
                Console.WriteLine("Enter model to search: ");
                string searchNumber = Console.ReadLine();

                var foundModel = notebook.FirstOrDefault(m => m.models == searchNumber);

                if (foundModel.models != null)
                {
                    Console.WriteLine(foundModel);
                }
                else
                {
                    Console.WriteLine("Model not found");
                }
            }
        }
    }

}
