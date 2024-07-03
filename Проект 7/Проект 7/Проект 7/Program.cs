using Проект_7;
class Program
{
    static void Main()
    {
        Student st1 = new Student("Иванов", 203, 5, 4, 3);
        Console.WriteLine(st1[1]);
        st1[1] = 5;
        Console.WriteLine(st1.Fiz);

        Console.WriteLine("Оценка по математике {0}", st1["Математика"]);
        st1["Математика"] = 4;
        Console.WriteLine("Оценка по математике {0}", st1[0]);

        Student st2 = new Student("Иванов", 203, 5, 4, 3);
        Student st3 = new Student("Петров", 204, 3, 4, 4);
        Student st4 = new Student("Сидоров", 201, 4, 5, 4);
        Student st5 = new Student("Алексеев", 202, 5, 5, 4);
        Student st6 = new Student("Титов", 201, 4, 5, 5);
        Student[] stud1 = new Student[] { st2, st3, st4, st5, st6 };
        double s_mat = 0;
        for (int k = 0; k < stud1.Length; k++)
            s_mat += stud1[k]["Математика"];
        s_mat /= stud1.Length;
        Console.WriteLine("Средний балл по математике равен {0}", Math.Round(s_mat, 2));

        Students studs = new Students(stud1);
        for (int k = 0; k < stud1.Length; k++)
            Console.WriteLine("Студент {0}, группа {1}", studs[k].Name, studs[k].Grup);
        Console.WriteLine("Студент {0}, средний балл {1}", studs["Петров"].Name, studs["Петров"].Sr_ball());

        Matrix1 mat = new Matrix1();
        mat[1, 2] = 10;
        Console.WriteLine("Первый = {0}, последний = {1}", mat[0, 0], mat[1, 2]);
    }
}