using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект_8
{
    class Student
    {
        public string Name { get; set; }
        public int Grup { set; get; }
        public int Mat { set; get; }
        public int Fiz { set; get; }
        public int Him { set; get; }
        public Student(string name, int grup, int mat, int fiz, int him)
        {
            Name = name;
            Grup = grup;
            Mat = mat;
            Fiz = fiz;
            Him = him;
        }
        public double Sr_ball() => Math.Round((Mat + Fiz + Him) / 3.0, 2);
        public int this[int k]
        {
            set
            {
                switch (k)
                {
                    case 0:
                        Mat = value;
                        break;
                    case 1:
                        Fiz = value;
                        break;
                    case 2:
                        Him = value;
                        break;
                    default:
                        throw
                    new Exception("Некорректный номер!");
                }
            }
            get
            {
                switch (k)
                {
                    case 0:
                        return Mat;
                    case 1:
                        return Fiz;
                    case 2:
                        return Him;
                    default:
                        throw
                    new Exception("Некорректный номер!");
                }
            }
        }
        public int this[string s]
        {
            set
            {
                switch (s)
                {
                    case "Математика":
                        Mat = value;
                        break;
                    case "Физика":
                        Fiz = value;
                        break;
                    case "Химия":
                        Him = value;
                        break;
                    default:
                        throw new Exception("Некорректный индекс!");
                }
            }
            get
            {
                switch (s)
                {
                    case "Математика":
                        return Mat;
                    case "Физика":
                        return Fiz;
                    case "Химия":
                        return Him;
                    default:
                        throw new Exception("Некорректный индекс!");
                }
            }
        }
    }
}
