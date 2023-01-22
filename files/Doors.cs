using System;

public class Doors
{
    private bool _closed;
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
    
    public void MakePass()
    {
        throw new NotImplementedException();   
    }
}
