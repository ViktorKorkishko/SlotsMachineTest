using Test;

namespace Tests;

[TestClass]
public class DistinctBigSymbolsCountInSpotTests
{
    private int bigSymbolId = 88;
    
    private readonly string wrongPartsMessage = "Parts are placed wrong";
    
    private readonly string[] bigSymbolParts_3 = ["head", "body", "legs"];
    
    private readonly string[] bigSymbolParts_4 = ["head", "body1", "body2", "legs"];
    
    [TestMethod]
    public void DefineBodyParts_3_0()
    {
        var reel = new[] { 88, 88,  0, 88, 88 };
        var parts = SlotOperations.DefineBigSymbolsParts(reel, bigSymbolId, bigSymbolParts_3);
        var expected = new[] { "body", "legs", "0", "head", "body" };
        CollectionAssert.AreEqual(expected, parts);
    }
    
    [TestMethod]
    public void DefineBodyParts_3_1()
    {
        var reel = new[] {  0,  1,  0, 88, 88 };
        var parts = SlotOperations.DefineBigSymbolsParts(reel, bigSymbolId, bigSymbolParts_3);
        var expected = new[] { "0", "1", "0", "head", "body" };
        CollectionAssert.AreEqual(expected, parts);
    }
    
    [TestMethod]
    public void DefineBodyParts_3_2()
    {
        var reel = new[] {  0, 88, 88, 88,  2 };
        var parts = SlotOperations.DefineBigSymbolsParts(reel, bigSymbolId, bigSymbolParts_3);
        var expected = new[] { "0", "head", "body", "legs", "2" };
        CollectionAssert.AreEqual(expected, parts);
    }
    
    [TestMethod]
    public void DefineBodyParts_3_3()
    {
        var reel = new[] { 88,  1,  4,  6,  2 };
        var parts = SlotOperations.DefineBigSymbolsParts(reel, bigSymbolId, bigSymbolParts_3);
        var expected = new[] { "legs", "1", "4", "6", "2" };
        CollectionAssert.AreEqual(expected, parts);
    }
    
    [TestMethod]
    public void DefineBodyParts_4_0()
    {
        var reel = new[] { 88, 88, 0, 88, 88, 88 };
        var parts = SlotOperations.DefineBigSymbolsParts(reel, bigSymbolId, bigSymbolParts_4);
        var expected = new[] { "body2", "legs", "0", "head", "body1", "body2"};
        CollectionAssert.AreEqual(expected, parts);
    }
    
    [TestMethod]
    public void DefineBodyParts_4_1()
    {
        var reel = new[] { 0, 1, 0, 88, 88, 88 };
        var parts = SlotOperations.DefineBigSymbolsParts(reel, bigSymbolId, bigSymbolParts_4);
        var expected = new[] { "0", "1", "0", "head", "body1", "body2"};
        CollectionAssert.AreEqual(expected, parts);
    }
    
    [TestMethod]
    public void DefineBodyParts_4_2()
    {
        var reel = new[] { 0, 88, 88, 88, 88, 2 };
        var parts = SlotOperations.DefineBigSymbolsParts(reel, bigSymbolId, bigSymbolParts_4);
        var expected = new[] { "0", "head", "body1", "body2", "legs", "2"};
        CollectionAssert.AreEqual(expected, parts);
    }
    
    [TestMethod]
    public void DefineBodyParts_4_3()
    {
        var reel = new[] { 88, 1, 4, 6, 2, 88 };
        var parts = SlotOperations.DefineBigSymbolsParts(reel, bigSymbolId, bigSymbolParts_4);
        var expected = new[] { "legs", "1", "4", "6", "2", "head"};
        CollectionAssert.AreEqual(expected, parts);
    }
}
