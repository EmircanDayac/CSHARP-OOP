using System;

namespace ConsoleOOPapp
{
    public class InstanceX
    {

private static InstanceX x = null; 


private  static void createInstance() {
     if (x == null)
        x = new InstanceX();
}


public static InstanceX getInstance() {
    if (x == null)
        createInstance();
    return x;
}

public void func()
{
    Console.WriteLine("ınstance class ");
}


    }

    
  
}
