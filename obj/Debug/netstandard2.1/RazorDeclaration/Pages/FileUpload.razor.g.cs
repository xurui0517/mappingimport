#pragma checksum "C:\Code\mappingimport\mappingimport\Pages\FileUpload.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6cb7e4f52d2a379c50721336019391e66a096cf"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MappingsSquad.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Code\mappingimport\mappingimport\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\mappingimport\mappingimport\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Code\mappingimport\mappingimport\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Code\mappingimport\mappingimport\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Code\mappingimport\mappingimport\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Code\mappingimport\mappingimport\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Code\mappingimport\mappingimport\_Imports.razor"
using MappingsSquad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Code\mappingimport\mappingimport\_Imports.razor"
using MappingsSquad.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Code\mappingimport\mappingimport\_Imports.razor"
using MappingsSquad.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Code\mappingimport\mappingimport\_Imports.razor"
using MappingsSquad.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Code\mappingimport\mappingimport\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Code\mappingimport\mappingimport\_Imports.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\mappingimport\mappingimport\Pages\FileUpload.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Code\mappingimport\mappingimport\Pages\FileUpload.razor"
using OfficeOpenXml;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Code\mappingimport\mappingimport\Pages\FileUpload.razor"
using MappingsSquad.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Code\mappingimport\mappingimport\Pages\FileUpload.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FileUpload")]
    public partial class FileUpload : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Code\mappingimport\mappingimport\Pages\FileUpload.razor"
       
    const int MaxFileSize = 5 * 1024 * 1024; // 5MB
    private bool showOverlay = false;
    string fileName;
    Dictionary<string, string> headers = new Dictionary<string, string>();
    Dictionary<string, Dictionary<string, string>> data = new Dictionary<string, Dictionary<string, string>>();

    string[] columns = new[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

    private void HideOverlay()
    {
        showOverlay = false;
    }

    protected override async Task OnInitializedAsync()
    {
        var selectedDataType = await sessionStorage.GetItemAsync<LabelAndValue>("selectedDataType");

        if (selectedDataType == null)
        {
            navigationManager.NavigateTo("/");
            return;
        }

        await base.OnInitializedAsync();
    }

    async Task ViewFile(IFileListEntry[] files)
    {
        var file = files.FirstOrDefault();
        if (file == null)
        {
            return;
        }
        else if (file.IsNotAccepted())
        {
            showOverlay = true;
            return;
        }
        else if (file.Size > MaxFileSize)
        {
            // TODO: Add some error handling here
        }
        else
        {
            headers = new Dictionary<string, string>();
            fileName = file.Name;
            await sessionStorage.SetItemAsync<string>("fileName", fileName);
            await using MemoryStream memoryStream = new MemoryStream();
            await file.Data.CopyToAsync(memoryStream);

            using (var package = new ExcelPackage(memoryStream))
            {
                var workSheet = package.Workbook.Worksheets.FirstOrDefault();
                for (int col = 1; col <= workSheet.Dimension.End.Column; col++)
                {
                    var headerValue = workSheet.Cells[1, col].Value.ToString();
                    headers.Add(columns[col - 1], headerValue);
                }

                for (int row = 2; row <= workSheet.Dimension.End.Row; row++)
                {
                    Dictionary<string, string> dataRow = new Dictionary<string, string>();
                    for (int col = 1; col <= workSheet.Dimension.End.Column; col++)
                    {
                        var header = workSheet.Cells[1, col].Value.ToString();
                        var value = workSheet.Cells[row, col].Value.ToString();
                        dataRow.Add(header.ToLower(), value);
                    }
                    data.Add(row.ToString(), dataRow);
                }
            }

            await sessionStorage.SetItemAsync<Dictionary<string, string>>("headers", headers);
            await sessionStorage.SetItemAsync<Dictionary<string, Dictionary<string, string>>>("excelData", data);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
