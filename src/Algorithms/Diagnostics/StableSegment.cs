using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

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

        int c = 0;

        foreach (var item in values)
        {
            dict.Add((item, c));
            c++;
        }

        int start = default;

        (int Value, int Idx) max = default;
        (int Value, int Idx) min = default;

        for (int i = values.Count; i > 1; --i)
        {
            for (int j = 0; j < values.Count - i + 1; j++)
            {
                var newDict = dict

                max = dict.Max();
                min = dict.Min();
                start = j;

                if (Math.Abs((long)max.Value - min.Value) <= maxDifference)
                    break;
            }
        }

        if (Math.Abs((long)max.Value - min.Value) > maxDifference)
            return (0, 1);

        return (start, max.Idx - min.Idx + 1);
    }
}