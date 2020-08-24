#pragma checksum "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Components\MappingFieldDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a511ecd22f1ec3a3a0bdd7d54d63bb395cf6d49c"
// <auto-generated/>
#pragma warning disable 1591
namespace MappingsSquad.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using MappingsSquad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using MappingsSquad.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using MappingsSquad.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using MappingsSquad.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\_Imports.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
    public partial class MappingFieldDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "my-1");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<label>Selected Column</label>\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.AddAttribute(7, "disabled", true);
            __builder.AddAttribute(8, "value", 
#nullable restore
#line 3 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Components\MappingFieldDetail.razor"
                                                             MappedField.Header

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "my-1");
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.AddMarkupContent(14, "<label>Matched Column</label>\r\n    ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "text");
            __builder.AddAttribute(17, "class", "form-control");
            __builder.AddAttribute(18, "disabled", true);
            __builder.AddAttribute(19, "value", 
#nullable restore
#line 7 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Components\MappingFieldDetail.razor"
                                                             MappedField.Field

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.AddMarkupContent(22, "<p class=\"my-1\">\r\n    100% of the row have a value for this column\r\n</p>\r\n");
            __builder.AddMarkupContent(23, "<div class=\"my-1\">\r\n    <button class=\"btn btn-block btn-primary rounded\">Confirm Mapping</button>\r\n</div>\r\n");
            __builder.AddMarkupContent(24, "<div class=\"my-1 d-flex flex-row justify-content-between align-items-baseline\">\r\n    <button class=\"btn btn-block btn-outline-dark mr-1\">Previous</button>\r\n    <button class=\"btn btn-block btn-outline-dark ml-1\">Next</button>\r\n</div>\r\n");
            __builder.AddMarkupContent(25, "<div>\r\n    <img src=\"/assests/Blonde.svg\">\r\n</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Components\MappingFieldDetail.razor"
       
    [Parameter] public MappedField MappedField { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
