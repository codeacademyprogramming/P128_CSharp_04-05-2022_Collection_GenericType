using CollectionGenericType.Collections;
using CollectionGenericType.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionGenericType
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Custom Collection generic Type Constraint
            //Department department = new Department();

            //department.Add(new Employee());


            //Company company = new Company();

            //company.Add(new Employee());


            //Group group = new Group();

            //group.Add(new Student());

            ////MyCollection<string> myCollectionStr = new MyCollection<string>();
            ////MyCollection<int> myCollectionInt = new MyCollection<int>();
            ////MyCollection<int> myCollection = new MyCollection<int>();
            //MyCollection<Student> myCollection = new MyCollection<Student>();
            #endregion

            #region Non Generic Type Collection
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("Test");
            //arrayList.Add(128);
            //arrayList.Add(new Employee { MyProperty = 35});

            //ArrayList arrayList1 = new ArrayList();
            //arrayList1.Add("Hello");
            //arrayList1.Add(new Company());

            ////arrayList.AddRange(arrayList1);
            //arrayList.Insert(1, "Hello");
            //arrayList.InsertRange(1, arrayList1);

            //foreach (object item in arrayList)
            //{
            //    if (item is Employee)
            //    {
            //        Employee employee = (Employee)item;
            //        Console.WriteLine(employee.MyProperty);
            //    }
            //}

            //arrayList.Clear();

            //Console.WriteLine(arrayList.Contains("Hello"));
            //arrayList.Remove("Hello");
            //arrayList.RemoveAt(1);
            //arrayList.RemoveRange(1,3);
            //Console.WriteLine(arrayList.IndexOf("Hello"));

            //SortedList sortedList = new SortedList();
            //sortedList.Add("Birinci", "Test-5");
            //sortedList.Add("dord", "Test-15");
            //sortedList.Add("doqquz", "Test-1");
            //sortedList.Add("alti", "Test-2");
            //sortedList.Add("sekkkiz", "Test-9");

            //KeyValuePair<string, int> keyValuePair = new KeyValuePair<string, int>("Age",15);
            //Console.WriteLine($"{keyValuePair.Key} : {keyValuePair.Value}");

            //foreach (var item in sortedList.Keys)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(sortedList.Count);

            //FIFO First In First Out
            //Queue queue = new Queue();
            //queue.Enqueue("Hello");
            //queue.Enqueue("P");
            //queue.Enqueue(128);
            //queue.Enqueue("World");
            //queue.Enqueue("Code");

            //Console.WriteLine(queue.Peek());

            //var a=  queue.Dequeue();
            //Console.WriteLine(a);

            //Console.WriteLine(queue.Peek());

            //queue.Dequeue();

            //Console.WriteLine(queue.Peek());

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //    queue.Dequeue();
            //}

            //LIFO Last In First Out
            //Stack stack = new Stack();
            //stack.Push("Hello");
            //stack.Push("P");
            //stack.Push(128);
            //stack.Push("World");
            //stack.Push("Code");

            //Console.WriteLine(stack.Peek());

            //Console.WriteLine(stack.Count);


            //stack.Pop();


            //Console.WriteLine(stack.Peek());


            //Console.WriteLine(stack.Count);
            #endregion

            #region Generic Type Collection
            //List<object> intList = new List<object>();
            //intList.Add(15);
            //intList.Add(33);
            //intList.Add(46);
            //intList.Add(15);
            //intList[3] = 56;
            //Console.WriteLine(intList[3]);

            //SortedList<int, string> demolist = new SortedList<int, string>();
            //demolist.Add(3, "test-3");
            //demolist.Add(2, "test-2");
            //demolist.Add(1, "test-1");
            //foreach (var item in demolist)
            //{
            //    Console.WriteLine($"{item.Key} {item.Value}");
            //}

            //Dictionary<string, string> pairs = new Dictionary<string, string>();
            //pairs.Add("Hamid Mammadov", "+9445555555");
            //pairs.Add("Rahman Vahabov", "+944514520048");
            //pairs.Add("Metin Necefov", "+994707161996");
            //foreach (var item in pairs)
            //{
            //    Console.WriteLine(item.Key+" "+item.Value);
            //}

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("test");
            queue.Peek();
            queue.Dequeue();

            Stack<string> stack = new Stack<string>();
            #endregion
        }
    }
}
