#pragma checksum "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Product\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32cb4a842632cc7d11bdd94736169a254c40e4e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Cart), @"mvc.1.0.view", @"/Views/Product/Cart.cshtml")]
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
#line 1 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\_ViewImports.cshtml"
using BookEcommerce_ASP.NETCore_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\_ViewImports.cshtml"
using BookEcommerce_ASP.NETCore_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32cb4a842632cc7d11bdd94736169a254c40e4e3", @"/Views/Product/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fdffa95800fb9a92c166624c09fd87195152aae", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClassLibrary_RepositoryDLL.Entities.CartItem>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveCartItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/product/updatecart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Product\Cart.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";
    double? total =0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""cart-page"">

            <div class=""container-fluid"">

                <div class=""row"">
                    <div class=""col-lg-8"">
                        <div class=""cart-page-inner"">
                            <div class=""table-responsive"">
");
#nullable restore
#line 17 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Product\Cart.cshtml"
                                 if(Model.Count>0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <table class=""table table-bordered"">
                                    <thead class=""thead-dark"">
                                        <tr>
                                            <th>Sản Phẩm</th>
                                            <th>Giá</th>
                                            <th>Số Lượng</th>
                                            <th>Thành Tiền</th>
                                            <th>Xóa</th>
                                            <th>Update</th>
                                        </tr>
                                    </thead>
                                    <tbody class=""align-middle"">
");
#nullable restore
#line 31 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Product\Cart.cshtml"
                                     foreach(var cartItem in Model)
                                    {
                                    var thanhtien = cartItem.Quantity * cartItem.Book.Price;
                                    total += thanhtien;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32cb4a842632cc7d11bdd94736169a254c40e4e38088", async() => {
                WriteLiteral("\r\n                                        <tr>\r\n                                            <td>\r\n                                                <div class=\"img\">\r\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32cb4a842632cc7d11bdd94736169a254c40e4e38569", async() => {
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "32cb4a842632cc7d11bdd94736169a254c40e4e38789", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    AddHtmlAttributeValue("", 1893, "~/image/", 1893, 8, true);
#nullable restore
#line 39 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Product\Cart.cshtml"
AddHtmlAttributeValue("", 1901, cartItem.Book.Image, 1901, 20, false);

#line default
#line hidden
#nullable disable
                    EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1843, "~/Home/ProductDetail/", 1843, 21, true);
#nullable restore
#line 39 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Product\Cart.cshtml"
AddHtmlAttributeValue("", 1864, cartItem.Book.Id, 1864, 17, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                    <p>");
#nullable restore
#line 40 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Product\Cart.cshtml"
                                                  Write(cartItem.Book.Bookname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                                </div>\r\n                                            </td>\r\n                                            <td>");
#nullable restore
#line 43 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Product\Cart.cshtml"
                                           Write(cartItem.Book.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>\r\n                                                <div class=\"qty\">\r\n");
                WriteLiteral("                                                    \r\n                                                    ");
#nullable restore
#line 48 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Product\Cart.cshtml"
                                               Write(Html.Hidden("BookId",@cartItem.Book.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                                                    ");
#nullable restore
#line 49 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Product\Cart.cshtml"
                                               Write(Html.TextBox("Quantity",@cartItem.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n");
                WriteLiteral("                                                    \r\n                                                </div>\r\n                                            </td>\r\n                                            <td>");
#nullable restore
#line 54 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Product\Cart.cshtml"
                                           Write(thanhtien);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32cb4a842632cc7d11bdd94736169a254c40e4e314233", async() => {
                    WriteLiteral("<i class=\"fa fa-trash\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Product\Cart.cshtml"
                                                                                 WriteLiteral(cartItem.BookId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                                           <td>\r\n                                                <button data-id=\"");
#nullable restore
#line 57 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Product\Cart.cshtml"
                                                            Write(cartItem.Book.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-qty=\"");
#nullable restore
#line 57 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Product\Cart.cshtml"
                                                                                         Write(cartItem.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""">
                                                    <i class=""fa fa-check""></i>
                                                </button>
                                  
                                            </td>
                                      


                                        </tr>
                                     ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 67 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Product\Cart.cshtml"
                                    
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tbody>\r\n                                </table>\r\n");
#nullable restore
#line 71 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Product\Cart.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4"">

                        <div class=""cart-page-inner"">

                            <div class=""row"">
                                
                                <div class=""col-md-12"">
                                    <div class=""cart-summary"">
                                        
                                        <div class=""cart-content"">
                                            <h1>Tổng Thanh Toán</h1>
                                            <p>Thành Tiền: <span>");
#nullable restore
#line 86 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Product\Cart.cshtml"
                                                            Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral(".000đ</span></p>\r\n                                            <p>Giá Ship: <span>$1</span></p>\r\n                                            <h2>Tổng Tiền: <span >");
#nullable restore
#line 88 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Product\Cart.cshtml"
                                                             Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral(".000đ</span></h2>\r\n                                        </div>\r\n                                        <div class=\"cart-btn\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32cb4a842632cc7d11bdd94736169a254c40e4e321496", async() => {
                WriteLiteral("Thanh Toán");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </div>
                                        
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>


            </div>

        </div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ClassLibrary_RepositoryDLL.Services.ICartService cartService { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ClassLibrary_RepositoryDLL.Entities.CartItem>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
