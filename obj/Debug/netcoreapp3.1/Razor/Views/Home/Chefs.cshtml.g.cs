#pragma checksum "C:\Users\Kevin D\Desktop\Dojo_Assignments\Java-or-CSharp\ChefsNDishes\Views\Home\Chefs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a4ebc263f3bcb5de8d05703209e3c8e4370cb7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Chefs), @"mvc.1.0.view", @"/Views/Home/Chefs.cshtml")]
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
#line 1 "C:\Users\Kevin D\Desktop\Dojo_Assignments\Java-or-CSharp\ChefsNDishes\Views\_ViewImports.cshtml"
using ChefsNDishes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kevin D\Desktop\Dojo_Assignments\Java-or-CSharp\ChefsNDishes\Views\_ViewImports.cshtml"
using ChefsNDishes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a4ebc263f3bcb5de8d05703209e3c8e4370cb7c", @"/Views/Home/Chefs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3683dbd783bea45b88d0b0d3ee52e8ec1e5d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Chefs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Chef>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Kevin D\Desktop\Dojo_Assignments\Java-or-CSharp\ChefsNDishes\Views\Home\Chefs.cshtml"
  
    ViewData["Title"] = "Chef's Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div>
    <div class=""containerSpaceBetween"">
        <h4><a id=""AddAChef"" href=""newchef"">Add a Chef</a></h4>
        <div>
            <h1 class=""display-4 text-center"">Chefs | <a href=""/dishes"">Dishes</a></h1>
        </div>
    </div>
    <br>
    <div");
            BeginWriteAttribute("class", " class=\"", 327, "\"", 335, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div>
                <h3>Check out our roster of Chefs!</h3>
                    
                <br>
                <table class=""table table-striped"">
                    <tr>
                        <th>Name</th>
                        <th>Age</th>
                        <th># of Dishes</th>
                    </tr>
");
#nullable restore
#line 26 "C:\Users\Kevin D\Desktop\Dojo_Assignments\Java-or-CSharp\ChefsNDishes\Views\Home\Chefs.cshtml"
                     foreach (Chef chef in ViewBag.Chefs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                        <td>\r\n                            <h4>");
#nullable restore
#line 30 "C:\Users\Kevin D\Desktop\Dojo_Assignments\Java-or-CSharp\ChefsNDishes\Views\Home\Chefs.cshtml"
                           Write(chef.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 30 "C:\Users\Kevin D\Desktop\Dojo_Assignments\Java-or-CSharp\ChefsNDishes\Views\Home\Chefs.cshtml"
                                           Write(chef.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 33 "C:\Users\Kevin D\Desktop\Dojo_Assignments\Java-or-CSharp\ChefsNDishes\Views\Home\Chefs.cshtml"
                             if(DateTime.Now.DayOfYear < @chef.DateOfBirth.DayOfYear)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h4>\r\n                                    ");
#nullable restore
#line 36 "C:\Users\Kevin D\Desktop\Dojo_Assignments\Java-or-CSharp\ChefsNDishes\Views\Home\Chefs.cshtml"
                                Write((DateTime.Now.Year-@chef.DateOfBirth.Year) -1 );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </h4>\r\n");
#nullable restore
#line 38 "C:\Users\Kevin D\Desktop\Dojo_Assignments\Java-or-CSharp\ChefsNDishes\Views\Home\Chefs.cshtml"
                            }
                            else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h4>\r\n                                    ");
#nullable restore
#line 41 "C:\Users\Kevin D\Desktop\Dojo_Assignments\Java-or-CSharp\ChefsNDishes\Views\Home\Chefs.cshtml"
                                Write((DateTime.Now.Year-@chef.DateOfBirth.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </h4>\r\n");
#nullable restore
#line 43 "C:\Users\Kevin D\Desktop\Dojo_Assignments\Java-or-CSharp\ChefsNDishes\Views\Home\Chefs.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n                            <h4>");
#nullable restore
#line 46 "C:\Users\Kevin D\Desktop\Dojo_Assignments\Java-or-CSharp\ChefsNDishes\Views\Home\Chefs.cshtml"
                           Write(chef.Dishes.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        </td>\r\n                        </tr>\r\n");
#nullable restore
#line 49 "C:\Users\Kevin D\Desktop\Dojo_Assignments\Java-or-CSharp\ChefsNDishes\Views\Home\Chefs.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n            </div>\r\n            \r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Chef> Html { get; private set; }
    }
}
#pragma warning restore 1591