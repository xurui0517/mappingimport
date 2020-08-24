#pragma checksum "C:\Code\mappingimport\mappingimport\Pages\MappingsSelection.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1297e276c4d4d0018a3c1b057718b98ff2b94186"
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
#line 3 "C:\Code\mappingimport\mappingimport\Pages\MappingsSelection.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MappingsSelection")]
    public partial class MappingsSelection : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MappingsSquad.Components.TopRowPage>(0);
            __builder.AddAttribute(1, "TopPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MappingsSquad.Models.TopPage>(
#nullable restore
#line 10 "C:\Code\mappingimport\mappingimport\Pages\MappingsSelection.razor"
                     TopPage.Mapping

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenComponent<MappingsSquad.Components.Loader>(3);
            __builder.AddAttribute(4, "Loading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Code\mappingimport\mappingimport\Pages\MappingsSelection.razor"
                 loading

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
#nullable restore
#line 14 "C:\Code\mappingimport\mappingimport\Pages\MappingsSelection.razor"
 if (mappedFields.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "mt-3 animate slideIn");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row d-flex justify-content-between align-items-baseline");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.AddMarkupContent(13, "<h3 class=\"font-weight-bolder\">Mapping <i class=\"far fa-question-circle icon-blur\"></i></h3>\r\n            ");
            __builder.AddMarkupContent(14, "<span class=\"ml-5 bg-light px-2 py-2 rounded font-weight-bolder text-black-50\"> Press A-Z </span>\r\n            ");
            __builder.AddMarkupContent(15, "<span class=\"ml-2 gochi-hand\"> Auto jump to a specific spreadsheet header</span>\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "flex-grow-1 float-right");
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenComponent<MappingsSquad.Components.ImportInformation>(19);
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "row mt-3 d-flex align-items-start");
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "mapping-field-wrapper col-12 bg-light d-flex flex-column px-4 py-3 rounded");
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.AddMarkupContent(29, @"<div class=""d-flex flex-row justify-content-around align-items-center"">
                    <div class=""text-center col-6 gochi-hand"">Uploaded Spreadsheet Header</div>
                    <div class=""text-center col-5 gochi-hand"">Mapped Fields</div>
                    <div class=""ml-5 no-gutters col-1 text-center gochi-hand"">Confirm Mapping</div>
                </div>
");
#nullable restore
#line 33 "C:\Code\mappingimport\mappingimport\Pages\MappingsSelection.razor"
                 foreach (var mappedField in mappedFields)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "                    ");
            __builder.OpenComponent<MappingsSquad.Components.MappingField>(31);
            __builder.AddAttribute(32, "Fields", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<MappingsSquad.Models.ApiMappingField>>(
#nullable restore
#line 36 "C:\Code\mappingimport\mappingimport\Pages\MappingsSelection.razor"
                                           apiMappingfields

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "MappedField", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MappingsSquad.Models.MappedField>(
#nullable restore
#line 37 "C:\Code\mappingimport\mappingimport\Pages\MappingsSelection.razor"
                                                mappedField.Value

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "OnConfirm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<MappingsSquad.Models.MappedField>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<MappingsSquad.Models.MappedField>(this, 
#nullable restore
#line 38 "C:\Code\mappingimport\mappingimport\Pages\MappingsSelection.razor"
                                              UpdateMappedField

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(35, "OnSelect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<MappingsSquad.Models.MappedField>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<MappingsSquad.Models.MappedField>(this, 
#nullable restore
#line 39 "C:\Code\mappingimport\mappingimport\Pages\MappingsSelection.razor"
                                             SelectMappedField

#line default
#line hidden
#nullable disable
            )));
            __builder.SetKey(
#nullable restore
#line 35 "C:\Code\mappingimport\mappingimport\Pages\MappingsSelection.razor"
                                        mappedField.Key

#line default
#line hidden
#nullable disable
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 41 "C:\Code\mappingimport\mappingimport\Pages\MappingsSelection.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 45 "C:\Code\mappingimport\mappingimport\Pages\MappingsSelection.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 47 "C:\Code\mappingimport\mappingimport\Pages\MappingsSelection.razor"
 if (mappedFields.Any(mappedField => !mappedField.Value.Skip))
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "fixed-bottom shadow p-3 bg-white");
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "container");
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "class", "btn btn-outline-purple btn-lg px-5");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Code\mappingimport\mappingimport\Pages\MappingsSelection.razor"
                                                                           e => navigationManager.NavigateTo("/FileUpload")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(52, "Back");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "class", "btn btn-purple btn-lg px-5");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Code\mappingimport\mappingimport\Pages\MappingsSelection.razor"
                                                                   async (e) => await SavingMappedFields()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(57, "\r\n                Next\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
#nullable restore
#line 57 "C:\Code\mappingimport\mappingimport\Pages\MappingsSelection.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 59 "C:\Code\mappingimport\mappingimport\Pages\MappingsSelection.razor"
 if (showOverlay)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "    ");
            __builder.OpenComponent<MappingsSquad.Components.Overlay>(63);
            __builder.AddAttribute(64, "Display", "block");
            __builder.AddAttribute(65, "OnVanish", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 61 "C:\Code\mappingimport\mappingimport\Pages\MappingsSelection.razor"
                                        HideOverlay

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(67, "\r\n        ");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "bg-white p-5 text-center rounded");
                __builder2.AddMarkupContent(70, "\r\n            <img src=\"/assests/duo.svg\">\r\n            ");
                __builder2.AddMarkupContent(71, "<h3 class=\"mt-4\">Mapping Error</h3>\r\n            ");
                __builder2.OpenElement(72, "p");
                __builder2.AddAttribute(73, "class", "text-black-50");
                __builder2.AddContent(74, 
#nullable restore
#line 65 "C:\Code\mappingimport\mappingimport\Pages\MappingsSelection.razor"
                                      validationError

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n            ");
                __builder2.AddMarkupContent(76, "<button class=\"btn btn-primary btn-lg\">Please Try Again</button>\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(78, "\r\n");
#nullable restore
#line 69 "C:\Code\mappingimport\mappingimport\Pages\MappingsSelection.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Code\mappingimport\mappingimport\Pages\MappingsSelection.razor"
       
    private List<ApiMappingField> apiMappingfields = new List<ApiMappingField>();
    private Dictionary<string, string> headers = new Dictionary<string, string>();
    private Dictionary<string, MappedField> mappedFields = new Dictionary<string, MappedField>();
    private MappedField selectedMappedField = new MappedField();
    private bool loading = true;
    private bool isInvalid = false;
    private bool showOverlay = false;
    private string validationError = "";

    protected override async Task OnInitializedAsync()
    {
        loading = true;

        await GetApiMappingFields();
        headers = await sessionStorage.GetItemAsync<Dictionary<string, string>>("headers");
        if (headers == null)
        {
            navigationManager.NavigateTo("/FileUpload");
        }

        await CreateMappedFields();

        loading = false;

        await base.OnInitializedAsync();
    }


    private void HideOverlay()
    {
        showOverlay = false;
    }

    private void UpdateMappedField(MappedField mappedField)
    {
        mappedFields[mappedField.Column] = mappedField;
        ValidateCompulsaryFields();
    }

    private void SelectMappedField(MappedField mappedField)
    {
        selectedMappedField = mappedField;
        ValidateCompulsaryFields();
    }

    private void ValidateCompulsaryFields()
    {

        var ilCompulsoryField = apiMappingfields.Where(p => p.IsCompulsory == true);

        if (ilCompulsoryField != null && ilCompulsoryField.Count() > 0)
        {
            bool bIsCompulsoryAllMapped = ilCompulsoryField.All(w => mappedFields.Values.Any(o => w.IsCompulsory == true && o.Skip == false && w.ApiInternalName == o.Field?.ApiInternalName));

            if (bIsCompulsoryAllMapped == false)
            {
                string strCompulsoryFields = string.Join(", ", ilCompulsoryField.Select(z => z.DisplayName));
                this.validationError = "Not All Api Compulsary Fields Mapped: " + strCompulsoryFields;
                isInvalid = true;
                return;
            }
        }

        var ilConfirmedNotMapped = mappedFields.Values.Where(p => p.Skip == false && (p.Field?.ApiInternalName == "" || p.Field == null));
        if (ilConfirmedNotMapped != null && ilConfirmedNotMapped.Count() > 0)
        {
            string stronfirmedNotMapped = string.Join(", ", ilConfirmedNotMapped.Select(z => z.Header));
            this.validationError = "Confirm Fields Not Mapped: " + stronfirmedNotMapped;
            isInvalid = true;
            return;
        }

        isInvalid = false;
    }

    private void CreateNewMappedFields()
    {
        try
        {
            foreach (var header in headers)
            {
                if (mappedFields == null)
                {
                    mappedFields = new Dictionary<string, MappedField>();
                }
                // TODO: Some logic here to auto mapp by compareing the name;

                var matchedFiled = apiMappingfields.Find(e => e.DisplayName.ToLower().Contains(header.Value.ToLower()));
                if (matchedFiled == null)
                    matchedFiled = apiMappingfields[0];

                mappedFields.Add(header.Key, new MappedField()
                {
                    Column = header.Key,
                    Header = header.Value,
                    Field = matchedFiled,
                    Skip = true
                });
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private async Task SavingMappedFields()
    {
        this.ValidateCompulsaryFields();
        if (isInvalid)
        {

            this.showOverlay = true;
            return;
        }

        await sessionStorage.SetItemAsync<Dictionary<string, MappedField>>("mappedFields", mappedFields);
        navigationManager.NavigateTo("/Import");
    }

    private async Task<Dictionary<string, MappedField>> GetMappedFields()
    {
        return await sessionStorage.GetItemAsync<Dictionary<string, MappedField>>("mappedFields");
    }

    private async Task CreateMappedFields()
    {
        mappedFields = await GetMappedFields();
        if (mappedFields == null || !mappedFields.Any())
        {
            CreateNewMappedFields();
        }
    }

    private async Task GetApiMappingFields()
    {

        var selectedDataType = await sessionStorage.GetItemAsync<LabelAndValue>("selectedDataType");

        if (selectedDataType == null)
        {
            navigationManager.NavigateTo("/");
            return;
        }

        try
        {
            apiMappingfields = await Http.GetFromJsonAsync<List<ApiMappingField>>("api/Innovation/InnovationImportGetFields?Username=ZBN0236&Password=52287F9C-6BCE-4868-A3AE-6939D4FD2448" + "&strDataType=" + selectedDataType.Value);
            await sessionStorage.SetItemAsync<List<ApiMappingField>>("apiMappingfields", apiMappingfields);
            ApiMappingField ApiMappingField = new ApiMappingField();
            ApiMappingField.ApiInternalName = "";
            ApiMappingField.DisplayName = "Un Mapping";
            ApiMappingField.IsCompulsory = false;

            apiMappingfields.Insert(0, ApiMappingField);
        }
        catch
        {

        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
