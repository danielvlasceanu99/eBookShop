#pragma checksum "D:\Licenta\eBookShop\Views\AuthorDetails\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6c98337684c4999ea0613c43e5c349c5e0f10ea"
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
#line 1 "D:\Licenta\eBookShop\Views\_ViewImports.cshtml"
using EBookShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Licenta\eBookShop\Views\_ViewImports.cshtml"
using EBookShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Licenta\eBookShop\Views\AuthorDetails\Details.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6c98337684c4999ea0613c43e5c349c5e0f10ea", @"/Views/AuthorDetails/Details.cshtml")]
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
#line 2 "D:\Licenta\eBookShop\Views\AuthorDetails\Details.cshtml"
  
    ViewData["Title"] = Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-3\">\r\n");
#nullable restore
#line 10 "D:\Licenta\eBookShop\Views\AuthorDetails\Details.cshtml"
          string srcAuthor = "https://drive.google.com/uc?export=view&id=" + Model.ImageId; 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <img");
            BeginWriteAttribute("src", " src=", 264, "", 279, 1);
#nullable restore
#line 11 "D:\Licenta\eBookShop\Views\AuthorDetails\Details.cshtml"
WriteAttributeValue("", 269, srcAuthor, 269, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mx-auto d-block mt-2\" style=\"width:175px; height:200px\">\r\n    </div>\r\n    <div class=\"col-lg-9\">\r\n        <h4>About ");
#nullable restore
#line 14 "D:\Licenta\eBookShop\Views\AuthorDetails\Details.cshtml"
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
#line 21 "D:\Licenta\eBookShop\Views\AuthorDetails\Details.cshtml"
                                     Write(Model.PlaceAOfBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></h5></td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td class=\"ebs-margin-right\"><h5><small class=\"font-weight-bold\">Date of birth</small></h5></td>\r\n                        <td><h5><small>");
#nullable restore
#line 25 "D:\Licenta\eBookShop\Views\AuthorDetails\Details.cshtml"
                                  Write(Model.DateOfBirth.ToString("dd MMMM yyyy", new CultureInfo("en-UK")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></h5></td>\r\n                    </tr>\r\n");
#nullable restore
#line 27 "D:\Licenta\eBookShop\Views\AuthorDetails\Details.cshtml"
                     if (Model.DateOfDeath != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td class=\"ebs-margin-right\"><h5><small class=\"font-weight-bold\">Date of death</small></h5></td>\r\n                            <td><h5><small>");
#nullable restore
#line 31 "D:\Licenta\eBookShop\Views\AuthorDetails\Details.cshtml"
                                      Write(Model.DateOfDeath.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></h5></td>\r\n                        </tr>\r\n");
#nullable restore
#line 33 "D:\Licenta\eBookShop\Views\AuthorDetails\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <br />\r\n        <div class=\"text-justify\">\r\n            <em>");
#nullable restore
#line 39 "D:\Licenta\eBookShop\Views\AuthorDetails\Details.cshtml"
           Write(Model.ShortDesctiption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em>\r\n        </div>\r\n        <br />\r\n        <br />\r\n        <p class=\"text-uppercase\">");
#nullable restore
#line 43 "D:\Licenta\eBookShop\Views\AuthorDetails\Details.cshtml"
                             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s books</p>\r\n        <div>\r\n");
#nullable restore
#line 45 "D:\Licenta\eBookShop\Views\AuthorDetails\Details.cshtml"
             foreach (Book book in Model.BookList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <hr />\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6c98337684c4999ea0613c43e5c349c5e0f10ea8438", async() => {
                WriteLiteral("\r\n                    <div class=\"media p-3\">\r\n");
#nullable restore
#line 50 "D:\Licenta\eBookShop\Views\AuthorDetails\Details.cshtml"
                          string srcBook = "https://drive.google.com/uc?export=view&id=" + book.ImageId; 

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <img");
                BeginWriteAttribute("src", " src=", 2166, "", 2179, 1);
#nullable restore
#line 51 "D:\Licenta\eBookShop\Views\AuthorDetails\Details.cshtml"
WriteAttributeValue("", 2171, srcBook, 2171, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"align-self-start mr-3\" style=\"width:50px; height:75px\"");
                BeginWriteAttribute("alt", " alt=", 2241, "", 2257, 1);
#nullable restore
#line 51 "D:\Licenta\eBookShop\Views\AuthorDetails\Details.cshtml"
WriteAttributeValue("", 2246, book.Title, 2246, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"media-body\">\r\n                            <h4>");
#nullable restore
#line 53 "D:\Licenta\eBookShop\Views\AuthorDetails\Details.cshtml"
                           Write(book.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n");
#nullable restore
#line 54 "D:\Licenta\eBookShop\Views\AuthorDetails\Details.cshtml"
                             if(book.Rating != 0)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <p class=\"font-weight-bold\">\r\n                                    Rating: ");
#nullable restore
#line 57 "D:\Licenta\eBookShop\Views\AuthorDetails\Details.cshtml"
                                        Write(String.Format("{0:#,##.##}", (float)(book.Rating)));

#line default
#line hidden
#nullable disable
                WriteLiteral("/5\r\n                                    <i class=\"fas fa-book-open\" style=\"color:#111111\"></i>\r\n                                </p>\r\n");
#nullable restore
#line 60 "D:\Licenta\eBookShop\Views\AuthorDetails\Details.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <p class=\"font-weight-bold\">\r\n                                    Rating: 0/5\r\n                                    <i class=\"fas fa-book-open\" style=\"color:#111111\"></i>\r\n                                </p>\r\n");
#nullable restore
#line 67 "D:\Licenta\eBookShop\Views\AuthorDetails\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n                    </div>\r\n                ");
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
#line 48 "D:\Licenta\eBookShop\Views\AuthorDetails\Details.cshtml"
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
#line 71 "D:\Licenta\eBookShop\Views\AuthorDetails\Details.cshtml"

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
