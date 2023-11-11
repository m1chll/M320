using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Stack;

public class StringStack
{
    private string[] StringArray { get; set; }
    private int CurrentPosition { get; set; }
    public bool IsEmpty
    {
        get { return CurrentPosition == -1; }
    }

    public int Count
    {
        get { return CurrentPosition + 1; }
    }

    public bool IsFull
    {
        get { return CurrentPosition == StringArray.Length - 1; }
    }

    public StringStack(int size)
    {
        StringArray = new string[size];
        CurrentPosition = -1;
    }

    public void Push(string val)
    {
        if (CurrentPosition < StringArray.Length - 1)
        {
            CurrentPosition++;
            StringArray[CurrentPosition] = val;
        }
    }

    public string Pop()
    {
        if (CurrentPosition >= 0)
        {
            string poppedValue = StringArray[CurrentPosition];
            StringArray[CurrentPosition] = null;
            CurrentPosition--;
            return poppedValue;
        }

        return "Stack is empty";
    }

    public string Peak()
    {
        if (CurrentPosition >= 0)
        {
            return StringArray[CurrentPosition];
        }

        return "Stack is empty";
    }

    public void Clear()
    {
        Array.Clear(StringArray, 0, StringArray.Length);
        CurrentPosition = -1; 
    }
}

