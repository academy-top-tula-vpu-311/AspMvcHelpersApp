using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Encodings.Web;

namespace AspMvcHelpersApp.Helpers
{
    public static class UnorderListHelper
    {
        public static HtmlString CreateList(this IHtmlHelper html, string[] items)
        {
            //string result = "<ul>";
            //foreach (var item in items)
            //{
            //    result += $"<li>{item}</li>";
            //}
            //result += "</ul>";

            TagBuilder listUnorder = new TagBuilder("ul");
            foreach (var item in items)
            {
                TagBuilder listItem = new TagBuilder("li");
                listItem.InnerHtml.Append(item);
                listUnorder.InnerHtml.AppendHtml(listItem);
            }

            listUnorder.Attributes.Add("class", "red-text");
            using(StringWriter writer = new StringWriter())
            {
                listUnorder.WriteTo(writer, HtmlEncoder.Default);
                return new HtmlString(writer.ToString());
            }


            //return new HtmlString(result);
        }
    }
}
