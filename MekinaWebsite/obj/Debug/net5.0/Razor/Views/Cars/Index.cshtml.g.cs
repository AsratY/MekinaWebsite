#pragma checksum "C:\Users\Pati\Downloads\Telegram Desktop\MekinaWebsite (2)\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "429e81dc6b63c66d0b87699a9b9f79d6a140b613"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Index), @"mvc.1.0.view", @"/Views/Cars/Index.cshtml")]
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
#line 1 "C:\Users\Pati\Downloads\Telegram Desktop\MekinaWebsite (2)\MekinaWebsite\MekinaWebsite\Views\_ViewImports.cshtml"
using MekinaWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pati\Downloads\Telegram Desktop\MekinaWebsite (2)\MekinaWebsite\MekinaWebsite\Views\_ViewImports.cshtml"
using MekinaWebsite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Pati\Downloads\Telegram Desktop\MekinaWebsite (2)\MekinaWebsite\MekinaWebsite\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"429e81dc6b63c66d0b87699a9b9f79d6a140b613", @"/Views/Cars/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fae27cb430124c3b391ee0437398326c6649493f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cars_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MekinaWebsite.Models.CarsList>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Pati\Downloads\Telegram Desktop\MekinaWebsite (2)\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
  
	ViewData["Title"] = "Index";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n\t<div class=\"row\">\r\n");
#nullable restore
#line 11 "C:\Users\Pati\Downloads\Telegram Desktop\MekinaWebsite (2)\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
         foreach (var item in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"card mb-3 shadow-lg p-3 mb-5 bg-white\"  style=\"width:300px; margin-left:15px; \">\r\n\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 317, "\"", 349, 2);
            WriteAttributeValue("", 324, "/cars/details/", 324, 14, true);
#nullable restore
#line 14 "C:\Users\Pati\Downloads\Telegram Desktop\MekinaWebsite (2)\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
WriteAttributeValue("", 338, item.CarId, 338, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"itemCard\" style=\"text-decoration:none;\">\r\n\t\t\t\t\t<img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 430, "\"", 450, 1);
#nullable restore
#line 15 "C:\Users\Pati\Downloads\Telegram Desktop\MekinaWebsite (2)\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
WriteAttributeValue("", 436, item.CarImage, 436, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Car Image\" style=\"height:200px;width:100%\">\r\n\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t<p class=\"card-text\" style=\"font-weight:bold\">");
#nullable restore
#line 17 "C:\Users\Pati\Downloads\Telegram Desktop\MekinaWebsite (2)\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
                                                                 Write(item.CarName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t<p class=\"card-text\">");
#nullable restore
#line 18 "C:\Users\Pati\Downloads\Telegram Desktop\MekinaWebsite (2)\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
                                        Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Br</p>\r\n\t\t\t\t\t\t<p class=\"card-text\">");
#nullable restore
#line 19 "C:\Users\Pati\Downloads\Telegram Desktop\MekinaWebsite (2)\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
                                        Write(item.Transmission);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</a>\r\n");
#nullable restore
#line 22 "C:\Users\Pati\Downloads\Telegram Desktop\MekinaWebsite (2)\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
                 if(SignInManager.IsSignedIn(User)){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 773, "\"", 802, 2);
            WriteAttributeValue("", 780, "/cars/book/", 780, 11, true);
#nullable restore
#line 23 "C:\Users\Pati\Downloads\Telegram Desktop\MekinaWebsite (2)\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
WriteAttributeValue("", 791, item.CarId, 791, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Book this car</a> \r\n");
#nullable restore
#line 24 "C:\Users\Pati\Downloads\Telegram Desktop\MekinaWebsite (2)\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
					
				}

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Pati\Downloads\Telegram Desktop\MekinaWebsite (2)\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
                 if(SignInManager.IsSignedIn(User) && User.IsInRole("Admin"))
				{
					

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 949, "\"", 978, 2);
            WriteAttributeValue("", 956, "/cars/edit/", 956, 11, true);
#nullable restore
#line 29 "C:\Users\Pati\Downloads\Telegram Desktop\MekinaWebsite (2)\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
WriteAttributeValue("", 967, item.CarId, 967, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary  mt-1\">Update</a>                \r\n\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1044, "\"", 1075, 2);
            WriteAttributeValue("", 1051, "/cars/delete/", 1051, 13, true);
#nullable restore
#line 30 "C:\Users\Pati\Downloads\Telegram Desktop\MekinaWebsite (2)\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
WriteAttributeValue("", 1064, item.CarId, 1064, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" style=\"margin-top:3px;\">Delete</a>\r\n");
#nullable restore
#line 31 "C:\Users\Pati\Downloads\Telegram Desktop\MekinaWebsite (2)\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</div>\r\n");
#nullable restore
#line 33 "C:\Users\Pati\Downloads\Telegram Desktop\MekinaWebsite (2)\MekinaWebsite\MekinaWebsite\Views\Cars\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; } = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MekinaWebsite.Models.CarsList>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
