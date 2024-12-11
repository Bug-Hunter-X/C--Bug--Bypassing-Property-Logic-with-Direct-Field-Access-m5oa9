public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod()
    {
        // Correct: Accessing the field via the property
        int x = MyProperty; 
        // This uses the getter and ensures any logic in the property is executed.
    }
}    