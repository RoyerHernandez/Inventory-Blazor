#pragma checksum "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Categories\UpdateCategoryComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff6d5bd9969fc5f2a1f13d4e56be0cec8a623c80"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory.Components.Categories
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\_Imports.razor"
using Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Exercises.BlazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Storage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.InOuts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Warehouses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Categories\UpdateCategoryComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Categories\UpdateCategoryComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class UpdateCategoryComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Categories\UpdateCategoryComponent.razor"
                     oCategory

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "form-group");
                __builder2.AddMarkupContent(6, "\r\n            ");
                __builder2.AddMarkupContent(7, "<label>Categoria:</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(8);
                __builder2.AddAttribute(9, "class", "form-control");
                __builder2.AddAttribute(10, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Categories\UpdateCategoryComponent.razor"
                                                         oCategory.categoryName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oCategory.categoryName = __value, oCategory.categoryName))));
                __builder2.AddAttribute(12, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oCategory.categoryName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n\r\n        ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "type", "button");
                __builder2.AddAttribute(17, "value", "Actualizar Producto");
                __builder2.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Categories\UpdateCategoryComponent.razor"
                                                                   UpdateProduct

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Categories\UpdateCategoryComponent.razor"
       
    [Parameter]
    public string IdCategory { get; set; }

    CategoryEntity oCategory = new CategoryEntity();

    protected override async Task OnInitializedAsync()
    {
        oCategory = B_Category.CategoryById(IdCategory);
    }

    public void UpdateProduct()
    {
        B_Category.UpdateCategory(oCategory);
        NavManager.NavigateTo("category/list");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
