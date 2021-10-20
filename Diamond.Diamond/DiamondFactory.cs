using System;

namespace Diamond.Diamond
{
    /**
    * NOT an actual factory pattern, just to avoid the namespace collision
    */
    public class DiamondFactory
    {
        const char A = 'A';
        const char WHITESPACE = ' ';

        /// <returns>
        /// A string representation of a diamond.
        /// </returns>
        public string PrintDiamond(char width)
        {
            var upper = string.Empty;
            var lower = string.Empty;

            for (char curr = A; curr < width + 1; curr++)
            {
                upper = upper + GetRow(width, curr);
                if (curr != width)
                {
                    lower = GetRow(width, curr) + lower;
                }
            }
            return upper + lower;
        }

        /// <returns>
        /// A diamond row with necessary spacing.
        /// </returns>
        private string GetRow(char width, char current)
        {
            var spacesBeforeAfter = GetWhiteSpaceBeforeAfter(width, current);
            if (current == A)
                return Environment.NewLine
                        + spacesBeforeAfter
                        + current
                        + spacesBeforeAfter;

            var spacesBetween = GetWhiteSpaceBetween(current);

            return Environment.NewLine
                    + spacesBeforeAfter
                    + current
                    + spacesBetween
                    + current
                    + spacesBeforeAfter;
        }
        /// <returns>
        /// Spaces that are used before and after the current diamond character.
        /// </returns>
        private string GetWhiteSpaceBeforeAfter(char width, char current)
        {
            var length = ((short)width) - ((short)current);
            return new String(WHITESPACE, length);
        }
        /// <summary>
        /// e.g.: spaces in between for row with 'C' ((67 - 65) * 2) - 1 = 3 
        /// </summary>
        /// <returns>
        /// Spaces that are in between the current diamond character.
        /// </returns>
        private string GetWhiteSpaceBetween(char current)
        {
            var length = ((((short)current) - ((short)A)) * 2) - 1;
            return length <= 0 ? String.Empty : new String(WHITESPACE, length);
        }
    }
}