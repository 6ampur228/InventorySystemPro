using System;
using System.Linq;

public static class CloneExtensions
{
    public static T[] DeepClone<T>(this T[] array) where T : ICloneable
    {
        return array.Select(item => (T)item.Clone()).ToArray();
    }
}
