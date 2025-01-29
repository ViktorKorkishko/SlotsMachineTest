namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 
            // tape = [ 0, 1, 2, 3, 4, 5, 6, 7 ]
            // reel = [ -1, -1, -1, -1, -1 ]
            //
            // shift = 3,
            // spot = 3
            // reel = [ 5, 4, 3 ]
            //
            // shift = 6
            // spot = 3
            // reel = [ 0, 7, 6 ]
            
            // var tape = new[] { 0, 1, 2, 3, 4, 5, 6, 7 }; // 8
            // var reel1 = SlotOperations.FillReel(tape, 3, 3);
            // var reel2 = SlotOperations.FillReel(tape, 3, 6);
            
            // Console.WriteLine(string.Join(',', reel1));
            // Console.WriteLine(string.Join(',', reel2));
            // Console.ReadLine();
            
            // reel = [ body, legs, 0, head, body ] // 2
            // reel = [ 0, 1, 0, head, body ] // 1
            // reel = [ 0, head, body, legs, 2 ] // 1
            // reel = [ legs, 1, 4, 6, 2 ] // 0

            int bigSymbolId = 88;
            var reel1 = new[] { 88, 88,  0, 88, 88 };
            var reel2 = new[] {  0,  1,  0, 88, 88 };
            var reel3 = new[] {  0, 88, 88, 88,  2 };
            var reel4 = new[] { 88,  1,  4,  6,  2 };
            
            Console.WriteLine(SlotOperations.GetBigSymbolsCount(reel1, bigSymbolId)); // 2
            Console.WriteLine(SlotOperations.GetBigSymbolsCount(reel2, bigSymbolId)); // 1
            Console.WriteLine(SlotOperations.GetBigSymbolsCount(reel3, bigSymbolId)); // 1
            Console.WriteLine(SlotOperations.GetBigSymbolsCount(reel4, bigSymbolId)); // 0
            
            var bigSymbolParts = new[] { "head", "body", "legs" };
            var parts1 = SlotOperations.DefineBigSymbolsParts(reel1, bigSymbolId, bigSymbolParts);
            var parts2 = SlotOperations.DefineBigSymbolsParts(reel2, bigSymbolId, bigSymbolParts);
            var parts3 = SlotOperations.DefineBigSymbolsParts(reel3, bigSymbolId, bigSymbolParts);
            var parts4 = SlotOperations.DefineBigSymbolsParts(reel4, bigSymbolId, bigSymbolParts);
            
            var reel5 = new[] { 88, 88,  0, 88, 88, 88 };
            var reel6 = new[] {  0,  1,  0, 88, 88, 88 };
            var reel7 = new[] {  0, 88, 88, 88, 88,  2 };
            var reel8 = new[] { 88,  1,  4,  6,  2, 88 };
            
            bigSymbolParts = new[] { "head", "body1", "body2", "legs" };
            var parts5 = SlotOperations.DefineBigSymbolsParts(reel5, bigSymbolId, bigSymbolParts);
            var parts6 = SlotOperations.DefineBigSymbolsParts(reel6, bigSymbolId, bigSymbolParts);
            var parts7 = SlotOperations.DefineBigSymbolsParts(reel7, bigSymbolId, bigSymbolParts);
            var parts8 = SlotOperations.DefineBigSymbolsParts(reel8, bigSymbolId, bigSymbolParts);
            
            
        }
    }
}