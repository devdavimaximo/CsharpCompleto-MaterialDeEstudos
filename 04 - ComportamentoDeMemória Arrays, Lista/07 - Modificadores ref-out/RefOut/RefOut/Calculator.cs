namespace RefOut
{
    internal class Calculator
    {
        public static void Triple(ref int x)
        {
            x = x * 3;
        } // Triple the value of x by reference

        public static void TripleOut (int origin, out int result)
        {
            result = origin * 3;
        }
    }

}
