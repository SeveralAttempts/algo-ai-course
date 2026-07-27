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
        if (values == null)
        {
            string? paramName = $"values";
            throw new ArgumentNullException(paramName);
        }

        if (maxDifference < 0)
        {
            string? paramName = $"maxDifference";
            throw new ArgumentOutOfRangeException(paramName);
        }

        if (!values.Any()) return (0, 0);

        if (values.Count == 1) return (0, 1);

        var dict = new SortedSet<(int Value, int Idx)>();

        int right = -1; 
        int left = 0;

        (int Idx, int Len) bestValue = new (0, 0);

        bool accept = true;

        while (right < values.Count - 1)
        {
            if (accept)
            {
                right++;
                dict.Add((values[right], right));
            }
            else
            {
                dict.Remove((values[left], left));
                left++;
            }

            if (Math.Abs((long)dict.Max.Value - dict.Min.Value) > maxDifference)
            {
                if (bestValue.Len >= right - left + 1)
                {
                    accept = true;
                    continue;
                }
                accept = false;
                continue;
            }

            if (bestValue.Len >= right - left + 1)
            {
                accept = true;
                continue;
            }

            bestValue = new (left, right - left + 1);
            accept = true;
        }

        return bestValue;
    }
}