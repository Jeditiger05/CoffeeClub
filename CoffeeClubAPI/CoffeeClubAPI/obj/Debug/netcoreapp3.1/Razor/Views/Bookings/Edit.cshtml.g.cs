#pragma checksum "C:\Users\John\OneDrive\Swinburne 2020\Anhs Class\Practice Challenge Coffee\CoffeeClubAPI\CoffeeClubAPI\Views\Bookings\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f547dad29f9faafcf2e0ac5b00c8bd1736b59b41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookings_Edit), @"mvc.1.0.view", @"/Views/Bookings/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f547dad29f9faafcf2e0ac5b00c8bd1736b59b41", @"/Views/Bookings/Edit.cshtml")]
    public class Views_Bookings_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoffeeClubAPI.Models.Booking>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\John\OneDrive\Swinburne 2020\Anhs Class\Practice Challenge Coffee\CoffeeClubAPI\CoffeeClubAPI\Views\Bookings\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Booking</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""BookingNumber"" />
            <div class=""form-group"">
                <label asp-for=""BookingDate"" class=""control-label""></label>
                <input asp-for=""BookingDate"" class=""form-control"" />
                <span asp-validation-for=""BookingDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Shoutee"" class=""control-label""></label>
                <input asp-for=""Shoutee"" class=""form-control"" />
                <span a");
            WriteLiteral(@"sp-validation-for=""Shoutee"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""AmountShouted"" class=""control-label""></label>
                <input asp-for=""AmountShouted"" class=""form-control"" />
                <span asp-validation-for=""AmountShouted"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Venue"" class=""control-label""></label>
                <input asp-for=""Venue"" class=""form-control"" />
                <span asp-validation-for=""Venue"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\John\OneDrive\Swinburne 2020\Anhs Class\Practice Challenge Coffee\CoffeeClubAPI\CoffeeClubAPI\Views\Bookings\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoffeeClubAPI.Models.Booking> Html { get; private set; }
    }
}
#pragma warning restore 1591
