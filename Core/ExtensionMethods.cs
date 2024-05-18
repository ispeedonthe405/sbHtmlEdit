using System.Windows.Media;

namespace sbHtmlEdit.Core
{
    public static class ExtensionMethods
    {
        public static Color FromJavascriptRGB(this Color incolor, string rgb)
        {
            Color color = new();

            if (rgb.Trim().StartsWith("rgb("))
            {
                try
                {
                    int start = rgb.IndexOf('(') + 1;
                    int end = rgb.IndexOf(')');
                    int substringLength = end - start;
                    string working = rgb.Substring(start, substringLength);
                    string[] values = working.Split(",", StringSplitOptions.TrimEntries);
                    if (values.Length == 3)
                    {
                        color.R = Convert.ToByte(values[0]);
                        color.G = Convert.ToByte(values[1]);
                        color.B = Convert.ToByte(values[2]);
                    }
                }
                catch (Exception ex)
                {
                    Logger.LogException(ex);
                }
            }

            return color;
        }
    }
}
