#pragma checksum "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3819e5a306e2949fa5e70370f1d56d37567c77b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductDetail), @"mvc.1.0.view", @"/Views/Home/ProductDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3819e5a306e2949fa5e70370f1d56d37567c77b2", @"/Views/Home/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fdffa95800fb9a92c166624c09fd87195152aae", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClassLibrary_RepositoryDLL.Entities.Book>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <!-- Product Detail Start -->
        <div class=""product-detail"">
            <div class=""container-fluid"">
                <div class=""row"">
                    <div class=""col-lg-8"">
                        <div class=""product-detail-top"">
                            <div class=""row align-items-center"">
                                <div class=""col-md-5"">
                                    <div class=""product-slider-single normal-slider"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3819e5a306e2949fa5e70370f1d56d37567c77b25121", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 880, "~/image/", 880, 8, true);
#nullable restore
#line 19 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
AddHtmlAttributeValue("", 888, Model.Image, 888, 12, false);

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
            WriteLiteral("\r\n                                    </div>\r\n");
            WriteLiteral(@"                                </div>
                                <div class=""col-md-7"">
                                     
                                    <div class=""product-content"">
                                        <div class=""title""><h2>");
#nullable restore
#line 33 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
                                                          Write(Model.Bookname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2></div>\r\n\r\n                                        <div class=\"price\">\r\n                                            <h4>Price:</h4>\r\n                                            <p>");
#nullable restore
#line 37 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
                                          Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p><p>.000đ</p>
                                        </div>
                                        
                                        <div class=""action"">
                                            <a class=""btn"" href=""#""><i class=""fa fa-shopping-cart""></i>Thêm Vào Giỏ</a>
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3819e5a306e2949fa5e70370f1d56d37567c77b28189", async() => {
                WriteLiteral("<i class=\"fa fa-shopping-bag\"></i>Mua Ngay");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2690, "~/product/AddToCart/", 2690, 20, true);
#nullable restore
#line 42 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
AddHtmlAttributeValue("", 2710, Model.Id, 2710, 9, false);

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
            WriteLiteral(@"
                                        </div>
                                    </div>

                                </div>
                            </div>
                        </div>
                        
                        <div class=""row product-detail-bottom"">
                            <div class=""col-lg-12"">
                                <ul class=""nav nav-pills nav-justified"">
                                    <li class=""nav-item"">
                                        <a class=""nav-link active"" data-toggle=""pill"" href=""#description"">Mô Tả</a>
                                    </li>
                                    <li class=""nav-item"">
                                        <a class=""nav-link"" data-toggle=""pill"" href=""#specification"">Thông Tin Chi Tiết</a>
                                    </li>
                                    <li class=""nav-item"">
                                        <a class=""nav-link"" data-toggle=""pill"" href=""#reviews"">Đá");
            WriteLiteral(@"nh Giá</a>
                                    </li>
                                </ul>

                                <div class=""tab-content"">
                                    <div id=""description"" class=""container tab-pane active"">
                                        <h4>Mô Tả Sản Phẩm</h4>
");
#nullable restore
#line 67 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
                                         foreach(var item in Model.Reviews)
                                        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
                                    Write(item.Comment);

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
                                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p>\r\n                                           ");
#nullable restore
#line 70 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
                                      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                    <div id=\"specification\" class=\"container tab-pane fade\">\r\n                                        <h4>Thông Tin Chi Tiết</h4>\r\n");
#nullable restore
#line 74 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
                                         foreach(var item in ptservice.getAllBook() as List<ClassLibrary_RepositoryDLL.Models.ProductModel>)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
                                                                  
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                    <div id=\"reviews\" class=\"container tab-pane fade\">\r\n");
#nullable restore
#line 80 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
                                         foreach(var item in Model.Reviews)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"reviews-submitted\">\r\n                                            <div class=\"reviewer\">");
#nullable restore
#line 83 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
                                                             Write(item.AccountId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>");
#nullable restore
#line 83 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
                                                                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                                            <div class=""ratting"">
                                                <i class=""fa fa-star""></i>
                                                <i class=""fa fa-star""></i>
                                                <i class=""fa fa-star""></i>
                                                <i class=""fa fa-star""></i>
                                                <i class=""fa fa-star""></i>
                                            </div>
                                            <p>
                                               ");
#nullable restore
#line 92 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
                                          Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </p>\r\n                                        </div>\r\n");
#nullable restore
#line 95 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""reviews-submit"">
                                            <h4>Gửi Đánh Giá: </h4>
                                            <div class=""ratting"">
                                                <i class=""far fa-star""></i>
                                                <i class=""far fa-star""></i>
                                                <i class=""far fa-star""></i>
                                                <i class=""far fa-star""></i>
                                                <i class=""far fa-star""></i>
                                            </div>
                                            <div class=""row form"">
                                                <div class=""col-sm-6"">
                                                    <input type=""text"" placeholder=""Name"">
                                                </div>
                                                <div class=""col-sm-6"">
                     ");
            WriteLiteral(@"                               <input type=""email"" placeholder=""Email"">
                                                </div>
                                                <div class=""col-sm-12"">
                                                    <textarea placeholder=""Review""></textarea>
                                                </div>
                                                <div class=""col-sm-12"">
                                                    <button>Gửi</button>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        
                        <div class=""product"">
                            <div class=""section-header"">
                                <h1>Sản Phẩm Tương Tự</h1>
                        ");
            WriteLiteral("    </div>\r\n\r\n                            <div class=\"row align-items-center product-slider product-slider-3\">\r\n");
#nullable restore
#line 131 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
                                 foreach(var item in ptservice.getAllBook() as List<ClassLibrary_RepositoryDLL.Models.ProductModel>)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""col-lg-3"">
                                    <div class=""product-item"">
                                        
                                            <div class=""product-title"">
                                            <a href=""#"">");
#nullable restore
#line 137 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                            <div class=""ratting"">
                                                <i class=""fa fa-star""></i>
                                                <i class=""fa fa-star""></i>
                                                <i class=""fa fa-star""></i>
                                                <i class=""fa fa-star""></i>
                                                <i class=""fa fa-star""></i>
                                            </div>
                                        </div>
                                        <div class=""product-image"">
                                            <a href=""product-detail.html"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3819e5a306e2949fa5e70370f1d56d37567c77b220044", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9423, "~/image/", 9423, 8, true);
#nullable restore
#line 148 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
AddHtmlAttributeValue("", 9431, item.Image, 9431, 11, false);

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
            WriteLiteral(@"
                                            </a>
                                            <div class=""product-action"">
                                                <a href=""#""><i class=""fa fa-cart-plus""></i></a>
                                                <a href=""#""><i class=""fa fa-heart""></i></a>
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3819e5a306e2949fa5e70370f1d56d37567c77b222010", async() => {
                WriteLiteral("<i class=\"fa fa-search\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9837, "~/Home/ProductDetail/", 9837, 21, true);
#nullable restore
#line 153 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
AddHtmlAttributeValue("", 9858, item.Id, 9858, 8, false);

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
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                        <div class=\"product-price\">\r\n                                            <h3>");
#nullable restore
#line 157 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
                                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>.000đ</span></h3>\r\n                                            <a class=\"btn\"");
            BeginWriteAttribute("href", " href=\"", 10213, "\"", 10220, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-shopping-cart\"></i>Mua Ngay</a>\r\n                                        </div>\r\n                                        \r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 163 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                    </div>
                    
                    <!-- Side Bar Start -->
                    <div class=""col-lg-4 sidebar"">
                        <div class=""sidebar-widget category"">
                            <h2 class=""title"">Danh Mục</h2>
                            <nav class=""navbar bg-light"">
                                <ul class=""navbar-nav"">
");
#nullable restore
#line 174 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
                                               foreach(var item in mnservice.getAllCategories() as List<ClassLibrary_RepositoryDLL.Entities.Category>)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"nav-item\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3819e5a306e2949fa5e70370f1d56d37567c77b225817", async() => {
                WriteLiteral("<i class=\"fa fa-female\"></i>");
#nullable restore
#line 177 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
                                                                                                                            Write(item.Categoryname);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 11247, "~/Home/Product/", 11247, 15, true);
#nullable restore
#line 177 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
AddHtmlAttributeValue("", 11262, item.Categoryname, 11262, 18, false);

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
            WriteLiteral("\r\n                                    </li>\r\n");
#nullable restore
#line 179 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </ul>
                            </nav>
                        </div>
                        
                        <div class=""sidebar-widget brands"">
                            <h2 class=""title"">Nhà Xuất Bản</h2>
                            <ul>
");
#nullable restore
#line 187 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
                                  foreach(var item in ptservice.getAllBook() as List<ClassLibrary_RepositoryDLL.Models.ProductModel>)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a href=\"#\">");
#nullable restore
#line 189 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
                                           Write(item.Authorname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><span>(");
#nullable restore
#line 189 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
                                                                      Write(item.StorageQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span></li>\r\n");
#nullable restore
#line 190 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </div>\r\n                        \r\n                        <div class=\"sidebar-widget tag\">\r\n                            <h2 class=\"title\">Thẻ Tags</h2>\r\n                            <a href=\"#\">");
#nullable restore
#line 202 "C:\Users\tranm\source\repos\BookEcommerceBE-be01\BookEcommerce_ASP.NETCore MVC\Views\Home\ProductDetail.cshtml"
                                   Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <!-- Side Bar End -->\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- Product Detail End -->\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ClassLibrary_RepositoryDLL.Services.IProductService ptservice { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ClassLibrary_RepositoryDLL.Services.IMenuService mnservice { get; private set; } = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClassLibrary_RepositoryDLL.Entities.Book> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
