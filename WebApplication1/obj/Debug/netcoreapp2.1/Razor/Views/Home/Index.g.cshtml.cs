#pragma checksum "C:\Users\laic\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fb6c84ad584a2320c4a04625a282e9d4bd940bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fb6c84ad584a2320c4a04625a282e9d4bd940bf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15243f3c6d073f65c82a5fe4a82572d82c4ba292", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Partial/slider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Partial/Features", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Partial/recommended_items", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\laic\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
  
    Layout = "_Layout_Base";
    ViewData["Title"] = "Главная страница";

#line default
#line hidden
            BeginContext(116, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(171, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5933f0dbe1ad446f8cc5ff81f0f0f344", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(202, 8366, true);
            WriteLiteral(@"

<section>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm-3"">
                <div class=""left-sidebar"">
                    <h2>Category</h2>
                    <div class=""panel-group category-products"" id=""accordian"">
                        <!--category-productsr-->
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title"">
                                    <a data-toggle=""collapse"" data-parent=""#accordian"" href=""#sportswear"">
                                        <span class=""badge pull-right""><i class=""fa fa-plus""></i></span>
                                        Sportswear
                                    </a>
                                </h4>
                            </div>
                            <div id=""sportswear"" class=""panel-collapse collapse"">
                                <div class=""panel-body"">
     ");
            WriteLiteral(@"                               <ul>
                                        <li><a href=""#"">Nike </a></li>
                                        <li><a href=""#"">Under Armour </a></li>
                                        <li><a href=""#"">Adidas </a></li>
                                        <li><a href=""#"">Puma</a></li>
                                        <li><a href=""#"">ASICS </a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title"">
                                    <a data-toggle=""collapse"" data-parent=""#accordian"" href=""#mens"">
                                        <span class=""badge pull-right""><i class=""fa fa-plus""></i></span>
                                        Mens
                                    </");
            WriteLiteral(@"a>
                                </h4>
                            </div>
                            <div id=""mens"" class=""panel-collapse collapse"">
                                <div class=""panel-body"">
                                    <ul>
                                        <li><a href=""#"">Fendi</a></li>
                                        <li><a href=""#"">Guess</a></li>
                                        <li><a href=""#"">Valentino</a></li>
                                        <li><a href=""#"">Dior</a></li>
                                        <li><a href=""#"">Versace</a></li>
                                        <li><a href=""#"">Armani</a></li>
                                        <li><a href=""#"">Prada</a></li>
                                        <li><a href=""#"">Dolce and Gabbana</a></li>
                                        <li><a href=""#"">Chanel</a></li>
                                        <li><a href=""#"">Gucci</a></li>
                             ");
            WriteLiteral(@"       </ul>
                                </div>
                            </div>
                        </div>

                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title"">
                                    <a data-toggle=""collapse"" data-parent=""#accordian"" href=""#womens"">
                                        <span class=""badge pull-right""><i class=""fa fa-plus""></i></span>
                                        Womens
                                    </a>
                                </h4>
                            </div>
                            <div id=""womens"" class=""panel-collapse collapse"">
                                <div class=""panel-body"">
                                    <ul>
                                        <li><a href=""#"">Fendi</a></li>
                                        <li><a href=""#"">Guess</a></li>
                            ");
            WriteLiteral(@"            <li><a href=""#"">Valentino</a></li>
                                        <li><a href=""#"">Dior</a></li>
                                        <li><a href=""#"">Versace</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title""><a href=""#"">Kids</a></h4>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title""><a href=""#"">Fashion</a></h4>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                           ");
            WriteLiteral(@"     <h4 class=""panel-title""><a href=""#"">Households</a></h4>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title""><a href=""#"">Interiors</a></h4>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title""><a href=""#"">Clothing</a></h4>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title""><a href=""#"">Bags</a></h4>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                         ");
            WriteLiteral(@"   <div class=""panel-heading"">
                                <h4 class=""panel-title""><a href=""#"">Shoes</a></h4>
                            </div>
                        </div>
                    </div><!--/category-products-->

                    <div class=""brands_products"">
                        <!--brands_products-->
                        <h2>Brands</h2>
                        <div class=""brands-name"">
                            <ul class=""nav nav-pills nav-stacked"">
                                <li><a href=""#""> <span class=""pull-right"">(50)</span>Acne</a></li>
                                <li><a href=""#""> <span class=""pull-right"">(56)</span>Grüne Erde</a></li>
                                <li><a href=""#""> <span class=""pull-right"">(27)</span>Albiro</a></li>
                                <li><a href=""#""> <span class=""pull-right"">(32)</span>Ronhill</a></li>
                                <li><a href=""#""> <span class=""pull-right"">(5)</span>Oddmolly</a></li>
            ");
            WriteLiteral(@"                    <li><a href=""#""> <span class=""pull-right"">(9)</span>Boudestijn</a></li>
                                <li><a href=""#""> <span class=""pull-right"">(4)</span>Rösch creative culture</a></li>
                            </ul>
                        </div>
                    </div><!--/brands_products-->

                    <div class=""price-range"">
                        <!--price-range-->
                        <h2>Price Range</h2>
                        <div class=""well text-center"">
                            <input type=""text"" class=""span2"" value="""" data-slider-min=""0"" data-slider-max=""600"" data-slider-step=""5"" data-slider-value=""[250,450]"" id=""sl2""><br />
                            <b class=""pull-left"">$ 0</b> <b class=""pull-right"">$ 600</b>
                        </div>
                    </div><!--/price-range-->

                    <div class=""shipping text-center"">
                        <!--shipping-->
                        <img src=""images/home/shippin");
            WriteLiteral("g.jpg\" alt=\"\" />\r\n                    </div><!--/shipping-->\r\n\r\n                </div>\r\n            </div>\r\n            <div class=\"col-sm-9 padding-right\">\r\n                ");
            EndContext();
            BeginContext(8568, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f5d39ec47ee47d6b1a56967c21d560d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8601, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(8624, 46, false);
#line 157 "C:\Users\laic\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
               Write(await Html.PartialAsync("Partial/categorytab"));

#line default
#line hidden
            EndContext();
            BeginContext(8670, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(8692, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e8227b461764e3a81b8c6e4834a4a02", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8734, 58, true);
            WriteLiteral("\r\n\r\n\r\n\r\n</div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
