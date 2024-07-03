using Проект_8;

class Program
{
    static void Main()
    {
        Console.WriteLine("Список");
        Student st1 = new Student("Иванов", 203, 5, 4, 3);
        Student st2 = new Student("Петров", 204, 3, 4, 4);
        Student st3 = new Student("Сидоров", 201, 4, 5, 4);
        Student st4 = new Student("Алексеев", 202, 5, 5, 4);
        Student st5 = new Student("Титов", 201, 4, 5, 5);
        List<Student> list1 = new List<Student> {st1, st2, st3};
        Console.WriteLine("Студент {0}, средний балл {1} \n\nAdd and insert", list1[2].Name, list1[2].Sr_ball());


        list1.Add(st4);
        list1.Insert(2, st5);
        foreach (var x in list1)
            Console.WriteLine("Студент {0} средний балл {1}", x.Name, x.Sr_ball());

        Console.WriteLine("\nReverse");
        list1.Reverse();
        for (int k = 0; k < list1.Count; k++)
            Console.WriteLine("Студент {0} средний балл {1}", list1[k].Name, list1[k].Sr_ball());

        Console.WriteLine("\nRemove and RemoveAt");
        if (list1.Remove(st2))
            Console.WriteLine("Элемент успешно удален");
        else
            Console.WriteLine("Элемент не удален");
        if (list1.Remove(st2))
            Console.WriteLine("Элемент успешно удален");
        else
            Console.WriteLine("Элемент не удален");
        list1.RemoveAt(2);
        for (int k = 0; k < list1.Count; k++)
            Console.WriteLine("Студент {0} средний балл {1}", list1[k].Name, list1[k].Sr_ball());

        Console.WriteLine("\nContains");
        Console.WriteLine("st1 содержится {0}", list1.Contains(st1));
        Console.WriteLine("st2 содержится {0}", list1.Contains(st2));

        Console.WriteLine("\nIndexOf and LastIndexOf");
        list1.Add(st3);
        list1.Add(st2);
        list1.Add(st3);
        list1.Add(st5);
        Console.WriteLine("Первое вхождение {0} под номером {1}", st3.Name, list1.IndexOf(st3));
        Console.WriteLine("Последнее вхождение {0} под номером {1}",st3.Name, list1.LastIndexOf(st3));
        for (int k = 0; k < list1.Count; k++)
            Console.WriteLine("Студент {0}", list1[k].Name);

        Console.WriteLine("\nClear");
        list1.Clear();
        Console.WriteLine("Список содержит {0} элементов", list1.Count);

        Console.WriteLine("\nОчередь");
        Student[] studs = {st1, st2, st3, st4};
        Queue<Student> queue1 = new Queue<Student>(studs);
        Console.WriteLine("В очереди {0} элементов\n", queue1.Count);
        foreach (var x in queue1)
            Console.WriteLine("Студент {0} ", x.Name);

        Console.WriteLine();
        queue1.Enqueue(st5);
        Console.WriteLine("В очереди {0} элементов\n", queue1.Count);
        foreach (var x in queue1)
            Console.WriteLine("Студент {0}", x.Name);

        Console.WriteLine();
        Student stQueue = queue1.Peek();
        Console.WriteLine("Получен студент {0} без удаления из очереди", stQueue.Name);
        Console.WriteLine();

        Console.WriteLine("st1 содержится {0}", queue1.Contains(st1));
        Console.WriteLine();

        Console.WriteLine("В очереди {0} элементов", queue1.Count);
        Console.WriteLine();

        while (queue1.Count > 0)
        {
            var x = queue1.Dequeue();
            Console.WriteLine("Студент {0} средний балл {1}",
            x.Name, x.Sr_ball());
        }
        Console.WriteLine("\nВ очереди {0} элементов", queue1.Count);

        Console.WriteLine("\nСтек\n");

        Stack<Student> stack1 = new Stack<Student>(studs);
        Console.WriteLine("В стеке {0} элементов", stack1.Count);
        Console.WriteLine();

        foreach (var x in stack1)
            Console.WriteLine("Студент {0}", x.Name);
        Console.WriteLine();

        stack1.Push(st5);
        Console.WriteLine("В стеке {0} элементов", stack1.Count);
        Console.WriteLine();

        foreach (var x in stack1)
            Console.WriteLine("Студент {0}", x.Name);
        Console.WriteLine();

        Student stStack = stack1.Peek();
        Console.WriteLine("Получен студент {0} без удаления из стека", stStack.Name);
        Console.WriteLine();

        Console.WriteLine("st5 содержится {0}", stack1.Contains(st5));
        Console.WriteLine();

        Console.WriteLine("В стеке {0} элементов", stack1.Count);
        Console.WriteLine();

        while (stack1.Count > 0)
        {
            var x = stack1.Pop();
            Console.WriteLine("Студент {0} средний балл {1}",
            x.Name, x.Sr_ball());
        }
        Console.WriteLine();
        Console.WriteLine("В стеке {0} элементов", stack1.Count);

        Console.WriteLine("\nСловарь\n");
        Dictionary<string, Student> dictionary1 = new Dictionary<string, Student>
        {
            ["КГАСУ"] = st1,
            ["КФУ"] = st2,
            ["КГТУ"] = st3
        };
        Console.WriteLine("В словаре {0} элементов", dictionary1.Count);
        foreach (var x in dictionary1)
        {
            Console.WriteLine("Ключ {0} студент {1}", x.Key, x.Value.Name);
        }

        dictionary1.Add("НГПУ", st4);
        dictionary1.Add("КЮИ", st5);

        Console.WriteLine("\nAdd");
        Console.WriteLine("В словаре {0} элементов", dictionary1.Count);
        foreach (var x in dictionary1)
        {
            Console.WriteLine("Ключ {0} студент {1}", x.Key, x.Value.Name);
        }

        Console.WriteLine();
        Console.WriteLine("Студент {0} средний балл {1}", dictionary1["КФУ"].Name, dictionary1["КФУ"].Sr_ball());

        Console.WriteLine("Update");
        dictionary1["КФУ"].Name = "Николаев";
        Console.WriteLine("Студент {0} средний балл {1}", dictionary1["КФУ"].Name, dictionary1["КФУ"].Sr_ball());

        Console.WriteLine("\nRemove");
        if (dictionary1.Remove("КФУ"))
            Console.WriteLine("Элемент удален!");
        else
            Console.WriteLine("Элемент не удален!");
        Console.WriteLine("В словаре {0} элементов", dictionary1.Count);

        Console.WriteLine("\nContainsKey and ContainsValue");
        Console.WriteLine("Элемент содержится в словаре {0}", dictionary1.ContainsKey("МГУ"));
        Console.WriteLine("Элемент содержится в словаре {0}", dictionary1.ContainsValue(st5));
    }
}