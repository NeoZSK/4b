﻿int[,] intsArr = new int[3, 5];
int[,] intsArr2 = {
    { 0, 1, 2, 2, 2 },
    { 1, 2, 3, 3, 3 },
    { 3, 4, 5, 3, 3 },
};

for (int i = 0; i < intsArr2.GetLength(0); i++)
{
    for (int j = 0; j < intsArr2.GetLength(1); j++)
    {
        Console.Write(intsArr2[i, j]);
        Console.Write(" ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < intsArr2.GetLength(1); i++)
{
    for (int j = 0; j < intsArr2.GetLength(0); j++)
    {
        Console.Write(intsArr2[j, i]);
        Console.Write(" ");
    }
    Console.WriteLine();
}








//void arrays()
//{
//    int[] intsArr = new int[5];
//    intsArr[0] = 1;
//    intsArr[3] = 2;

//    for (int i = 0; i < intsArr.Length; i++)
//    {
//        intsArr[i] = i * 5;
//    }

//    foreach (int item in intsArr)
//    {
//        Console.WriteLine(item);
//    }

//}
//void lists()
//{
//    List<int> intsList = new List<int>();

//    intsList.Add(50);
//    intsList.Add(200);
//    intsList.Add(4000);
//    intsList.Add(4000);


//    for (int i = 0; i < intsList.Count; i++)
//    {
//        Console.WriteLine(intsList[i]);
//    }
//    intsList.Remove(4000);
//    intsList.RemoveAt(0);
//    intsList.RemoveAll(el => el > 100);
//    intsList.Insert(0, 99);

//    Console.WriteLine(" --- ");
//    for (int i = 0; i < intsList.Count; i++)
//    {
//        Console.WriteLine(intsList[i]);
//    }


//}
//void arrayLists()
//{
//    ArrayList x = new ArrayList();
//    x.Add(1);
//    x.Add("3");
//}





