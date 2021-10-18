using System;

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
                diamond = diamond
                    + Environment.NewLine
                    + GetSpacesBeforeAfter(width, a)
                    + a
                    + GetSpacesBeforeAfter(width, a);
            }
            return diamond;
        }

        private string GetSpacesBeforeAfter(char width, char current)
        {
            var length = ((short)width) - ((short)current);
            return new String(' ', length);
        }
    }
}