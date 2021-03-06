#pragma checksum "C:\Users\unilogistix\source\repos\CommerceApp\CommerceApp\Views\Categoria\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05a3b37a3b4b5528e7c8281d5e00e762b671d3aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categoria_List), @"mvc.1.0.view", @"/Views/Categoria/List.cshtml")]
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
#line 1 "C:\Users\unilogistix\source\repos\CommerceApp\CommerceApp\Views\_ViewImports.cshtml"
using CommerceApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\unilogistix\source\repos\CommerceApp\CommerceApp\Views\_ViewImports.cshtml"
using CommerceApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05a3b37a3b4b5528e7c8281d5e00e762b671d3aa", @"/Views/Categoria/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cafa9554052d96717b2749782c951ff26b5b1ac8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Categoria_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllLayoutModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\unilogistix\source\repos\CommerceApp\CommerceApp\Views\Categoria\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = Model.Layout;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<section class=""bg0 p-t-23 p-b-140"">
    <div class=""container"">
        <header class=""page-header"">
            <input type=""text"" id=""txtsearch"" placeholder=""M????teri Giriniz"" />
        </header>
        <hr />
        <table class=""table table-bordered"">
            <tr>
                <td>Kategori</td>
                <td>??st Kategori</td>
                <td></td>
            </tr>
");
#nullable restore
#line 22 "C:\Users\unilogistix\source\repos\CommerceApp\CommerceApp\Views\Categoria\List.cshtml"
             foreach (var customer in Model.Categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"Search\">\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\unilogistix\source\repos\CommerceApp\CommerceApp\Views\Categoria\List.cshtml"
                   Write(customer.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 26 "C:\Users\unilogistix\source\repos\CommerceApp\CommerceApp\Views\Categoria\List.cshtml"
                     if (customer.parentId != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 28 "C:\Users\unilogistix\source\repos\CommerceApp\CommerceApp\Views\Categoria\List.cshtml"
                       Write(Functions.parentidcategoryname(customer.parentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 29 "C:\Users\unilogistix\source\repos\CommerceApp\CommerceApp\Views\Categoria\List.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>Bo??</td>\r\n");
#nullable restore
#line 33 "C:\Users\unilogistix\source\repos\CommerceApp\CommerceApp\Views\Categoria\List.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"text-align:right\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1028, "\"", 1071, 2);
            WriteAttributeValue("", 1035, "/Categoria/SubCategoria/", 1035, 24, true);
#nullable restore
#line 35 "C:\Users\unilogistix\source\repos\CommerceApp\CommerceApp\Views\Categoria\List.cshtml"
WriteAttributeValue("", 1059, customer.id, 1059, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"id\" class=\"btn-sm btn-success\" style=\"margin-right:6px !important;\" title=\"Fi??ler\">Alt Kategorileri</a>\r\n");
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 42 "C:\Users\unilogistix\source\repos\CommerceApp\CommerceApp\Views\Categoria\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </table>
    </div>

</section>


<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
<script>
    $(document).ready(function() {
        function Contains(text_one, text_two) {
            if (text_one.indexOf(text_two) != -1)
                return true;
        }
        $(""#txtsearch"").keyup(function() {
            var searchtext = $(""#txtsearch"").val().toLowerCase();
            $("".Search"").each(function() {
                if (!Contains($(this).text().toLowerCase(), searchtext)) {
                    $(this).hide();
                }
                else {
                    $(this).show();
                }
            })
        })
    })
</script>


");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllLayoutModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
