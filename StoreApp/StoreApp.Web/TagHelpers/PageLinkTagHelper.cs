using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using StoreApp.Web.Models;

namespace StoreApp.Web.TagHelpers
{
    [HtmlTargetElement("div", Attributes ="page-model")]
    public class PageLinkTagHelper:TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;

        public PageLinkTagHelper(IUrlHelperFactory _urlHelperFactory)
        {
            urlHelperFactory = _urlHelperFactory;
            
        }
        [ViewContext]
        public ViewContext? ViewContext { get; set; }
        public SayfaBilgisi? PageModel { get; set; }
        public string? PageAction { get; set; }
        public string PageClass { get; set; } = string.Empty;
        public string PageClassLink { get; set; } = string.Empty;
        public string PageClassActive { get; set; } = string.Empty;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if(ViewContext != null && PageModel != null)
            {
               IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
                TagBuilder div = new TagBuilder("div");
                for(var i =1; i<= PageModel.ToplamSayfa; i++)
                {
                    TagBuilder tagBuilder = new TagBuilder("a");
                    tagBuilder.Attributes["href"] = urlHelper.Action(PageAction, new {page = i});
                    tagBuilder.AddCssClass(PageClass);
                    tagBuilder.AddCssClass(i ==PageModel.CurrentPage ? PageClassActive : PageClass);
                    tagBuilder.InnerHtml.Append(i.ToString());
                    div.InnerHtml.AppendHtml(tagBuilder);
                }
                output.Content.AppendHtml(div.InnerHtml);
                 
            }
        }
    }
}
