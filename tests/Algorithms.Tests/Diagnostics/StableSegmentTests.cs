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

        Assert.Equal(maxmin, (0, 2));
    }

    [Fact]
    public void OverflowCheck()
    {
        var list = new List<int> { int.MaxValue, int.MinValue };
        var diff = 1;

        var maxmin = StableSegment.LongestStableSegment(list, diff);

        Assert.Equal(maxmin, (0, 1));
    }

    [Fact]
    public void NoSegments()
    {
        var list = new List<int> { 8, 2, 10 };
        var diff = 1;

        var maxmin = StableSegment.LongestStableSegment(list, diff);

        Assert.Equal(maxmin, (0, 1));
    }

    [Fact]
    public void SegmentInTheEnd()
    {
        var list = new List<int> { 16, 200, 83, 7, 14, 21 };
        var diff = 7;

        var maxmin = StableSegment.LongestStableSegment(list, diff);

        Assert.Equal(maxmin, (3, 2));
    }

    [Fact]
    public void ListIsEmty()
    {
        var list = new List<int> { };
        var diff = 100;

        var maxmin = StableSegment.LongestStableSegment(list, diff);

        Assert.Equal(maxmin, (0, 0));
    }

    [Fact]
    public void HasSegmentWithNegativeValues()
    {
        var list = new List<int> { 7, 2, -3, 2, 17 };
        var diff = 5;

        var maxmin = StableSegment.LongestStableSegment(list, diff);

        Assert.Equal(maxmin, (1, 3));
    }

    [Fact]
    public void MoreThanOneSegment()
    {
        var list = new List<int> { 1, 100, 500, 1200, 0, 79, 90, 15, 1040, 203 };
        var diff = 99;

        var maxmin = StableSegment.LongestStableSegment(list, diff);

        Assert.Equal(maxmin, (4, 4));
    }

    [Fact]
    public void TwoEqualSegmentsInARow()
    {
        var list = new List<int> { 5, 14, 23, 0, 9, 18 };
        var diff = 9;

        var maxmin = StableSegment.LongestStableSegment(list, diff);

        Assert.Equal(maxmin, (0, 2));
    }

    [Fact]
    public void TwoEqualSegmentsAfterSpaceElement()
    {
        var list = new List<int> { 0, 9, 18, 130, 5, 14, 23 };
        var diff = 18;

        var maxmin = StableSegment.LongestStableSegment(list, diff);

        Assert.Equal(maxmin, (0, 3));
    }

    [Fact]
    public void ThrowsArgumentOutOfRangeException()
    {
        List<int> list = new List<int> { 0, 9, 18, 13, 5, 14, 23 };
        var diff = -1;

        var e = Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            StableSegment.LongestStableSegment(list, diff);
        });
        Assert.Equal("maxDifference", e.ParamName);
    }

    [Fact]
    public void NeedToCheckMinAndMax()
    {
        List<int> list = new List<int> { 5, 10, 0 };
        var diff = 5;

        var maxmin = StableSegment.LongestStableSegment(list, diff);

        Assert.Equal(maxmin, (0, 2));
    }

    [Fact]
    public void NullWithPositive()
    {
        var diff = 100;

        var e = Assert.Throws<ArgumentNullException>(() =>
        {
            StableSegment.LongestStableSegment(null!, diff);
        });
        Assert.Equal("values", e.ParamName);
    }

    [Fact]
    public void NullWithNegative()
    {
        var diff = -1;

        var e = Assert.Throws<ArgumentNullException>(() =>
        {
            StableSegment.LongestStableSegment(null!, diff);
        });
        Assert.Equal("values", e.ParamName);
    }

    [Fact]
    public void EmptyWithNegative()
    {
        var diff = -1;

        var e = Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            StableSegment.LongestStableSegment(new List<int>(), diff);
        });
        Assert.Equal("maxDifference", e.ParamName);
    }
}