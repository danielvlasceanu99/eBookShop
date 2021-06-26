#pragma checksum "D:\AN_3_SEM_2\Licenta\eBookShop\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8800fb47427a1b0cd1f6c50f77455cfa2d79222a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "D:\AN_3_SEM_2\Licenta\eBookShop\Views\_ViewImports.cshtml"
using EBookShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AN_3_SEM_2\Licenta\eBookShop\Views\_ViewImports.cshtml"
using EBookShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8800fb47427a1b0cd1f6c50f77455cfa2d79222a", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86d4ec338346d3ccb66fc77fd8ad5bcba04ffdf3", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EBookShop.ViewModels.AdminViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\AN_3_SEM_2\Licenta\eBookShop\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Admin page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <div id=""plotOned"" class=""col-md-12""></div>
    <hr />
    <div id=""plotWishlist"" class=""col-md-12""></div>
    <hr />
    <div id=""plotCart"" class=""col-md-12""></div>
    <hr />
    <div class=""col-md-12"">
        <button type=""button"" class=""btn btn-primary"" id=""download"">Download as CSV</button>
    </div>
    <br />
    <div class=""col-md-12"">
        <table class=""table table-hover"">
            <thead class=""thead-light"">
                <tr>
                    <th>Title</th>
                    <th>Number of copies sold</th>
                    <th>Number of copies in wishlist</th>
                    <th>Number of copies in cart</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 28 "D:\AN_3_SEM_2\Licenta\eBookShop\Views\Admin\Index.cshtml"
                 for (int i = 0; i < Model.Titles.Count; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 31 "D:\AN_3_SEM_2\Licenta\eBookShop\Views\Admin\Index.cshtml"
                       Write(Model.Titles[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "D:\AN_3_SEM_2\Licenta\eBookShop\Views\Admin\Index.cshtml"
                       Write(Model.OwnedNo[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "D:\AN_3_SEM_2\Licenta\eBookShop\Views\Admin\Index.cshtml"
                       Write(Model.WishlistNo[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "D:\AN_3_SEM_2\Licenta\eBookShop\Views\Admin\Index.cshtml"
                       Write(Model.CartNo[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 36 "D:\AN_3_SEM_2\Licenta\eBookShop\Views\Admin\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n            <tfoot style=\"background-color: #e9ecef;\" class=\"shadow\">\r\n");
#nullable restore
#line 39 "D:\AN_3_SEM_2\Licenta\eBookShop\Views\Admin\Index.cshtml"
                  
                    double ownedSum = Model.Prices.Select((n, i) => n * Model.OwnedNo[i]).Sum();
                    double wishlistSum = Model.Prices.Select((n, i) => n * Model.WishlistNo[i]).Sum();
                    double cartSum = Model.Prices.Select((n, i) => n * Model.CartNo[i]).Sum();
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"font-weight-bold\">Revenue(recived or to get)</td>\r\n                    <td class=\"font-weight-bold\">$");
#nullable restore
#line 46 "D:\AN_3_SEM_2\Licenta\eBookShop\Views\Admin\Index.cshtml"
                                              Write(String.Format("{0:##,##}", ownedSum));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"font-weight-bold\">$");
#nullable restore
#line 47 "D:\AN_3_SEM_2\Licenta\eBookShop\Views\Admin\Index.cshtml"
                                              Write(String.Format("{0:##,##}", wishlistSum));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"font-weight-bold\">$");
#nullable restore
#line 48 "D:\AN_3_SEM_2\Licenta\eBookShop\Views\Admin\Index.cshtml"
                                              Write(String.Format("{0:##,##}", cartSum));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n            </tfoot>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("AdminScript", async() => {
                WriteLiteral("\r\n    <script>\r\n        document.addEventListener(\"DOMContentLoaded\", function () {\r\n            var data = ");
#nullable restore
#line 58 "D:\AN_3_SEM_2\Licenta\eBookShop\Views\Admin\Index.cshtml"
                  Write(Html.Raw(Json.Serialize(Model)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

            bougthChart(data);
            wishlistChart(data);
            cartNoChart(data);
            console.log(data);

            document.getElementById(""download"").onclick = function downloadData() {
                let csvContent = ""data:text/csv;charset=utf-8,"";
                for (var i = 0; i < data.titles.length; i++) {
                    csvContent += data.titles[i] + "","" + data.ownedNo[i] + "",""
                        + data.wishlistNo[i] + "","" + data.cartNo[i] + "",\n""; 
                }
                console.log(csvContent);
                var encodedUri = encodeURI(csvContent);
                var link = document.createElement(""a"");
                link.setAttribute(""href"", encodedUri);
                link.setAttribute(""download"", ""data.csv"");
                document.body.appendChild(link);
                link.click();
            }

        });

        function bougthChart(data) {
            let titles = Array.from(data.titles);
            let owne");
                WriteLiteral(@"dNo = Array.from(data.ownedNo);

            for (var i = 0; i < titles.length; i++) {
                if (ownedNo[i] == 0) {
                    titles.splice(i, 1);
                    ownedNo.splice(i, 1);
                    i--;
                }
            }
            var values = [{
                x: titles,
                y: ownedNo,
                type: ""bar""
            }];
            var layout = {
                title: ""Number of copies bought"",
            };
            Plotly.newPlot(""plotOned"", values, layout);
        }
        function wishlistChart(data) {
            let titles = Array.from(data.titles);
            let wishlistNo = Array.from(data.wishlistNo);

            for (var i = 0; i < titles.length; i++) {
                if (wishlistNo[i] == 0) {
                    titles.splice(i, 1);
                    wishlistNo.splice(i, 1);
                    i--;
                }
            }
            var values = [{
                x: titles,
                WriteLiteral(@"
                y: wishlistNo,
                type: ""bar""
            }];
            var layout = {
                title: ""Number of copies in wishlist"",
            };
            Plotly.newPlot(""plotWishlist"", values, layout);
        }
        function cartNoChart(data) {
            let titles = Array.from(data.titles);
            let cartNo = Array.from(data.cartNo);

            for (var i = 0; i < titles.length; i++) {
                if (cartNo[i] == 0) {
                    titles.splice(i, 1);
                    cartNo.splice(i, 1);
                    i--;
                }
            }
            var values = [{
                x: titles,
                y: cartNo,
                type: ""bar""
            }];
            var layout = {
                title: ""Number of copies in cart"",
            };
            Plotly.newPlot(""plotCart"", values, layout);
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EBookShop.ViewModels.AdminViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591