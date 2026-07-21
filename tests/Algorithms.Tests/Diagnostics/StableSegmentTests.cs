using Algorithms.Diagnostics;
using Xunit;

namespace Algorithms.Tests.Diagnostics;

public class StableSegmentTests
{
    [Fact]
    public void MaxSegmentLengthIsOne()
    {
        var list = new List<int> { 1, 2, 3, 4, 5 };
        var diff = 1;

        var maxmin = StableSegment.LongestStableSegment(list, diff);

        Assert.Equal(maxmin, (0, 5));
    }
}