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

            for (char curr = 'A'; curr < width + 1; curr++)
            {
                diamond = diamond + GetRow(width, curr);
            }
            return diamond;
        }
        private string GetRow(char width, char current)
        {
            var spacesBeforeAfter = GetSpacesBeforeAfter(width, current);
            if (current == 'A') return spacesBeforeAfter + current + spacesBeforeAfter;
            var spacesBetween = GetSpacesBetween(current);
            return Environment.NewLine + spacesBeforeAfter + current + spacesBetween + current + spacesBeforeAfter;
        }
        private string GetSpacesBeforeAfter(char width, char current)
        {
            var length = ((short)width) - ((short)current);
            return new String(' ', length);
        }
        private string GetSpacesBetween(char current)
        {
            char a = 'A';
            var length = ((((short)current) - ((short)a)) * 2) - 1;
            return length <= 0 ? "" : new String(' ', length);
        }
    }
}