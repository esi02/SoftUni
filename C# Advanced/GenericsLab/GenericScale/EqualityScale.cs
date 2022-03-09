using System;
using System.Collections.Generic;
using System.Text;


public class EqualityScale<T>
   where T : IComparable<T>
{
    private T Left;
    private T Right;
    public EqualityScale(T left, T right)
    {
        Left = left;
        Right = right;
    }
    public bool AreEqual()
    {
        bool result = Left.Equals(Right);
        return result;
    }
    public T GetHeavier()
    {
        var comparison = Left.CompareTo(Right);

        if (comparison > 0)
        {
            return Left;
        }
        else if (comparison < 0)
        {
            return Right;
        }

        return default(T);
    }
}

