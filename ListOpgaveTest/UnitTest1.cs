using Xunit;
using ListOpgave;
using NuGet.Frameworks;

namespace ListOpgaveTest {
    public class UnitTest1
    {
        [Fact]
        public void AddFirstTest()
        {
            LinkedList MyList = new LinkedList();
            MyList.AddFirst(1);
            Assert.Equal(1, MyList.First.Data);
        }

        [Fact]
        public void RemoveFirstTest() {
            LinkedList Mylist = new();
            Mylist.AddFirst(1);
            Mylist.RemoveFirst();
            Assert.True(Mylist.First == null);
        }
        
        [Fact]
        public void GetElementTest(){
            LinkedList Mylist = new();
            Mylist.AddFirst(1);
            Mylist.AddFirst(3);
            Mylist.AddFirst(2);
            Assert.True(Mylist.GetElement(3).Data == 3);
        }

        [Fact]
        public void CountTest(){
            LinkedList Mylist = new();
            Mylist.AddFirst(1);
            Assert.True(Mylist.Length() == 0);
        }

        [Fact]
        public void PrintTest(){
            LinkedList Mylist = new();
            Mylist.AddFirst(1);
            Assert.Equal("1 ",Mylist.Print(1));
        }

        [Fact]
        public void SortTest(){
            LinkedList Mylist = new();
            Mylist.AddFirst(4);
            Mylist.AddFirst(3);
            Mylist.AddFirst(9);
            Mylist.AddFirst(1);       
            Mylist.Sort();
            Assert.Equal(1, Mylist.GetFirst().Data);        
        }
    }
}
