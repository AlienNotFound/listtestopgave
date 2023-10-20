using Xunit;
using ListOpgave;
using NuGet.Frameworks;


public class UnitTest1
{
    [Fact]
    public void AddFirstTest()
    {
        // Element myElement = new Element { Data = 1 };
        // Element secondElement = new Element { Data = 2 };
        LinkedList MyList = new LinkedList();

        MyList.AddFirst(1);

        Assert.Equal(1, MyList.First.Data);

        // if (MyList.First == null)
        // {
        //     MyList.First = myElement; // Assign myElement to the First property of the LinkedList
        // }
        // else
        // {
        //     secondElement.Next = MyList.First;
        //     MyList.First = secondElement; // Update the First property of the LinkedList
        // }

        // Assert.Equal(myElement, secondElement); // Use Assert.Equal to compare elements
    }
    [Fact]
    public void RemoveFirstTest() {
        LinkedList Mylist = new();

        Mylist.AddFirst(1);
        Mylist.RemoveFirst();

        Assert.True(Mylist.First == null);
    }
    [Fact]
    public void PrintTest(){
        int printed = 0;
        LinkedList Mylist = new();
        Mylist.AddFirst(1);
        printed = Mylist.First.Data;
        Console.WriteLine(printed);
        Assert.Equal("1 ",Mylist.Print(1));

    }

    [Fact]
    public void CountTest(){
        LinkedList Mylist = new();
        Mylist.AddFirst(1);
        Assert.True(Mylist.Count() == 0);
    }

    [Fact]
    public void GetSomethingTest(){
        LinkedList Mylist = new();
        Mylist.AddFirst(1);
        Mylist.AddFirst(3);
        Mylist.AddFirst(2);
        Assert.True(Mylist.GetSomething(3).Data == 3);
    }

    [Fact]
    public void sortTest(){
        LinkedList Mylist = new();
        Mylist.AddFirst(4);
        Mylist.AddFirst(3);
         Mylist.AddFirst(9);
        Mylist.AddFirst(1);       
        Mylist.Sort();

        Assert.Equal(1, Mylist.GetFirst().Data);        
    }
}
