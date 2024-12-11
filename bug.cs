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
        // Potential bug: Accessing _myField directly instead of using the property
        int x = _myField; 
        // This could be dangerous if we later add validation or other logic to the setter.
    }
}