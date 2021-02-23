// ======================================
//  Blazor Spread. LHTV
// ======================================
using Markdig;

namespace BZPrism
{
    public static class MarkdownParser
    {
        public static string ParseForPrim(string markdown, bool lineNumbers)
        {
            var pipeline = new MarkdownPipelineBuilder()
                .UseAdvancedExtensions()
                .Build();
            var html = Markdown.ToHtml(markdown, pipeline);

            if (lineNumbers)
                // depends of Prism CSS, JS
                return html.Replace("<pre>", "<pre class=\"line-numbers\">");
            else
                return html;
        }

    }
}
