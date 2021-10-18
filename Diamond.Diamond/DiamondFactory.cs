namespace Diamond.Diamond
{
    /**
    * NOT an actual factory pattern, just to avoid the namespace collision
    */
    public class DiamondFactory
    {
        public string PrintDiamond(char width)
        {
            if (width == 'A') return "A";
            var diamond = "";

            for (char a = 'A'; a < width; a++)
            {
                diamond = diamond + a;
            }
            return diamond;
        }
    }
}