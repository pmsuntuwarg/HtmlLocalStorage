#pragma checksum "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89c7b5c27b567f65dcd5251f45b33353fe57f083"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LocalStorageTest_Index), @"mvc.1.0.view", @"/Views/LocalStorageTest/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LocalStorageTest/Index.cshtml", typeof(AspNetCore.Views_LocalStorageTest_Index))]
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
#line 1 "E:\Study\Topics\LocalStorage\Views\_ViewImports.cshtml"
using LocalStorage;

#line default
#line hidden
#line 2 "E:\Study\Topics\LocalStorage\Views\_ViewImports.cshtml"
using LocalStorage.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89c7b5c27b567f65dcd5251f45b33353fe57f083", @"/Views/LocalStorageTest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de8d3b3059374c6c2000184e530accddba625c9d", @"/Views/_ViewImports.cshtml")]
    public class Views_LocalStorageTest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LocalStorage.Models.TestFormModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(127, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89c7b5c27b567f65dcd5251f45b33353fe57f0834703", async() => {
                BeginContext(150, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(164, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(257, 45, false);
#line 16 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(302, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(358, 46, false);
#line 19 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MiddleName));

#line default
#line hidden
            EndContext();
            BeginContext(404, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(460, 44, false);
#line 22 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(504, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(560, 41, false);
#line 25 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(601, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(657, 43, false);
#line 28 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(700, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(756, 51, false);
#line 31 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FatherFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(807, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(863, 52, false);
#line 34 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FatherMiddleName));

#line default
#line hidden
            EndContext();
            BeginContext(915, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(971, 50, false);
#line 37 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FatherLastName));

#line default
#line hidden
            EndContext();
            BeginContext(1021, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1077, 51, false);
#line 40 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MotherFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1128, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1184, 52, false);
#line 43 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MotherMiddleName));

#line default
#line hidden
            EndContext();
            BeginContext(1236, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1292, 50, false);
#line 46 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MotherLastName));

#line default
#line hidden
            EndContext();
            BeginContext(1342, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1398, 46, false);
#line 49 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BirthPlace));

#line default
#line hidden
            EndContext();
            BeginContext(1444, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1500, 52, false);
#line 52 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FatherBirthPlace));

#line default
#line hidden
            EndContext();
            BeginContext(1552, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1608, 52, false);
#line 55 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MotherBirthPlace));

#line default
#line hidden
            EndContext();
            BeginContext(1660, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1716, 47, false);
#line 58 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FatherPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1763, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1819, 47, false);
#line 61 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MotherPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1866, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1922, 51, false);
#line 64 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SpouseFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1973, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2029, 51, false);
#line 67 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SposeMiddleName));

#line default
#line hidden
            EndContext();
            BeginContext(2080, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2136, 50, false);
#line 70 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SpouseLastName));

#line default
#line hidden
            EndContext();
            BeginContext(2186, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2242, 46, false);
#line 73 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SpusePhone));

#line default
#line hidden
            EndContext();
            BeginContext(2288, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2344, 45, false);
#line 76 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WorkPlace));

#line default
#line hidden
            EndContext();
            BeginContext(2389, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2445, 52, false);
#line 79 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WorkPlaceAddress));

#line default
#line hidden
            EndContext();
            BeginContext(2497, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2553, 45, false);
#line 82 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(2598, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2654, 51, false);
#line 85 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FatherBirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(2705, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2761, 51, false);
#line 88 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MotherBirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(2812, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2868, 51, false);
#line 91 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SpouseBirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(2919, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2975, 52, false);
#line 94 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SpouseBirthPlace));

#line default
#line hidden
            EndContext();
            BeginContext(3027, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(3083, 40, false);
#line 97 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
            EndContext();
            BeginContext(3123, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 103 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(3241, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3290, 44, false);
#line 106 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(3334, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3390, 45, false);
#line 109 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MiddleName));

#line default
#line hidden
            EndContext();
            BeginContext(3435, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3491, 43, false);
#line 112 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(3534, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3590, 40, false);
#line 115 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(3630, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3686, 42, false);
#line 118 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(3728, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3784, 50, false);
#line 121 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FatherFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(3834, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3890, 51, false);
#line 124 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FatherMiddleName));

#line default
#line hidden
            EndContext();
            BeginContext(3941, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3997, 49, false);
#line 127 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FatherLastName));

#line default
#line hidden
            EndContext();
            BeginContext(4046, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4102, 50, false);
#line 130 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MotherFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(4152, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4208, 51, false);
#line 133 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MotherMiddleName));

#line default
#line hidden
            EndContext();
            BeginContext(4259, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4315, 49, false);
#line 136 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MotherLastName));

#line default
#line hidden
            EndContext();
            BeginContext(4364, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4420, 45, false);
#line 139 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BirthPlace));

#line default
#line hidden
            EndContext();
            BeginContext(4465, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4521, 51, false);
#line 142 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FatherBirthPlace));

#line default
#line hidden
            EndContext();
            BeginContext(4572, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4628, 51, false);
#line 145 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MotherBirthPlace));

#line default
#line hidden
            EndContext();
            BeginContext(4679, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4735, 46, false);
#line 148 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FatherPhone));

#line default
#line hidden
            EndContext();
            BeginContext(4781, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4837, 46, false);
#line 151 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MotherPhone));

#line default
#line hidden
            EndContext();
            BeginContext(4883, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4939, 50, false);
#line 154 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SpouseFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(4989, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5045, 50, false);
#line 157 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SposeMiddleName));

#line default
#line hidden
            EndContext();
            BeginContext(5095, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5151, 49, false);
#line 160 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SpouseLastName));

#line default
#line hidden
            EndContext();
            BeginContext(5200, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5256, 45, false);
#line 163 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SpusePhone));

#line default
#line hidden
            EndContext();
            BeginContext(5301, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5357, 44, false);
#line 166 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.WorkPlace));

#line default
#line hidden
            EndContext();
            BeginContext(5401, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5457, 51, false);
#line 169 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.WorkPlaceAddress));

#line default
#line hidden
            EndContext();
            BeginContext(5508, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5564, 44, false);
#line 172 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(5608, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5664, 50, false);
#line 175 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FatherBirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(5714, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5770, 50, false);
#line 178 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MotherBirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(5820, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5876, 50, false);
#line 181 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SpouseBirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(5926, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(5982, 51, false);
#line 184 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SpouseBirthPlace));

#line default
#line hidden
            EndContext();
            BeginContext(6033, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(6089, 42, false);
#line 187 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.User.Id));

#line default
#line hidden
            EndContext();
            BeginContext(6131, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(6186, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89c7b5c27b567f65dcd5251f45b33353fe57f08329480", async() => {
                BeginContext(6232, 4, true);
                WriteLiteral("Edit");
                EndContext();
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
#line 190 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
                                       WriteLiteral(item.Int);

#line default
#line hidden
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
            EndContext();
            BeginContext(6240, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(6260, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89c7b5c27b567f65dcd5251f45b33353fe57f08331813", async() => {
                BeginContext(6309, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 191 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
                                          WriteLiteral(item.Int);

#line default
#line hidden
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
            EndContext();
            BeginContext(6320, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(6340, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89c7b5c27b567f65dcd5251f45b33353fe57f08334152", async() => {
                BeginContext(6388, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 192 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
                                         WriteLiteral(item.Int);

#line default
#line hidden
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
            EndContext();
            BeginContext(6398, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 195 "E:\Study\Topics\LocalStorage\Views\LocalStorageTest\Index.cshtml"
}

#line default
#line hidden
            BeginContext(6437, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LocalStorage.Models.TestFormModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
