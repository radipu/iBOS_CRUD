#pragma checksum "F:\My Work Station\C# all\iBOS_CRUD\iBOS_CRUD\iBOS_CRUD\Views\iBOS\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b2ffc77f3b5c7ed4c8e345e9806f8bf04c2519d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_iBOS_Details), @"mvc.1.0.view", @"/Views/iBOS/Details.cshtml")]
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
#line 1 "F:\My Work Station\C# all\iBOS_CRUD\iBOS_CRUD\iBOS_CRUD\Views\_ViewImports.cshtml"
using iBOS_CRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\My Work Station\C# all\iBOS_CRUD\iBOS_CRUD\iBOS_CRUD\Views\_ViewImports.cshtml"
using iBOS_CRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b2ffc77f3b5c7ed4c8e345e9806f8bf04c2519d", @"/Views/iBOS/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cb745daa05defac045ebc5d4859f7e5bc9483f2", @"/Views/_ViewImports.cshtml")]
    public class Views_iBOS_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<iBOS_CRUD.Models.iBOS>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\My Work Station\C# all\iBOS_CRUD\iBOS_CRUD\iBOS_CRUD\Views\iBOS\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>iBOS</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "F:\My Work Station\C# all\iBOS_CRUD\iBOS_CRUD\iBOS_CRUD\Views\iBOS\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.intColdDrinksId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "F:\My Work Station\C# all\iBOS_CRUD\iBOS_CRUD\iBOS_CRUD\Views\iBOS\Details.cshtml"
       Write(Html.DisplayFor(model => model.intColdDrinksId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "F:\My Work Station\C# all\iBOS_CRUD\iBOS_CRUD\iBOS_CRUD\Views\iBOS\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.strColdDrinksName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "F:\My Work Station\C# all\iBOS_CRUD\iBOS_CRUD\iBOS_CRUD\Views\iBOS\Details.cshtml"
       Write(Html.DisplayFor(model => model.strColdDrinksName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "F:\My Work Station\C# all\iBOS_CRUD\iBOS_CRUD\iBOS_CRUD\Views\iBOS\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.numQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "F:\My Work Station\C# all\iBOS_CRUD\iBOS_CRUD\iBOS_CRUD\Views\iBOS\Details.cshtml"
       Write(Html.DisplayFor(model => model.numQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "F:\My Work Station\C# all\iBOS_CRUD\iBOS_CRUD\iBOS_CRUD\Views\iBOS\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.numUnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "F:\My Work Station\C# all\iBOS_CRUD\iBOS_CRUD\iBOS_CRUD\Views\iBOS\Details.cshtml"
       Write(Html.DisplayFor(model => model.numUnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 40 "F:\My Work Station\C# all\iBOS_CRUD\iBOS_CRUD\iBOS_CRUD\Views\iBOS\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b2ffc77f3b5c7ed4c8e345e9806f8bf04c2519d6672", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<iBOS_CRUD.Models.iBOS> Html { get; private set; }
    }
}
#pragma warning restore 1591
