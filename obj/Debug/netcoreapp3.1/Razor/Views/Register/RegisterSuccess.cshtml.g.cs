#pragma checksum "C:\Users\Adam\source\repos\CST247CLC\CST247CLC\Views\Register\RegisterSuccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de38ea48057d48c68dc08a22e6e7da07542d9eb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_RegisterSuccess), @"mvc.1.0.view", @"/Views/Register/RegisterSuccess.cshtml")]
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
#line 1 "C:\Users\Adam\source\repos\CST247CLC\CST247CLC\Views\_ViewImports.cshtml"
using CST247CLC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Adam\source\repos\CST247CLC\CST247CLC\Views\_ViewImports.cshtml"
using CST247CLC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de38ea48057d48c68dc08a22e6e7da07542d9eb7", @"/Views/Register/RegisterSuccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2de8811520943acb4bdeaa4faebbd9f50c709192", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_RegisterSuccess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CST247CLC.Models.UserModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n    <div>\n        <h4>Registered Successfully!</h4>\n        <hr />\n        <dl class=\"dl-horizontal\">\n            <dt>\n                ");
#nullable restore
#line 8 "C:\Users\Adam\source\repos\CST247CLC\CST247CLC\Views\Register\RegisterSuccess.cshtml"
           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd>\n                ");
#nullable restore
#line 11 "C:\Users\Adam\source\repos\CST247CLC\CST247CLC\Views\Register\RegisterSuccess.cshtml"
           Write(Html.DisplayFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt>\n                ");
#nullable restore
#line 14 "C:\Users\Adam\source\repos\CST247CLC\CST247CLC\Views\Register\RegisterSuccess.cshtml"
           Write(Html.DisplayNameFor(model => model.firstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd>\n                ");
#nullable restore
#line 17 "C:\Users\Adam\source\repos\CST247CLC\CST247CLC\Views\Register\RegisterSuccess.cshtml"
           Write(Html.DisplayFor(model => model.firstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt>\n                ");
#nullable restore
#line 20 "C:\Users\Adam\source\repos\CST247CLC\CST247CLC\Views\Register\RegisterSuccess.cshtml"
           Write(Html.DisplayNameFor(model => model.lastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd>\n                ");
#nullable restore
#line 23 "C:\Users\Adam\source\repos\CST247CLC\CST247CLC\Views\Register\RegisterSuccess.cshtml"
           Write(Html.DisplayFor(model => model.lastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt>\n                ");
#nullable restore
#line 26 "C:\Users\Adam\source\repos\CST247CLC\CST247CLC\Views\Register\RegisterSuccess.cshtml"
           Write(Html.DisplayNameFor(model => model.sex));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd>\n                ");
#nullable restore
#line 29 "C:\Users\Adam\source\repos\CST247CLC\CST247CLC\Views\Register\RegisterSuccess.cshtml"
           Write(Html.DisplayFor(model => model.sex));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt>\n                ");
#nullable restore
#line 32 "C:\Users\Adam\source\repos\CST247CLC\CST247CLC\Views\Register\RegisterSuccess.cshtml"
           Write(Html.DisplayNameFor(model => model.age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd>\n                ");
#nullable restore
#line 35 "C:\Users\Adam\source\repos\CST247CLC\CST247CLC\Views\Register\RegisterSuccess.cshtml"
           Write(Html.DisplayFor(model => model.age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt>\n                ");
#nullable restore
#line 38 "C:\Users\Adam\source\repos\CST247CLC\CST247CLC\Views\Register\RegisterSuccess.cshtml"
           Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd>\n                ");
#nullable restore
#line 41 "C:\Users\Adam\source\repos\CST247CLC\CST247CLC\Views\Register\RegisterSuccess.cshtml"
           Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt>\n                ");
#nullable restore
#line 44 "C:\Users\Adam\source\repos\CST247CLC\CST247CLC\Views\Register\RegisterSuccess.cshtml"
           Write(Html.DisplayNameFor(model => model.userName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd>\n                ");
#nullable restore
#line 47 "C:\Users\Adam\source\repos\CST247CLC\CST247CLC\Views\Register\RegisterSuccess.cshtml"
           Write(Html.DisplayFor(model => model.userName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt>\n                ");
#nullable restore
#line 50 "C:\Users\Adam\source\repos\CST247CLC\CST247CLC\Views\Register\RegisterSuccess.cshtml"
           Write(Html.DisplayNameFor(model => model.password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd>\n                ");
#nullable restore
#line 53 "C:\Users\Adam\source\repos\CST247CLC\CST247CLC\Views\Register\RegisterSuccess.cshtml"
           Write(Html.DisplayFor(model => model.password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt>\n                ");
#nullable restore
#line 56 "C:\Users\Adam\source\repos\CST247CLC\CST247CLC\Views\Register\RegisterSuccess.cshtml"
           Write(Html.DisplayNameFor(model => model.state));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd>\n                ");
#nullable restore
#line 59 "C:\Users\Adam\source\repos\CST247CLC\CST247CLC\Views\Register\RegisterSuccess.cshtml"
           Write(Html.DisplayFor(model => model.state));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n        </dl>\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CST247CLC.Models.UserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
