#pragma checksum "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b58d28b55e7a1dad65557549189ca6edbfc19b43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookDetails_Details), @"mvc.1.0.view", @"/Views/BookDetails/Details.cshtml")]
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
#line 6 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
using EBookShop.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b58d28b55e7a1dad65557549189ca6edbfc19b43", @"/Views/BookDetails/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86d4ec338346d3ccb66fc77fd8ad5bcba04ffdf3", @"/Views/_ViewImports.cshtml")]
    public class Views_BookDetails_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EBookShop.ViewModels.BookDetailesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cols", new global::Microsoft.AspNetCore.Html.HtmlString("89"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("resize:none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Post review"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ReviewCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateReview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("sp-controller", new global::Microsoft.AspNetCore.Html.HtmlString("TODO"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TODO", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AuthorDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration-none text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
  
    ViewData["Title"] = "Book details Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-9\">\r\n        <div class=\"media p-md-2\">\r\n");
#nullable restore
#line 14 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
              string srcBook = "https://drive.google.com/uc?export=view&id=" + "1rC4i3rSX3bYggJq4nDPJfdWCvWdBdixG"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img");
            BeginWriteAttribute("src", " src=", 484, "", 497, 1);
#nullable restore
#line 15 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
WriteAttributeValue("", 489, srcBook, 489, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"align-self-start mr-3 mt-3\" width=\"156\" height=\"212\"");
            BeginWriteAttribute("alt", " alt=", 557, "", 579, 1);
#nullable restore
#line 15 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
WriteAttributeValue("", 562, Model.Book.Title, 562, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"media-body text-justify\">\r\n                <h4 class=\"d-flex justify-content-md-between align-items-md-start\">\r\n                    ");
#nullable restore
#line 18 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
               Write(Model.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <span class=\"badge\">");
#nullable restore
#line 19 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
                                   Write(Model.Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</span>\r\n                </h4>\r\n                <p>by ");
#nullable restore
#line 21 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
                 Write(Model.Book.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h5 class=\"font-weight-bold\">Description:</h5>\r\n                <em>");
#nullable restore
#line 23 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
               Write(Model.Book.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</em>
                <br />
                <br />
                <div>
                    <a href=""#info"" class=""text-decoration-none text-dark font-weight-bold"" data-toggle=""collapse"">More info</a>
                    <div id=""info"" class=""collapse"">
                        <div class=""font-weight-light"">ISBN: ");
#nullable restore
#line 29 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
                                                        Write(Model.Book.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"font-weight-light\">Goodreads rating: ");
#nullable restore
#line 30 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
                                                                    Write(Model.Book.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("/5</div>\r\n                        <div class=\"font-weight-light\">Original language: ");
#nullable restore
#line 31 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
                                                                     Write(Model.Book.OriginalLanguage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                </div>
                <div>
                    <div>
                        <hr />
                        <h5 class=""font-weight-bold"">Preview</h5>
                        <embed frameborder=""1"" scrolling=""no"" width=""480"" height=""610""
                               src=""https://drive.google.com/file/d/1gW1twdVQPD4ZSakNr4-Me4Z4sB14ZCBx/preview"" />
                    </div>
                </div>
                <div>
                    <hr />
                    <h5>
                        ");
#nullable restore
#line 45 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
                   Write(Model.Book.ReviewList.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Reviews\r\n");
#nullable restore
#line 46 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
                         if (@Model.Book.ReviewList.Count == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <small>Be the first to review this book</small>\r\n");
#nullable restore
#line 49 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </h5>\r\n");
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b58d28b55e7a1dad65557549189ca6edbfc19b4315462", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b58d28b55e7a1dad65557549189ca6edbfc19b4315745", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 56 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Review.BookID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
                                                                     WriteLiteral(Model.Book.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b58d28b55e7a1dad65557549189ca6edbfc19b4318164", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 57 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Review.UserID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
                                                                     WriteLiteral(UserManager.GetUserId(User));

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b58d28b55e7a1dad65557549189ca6edbfc19b4320597", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 58 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Review.Text);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "placeholder", 6, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2999, "Write", 2999, 5, true);
                AddHtmlAttributeValue(" ", 3004, "a", 3005, 2, true);
                AddHtmlAttributeValue(" ", 3006, "review", 3007, 7, true);
                AddHtmlAttributeValue(" ", 3013, "about", 3014, 6, true);
#nullable restore
#line 58 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
AddHtmlAttributeValue(" ", 3019, Model.Book.Title, 3020, 17, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 3037, "...", 3037, 3, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
                         if (SignInManager.IsSignedIn(User))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <div class=""d-flex justify-content-end"">
                                <input id=""submit"" type=""submit"" value=""Post review"" class=""btn btn-secondary"" onclick=""() => { console.log('mere') }"" />
                            </div>
");
#nullable restore
#line 64 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"d-flex justify-content-end\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b58d28b55e7a1dad65557549189ca6edbfc19b4324196", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Area = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Page = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 70 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    <br />\r\n                    <hr />\r\n");
#nullable restore
#line 76 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
                     foreach (Review review in Model.Book.ReviewList)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"media\">\r\n");
#nullable restore
#line 79 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
                              string srcUser = "https://drive.google.com/uc?export=view&id=" + "1qT1rVtWGshdNr2ZhSQgSoaT-6xSYodHz"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("src", " src=", 4209, "", 4222, 1);
#nullable restore
#line 80 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
WriteAttributeValue("", 4214, srcUser, 4214, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"align-self-start mr-3\" style=\"width:60px; height:60px\">\r\n                            <div class=\"media-body\">\r\n                                <h5>");
#nullable restore
#line 82 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
                               Write(review.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 82 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
                                                      Write(review.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p>");
#nullable restore
#line 83 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
                              Write(review.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 86 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-3\">\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b58d28b55e7a1dad65557549189ca6edbfc19b4329985", async() => {
                WriteLiteral("\r\n                <button class=\"btn btn-secondary btn-lg btn-block\">\r\n                    Get the book\r\n                </button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <hr />\r\n        </div>\r\n        <h5>Genres</h5>\r\n");
#nullable restore
#line 102 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
         foreach (GenreToBookAssociation g in Model.Book.GenreList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"badge badge-secondary\">");
#nullable restore
#line 104 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
                                           Write(g.Genre.GenreName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 105 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <hr />\r\n        <p class=\"text-uppercase\">About ");
#nullable restore
#line 108 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
                                   Write(Model.Book.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        <div class=\"ebs-author-card text-justify\">\r\n");
#nullable restore
#line 111 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
              string srcAuthor = "https://drive.google.com/uc?export=view&id=" + "1qT1rVtWGshdNr2ZhSQgSoaT-6xSYodHz"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img");
            BeginWriteAttribute("src", " src=", 5432, "", 5447, 1);
#nullable restore
#line 112 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
WriteAttributeValue("", 5437, srcAuthor, 5437, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mx-auto d-block\" style=\"width:150px; height:150px\">\r\n            <div>\r\n                <h5>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b58d28b55e7a1dad65557549189ca6edbfc19b4333862", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 116 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
                   Write(Model.Book.Author.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_15.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_16.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_16);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 115 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
                                                                             WriteLiteral(Model.Book.Author.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_17);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </h5>\r\n                <em class=\"small\">");
#nullable restore
#line 119 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
                             Write(Model.Book.Author.ShortDesctiption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n    <script>\r\n    document.addEventListener(\"DOMContentLoaded\", () => {\r\n        if (\"");
#nullable restore
#line 128 "C:\Users\danie\Desktop\eBookShop\Views\BookDetails\Details.cshtml"
        Write(UserManager.GetUserId(User));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" !== """") {
            let tArea = document.getElementById(""text"");
            let subButton = document.getElementById(""submit"")
            subButton.disabled = true;
            tArea.oninput = () => {
                console.log(""merge"")
                if (tArea.value === """") {
                    subButton.disabled = true;
                }
                else {
                    subButton.disabled = false;
                }
            }
        }
    })
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EBookShop.ViewModels.BookDetailesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
