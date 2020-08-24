#pragma checksum "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\ImportResult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88209c46e8c0ff1f5d116ae3e19292240d015d80"
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
#nullable restore
#line 2 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\ImportResult.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/importResult")]
    public partial class ImportResult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MappingsSquad.Components.TopRowPage>(0);
            __builder.AddAttribute(1, "TopPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MappingsSquad.Models.TopPage>(
#nullable restore
#line 7 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\ImportResult.razor"
                     TopPage.Result

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "mt-3 animate slideIn");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row d-flex justify-content-between align-items-baseline");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.AddMarkupContent(9, "<h3 class=\"font-weight-bolder\">Data Import Details <i class=\"far fa-question-circle icon-blur\"></i></h3>\r\n        ");
            __builder.OpenComponent<MappingsSquad.Components.ImportInformation>(10);
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "progress");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "progress-bar progress-bar-purple");
            __builder.AddAttribute(18, "role", "progressbar");
            __builder.AddAttribute(19, "style", "width:" + " " + (
#nullable restore
#line 16 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\ImportResult.razor"
                                                                                         percentageImport

#line default
#line hidden
#nullable disable
            ) + "%");
            __builder.AddAttribute(20, "aria-valuenow", 
#nullable restore
#line 16 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\ImportResult.razor"
                                                                                                                             percentageImport

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "aria-valuemin", "0");
            __builder.AddAttribute(22, "aria-valuemax", "100");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "mt-3");
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenComponent<MappingsSquad.Components.TabSet>(28);
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.OpenComponent<MappingsSquad.Components.Tab>(31);
                __builder2.AddAttribute(32, "Title", "Import Result Information");
                __builder2.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(34, "\r\n                ");
                    __builder3.OpenElement(35, "table");
                    __builder3.AddAttribute(36, "class", "table");
                    __builder3.AddMarkupContent(37, "\r\n                    ");
                    __builder3.OpenElement(38, "tbody");
                    __builder3.AddMarkupContent(39, "\r\n                        ");
                    __builder3.OpenElement(40, "tr");
                    __builder3.AddMarkupContent(41, "\r\n                            ");
                    __builder3.AddMarkupContent(42, "<td>Start Time</td>\r\n                            ");
                    __builder3.OpenElement(43, "td");
                    __builder3.AddContent(44, 
#nullable restore
#line 26 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\ImportResult.razor"
                                 importStat.StartTime

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(45, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(46, "\r\n                        ");
                    __builder3.OpenElement(47, "tr");
                    __builder3.AddMarkupContent(48, "\r\n                            ");
                    __builder3.AddMarkupContent(49, "<td>End time</td>\r\n                            ");
                    __builder3.OpenElement(50, "td");
                    __builder3.AddContent(51, 
#nullable restore
#line 30 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\ImportResult.razor"
                                 importStat.EndTime

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(52, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(53, "\r\n                        ");
                    __builder3.OpenElement(54, "tr");
                    __builder3.AddMarkupContent(55, "\r\n                            ");
                    __builder3.AddMarkupContent(56, "<td>Total time taken</td>\r\n                            ");
                    __builder3.OpenElement(57, "td");
                    __builder3.AddContent(58, 
#nullable restore
#line 34 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\ImportResult.razor"
                                 importStat.TotalMinutes.ToString("f2")

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(59, " min(s)");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(60, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(61, "\r\n                        ");
                    __builder3.OpenElement(62, "tr");
                    __builder3.AddMarkupContent(63, "\r\n                            ");
                    __builder3.AddMarkupContent(64, "<td>No. of records processed</td>\r\n                            ");
                    __builder3.OpenElement(65, "td");
                    __builder3.AddContent(66, 
#nullable restore
#line 38 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\ImportResult.razor"
                                 numberOfRecords

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(67, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(68, "\r\n                        ");
                    __builder3.OpenElement(69, "tr");
                    __builder3.AddMarkupContent(70, "\r\n                            ");
                    __builder3.AddMarkupContent(71, "<td>No. of records successful</td>\r\n                            ");
                    __builder3.OpenElement(72, "td");
                    __builder3.AddContent(73, 
#nullable restore
#line 42 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\ImportResult.razor"
                                 numberOfSuccessRecords

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(74, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(75, "\r\n                        ");
                    __builder3.OpenElement(76, "tr");
                    __builder3.AddMarkupContent(77, "\r\n                            ");
                    __builder3.AddMarkupContent(78, "<td>No. of records failed</td>\r\n                            ");
                    __builder3.OpenElement(79, "td");
                    __builder3.AddContent(80, 
#nullable restore
#line 46 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\ImportResult.razor"
                                 numberOfErrorRecords

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(81, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(82, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(83, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(84, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\r\n            ");
                __builder2.OpenComponent<MappingsSquad.Components.Tab>(86);
                __builder2.AddAttribute(87, "Title", "Number of failed records");
                __builder2.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(89, "\r\n");
#nullable restore
#line 52 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\ImportResult.razor"
                 if (failureRecords.Any())
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(90, "                    ");
                    __Blazor.MappingsSquad.Pages.ImportResult.TypeInference.CreateTable_0(__builder3, 91, 92, 
#nullable restore
#line 54 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\ImportResult.razor"
                                  failureRecords

#line default
#line hidden
#nullable disable
                    , 93, (__builder4) => {
                        __builder4.AddMarkupContent(94, "\r\n                            ");
                        __builder4.AddMarkupContent(95, "<th>#</th>\r\n");
#nullable restore
#line 57 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\ImportResult.razor"
                             foreach (var header in headers)
                            {
                                if (header != "ROW")
                                {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(96, "                                    ");
                        __builder4.OpenElement(97, "th");
                        __builder4.AddContent(98, 
#nullable restore
#line 61 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\ImportResult.razor"
                                         header

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(99, "\r\n");
#nullable restore
#line 62 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\ImportResult.razor"
                                }
                            }

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(100, "                        ");
                    }
                    , 101, (context) => (__builder4) => {
                        __builder4.AddMarkupContent(102, "\r\n                            ");
                        __builder4.OpenElement(103, "td");
                        __builder4.AddContent(104, 
#nullable restore
#line 66 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\ImportResult.razor"
                                 context["ROW"]

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(105, "\r\n");
#nullable restore
#line 67 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\ImportResult.razor"
                             foreach (var header in headers)
                                {
                                    if (header != "ROW")
                                    {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(106, "                                    ");
                        __builder4.OpenElement(107, "td");
                        __builder4.AddContent(108, 
#nullable restore
#line 71 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\ImportResult.razor"
                                         context[header]

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(109, "\r\n");
#nullable restore
#line 72 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\ImportResult.razor"
                                    }
                                }

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(110, "                        ");
                    }
                    );
                    __builder3.AddMarkupContent(111, "\r\n");
#nullable restore
#line 76 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\ImportResult.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(112, "            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(113, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(114, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n\r\n");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "class", "fixed-bottom shadow p-3 bg-white");
            __builder.AddMarkupContent(119, "\r\n    ");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "container");
            __builder.AddMarkupContent(122, "\r\n        ");
            __builder.OpenElement(123, "button");
            __builder.AddAttribute(124, "class", "btn btn-purple btn-lg px-5");
            __builder.AddAttribute(125, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 84 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\ImportResult.razor"
                                                               e => navigationManager.NavigateTo("/")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(126, "Start another import");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 88 "C:\Code\RTFileMappingAndImportTool\MappingsSquad\MappingsSquad\Pages\ImportResult.razor"
       
    private int numberOfRecords = 0;
    private int numberOfErrorRecords = 0;
    private int numberOfSuccessRecords = 0;
    private int percentageImport = 0;

    private List<string> headers = new List<string> { };
    private List<Dictionary<string, string>> failureRecords = new List<Dictionary<string, string>>();
    private ImportStat importStat = new ImportStat();

    protected override async Task OnInitializedAsync()
    {
        importStat = await sessionStorage.GetItemAsync<ImportStat>("importStat");

        var importResult = await sessionStorage.GetItemAsync<string>("importResult");

        if (string.IsNullOrEmpty(importResult))
        {
            navigationManager.NavigateTo("/Import");
            return;
        }

        List<Dictionary<string, string>> resultObjects = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(importResult);

        var errorObjects = resultObjects.Where(obj => !string.IsNullOrEmpty(obj.GetValueOrDefault("Error"))).ToList();

        numberOfRecords = resultObjects.Count;
        numberOfErrorRecords = errorObjects.Count;
        numberOfSuccessRecords = numberOfRecords - numberOfErrorRecords;

        failureRecords = await PopulateTheFailureRecords(errorObjects);

        if (failureRecords.Any())
        {
            headers = failureRecords.First().Select(record => record.Key).ToList();
        }
        percentageImport = numberOfRecords == 0 ? 0 : (numberOfSuccessRecords / numberOfRecords) * 100;
        await base.OnInitializedAsync();
    }

    private async Task<List<Dictionary<string, string>>> PopulateTheFailureRecords(List<Dictionary<string, string>> errorObjects)
    {
        var mappedFields = await sessionStorage.GetItemAsync<Dictionary<string, MappedField>>("mappedFields");
        var result = new List<Dictionary<string, string>>();
        foreach(var errorObject in errorObjects)
        {
            var data = new Dictionary<string, string>();
            foreach(var obj in errorObject)
            {
                if (obj.Key != "Error" && obj.Key != "ROW")
                {
                    var mappedField = mappedFields.Where(m => m.Value.Field.ApiInternalName == obj.Key).FirstOrDefault();
                    data.Add(mappedField.Value.Header, obj.Value);
                }
                else
                {
                    data.Add(obj.Key, obj.Value);
                }
            }
            result.Add(data);
        }
        return result;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionStorageService sessionStorage { get; set; }
    }
}
namespace __Blazor.MappingsSquad.Pages.ImportResult
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTable_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IReadOnlyList<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg2)
        {
        __builder.OpenComponent<global::MappingsSquad.Components.Table<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "TableHeader", __arg1);
        __builder.AddAttribute(__seq2, "RowTemplate", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591