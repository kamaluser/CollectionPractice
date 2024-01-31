
List<int> intList = new List<int>();
intList.Add(0);
intList.Add(1);
intList.Add(2);


int[] nums = { 11, 22, 33 };


List<int> list = new List<int>();
list.Add(10);
list.Add(20);
list.Add(30);
list.Add(40);
list.Add(50);

list.Remove(10); // List-den daxil edilen deyeri silir


//list.Clear(); //Listi 0-layir

Console.WriteLine($"Capacity - {list.Capacity}");

var check = list.Contains(20);// elementin listde olub olmadigini yoxlayir
Console.WriteLine(check);

list.AddRange(intList);// Liste daxil etdiyimiz collectionu elave edir

list.CopyTo(3, nums, 0, 2);// List-i daxil etdiyimiz array-e copyTo edir

Console.WriteLine(list.Count);// Listdeki elementlerin sayi(listin uzunlugu)
Console.WriteLine(list.Average());//Listdeki ededlerin ededi ortasi
Console.WriteLine(list.Equals(list));//listlerin beraber olub olmadigini yoxlayir
Console.WriteLine(list.IndexOf(50));//elementin indexini qaytarir
list.RemoveAt(0);// daxil edilen indeksdeki deyeri silir
list.Insert(3,33);//liste element elave edir(index,value)
list.InsertRange(0,nums);// liste collection elave edir(index, collection)
Console.WriteLine(list.Max());// listin en boyuk elememtini qaytarir
Console.WriteLine(list.Min());
list.Sort();
list.Reverse();
Console.WriteLine("List-in Elementleri: ");
foreach (var item in list)
{
    Console.WriteLine(item);
}
/*Console.WriteLine("\nNums\n");

for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}*/

Console.WriteLine("\t\t\t\t\tDictionary\n\n");

Dictionary<string, string> dict = new Dictionary<string, string>();

dict.Add("A", "Senan");
dict.Add("B", "Murad");
dict.Add("b", "Rauf");
dict.Add("C", "Elxan");
dict.Add("w", "Oruc");

dict.Remove("A");
//string name;
//if (!dict.TryGetValue("C",out name))
//{
//    name = "Raul";
//}
//else
//{
//    Console.WriteLine(name);
//}

Console.WriteLine(dict.ContainsKey("b"));

Console.WriteLine(dict.Equals(dict));
Console.WriteLine(dict.TryAdd("C", "Yagmur"));//key dictionaryde yoxdursa elave edir
Console.WriteLine("\tDictionary-deki elementler: \n");
foreach (var item in dict)
{
    Console.WriteLine(item);
}

Console.WriteLine("\t\t\t\tStack\n");
Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Pop();
Console.WriteLine(stack.Peek());
stack.Pop();
Console.WriteLine(stack.Peek());

foreach (var item in stack)
{
    Console.WriteLine(item);
}


Console.WriteLine("\t\t\t\tQueue\n");
Queue<string> qu = new Queue<string>();
qu.Enqueue("Arif");
qu.Enqueue("Elnur");
qu.Enqueue("Ramin");
qu.Enqueue("Resul");
qu.Enqueue("Faiq");

qu.Dequeue();
Console.WriteLine(qu.Peek());
qu.Dequeue();
Console.WriteLine(qu.Peek());
foreach (var item in qu)
{
    Console.WriteLine(item);
}