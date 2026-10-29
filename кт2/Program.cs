/* 
 
using System;

namespace Lab2
{
    public class Point
    {
        private int _x;
        private int _y;

        public Point()
        {
            _x = 0;
            _y = 0;
        }

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public override string ToString()
        {
            return "(" + _x + ";" + _y + ")";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Задание 1: Точка ");

            Point first = ReadPoint("Точка 1");
            Point second = ReadPoint("Точка 2");
            Point third = ReadPoint("Точка 3");

            Console.WriteLine();
            Console.WriteLine("Точка 1: " + first);
            Console.WriteLine("Точка 2: " + second);
            Console.WriteLine("Точка 3: " + third);

            Console.ReadKey();
        }

        private static Point ReadPoint(string label)
        {
            Console.WriteLine(label + ":");

            int x = ReadInt("  X = ");
            int y = ReadInt("  Y = ");

            return new Point(x, y);
        }

        private static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int value))
                {
                    return value;
                }

                Console.WriteLine("Ошибка: введите целое число.");
            }
        }
    }
}


*/








/*
 
using System;

namespace Lab2
{
    public class Point
    {
        private int _x;
        private int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public override string ToString()
        {
            return "{" + _x + ";" + _y + "}";
        }
    }

    public class Line
    {
        private Point _start;
        private Point _end;

        public Line(Point start, Point end)
        {
            if (start == null)
            {
                throw new ArgumentNullException(nameof(start));
            }

            if (end == null)
            {
                throw new ArgumentNullException(nameof(end));
            }

            _start = start;
            _end = end;
        }

        public Point Start
        {
            get { return _start; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                _start = value;
            }
        }

        public Point End
        {
            get { return _end; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                _end = value;
            }
        }

        public override string ToString()
        {
            return "Линия от " + _start + " до " + _end;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Задание 2.1: Линия ");

            int x1 = ReadInt("Линия 1, X начала = ");
            int y1 = ReadInt("Линия 1, Y начала = ");
            int x2 = ReadInt("Линия 1, X конца = ");
            int y2 = ReadInt("Линия 1, Y конца = ");
            Line line1 = new Line(new Point(x1, y1), new Point(x2, y2));

            int x3 = ReadInt("Линия 2, X начала = ");
            int y3 = ReadInt("Линия 2, Y начала = ");
            int x4 = ReadInt("Линия 2, X конца = ");
            int y4 = ReadInt("Линия 2, Y конца = ");
            Line line2 = new Line(new Point(x3, y3), new Point(x4, y4));

            Line line3 = new Line(line1.Start, line2.End);

            Console.WriteLine();
            Console.WriteLine("Линия 1: " + line1);
            Console.WriteLine("Линия 2: " + line2);
            Console.WriteLine("Линия 3: " + line3);

            Console.WriteLine();
            Console.WriteLine(" Пункт 4: меняем координаты точек ");
            line1.Start.X = ReadInt("Новый X начала линии 1 = ");
            line1.Start.Y = ReadInt("Новый Y начала линии 1 = ");
            line2.End.X = ReadInt("Новый X конца линии 2 = ");
            line2.End.Y = ReadInt("Новый Y конца линии 2 = ");

            Console.WriteLine("Линия 1: " + line1);
            Console.WriteLine("Линия 2: " + line2);
            Console.WriteLine("Линия 3: " + line3);

            Console.WriteLine();
            Console.WriteLine(" Пункт 5: заменяем точки линии 1 ");
            line1.Start = new Point(
                ReadInt("Новый X начала линии 1 = "),
                ReadInt("Новый Y начала линии 1 = "));
            line1.End = new Point(
                ReadInt("Новый X конца линии 1 = "),
                ReadInt("Новый Y конца линии 1 = "));

            Console.WriteLine("Линия 1: " + line1);
            Console.WriteLine("Линия 3: " + line3);

            Console.ReadKey();
        }

        private static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int value))
                {
                    return value;
                }

                Console.WriteLine("Ошибка: введите целое число.");
            }
        }
    }
}


*/










/*

using System;

namespace Lab2
{
    public class Student
    {
        private string _name;
        private int[] _grades;

        public Student(string name, int[] grades)
        {
            _name = name;
            _grades = grades;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int[] Grades
        {
            get { return _grades; }
            set { _grades = value; }
        }

        public override string ToString()
        {
            string result = _name + ": [";

            for (int i = 0; i < _grades.Length; i++)
            {
                result += _grades[i];

                if (i < _grades.Length - 1)
                {
                    result += ", ";
                }
            }

            return result + "]";
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Задание 3.1: Студент ");

            string vasyaName = ReadString("Имя первого студента: ");
            int[] vasyaGrades = ReadGrades(vasyaName);
            Student vasya = new Student(vasyaName, vasyaGrades);

            Console.WriteLine();
            Console.WriteLine(vasya);

            Console.WriteLine();
            Console.WriteLine(" Пункт 2: второй студент получает ссылку на массив первого ");
            string petyaName = ReadString("Имя второго студента: ");
            Student petya = new Student(petyaName, vasya.Grades);

            Console.WriteLine(vasya);
            Console.WriteLine(petya);

            Console.WriteLine();
            Console.WriteLine(" Пункт 3: меняем первую оценку второго студента ");
            int newGrade = ReadInt("Новое значение первой оценки: ");
            petya.Grades[0] = newGrade;

            Console.WriteLine(vasya);
            Console.WriteLine(petya);
            Console.WriteLine();
            Console.WriteLine("Объяснение: массив — ссылочный тип. При присваивании");
            Console.WriteLine("grades первого студента второму обе переменные");
            Console.WriteLine("указывают на один массив. Изменение через второго");
            Console.WriteLine("видно и у первого.");

            Console.WriteLine();
            Console.WriteLine(" Пункт 4: третий студент получает копию массива ");
            string andreyName = ReadString("Имя третьего студента: ");
            int[] andreyGrades = CopyArray(vasya.Grades);
            Student andrey = new Student(andreyName, andreyGrades);

            Console.WriteLine(vasya);
            Console.WriteLine(andrey);

            Console.WriteLine();
            Console.WriteLine(" Меняем первую оценку первого студента ");
            int anotherGrade = ReadInt("Новое значение первой оценки: ");
            vasya.Grades[0] = anotherGrade;

            Console.WriteLine(vasya);
            Console.WriteLine(andrey);
            Console.WriteLine();
            Console.WriteLine("Объяснение: массив третьего студента — отдельная");
            Console.WriteLine("копия, изменение оценок первого на него не влияет.");

            Console.ReadKey();
        }

        private static int[] ReadGrades(string studentName)
        {
            int count = ReadInt("Сколько оценок у " + studentName + "? ");
            int[] grades = new int[count];

            for (int i = 0; i < count; i++)
            {
                grades[i] = ReadInt("  Оценка " + (i + 1) + " = ");
            }

            return grades;
        }

        private static int[] CopyArray(int[] source)
        {
            int[] copy = new int[source.Length];

            for (int i = 0; i < source.Length; i++)
            {
                copy[i] = source[i];
            }

            return copy;
        }

        private static string ReadString(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input.Trim();
                }

                Console.WriteLine("Ошибка: пустая строка.");
            }
        }

        private static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int value))
                {
                    return value;
                }

                Console.WriteLine("Ошибка: введите целое число.");
            }
        }
    }
}

*/






/*
using System;

namespace Lab2
{
    public class Point
    {
        private int _x;
        private int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public override string ToString()
        {
            return "{" + _x + ";" + _y + "}";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Задание 4.1: Создаём Точку ");

            int x1 = ReadInt("Точка 1, X = ");
            int y1 = ReadInt("Точка 1, Y = ");
            Point first = new Point(x1, y1);

            int x2 = ReadInt("Точка 2, X = ");
            int y2 = ReadInt("Точка 2, Y = ");
            Point second = new Point(x2, y2);

            int x3 = ReadInt("Точка 3, X = ");
            int y3 = ReadInt("Точка 3, Y = ");
            Point third = new Point(x3, y3);

            Console.WriteLine();
            Console.WriteLine("Точка 1: " + first);
            Console.WriteLine("Точка 2: " + second);
            Console.WriteLine("Точка 3: " + third);

            Console.ReadKey();
        }

        private static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int value))
                {
                    return value;
                }

                Console.WriteLine("Ошибка: введите целое число.");
            }
        }
    }
}

*/


/*

using System;

namespace Lab2
{
    public class Student
    {
        private string _name;
        private int[] _grades;

        public Student(string name, int[] grades = null)
        {
            _name = name;

            if (grades == null)
            {
                _grades = new int[0];
            }
            else
            {
                _grades = new int[grades.Length];

                for (int i = 0; i < grades.Length; i++)
                {
                    _grades[i] = grades[i];
                }
            }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int[] Grades
        {
            get { return _grades; }
            set
            {
                if (value == null)
                {
                    _grades = new int[0];
                }
                else
                {
                    _grades = value;
                }
            }
        }

        public override string ToString()
        {
            string result = _name + ": [";

            for (int i = 0; i < _grades.Length; i++)
            {
                result += _grades[i];

                if (i < _grades.Length - 1)
                {
                    result += ", ";
                }
            }

            return result + "]";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Задание 4.7: Создаем Студента ");

            Console.WriteLine();
            Console.WriteLine(" Студент с именем и оценками ");
            string vasyaName = ReadString("Имя студента: ");
            int count = ReadInt("Сколько оценок? ");

            int[] vasyaGrades = new int[count];

            for (int i = 0; i < count; i++)
            {
                vasyaGrades[i] = ReadInt("  Оценка " + (i + 1) + " = ");
            }

            Student vasya = new Student(vasyaName, vasyaGrades);
            Console.WriteLine(vasya);

            Console.WriteLine();
            Console.WriteLine(" Студент только с именем ");
            string maximName = ReadString("Имя студента: ");
            Student maxim = new Student(maximName);
            Console.WriteLine(maxim);

            Console.ReadKey();
        }

        private static string ReadString(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input.Trim();
                }

                Console.WriteLine("Ошибка: пустая строка.");
            }
        }

        private static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int value))
                {
                    return value;
                }

                Console.WriteLine("Ошибка: введите целое число.");
            }
        }
    }
}

*/


