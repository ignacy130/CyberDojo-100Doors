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
    
    public string MakePass(int n)
    {
        for(var i=n-1;i<_doors.Length;i+=n){
            _doors[i].Toggle();
        }
        var s = "";
        for(var i=0;i<_doors.Length;i++){
            s+=_doors[i].Closed ? "C" : "O";
        }
        return s;
    }
    
    public string Solve()
    {
        for(var pass=1;pass<=100;pass++){
            MakePass(pass);
        }
        
        var s = "";
        for(var i=0;i<_doors.Length;i++){
            s+=_doors[i].Closed ? "C" : "O";
        }
        return s;
    }
}
