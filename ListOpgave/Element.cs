namespace ListOpgave{
    
    public class Element
    {
        public int Data;
        public Element Next;

        public override string ToString() {
            return "" + Data + "";
            // return "[" + Data + " | " + Next + "]";
        }
    }
}




