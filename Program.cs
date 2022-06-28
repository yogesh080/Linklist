namespace LinkedList_Day_14
{

    public class Program
    {
        public static void Main(string[] args)
        {

            //create Linked List by adding 30 and 56 to 70
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.add(70);
            linkedList.add(30);
            linkedList.add(56);

            linkedList.show();

            //create Linked List by appending 30 and 56 to 70
            //LinkedList<int> linkedList2 = new LinkedList<int>();

            //linkedList2.append(56);
            //linkedList2.append(30);
            //linkedList2.append(70);

            //linkedList2.show();

            //
            linkedList.InsertBetween(56,30,70);
            linkedList.show();
        }
    }
}