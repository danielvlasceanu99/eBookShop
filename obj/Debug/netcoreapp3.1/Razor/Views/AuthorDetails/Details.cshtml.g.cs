#pragma checksum "C:\Users\danie\Desktop\eBookShop\Views\AuthorDetails\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33a33c711a2e6aa7fc29883e2aed491fb310ca10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AuthorDetails_Details), @"mvc.1.0.view", @"/Views/AuthorDetails/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\danie\Desktop\eBookShop\Views\_ViewImports.cshtml"
using EBookShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danie\Desktop\eBookShop\Views\_ViewImports.cshtml"
using EBookShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\danie\Desktop\eBookShop\Views\AuthorDetails\Details.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33a33c711a2e6aa7fc29883e2aed491fb310ca10", @"/Views/AuthorDetails/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86d4ec338346d3ccb66fc77fd8ad5bcba04ffdf3", @"/Views/_ViewImports.cshtml")]
    public class Views_AuthorDetails_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EBookShop.Models.Author>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BookDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration-none text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\danie\Desktop\eBookShop\Views\AuthorDetails\Details.cshtml"
  
    ViewData["Title"] = "Author details Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-3\">\r\n");
#nullable restore
#line 10 "C:\Users\danie\Desktop\eBookShop\Views\AuthorDetails\Details.cshtml"
          string srcAuthor = "https://drive.google.com/uc?export=view&id=" + "1qT1rVtWGshdNr2ZhSQgSoaT-6xSYodHz"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <img");
            BeginWriteAttribute("src", " src=", 297, "", 312, 1);
#nullable restore
#line 11 "C:\Users\danie\Desktop\eBookShop\Views\AuthorDetails\Details.cshtml"
WriteAttributeValue("", 302, srcAuthor, 302, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mx-auto d-block\" style=\"width:200px; height:200px\">\r\n    </div>\r\n    <div class=\"col-lg-9\">\r\n        <h4>About ");
#nullable restore
#line 14 "C:\Users\danie\Desktop\eBookShop\Views\AuthorDetails\Details.cshtml"
             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
        <hr />
        <div>
            <table>
                <tbody class=""table-borderless"">
                    <tr>
                        <td class=""ebs-margin-right""><h5><small class=""font-weight-bold"">Place of birth</small></h5></td>
                        <td><h5><small>in ");
#nullable restore
#line 21 "C:\Users\danie\Desktop\eBookShop\Views\AuthorDetails\Details.cshtml"
                                     Write(Model.PlaceAOfBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></h5></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td class=\"ebs-margin-right\"><h5><small class=\"font-weight-bold\">Date of birth</small></h5></td>\r\n                        <td><h5><small>");
#nullable restore
#line 25 "C:\Users\danie\Desktop\eBookShop\Views\AuthorDetails\Details.cshtml"
                                  Write(Model.DateOfBirth.ToString("dd MMMM yyyy", new CultureInfo("en-UK")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></h5></td>\r\n                    </tr>\r\n");
#nullable restore
#line 27 "C:\Users\danie\Desktop\eBookShop\Views\AuthorDetails\Details.cshtml"
                     if (Model.DateOfDeath != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td class=\"ebs-margin-right\"><h5><small class=\"font-weight-bold\">Date of death</small></h5></td>\r\n                            <td><h5><small>");
#nullable restore
#line 31 "C:\Users\danie\Desktop\eBookShop\Views\AuthorDetails\Details.cshtml"
                                      Write(Model.DateOfDeath.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></h5></td>\r\n                        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\danie\Desktop\eBookShop\Views\AuthorDetails\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <br />\r\n        <div class=\"text-justify\">\r\n            <em>");
#nullable restore
#line 39 "C:\Users\danie\Desktop\eBookShop\Views\AuthorDetails\Details.cshtml"
           Write(Model.ShortDesctiption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em>\r\n        </div>\r\n        <br />\r\n        <br />\r\n        <p class=\"text-uppercase\">");
#nullable restore
#line 43 "C:\Users\danie\Desktop\eBookShop\Views\AuthorDetails\Details.cshtml"
                             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s books</p>\r\n        <div>\r\n");
#nullable restore
#line 45 "C:\Users\danie\Desktop\eBookShop\Views\AuthorDetails\Details.cshtml"
             foreach (Book book in Model.BookList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <hr />\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33a33c711a2e6aa7fc29883e2aed491fb310ca108658", async() => {
                WriteLiteral("\r\n                    <div class=\"media p-3\">\r\n");
#nullable restore
#line 50 "C:\Users\danie\Desktop\eBookShop\Views\AuthorDetails\Details.cshtml"
                          string srcBook = "https://drive.google.com/uc?export=view&id=" + "1rC4i3rSX3bYggJq4nDPJfdWCvWdBdixG"; 

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <img");
                BeginWriteAttribute("src", " src=", 2217, "", 2230, 1);
#nullable restore
#line 51 "C:\Users\danie\Desktop\eBookShop\Views\AuthorDetails\Details.cshtml"
WriteAttributeValue("", 2222, srcBook, 2222, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"align-self-start  mr-3\" style=\"width:50px; height:75px\"");
                BeginWriteAttribute("alt", " alt=", 2293, "", 2309, 1);
#nullable restore
#line 51 "C:\Users\danie\Desktop\eBookShop\Views\AuthorDetails\Details.cshtml"
WriteAttributeValue("", 2298, book.Title, 2298, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"media-body\">\r\n                            <h4>");
#nullable restore
#line 53 "C:\Users\danie\Desktop\eBookShop\Views\AuthorDetails\Details.cshtml"
                           Write(book.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                            <p class=\"font-weight-bold\">Goodreads rating: ");
#nullable restore
#line 54 "C:\Users\danie\Desktop\eBookShop\Views\AuthorDetails\Details.cshtml"
                                                                     Write(book.Rating);

#line default
#line hidden
#nullable disable
                WriteLiteral("/5</p>\r\n                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\danie\Desktop\eBookShop\Views\AuthorDetails\Details.cshtml"
                                                                       WriteLiteral(book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\Users\danie\Desktop\eBookShop\Views\AuthorDetails\Details.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EBookShop.Models.Author> Html { get; private set; }
    }
}
#pragma warning restore 1591
