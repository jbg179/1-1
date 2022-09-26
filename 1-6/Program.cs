using System;
delegate void SampleDelegate();
class DelegateClass
{
    public void DelegateMethod()
    {
        Console.WriteLine("In the DelegateClass.DelegateMethod ...");
    }
}
class DelegateApp
{
    public static void Main()
    {
        DelegateClass obj = new DelegateClass();
        SampleDelegate sd = new SampleDelegate(obj.DelegateMethod);
        sd();
    }
}