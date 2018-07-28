using System;

namespace CSC479_A1.Helpers
{
    public static class RandomNumberHelper
    {
        // Random Number Generator objects
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();

        //Function to get a synchronized random number 
        public static int RandomNumber(int min, int max)
        {
            // Using lock to fix issues with random and fast loops
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }
    }
}