using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Stack;

public class GenericStack<T>
{
    private T[] TArray { get; set; }
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
        get { return CurrentPosition == TArray.Length - 1; }
    }

    public GenericStack(int size)
    {
        TArray = new T[size];
        CurrentPosition = -1;
    }

    public void Push(T val)
    {
        if (CurrentPosition < TArray.Length - 1)
        {
            CurrentPosition++;
            TArray[CurrentPosition] = val;
        }
    }

    public T Pop()
    {
        if (CurrentPosition >= 0)
        {
            T poppedValue = TArray[CurrentPosition];
            TArray[CurrentPosition] = default(T);
            CurrentPosition--;
            return poppedValue;
        }

        return default(T);
    }

    public T Peak()
    {
        if (CurrentPosition >= 0)
        {
            return TArray[CurrentPosition];
        }

        return default(T);
    }

    public void Clear()
    {
        Array.Clear(TArray, 0, TArray.Length);
        CurrentPosition = -1;
    }
}

