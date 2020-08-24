#pragma checksum "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Components\ImportInformation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bca62580d1a88a2edbd7fea7e8c413860f54c1cb"
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
    public partial class ImportInformation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "import-information d-flex justify-content-end");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "span");
            __builder.AddAttribute(4, "class", "mr-3");
            __builder.AddMarkupContent(5, "\r\n        <i class=\"fas fa-file-import icon-blur\"></i>\r\n        ");
            __builder.AddContent(6, 
#nullable restore
#line 6 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Components\ImportInformation.razor"
         fileName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "span");
            __builder.AddAttribute(10, "class", "ml-3");
            __builder.AddMarkupContent(11, "\r\n        <i class=\"fas fa-database icon-blur\"></i>\r\n        ");
            __builder.AddContent(12, 
#nullable restore
#line 10 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Components\ImportInformation.razor"
         selectedDataType.Label

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Components\ImportInformation.razor"
       
    private string fileName = string.Empty;
    private LabelAndValue selectedDataType = new LabelAndValue();

    protected override async Task OnInitializedAsync()
    {
        fileName = await sessionStorage.GetItemAsync<string>("fileName");
        selectedDataType = await sessionStorage.GetItemAsync<LabelAndValue>("selectedDataType");

        await base.OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
