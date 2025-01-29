using Test;

namespace Tests;

[TestClass]
public class BigSymbolsPartsTests
{
    private int bigSymbolId = 88;
    
    private readonly string wrongCountMessage = "Count is wrong";
    
    [TestMethod]
    public void TestSymbolsCount_Returns0()
    {
        var reel = new[] { bigSymbolId,  1,  4,  6,  2 };
        var count = SlotOperations.GetDistinctBigSymbolsCountInSpot(reel, bigSymbolId);
        Assert.AreEqual(0, count, wrongCountMessage);
    }
    
    [TestMethod]
    public void TestSymbolsCount_Returns1_0()
    {
        var reel = new[] {  0,  1,  0, bigSymbolId, bigSymbolId };
        var count = SlotOperations.GetDistinctBigSymbolsCountInSpot(reel, bigSymbolId);
        Assert.AreEqual(1, count, wrongCountMessage);
    }
    
    [TestMethod]
    public void TestSymbolsCount_Returns1_1()
    {
        var reel = new[] {  0, bigSymbolId, bigSymbolId, bigSymbolId,  2 };
        var count = SlotOperations.GetDistinctBigSymbolsCountInSpot(reel, bigSymbolId);
        Assert.AreEqual(1, count, wrongCountMessage);
    }
    
    [TestMethod]
    public void TestSymbolsCount_Returns2()
    {
        
        var reel = new[] { bigSymbolId, bigSymbolId,  0, bigSymbolId, bigSymbolId };
        var count = SlotOperations.GetDistinctBigSymbolsCountInSpot(reel, bigSymbolId);
        Assert.AreEqual(2, count, wrongCountMessage);
    }
}