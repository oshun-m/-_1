using System.Globalization;

namespace Практика_1
{
    internal static class ParseUtil
    {
        public static bool TryParseDoubleFlexible(string text, out double value)
        {
            value = 0;

            if (text == null) return false;
            text = text.Trim();
            if (text.Length == 0) return false;

            if (double.TryParse(text, NumberStyles.Float, CultureInfo.CurrentCulture, out value))
                return true;

            if (double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out value))
                return true;

            string normalized = text.Replace(',', '.');
            if (double.TryParse(normalized, NumberStyles.Float, CultureInfo.InvariantCulture, out value))
                return true;

            return false;
        }
    }
}
