public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        //Check if MyProperty has been initialized
        if(MyProperty != null)
        {
            Console.WriteLine(MyProperty); 
        }
        else
        {
            Console.WriteLine("MyProperty has not been initialized");
        }
    }
}