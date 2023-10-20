namespace ListOpgave{
    public class LinkedList {
    
        int Count = -1;
        public Element First;

        public Element GetFirst() {
            return First;
        }
        public void AddFirst(int data) {
            Element newElement = new();

            Count++;
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
            Count--;
            if (First != null) {
                First = First.Next;
            }
        }
        public Element GetElement(int data){
            bool DataNotFound = true;
            Element Pointer;

            if (First.Data == data) {
                return First;
            } else {
                Pointer = First;

                while(DataNotFound){
                    if(Pointer.Data == data){
                        DataNotFound = false;
                        return Pointer;
                    } else {
                        if(Pointer.Next != null){
                            Pointer = Pointer.Next;
                        } else {
                            return null;
                        }                        
                    }
                }
            }
            return null;
        }
        public int Length() {
            return Count;
        }
        public string Print(int data) {
            Element element = GetElement(data);
            return "" + element.Data + " " + element.Next ;
        }
        public void Sort() {
            bool swapped = false;
            bool isFirst = true;
            Element pointer = new();
            while(swapped == false){
                swapped = true;
                if (isFirst) {
                    pointer = First;
                    isFirst = false;
                }
                if(pointer.Data > pointer.Next.Data){
                    Element before = pointer;
                    if(pointer == First){
                        First = pointer;
                    }
                    pointer = pointer.Next;
                    pointer.Next = before;
                    swapped = false;
                }else{
                    if (pointer.Next == null) {
                        swapped = true;
                    } else {
                        pointer = pointer.Next;
                    }
                }
            }
        }
    }    
}

