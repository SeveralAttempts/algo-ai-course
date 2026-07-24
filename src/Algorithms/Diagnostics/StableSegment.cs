using System.Reflection;
using System.Reflection.Emit;

namespace Algorithms.Diagnostics;

public static class StableSegment
{
    public static (int Start, int Length) LongestStableSegment(
        IReadOnlyList<int> values,
        int maxDifference)
    {
        if (!values.Any()) return (0, 0);

        if (values == null)
        {
            string? paramName = "List of values can't be null.";
            throw new ArgumentNullException(paramName);
        }

        if (maxDifference < 0)
        {
            string? paramName = "Max difference value should be not negative.";
            throw new ArgumentOutOfRangeException(paramName);
        }

        if (values.Count == 1) return (0, 1);

        var dict = new SortedSet<(int Value, int Idx)>();

        for (int i = 0; i < values.Count; ++i)
        {
            dict.Add((values[i], i));
        }

        var max = dict.Last();
        var min = dict.First();
        var count = dict.Count;

        while (Math.Abs((long)max.Value - min.Value) > maxDifference && count > 1)
        {
            --count;
            max = dict.ElementAt(count);
        }

        if (Math.Abs((long)max.Value - min.Value) > maxDifference)
            return (0, 1);

        return (dict.First().Idx, max.Idx - min.Idx + 1);
    }
}