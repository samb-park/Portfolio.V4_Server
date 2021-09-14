#pragma checksum "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e04431e7567c8a10fbce5618366ca765f69af49"
// <auto-generated/>
#pragma warning disable 1591
namespace Server.Pages.Portfolio.Experience
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using Server.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/portfolio/experience")]
    public partial class Experience : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudBreadcrumbs>(0);
            __builder.AddAttribute(1, "Items", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<MudBlazor.BreadcrumbItem>>(
#nullable restore
#line 8 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                       BreadcrumbItems

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\n");
            __builder.OpenComponent<MudBlazor.MudDivider>(3);
            __builder.AddAttribute(4, "Class", "mb-7");
            __builder.AddAttribute(5, "DividerType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.DividerType>(
#nullable restore
#line 9 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                                      DividerType.Middle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Light", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\n\n");
            __builder.OpenComponent<MudBlazor.MudGrid>(8);
            __builder.AddAttribute(9, "Spacing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                  3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudItem>(11);
                __builder2.AddAttribute(12, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                 6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                        6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "Class", "d-flex justify-space-between");
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(16);
                    __builder3.AddAttribute(17, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 13 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                       Typo.h4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "Style", "font-weight: bolder");
                    __builder3.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(20, 
#nullable restore
#line 13 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                                                             Title

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudItem>(22);
                __builder2.AddAttribute(23, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                 6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                        6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "Class", "d-flex align-center justify-end");
                __builder2.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 16 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
         if (SelectedExperiece != null)
        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudButton>(27);
                    __builder3.AddAttribute(28, "Link", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                               $"/portfolio/experience/update/{SelectedExperiece.Id}"

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "Class", "mr-2");
                    __builder3.AddAttribute(30, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 18 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                                                                                                            Color.Secondary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(31, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 18 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                                                                                                                                      Variant.Outlined

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(33, "EDIT");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\n            ");
                    __builder3.OpenComponent<MudBlazor.MudButton>(35);
                    __builder3.AddAttribute(36, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                                HandleDelete

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(37, "Class", "mr-2");
                    __builder3.AddAttribute(38, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 19 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                                                                  Color.Secondary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 19 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                                                                                            Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(41, "DEL");
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 20 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
        }

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudButton>(42);
                    __builder3.AddAttribute(43, "Link", "/portfolio/experience/create");
                    __builder3.AddAttribute(44, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 21 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                                                              Color.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(45, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 21 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                                                                                      Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(47, "ADD");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudItem>(49);
                __builder2.AddAttribute(50, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 23 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudTabs>(52);
                    __builder3.AddAttribute(53, "Class", "pa-5");
                    __builder3.AddAttribute(54, "Rounded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                                       true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(55, "Outlined", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                                                       true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(56, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                                                                        0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(57, "ApplyEffectsToContainer", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                                                                                                    true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(58, "PanelClass", "mt-5");
                    __builder3.AddAttribute(59, "Centered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                                                                                                                                      true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 26 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
             foreach (var type in SD.ExperienceTypes)
            {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudTabPanel>(61);
                        __builder4.AddAttribute(62, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                                    type

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __Blazor.Server.Pages.Portfolio.Experience.Experience.TypeInference.CreateMudTable_0(__builder5, 64, 65, 
#nullable restore
#line 29 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                                      Experiences

#line default
#line hidden
#nullable disable
                            , 66, 
#nullable restore
#line 29 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                                                         true

#line default
#line hidden
#nullable disable
                            , 67, 
#nullable restore
#line 29 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                                                                       false

#line default
#line hidden
#nullable disable
                            , 68, 
#nullable restore
#line 29 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                                                                                        0

#line default
#line hidden
#nullable disable
                            , 69, 
#nullable restore
#line 29 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                                                                                                               SelectedExperiece

#line default
#line hidden
#nullable disable
                            , 70, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedExperiece = __value, SelectedExperiece)), 71, (__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudTh>(72);
                                __builder6.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(74, "Title");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(75, "\n                            ");
                                __builder6.OpenComponent<MudBlazor.MudTh>(76);
                                __builder6.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(78, "Position");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(79, "\n                            ");
                                __builder6.OpenComponent<MudBlazor.MudTh>(80);
                                __builder6.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(82, "Start Date");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(83, "\n                            ");
                                __builder6.OpenComponent<MudBlazor.MudTh>(84);
                                __builder6.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(86, "End Date");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(87, "\n                            ");
                                __builder6.OpenComponent<MudBlazor.MudTh>(88);
                                __builder6.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(90, "Molar mass");
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            , 91, (context) => (__builder6) => {
#nullable restore
#line 39 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                             if (type == context.Type)
                            {

#line default
#line hidden
#nullable disable
                                __builder6.OpenComponent<MudBlazor.MudTd>(92);
                                __builder6.AddAttribute(93, "DataLabel", "Title");
                                __builder6.AddAttribute(94, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(95, 
#nullable restore
#line 41 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                                                          context.Title

#line default
#line hidden
#nullable disable
                                    );
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(96, "\n                                ");
                                __builder6.OpenComponent<MudBlazor.MudTd>(97);
                                __builder6.AddAttribute(98, "DataLabel", "Position");
                                __builder6.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(100, 
#nullable restore
#line 42 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                                                             context.Position

#line default
#line hidden
#nullable disable
                                    );
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(101, "\n                                ");
                                __builder6.OpenComponent<MudBlazor.MudTd>(102);
                                __builder6.AddAttribute(103, "DataLabel", "Start Date");
                                __builder6.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(105, 
#nullable restore
#line 43 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                                                               context.StartDate.Value.ToString("MMM yyyy")

#line default
#line hidden
#nullable disable
                                    );
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(106, "\n                                ");
                                __builder6.OpenComponent<MudBlazor.MudTd>(107);
                                __builder6.AddAttribute(108, "DataLabel", "End Date");
                                __builder6.AddAttribute(109, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(110, 
#nullable restore
#line 44 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                                                              context.Current == false ? context.EndDate.Value.ToString("MMM yyyy") : "present"

#line default
#line hidden
#nullable disable
                                    );
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(111, "\n                                ");
                                __builder6.OpenComponent<MudBlazor.MudTd>(112);
                                __builder6.AddAttribute(113, "DataLabel", "Molar mass");
                                __builder6.CloseComponent();
#nullable restore
#line 46 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
                            }

#line default
#line hidden
#nullable disable
                            }
                            , 114, (__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudTablePager>(115);
                                __builder6.CloseComponent();
                            }
                            );
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 54 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
            }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "\\Mac\Home\Documents\GitHub\Personal\Portfolio\Server\Pages\Portfolio\Experience\Experience.razor"
       

    private string Title { get; set; } = "EXPERIENCE";
    private IEnumerable<ExperienceDTO> Experiences { get; set; } = new List<ExperienceDTO>();
    private ExperienceDTO SelectedExperiece { get; set; } = null;

    protected override async Task OnInitializedAsync()
    {
        Experiences = await _experienceRepository.GetAllExperiences();

        if (Experiences.Count() == 0)
        {
            _navigationManager.NavigateTo("/portfolio/experience/create",true);
        }
    }

    private List<BreadcrumbItem> BreadcrumbItems { get; set; } = new List<BreadcrumbItem>
    {
        new BreadcrumbItem("Portfolio", href: "/portfolio"),
        new BreadcrumbItem("Experience", href: "/portfolio/experience"),
    };

    private async Task HandleDelete()
    {
        try
        {
            var dialog = DialogService.Show<DeleteConfirmation>("Delete Confirmation");
            var result = await dialog.Result;
            if (result.Cancelled)
            {
                _snackbar.Add("cancel", Severity.Error);
                return;
            }
            var deletedExperiece = await _experienceRepository.DeleteExperience(SelectedExperiece.Id);

            if (deletedExperiece != 0)
            {
                _snackbar.Add("Delete Success", Severity.Success);
                Experiences = await _experienceRepository.GetAllExperiences();
                SelectedExperiece = null;
                return;
            }

            _snackbar.Add("Delete Failure", Severity.Error);
        }
        catch (Exception)
        {
            _snackbar.Add("Delete Failure", Severity.Error);
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar _snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IExperienceRepository _experienceRepository { get; set; }
    }
}
namespace __Blazor.Server.Pages.Portfolio.Experience.Experience
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Int32 __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Hover", __arg1);
        __builder.AddAttribute(__seq2, "Bordered", __arg2);
        __builder.AddAttribute(__seq3, "Elevation", __arg3);
        __builder.AddAttribute(__seq4, "SelectedItem", __arg4);
        __builder.AddAttribute(__seq5, "SelectedItemChanged", __arg5);
        __builder.AddAttribute(__seq6, "HeaderContent", __arg6);
        __builder.AddAttribute(__seq7, "RowTemplate", __arg7);
        __builder.AddAttribute(__seq8, "PagerContent", __arg8);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591