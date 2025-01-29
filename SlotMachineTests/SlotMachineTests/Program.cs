namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // all tests are in Tests project
            
            /////////////////////////////////////////////////////////
            
            // tape = [ 0, 1, 2, 3, 4, 5, 6, 7 ]
            // reel = [ -1, -1, -1, -1, -1 ]
            // 
            // shift = 3,
            // spot = 3
            // expected reel = [ 5, 4, 3 ]
            // 
            // shift = 6
            // spot = 3
            // expected reel = [ 0, 7, 6 ]
            
            /////////////////////////////////////////////////////////
            
            // reel = [ body, legs, 0, head, body ]     // expected 2
            // reel = [ 0, 1, 0, head, body ]           // expected 1
            // reel = [ 0, head, body, legs, 2 ]        // expected 1
            // reel = [ legs, 1, 4, 6, 2 ]              // expected 0
            
            /////////////////////////////////////////////////////////
            
            // reel = [ 88, 88, 0, 88, 88 ]             // expected [ body, legs, 0, head, body ]
            // reel = [ 0, 1, 0, 88, 88 ]               // expected [ 0, 1, 0, head, body ]
            // reel = [ 0, 88, 88, 88, 2 ]              // expected [ 0, head, body, legs, 2 ]
            // reel = [ 88, 1, 4, 6, 2 ]                // expected [ legs, 1, 4, 6, 2 ]
            
            /////////////////////////////////////////////////////////
        }
    }
}