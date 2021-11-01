namespace DSA2021.AlgoExpert
{
    public class LinkedList
    {
        public int value;
        public LinkedList next;

        public LinkedList(int value)
        {
            this.value = value;
            this.next = null;
        }
    }

    public class LinkedLiskEasy
    {

        public static LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList)
        {
            // 1,2,3,4
          
            var node = linkedList;


            if (node == null)
                return null;



            while (node != null && node.next != null)
            {             

                if (node.value == node.next.value)
                {
                    node.next = node.next.next;
                }
                else
                {
                    node = node.next;
                }
            }

            return linkedList;
        }
    }
}
