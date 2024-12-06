using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UVSUtil : MonoBehaviour
{
    class Comparer : IComparer
    {
        System.Func<object, object, int> func;
        public Comparer(System.Func<object, object, int> func)
        {
            this.func = func;
        }
        public int Compare(object x, object y)
        {
            return func(x, y);
        }
    }

    public static IComparer FuncToComparer(System.Func<object, object, int> func)
    {
        return new Comparer(func);
    }
}
