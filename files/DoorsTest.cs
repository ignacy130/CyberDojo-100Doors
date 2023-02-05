using NUnit.Framework;

//100 doors in a row are all initially closed. You make 100 passes by the doors. The first time through, you visit every door and toggle the door
//(if the door is closed, you open it; if it is open, you close it).
//The second time you only visit every 2nd door (door #2, #4, #6, ...).
//The third time, every 3rd door (door #3, #6, #9, ...), etc, until you only visit the 100th door.

//Question: What state are the doors in after the last pass? Which are open, which are closed?

[TestFixture]
public class DoorsTest
{
    [Test]
    public void GivenFreshDoorsCheckAreClosed()
    {
        var doors = new Doors();
        Assert.True(doors.Closed);
    }
    
    [Test]
    public void GivenClosedDoorsOpenThem()
    {
        var doors = new Doors();
        doors.Toggle();
        Assert.False(doors.Closed);
    }
    
    [Test]
    public void GivenOpenDoorsCloseThem()
    {
        var doors = new Doors();
        doors.Toggle();
        doors.Toggle();
        Assert.True(doors.Closed);
    }
}

[TestFixture]
public class DoorsRowTest
{
    [Test]
    public void VisitEveryDoor()
    {
        var row = new DoorsRow();
        row.MakePass(1);
        foreach(var d in row.Doors)
        {
            Assert.True(!d.Closed);
        }
    }
    
    [Test]
    public void VisitEverySecondDoor()
    {
        var row = new DoorsRow();
        var n = 2;
        row.MakePass(n);
        
        Assert.True(row.Doors[0].Closed);
        Assert.True(row.Doors[2].Closed);
        Assert.True(row.Doors[4].Closed);
        
        Assert.True(!row.Doors[1].Closed);
        Assert.True(!row.Doors[3].Closed);
        Assert.True(!row.Doors[5].Closed);
        
    }
    
    [Test]
    public void VisitEveryFifthDoor()
    {
        var row = new DoorsRow();
        var n = 5;
        row.MakePass(n);
        
        Assert.True(row.Doors[0].Closed);
        Assert.True(row.Doors[1].Closed);
        Assert.True(row.Doors[2].Closed);
        Assert.True(row.Doors[3].Closed);
        
        Assert.True(!row.Doors[4].Closed);
        Assert.True(!row.Doors[9].Closed);
        Assert.True(!row.Doors[14].Closed);
        
    }
    
    [Test]
    public void VisitEveryHundrethDoor()
    {
        var row = new DoorsRow();
        var n = 100;
        row.MakePass(n);
        
        Assert.True(row.Doors[0].Closed);
        Assert.True(row.Doors[1].Closed);
        Assert.True(row.Doors[98].Closed);
        
        Assert.True(!row.Doors[99].Closed);
    }
    
    [Test]
    public void Solve_Test()
    {
        var row = new DoorsRow();
        var s = row.Solve();
        Console.WriteLine(s);
    }
}
