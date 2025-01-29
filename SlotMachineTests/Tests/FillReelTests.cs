using Test;

namespace Tests;

[TestClass]
public class FillReelTests
{
    private readonly int[] tape = [0, 1, 2, 3, 4, 5, 6, 7]; // 8
    
    [TestMethod]
    public void FillReel_0()
    {
        var expected = new[] { 5, 4, 3 };
        var reel = SlotOperations.FillReel(tape, 3, 3);
        CollectionAssert.AreEqual(expected, reel);
    }
    
    [TestMethod]
    public void FillReel_1()
    {
        var expected = new[] { 0, 7, 6 };
        var reel = SlotOperations.FillReel(tape, 3, 6);
        CollectionAssert.AreEqual(expected, reel);
    }
}