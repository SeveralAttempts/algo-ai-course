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

        var dict = new Dictionary<int, int>(values.Count);

        for (int i = values.Count; i > 1; --i)
        {
            int iterCount = 0;

            for (int j = 0; j < values.Count - i + 1; j++)
            {
                var tmp = values.Skip(j).Take(i);
                var max = tmp.Max();
                var min = tmp.Min();

                if (Math.Abs((long)max - min) <= maxDifference)
                {
                    dict.Add(j, i);
                    iterCount++;
                }
            }

            if (iterCount > 0) break;
        }

        if (dict.Count > 1)
        {
            var res = dict.MinBy(x => x.Key);
            return (res.Key, res.Value);
        }

        if (dict.Count == 0) return (0, 1);

        return (dict.First().Key, dict.First().Value);
    }
}