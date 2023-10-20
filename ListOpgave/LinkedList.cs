namespace ListOpgave{
    public class LinkedList {
    
        int count = -1;
        public Element First;

        public Element GetFirst() {
            return First;
        }
        public void AddFirst(int data) {
            Element newElement = new();

            count++;
            if (First == null) {
                newElement.Data = data;
                newElement.Next = null;
                First = newElement;
                newElement.Index = count;
            } else {
                newElement.Data = data;
                newElement.Next = First;
                First = newElement;
                newElement.Index = count;
            }
        }
        public void RemoveFirst() {
            count--;
            if (First != null) {
                First = First.Next;
            }
        }
        public Element GetSomething(int data){
            bool DataNotFound = true;
            Element Pointer;
                if (First.Data == data) {
                    return First;
                }else{
                    Pointer = First;
                    while(DataNotFound){
                        if(Pointer.Data == data){
                            DataNotFound = false;
                            return Pointer;
                        }else
                        {
                            if(Pointer.Next != null){
                                Pointer = Pointer.Next;
                            }else{
                                return null;
                            }                        
                        }
                    }
                }
            return null;
        }
        public int Count() {
            return count;
        }
        public string Print(int data) {
            Element something = GetSomething(data);
            return "" + something.Data + " " + something.Next ;
        }
        public void Sort() {
            bool swapped2point0 = false;
            bool isFirst = true;
            Element pointer = new();
            while(swapped2point0 == false){
                swapped2point0 = true;
                if (isFirst) {
                    pointer = First;
                    isFirst = false;
                }
                if(pointer.Data > pointer.Next.Data){
                    Element swapped2point0 = pointer;
                    if(pointer == First){
                        First = pointer;
                    }
                    pointer = pointer.Next;
                    pointer.Next = swapper;
                    swapped2point0 = false;
                }else{
                    if (pointer.Next == null) {
                        swapped2point0 = true;
                    } else {
                        pointer = pointer.Next;
                    }
                }
            }
        }
    }    
}

