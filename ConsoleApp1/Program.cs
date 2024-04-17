using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntArrayList list = new IntArrayList();
            list.Add(1);
            list.Add(12);
            list.Add(23);
            list.Add(34);
            list.Add(45);
            list.Add(66);
            list.Add(23);

            list.GetElements();
            //list.IndexOf(23);
            list.LastIndexOf(23);
            Console.WriteLine(" ");
            list.RemoveAt(0);
            list.GetElements();

            Console.WriteLine(list.ToString());

        }
    }
    class IntArrayList
    {
        public int[] _arr;
        public int Capacity { get; set; } = 5;
        public int Count { get; private set; }
        public IntArrayList()
        {
            _arr = new int[Capacity];
        }
        public IntArrayList(int capacity)
        {
            Capacity = capacity;
            _arr = new int[Capacity];
        }
        public void Add(int value)
        {
            if (_arr.Length == Count)
            {
                Array.Resize(ref _arr, Count + Capacity);
            }
            _arr[Count] = value;
            Count++;
        }
        public void GetElements()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException("invalid index");

                }
                return _arr[index];
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }
                _arr[index] = value;
            }
        }
        public void IndexOf(int number)
        {
            bool index = false;
            for (int i = 0; i < Count; i++)
            {
                if (number == _arr[i])
                {
                    index = true;
                    Console.WriteLine("daxil etiyiniz reqem " + i  +"  indeksde yerlesir");
                    break;
                }
            }
            if (!index)
            {
                Console.WriteLine("daxil etiyiniz reqem yoxdur");
            }

        }
        public void LastIndexOf(int number)
        {
            bool index = false;
            for (int i = Count; i > 0; i--)
            {
                if (number == _arr[i])
                {
                    index = true;
                    Console.WriteLine("daxil etiyiniz reqem " + i + "  indeksde yerlesir");
                    break;
                }
            }
            if (!index)
            {
                Console.WriteLine("daxil etiyiniz reqem yoxdur");
            }

        }
        public void RemoveAt(int index)
        {
            for (int i = 0; i < Count; i++)
            {
                if (index == i)
                {
                    _arr[i] = 0;
                    Console.WriteLine(_arr[i] + " siyahidan silindi");

                }
            }
        }
     

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

           

            for (int i = 0; i < Count; i++)
            {
                sb.Append($"{_arr[i]} ");
            }

            return sb.ToString();
        }

    }
}

