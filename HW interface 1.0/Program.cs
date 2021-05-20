using System;

namespace HW_interface_1._0
{
    interface IMusInstr
    {
        const string key = "До мажор";
        public void Play() { }
        
    }
    class Guitar : IMusInstr
    {
        public int numberOfStrings;

        public int NumberOfStrings
        {
            get { return numberOfStrings; }
            set { numberOfStrings = value; }
        }
        public Guitar(int numberOfStrings)
        {
            NumberOfStrings = numberOfStrings;
        }

        public void Play()
        {
            Console.WriteLine($"Гитара играет {IMusInstr.key}, количество струн: {numberOfStrings}");
        }
    }
    class Drum : IMusInstr
    {
        
        private int size;

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public Drum(int size)
        {
            Size = size;
        }
        public void Play()
        {
            Console.WriteLine($"Барабан играет {IMusInstr.key}, размер: {size}");

        }
    }
class Pipe : IMusInstr
{
        private int diameter;

        public int Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }

        public Pipe(int diameter)
        {
            Diameter = diameter;
        }

        public void Play()
        {
            Console.WriteLine($"Труба играет {IMusInstr.key}, диаметр: {diameter}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IMusInstr[] musInstr = new IMusInstr[3];
            musInstr[0]=new Guitar(2);
            musInstr[1]= new Drum(3);
            musInstr[2]= new Pipe(4);
            foreach (IMusInstr item in musInstr)
            {
                item.Play();
            }

            Console.ReadKey();
        }
    }
}
