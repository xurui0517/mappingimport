#pragma checksum "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f7c3662a5b89696911e4ad3f4b7e5bb853ad20d"
// <auto-generated/>
#pragma warning disable 1591
namespace MappingsSquad.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#nullable restore
#line 3 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Import")]
    public partial class Import : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MappingsSquad.Components.TopRowPage>(0);
            __builder.AddAttribute(1, "TopPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MappingsSquad.Models.TopPage>(
#nullable restore
#line 12 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                     TopPage.Import

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenComponent<MappingsSquad.Components.Loader>(3);
            __builder.AddAttribute(4, "Loading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                 loading

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "mt-3 animate slideIn");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "d-flex justify-content-between align-items-baseline");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.AddMarkupContent(12, "<h3>Review Fields Before Importing <i class=\"far fa-question-circle icon-blur\"></i></h3>\r\n        ");
            __builder.OpenComponent<MappingsSquad.Components.ImportInformation>(13);
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "mapping-information d-flex justify-content-around mt-3");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "mapped-fields" + " " + (
#nullable restore
#line 22 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                                    showMappedFields ? "active" : ""

#line default
#line hidden
#nullable disable
            ) + " px-5" + " mr-1" + " py-3" + " flex-fill" + " rounded");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                                                                                                                    e => SelectMappedFields(true)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "h1");
            __builder.AddAttribute(24, "class", "text-center");
            __builder.AddContent(25, 
#nullable restore
#line 23 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                                     numberOfMappedFields.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.AddMarkupContent(27, "<p class=\"text-center\">\r\n                <i class=\"checked-icon fas fa-check-circle\"></i>\r\n                <span class=\"font-weight-bolder\">Number of Mapped Fields</span>\r\n            </p>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n        ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "unmapped-fields" + " " + (
#nullable restore
#line 30 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                                      !showMappedFields ? "active" : ""

#line default
#line hidden
#nullable disable
            ) + " px-5" + " py-3" + " ml-1" + " flex-fill" + " rounded");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                                                                                                                       e => SelectMappedFields(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "h1");
            __builder.AddAttribute(34, "class", "text-center");
            __builder.AddContent(35, 
#nullable restore
#line 31 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                                     numberOfUnmappedFields.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.AddMarkupContent(37, "<p class=\"text-center\">\r\n                <i class=\"fas fa-check-circle\" style=\"opacity: 0.5\"></i>\r\n                <span class=\"font-weight-bolder\">Number of UnMapped Fields</span>\r\n            </p>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "mt-3 table-responsive");
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 39 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
         if (excelData.Any())
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "            ");
            __builder.OpenElement(44, "table");
            __builder.AddAttribute(45, "class", "table table-bordered border-secondary table-sm");
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "thead");
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.OpenElement(49, "tr");
            __builder.AddMarkupContent(50, "\r\n                        ");
            __builder.AddMarkupContent(51, "<th scope=\"col\">#</th>\r\n");
#nullable restore
#line 45 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                         foreach (var mappedField in selectedFields)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "                            ");
            __builder.OpenElement(53, "th");
            __builder.AddContent(54, 
#nullable restore
#line 47 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                                 mappedField.Header

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 48 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "tbody");
            __builder.AddMarkupContent(60, "\r\n");
#nullable restore
#line 52 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                     foreach (var item in excelData)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(61, "                        ");
            __builder.OpenElement(62, "tr");
            __builder.AddMarkupContent(63, "\r\n                            ");
            __builder.OpenElement(64, "td");
            __builder.AddContent(65, 
#nullable restore
#line 55 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                                 item.Key

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 56 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                             foreach (var mappedField in selectedFields)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(67, "                                ");
            __builder.OpenElement(68, "td");
            __builder.AddContent(69, 
#nullable restore
#line 58 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                                     item.Value[mappedField.Header.ToLower()]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
#nullable restore
#line 59 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(71, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
#nullable restore
#line 61 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(73, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n");
#nullable restore
#line 64 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n\r\n");
#nullable restore
#line 68 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
 if (showOverlay)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(79, "    ");
            __builder.OpenComponent<MappingsSquad.Components.Overlay>(80);
            __builder.AddAttribute(81, "Display", "block");
            __builder.AddAttribute(82, "OnVanish", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 70 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                                         e => showOverlay = false

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(84, "\r\n        ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "bg-white p-5 text-center rounded");
                __builder2.AddEventStopPropagationAttribute(87, "onclick", 
#nullable restore
#line 71 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                                                                                true

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(88, "\r\n            <img src=\"/assests/duo.svg\">\r\n            ");
                __builder2.AddMarkupContent(89, "<h3 class=\"mt-4\">Oops ! There was an exception</h3>\r\n            ");
                __builder2.OpenElement(90, "p");
                __builder2.AddAttribute(91, "class", "text-black-50");
                __builder2.AddContent(92, 
#nullable restore
#line 74 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                                      errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n            ");
                __builder2.AddMarkupContent(94, "<button class=\"btn btn-primary btn-lg\">Please Try Again</button>\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(96, "\r\n");
#nullable restore
#line 78 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(97, "\r\n");
#nullable restore
#line 80 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
 if (showSuccessPopup)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(98, "    ");
            __builder.OpenComponent<MappingsSquad.Components.Overlay>(99);
            __builder.AddAttribute(100, "Display", "block");
            __builder.AddAttribute(101, "OnVanish", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 82 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                                         e => navigationManager.NavigateTo("/")

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(102, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(103, "\r\n        ");
                __builder2.OpenElement(104, "div");
                __builder2.AddAttribute(105, "class", "bg-purple p-5 text-center rounded");
                __builder2.AddEventStopPropagationAttribute(106, "onclick", 
#nullable restore
#line 83 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                                                                                 true

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(107, "\r\n            <img src=\"/assests/Trio 2.svg\">\r\n            ");
                __builder2.AddMarkupContent(108, "<h2 class=\"text-white mt-3\">Congratulations! Your import was successful</h2>\r\n            ");
                __builder2.OpenElement(109, "div");
                __builder2.AddAttribute(110, "class", "mt-5");
                __builder2.AddMarkupContent(111, "\r\n                ");
                __builder2.OpenElement(112, "button");
                __builder2.AddAttribute(113, "class", "btn btn-green btn-lg");
                __builder2.AddAttribute(114, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 87 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                                                                 e => navigationManager.NavigateTo("/")

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddEventStopPropagationAttribute(115, "onclick", 
#nullable restore
#line 87 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                                                                                                                                    true

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(116, "Start another import");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n                ");
                __builder2.OpenElement(118, "button");
                __builder2.AddAttribute(119, "class", "btn btn-outline-light btn-lg text-black-50");
                __builder2.AddAttribute(120, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                                                                                       e => navigationManager.NavigateTo("/ImportResult")

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(121, "View my imports");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(125, "\r\n");
#nullable restore
#line 92 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(126, "\r\n");
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "class", "fixed-bottom shadow p-3 bg-white");
            __builder.AddMarkupContent(129, "\r\n    ");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "container");
            __builder.AddMarkupContent(132, "\r\n        ");
            __builder.OpenElement(133, "button");
            __builder.AddAttribute(134, "class", "btn btn-outline-purple btn-lg px-5");
            __builder.AddAttribute(135, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                                                                       e => navigationManager.NavigateTo("/MappingsSelection")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(136, "Back");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n        ");
            __builder.OpenElement(138, "button");
            __builder.AddAttribute(139, "class", "btn btn-purple btn-lg px-5");
            __builder.AddAttribute(140, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 97 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
                                                             ImportData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(141, "Import");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 101 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\Import.razor"
       
    private Dictionary<string, MappedField> mappedFields = new Dictionary<string, MappedField>();
    private Dictionary<string, Dictionary<string, string>> excelData = new Dictionary<string, Dictionary<string, string>>();
    private List<MappedField> numberOfMappedFields = new List<MappedField>();
    private List<MappedField> numberOfUnmappedFields = new List<MappedField>();
    private List<MappedField> selectedFields = new List<MappedField>();
    private bool showMappedFields = true;
    private bool showOverlay = false;
    private string errorMessage = string.Empty;
    private bool showSuccessPopup = false;
    private bool loading = false;

    protected override async Task OnInitializedAsync()
    {
        mappedFields = await sessionStorage.GetItemAsync<Dictionary<string, MappedField>>("mappedFields");
        if (mappedFields == null || !mappedFields.Any())
        {
            navigationManager.NavigateTo("/MappingsSelection");
            return;
        }
        excelData = await sessionStorage.GetItemAsync<Dictionary<string, Dictionary<string, string>>>("excelData");
        numberOfMappedFields = mappedFields.Where(mappedField => !mappedField.Value.Skip).Select(mappedField => mappedField.Value).ToList();
        numberOfUnmappedFields = mappedFields.Where(mappedField => mappedField.Value.Skip).Select(mappedField => mappedField.Value).ToList();
        selectedFields = numberOfMappedFields;
        await base.OnInitializedAsync();
    }

    private void SelectMappedFields(bool selectMappedFields)
    {
        showMappedFields = selectMappedFields;
        selectedFields = selectMappedFields ? numberOfMappedFields : numberOfUnmappedFields;
    }

    private async Task ImportData()
    {
        loading = true;
        var importStat = new ImportStat();

        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        importStat.StartTime = DateTime.Now.ToString("dd/MM/yyyy hh:mm");

        var selectedDataType = await sessionStorage.GetItemAsync<LabelAndValue>("selectedDataType");

        if (selectedDataType == null)
        {
            navigationManager.NavigateTo("/");
            return;
        }

        IList<Dictionary<string, string>> ilDataType = new List<Dictionary<string, string>>();

        foreach (var row in excelData.Keys)
        {
            if (row != null)
            {
                var rowItem = excelData[row];
                if (rowItem != null)
                {
                    var data = new Dictionary<string, string>();
                    data["ROW"] = row;

                    foreach (var columnName in rowItem.Keys)
                    {
                        var macthedColumn = numberOfMappedFields.Find(e => e.Header.ToLower() == columnName.ToLower());

                        if (macthedColumn != null)
                        {
                            data[macthedColumn.Field.ApiInternalName] = rowItem[columnName];
                        }
                    }

                    ilDataType.Add(data);
                }
            }
        }

        object obImport = new
        {
            importType = selectedDataType.Value,
            importData = ilDataType
        };

        var jObject = JsonConvert.SerializeObject(obImport);

        string strEndPoint = "https://innovationapiteame.zambion.com/";
        strEndPoint += "api/Innovation/InnovationImport?";
        strEndPoint += "Username=ZBN0236&Password=52287F9C-6BCE-4868-A3AE-6939D4FD2448";
        try
        {

            HttpClient httpClient = new HttpClient();
            var stringContent = new StringContent(jObject, UnicodeEncoding.UTF8, "application/json"); // use MediaTypeNames.Application.Json in Core 3.0+ and Standard 2.1+

            HttpResponseMessage response = await httpClient.PostAsync(strEndPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                await sessionStorage.SetItemAsync<string>("importResult", responseContent);
                showSuccessPopup = true;
            }
            else
            {
                errorMessage = "There was an exception in the case";
                throw new Exception(response.StatusCode.ToString());
            }
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
            showOverlay = true;
        }
        finally
        {
            loading = false;
            stopWatch.Stop();
            importStat.EndTime = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
            importStat.TotalMinutes = stopWatch.Elapsed.TotalMinutes;
            await sessionStorage.SetItemAsync<ImportStat>("importStat", importStat);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
