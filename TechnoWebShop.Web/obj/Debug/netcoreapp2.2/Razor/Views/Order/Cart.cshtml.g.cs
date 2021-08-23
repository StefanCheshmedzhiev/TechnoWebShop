#pragma checksum "D:\Source\Repos\TechnoWebShop\TechnoWebShop.Web\Views\Order\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "befea9a790d474e856d16fa146877a4162ccecfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Cart), @"mvc.1.0.view", @"/Views/Order/Cart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Cart.cshtml", typeof(AspNetCore.Views_Order_Cart))]
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
#line 1 "D:\Source\Repos\TechnoWebShop\TechnoWebShop.Web\Views\_ViewImports.cshtml"
using TechnoWebShop.Web;

#line default
#line hidden
#line 2 "D:\Source\Repos\TechnoWebShop\TechnoWebShop.Web\Views\_ViewImports.cshtml"
using TechnoWebShop.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"befea9a790d474e856d16fa146877a4162ccecfb", @"/Views/Order/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0db95572522bcdd28fea6cde26daa673156ba5f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TechnoWebShop.Web.ViewModels.Order.Cart.OrderCartViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Order/Cart/Complete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex justify-content-between"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Source\Repos\TechnoWebShop\TechnoWebShop.Web\Views\Order\Cart.cshtml"
  
    ViewData["Title"] = "Cart";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(155, 74, true);
            WriteLiteral("<h1 class=\"text-left text-primary\">Cart</h1>\n<hr class=\"hr-2 bg-primary\">\n");
            EndContext();
#line 8 "D:\Source\Repos\TechnoWebShop\TechnoWebShop.Web\Views\Order\Cart.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(254, 112, true);
            WriteLiteral("    <h2 class=\"text-center text-primary\">You have no orders in your cart.</h2>\n    <hr class=\"hr-2 bg-primary\">\n");
            EndContext();
#line 12 "D:\Source\Repos\TechnoWebShop\TechnoWebShop.Web\Views\Order\Cart.cshtml"
}
else
{


#line default
#line hidden
            BeginContext(376, 466, true);
            WriteLiteral(@"    <div id=""orders"" class=""text-primary"">
        <div class=""order-info row mt-4"">
            <h3 class=""col-md-1 text-left"">#</h3>
            <h3 class=""col-md-3 text-left"">Image</h3>
            <h3 class=""col-md-3 text-left"">Product</h3>
            <h3 class=""col-md-2 text-left"">Price</h3>
            <h3 class=""col-md-1 text-left"">Quantity</h3>
            <h3 class=""col-md-2 text-center"">Actions</h3>
        </div>
        <hr class=""hr-2 bg-primary"">
");
            EndContext();
#line 26 "D:\Source\Repos\TechnoWebShop\TechnoWebShop.Web\Views\Order\Cart.cshtml"
         for (int i = 0; i < Model.Count; i++)
        {

#line default
#line hidden
            BeginContext(899, 83, true);
            WriteLiteral("            <div class=\"order row\">\n                <h5 class=\"col-md-1 text-left\">");
            EndContext();
            BeginContext(984, 5, false);
#line 29 "D:\Source\Repos\TechnoWebShop\TechnoWebShop.Web\Views\Order\Cart.cshtml"
                                           Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(990, 110, true);
            WriteLiteral("</h5>\n                <div class=\"col-md-3\">\n                    <img class=\"img-thumbnail product-cart-image\"");
            EndContext();
            BeginWriteAttribute("src", "\n                         src=\"", 1100, "\"", 1155, 1);
#line 32 "D:\Source\Repos\TechnoWebShop\TechnoWebShop.Web\Views\Order\Cart.cshtml"
WriteAttributeValue("", 1131, Model[i].ProductPicture, 1131, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1156, 74, true);
            WriteLiteral(" />\n                </div>\n                <h5 class=\"col-md-3 text-left\">");
            EndContext();
            BeginContext(1231, 20, false);
#line 34 "D:\Source\Repos\TechnoWebShop\TechnoWebShop.Web\Views\Order\Cart.cshtml"
                                          Write(Model[i].ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1251, 65, true);
            WriteLiteral("</h5>\n                <h5 class=\"col-md-2 text-left order-price\">");
            EndContext();
            BeginContext(1317, 21, false);
#line 35 "D:\Source\Repos\TechnoWebShop\TechnoWebShop.Web\Views\Order\Cart.cshtml"
                                                      Write(Model[i].ProductPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1338, 70, true);
            WriteLiteral("</h5>\n                <h5 class=\"col-md-1 text-right order-quantity\">x");
            EndContext();
            BeginContext(1410, 17, false);
#line 36 "D:\Source\Repos\TechnoWebShop\TechnoWebShop.Web\Views\Order\Cart.cshtml"
                                                            Write(Model[i].Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1428, 128, true);
            WriteLiteral("</h5>\n                <div class=\"col-md-1 mx-auto d-flex justify-content-around\">\n                    <div class=\"minus-button\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1556, "\"", 1581, 2);
#line 38 "D:\Source\Repos\TechnoWebShop\TechnoWebShop.Web\Views\Order\Cart.cshtml"
WriteAttributeValue("", 1561, Model[i].Id, 1561, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1575, "-minus", 1575, 6, true);
            EndWriteAttribute();
            BeginContext(1582, 142, true);
            WriteLiteral(">\n                        <i class=\"fas fa-minus text-primary h4\"></i>\n                    </div>\n                    <div class=\"plus-button\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1724, "\"", 1748, 2);
#line 41 "D:\Source\Repos\TechnoWebShop\TechnoWebShop.Web\Views\Order\Cart.cshtml"
WriteAttributeValue("", 1729, Model[i].Id, 1729, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1743, "-plus", 1743, 5, true);
            EndWriteAttribute();
            BeginContext(1749, 139, true);
            WriteLiteral(">\n                        <i class=\"fas fa-plus text-primary h4\"></i>\n                    </div>\n                </div>\n            </div>\n");
            EndContext();
#line 46 "D:\Source\Repos\TechnoWebShop\TechnoWebShop.Web\Views\Order\Cart.cshtml"
        }

#line default
#line hidden
            BeginContext(1898, 48, true);
            WriteLiteral("    </div>\n    <hr class=\"hr-2 bg-primary\">\n    ");
            EndContext();
            BeginContext(1946, 309, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "befea9a790d474e856d16fa146877a4162ccecfb9921", async() => {
                BeginContext(2035, 132, true);
                WriteLiteral("\n        <button class=\"btn btn-primary font-weight-bold\">Cashout</button>\n        <h2 class=\"text-primary\" id=\"total-price\">Total: ");
                EndContext();
                BeginContext(2168, 70, false);
#line 51 "D:\Source\Repos\TechnoWebShop\TechnoWebShop.Web\Views\Order\Cart.cshtml"
                                                    Write(Model.Sum(order => order.ProductPrice * order.Quantity).ToString("F2"));

#line default
#line hidden
                EndContext();
                BeginContext(2238, 10, true);
                WriteLiteral("</h2>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2255, 2312, true);
            WriteLiteral(@"
    <script>
        function updateTotalPrice() {
            // This function updates the total price upon changing the quantity of one product.

            // Extract all elements with class order (the table rows)
            let orders = $('.order');

            // Variable to hold the total price
            let totalPrice = 0;

            // Iterate over all othe orders
            for (let order of orders) {

                // Extract the element <h5> holding the price
                let priceElement = $($(order).children()[3]);
                // Extract the element <h5> holding the quantity
                let quantityElement = $($(order).children()[4]);

                // Extract the elements' values
                let currentPrice = Number($(priceElement).text())
                let currentQuantity = Number($(quantityElement).text().toString().replace('x', ''));

                // Calculate the total price
                totalPrice += currentPrice * currentQuantity;
            }

       ");
            WriteLiteral(@"     // Attach the new total price to the total-price element
            $('#total-price').text('Total: ' + totalPrice.toFixed(2));
        }

        $('.minus-button').click(function () {
            let orderId = $(this).attr('id').toString().replace('-minus', '');

            let element = $($($($(this).parent()).parent()).children()[4]);

            $.post({
                url: `/Order/${orderId}/Quantity/Reduce`,
                success: function () {
                    let currentQuantity = Number(element.text().toString().replace('x', ''));
                    element.text('x' + (currentQuantity - 1));
                    updateTotalPrice();
                }
            });
        });
        $('.plus-button').click(function () {
            let orderId = $(this).attr('id').toString().replace('-plus', '');

            let element = $($($($(this).parent()).parent()).children()[4]);

            $.post({
                url: `/Order/${orderId}/Quantity/Increase`,
                success: functio");
            WriteLiteral(@"n () {
                    let currentQuantity = Number(element.text().toString().replace('x', ''));
                    element.text('x' + (currentQuantity + 1));
                    updateTotalPrice();
                }
            });
        });
    </script>
");
            EndContext();
#line 112 "D:\Source\Repos\TechnoWebShop\TechnoWebShop.Web\Views\Order\Cart.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TechnoWebShop.Web.ViewModels.Order.Cart.OrderCartViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591