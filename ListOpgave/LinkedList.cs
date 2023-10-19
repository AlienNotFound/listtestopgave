namespace ListOpgave{
    public class LinkedList {
    
        int count = -1;
        public Element First;

        public Element GetFirst() {
            return First;
        }
        public void AddFirst(int data) {
            Element newElement = new();

            if (First == null) {
                newElement.Data = data;
                newElement.Next = null;
                First = newElement;
            } else {
                newElement.Data = data;
                newElement.Next = First;
                First = newElement;
            }
        }
        public void RemoveFirst() {

        }
        public Element GetSomething(int index){
            Element something = null;
            return something;
        }
        public int Count() {
            return count;
        }
        public void Print() {

        }
        public void Sort() {

        }
    }    
}

