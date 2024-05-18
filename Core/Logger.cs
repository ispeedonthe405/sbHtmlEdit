using System.Diagnostics;

namespace sbHtmlEdit.Core
{
    public static class Logger
    {
        public static void LogException(Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }
    }
}
