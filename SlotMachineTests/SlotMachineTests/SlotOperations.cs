namespace Test

{
    public static class SlotOperations
    {
        public static int[] FillReel(int[] tape, int spot, int shift)
        {
            int[] result = new int[spot];
            int startIndex = spot + shift - 1;
            if (startIndex >= tape.Length)
            {
                startIndex -= tape.Length;
            }

            for (int i = 0; i < spot; i++)
            {
                int tapeIndex = startIndex - i;
                
                if (tapeIndex < 0)
                {
                    tapeIndex = tape.Length - i;
                }
                
                var tapeElement = tape[tapeIndex];
                result[i] = tapeElement;
            }
            
            return result;
        }
        
        public static int GetBigSymbolsCount(int[] reel, int bigSymbolId)
        {
            int bigSymbolsCount = 0;
            
            for (int i = 1; i < reel.Length - 1; i++)
            {
                var spotElement = reel[i];
                if (spotElement == bigSymbolId)
                {
                    bigSymbolsCount++;
                }
            }
            
            if (bigSymbolsCount == reel.Length - 2)
            {
                return 1;
            }
            
            return bigSymbolsCount;
        }
        
        public static string[] DefineBigSymbolsParts(int[] reel, int bigSymbolId, string[] bigSymbolParts)
        {
            var result = new string[reel.Length];

            int nextSymbolIndex = 1;
            int bigSymbolsCountInARow = 0;
            for (int i = 0; i < reel.Length; i++)
            {
                var elementId = reel[i];
                if (elementId == bigSymbolId)
                {
                    bigSymbolsCountInARow++;

                    if (reel.IsInRange(nextSymbolIndex))
                    {
                        if (reel[nextSymbolIndex] != bigSymbolId)
                        {
                            CompleteSymbol(i);
                        }
                    }
                    else
                    {
                        CompleteSymbol(i);
                    }
                }
                else
                {
                    result[i] = elementId.ToString();
                    bigSymbolsCountInARow = 0;
                }
                
                nextSymbolIndex++;
            }

            return result;

            void CompleteSymbol(int currentIndex)
            {
                int startIndex = 0;
                if (currentIndex < bigSymbolsCountInARow)
                {
                    startIndex = bigSymbolParts.Length - bigSymbolsCountInARow;
                }
                
                for (int j = 0; j < bigSymbolsCountInARow; j++)
                {
                    var bigSymbolPart = bigSymbolParts[startIndex + j];
                    result[currentIndex - bigSymbolsCountInARow + j + 1] = bigSymbolPart;
                }
            }
        }

        public static bool IsInRange(this int[] array, int i)
        {
            bool inRange = i >= 0 && i < array.Length;
            return inRange;
        }
    }
}