namespace ListOpgave{
    
    public class Element
    {
        public int Index;
        public int Data;
        public Element Next;

        public override string ToString() {
            return "" + Data + "";
            // return "[" + Data + " | " + Next + "]";
        }

        // public int AtIndex(int idx) {
        //     if (idx == Index) {
        //         return Data;
        //     }
        //     return -1;
        // }
    }
}