using System;

namespace LinkListU
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkList list = new LinkList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            //list.Display();
            int a = list.Search(30);
            
            list.InsertInPerticularPosition(a+1, 40);
            list.Display();



        }
    }
}