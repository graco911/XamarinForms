using Xamarin.Forms;

namespace App1.Utils
{
    public static class Helper
    {
        public static FormattedString CreateFormattedString(Span[] texts)
        {
            var formattedText = new FormattedString();

            foreach (var item in texts)
            {
                formattedText.Spans.Add(item);
            }
            return formattedText;
        }
    }
}
