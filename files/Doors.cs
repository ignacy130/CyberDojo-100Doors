using System;

public class Doors
{
    private bool _closed = true;
    public bool Closed
    {
        get
        {
            return _closed;
        }
    }
    
    public void Toggle()
    {
        if(this.Closed)
        {
            _closed = false;
        }
        else
        {
            _closed = true;
        }
    }
}

public class DoorsRow
{
    private Doors[] _doors = new Doors[100];
    
    public Doors[] Doors
    {
        get
        {
            return _doors;
        }
    }
    
    public DoorsRow(){
        for(var i=0;i<_doors.Length;i++){
            _doors[i] = new Doors();
        }   
    }
    
    public void MakePass()
    {
        for(var i=0;i<_doors.Length;i++){
            _doors[i].Toggle();
        } 
    }
    
    //public void Solve
}
