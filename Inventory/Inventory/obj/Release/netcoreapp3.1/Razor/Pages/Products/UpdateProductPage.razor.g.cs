#pragma checksum "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Pages\Products\UpdateProductPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45949defd8f56dc479562e2b304cb5ed80fcf7e6"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory.Pages.Products
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
#line 16 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Orders;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/update/{IdProduct}")]
    public partial class UpdateProductPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Inventory.Components.Products.UpdateProductComponent>(0);
            __builder.AddAttribute(1, "IdProduct", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Pages\Products\UpdateProductPage.razor"
                                    IdProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Pages\Products\UpdateProductPage.razor"
 
    [Parameter]
    public string IdProduct { get; set; }

    protected override async Task OnInitializedAsync()
    {
        IdProduct = IdProduct;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
