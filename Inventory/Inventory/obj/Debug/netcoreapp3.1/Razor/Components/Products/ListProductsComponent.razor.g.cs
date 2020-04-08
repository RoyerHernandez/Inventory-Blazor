#pragma checksum "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\ListProductsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b46aab7dfb4b586f2e5d76a9a0f8b3de1110dd33"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory.Components.Products
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
#line 1 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class ListProductsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr>\r\n    ");
            __builder.OpenElement(1, "select");
            __builder.AddAttribute(2, "class", "form-control");
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 5 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
                                            CategoryChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "option");
            __builder.AddAttribute(6, "value", true);
            __builder.AddContent(7, "Seleccione una categoria....");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 7 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
         foreach (var category in categories) 
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "            ");
            __builder.OpenElement(10, "option");
            __builder.AddAttribute(11, "value", 
#nullable restore
#line 9 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
                            category.categoryId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, 
#nullable restore
#line 9 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
                                                  category.categoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 10 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n<hr>\r\n\r\n\r\n    ");
            __builder.OpenElement(16, "table");
            __builder.AddAttribute(17, "class", "table table-bordered table-hover");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.AddMarkupContent(19, "<thead>\r\n            <tr>\r\n                <th>Referencia</th>\r\n                <th>Nombre del Producto</th>\r\n                <th>Categoria</th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(20, "tbody");
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 25 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
             foreach (var product in tmpProducts)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "            ");
            __builder.OpenElement(23, "tr");
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 28 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
                     product.productId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 29 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
                     product.productName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 30 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
                     product.categoryId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "td");
            __builder.OpenElement(35, "a");
            __builder.AddAttribute(36, "href", "product/update/" + (
#nullable restore
#line 31 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
                                             product.productId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Actualizar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 33 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.AddContent(43, 
#nullable restore
#line 36 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
 message

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(44, ";\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\ListProductsComponent.razor"
       
    List<ProductEntity> products = new List<ProductEntity>();
    List<ProductEntity> tmpProducts = new List<ProductEntity>();
    List<CategoryEntity> categories = new List<CategoryEntity>();

    string message;

    protected override async Task OnInitializedAsync()
    {
        products = B_Product.ProductList();
        tmpProducts = products;
        categories = B_Category.CategoryList();
    }
    private void CategoryChanged(ChangeEventArgs e)
    {
        //message = e.Value.ToString();
        tmpProducts= products.Where(c=>c.categoryId == e.Value.ToString()).ToList();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
