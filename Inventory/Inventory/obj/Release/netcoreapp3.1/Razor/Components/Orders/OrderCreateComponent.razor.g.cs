#pragma checksum "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Orders\OrderCreateComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54b767f30f3bb4ed47adf0b4b92798dfb97f554a"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory.Components.Orders
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
#nullable restore
#line 1 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Orders\OrderCreateComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Orders\OrderCreateComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class OrderCreateComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr>\r\n");
            __builder.OpenElement(1, "select");
            __builder.AddAttribute(2, "class", "form-control");
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 6 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Orders\OrderCreateComponent.razor"
                                        CategoryChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "option");
            __builder.AddAttribute(6, "value", true);
            __builder.AddContent(7, "Seleccione una categoria....");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 8 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Orders\OrderCreateComponent.razor"
     foreach (var category in categories)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "        ");
            __builder.OpenElement(10, "option");
            __builder.AddAttribute(11, "value", 
#nullable restore
#line 10 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Orders\OrderCreateComponent.razor"
                        category.categoryId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, 
#nullable restore
#line 10 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Orders\OrderCreateComponent.razor"
                                              category.categoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 11 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Orders\OrderCreateComponent.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n<hr>\r\n\r\n\r\n\r\n");
            __builder.OpenElement(15, "tbody");
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "container");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "row-fluid ");
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 48 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Orders\OrderCreateComponent.razor"
                 foreach (var product in tmpProducts)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "card mb-3");
            __builder.AddAttribute(26, "style", "max-width: 1200px;");
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "row no-gutters");
            __builder.AddMarkupContent(30, "\r\n                            ");
            __builder.AddMarkupContent(31, "<div class=\"col-md-4\">\r\n                                <img src=\"https://i.picsum.photos/id/201/5184/3456.jpg\" class=\"img-thumbnail\" alt=\"...\">\r\n                            </div>\r\n                            ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col-md-8");
            __builder.AddMarkupContent(34, "\r\n                                ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "card-body");
            __builder.AddMarkupContent(37, "\r\n                                    ");
            __builder.OpenElement(38, "h5");
            __builder.AddAttribute(39, "class", "card-title");
            __builder.AddContent(40, 
#nullable restore
#line 57 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Orders\OrderCreateComponent.razor"
                                                            product.productName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                                    ");
            __builder.OpenElement(42, "p");
            __builder.AddAttribute(43, "class", "card-text");
            __builder.AddContent(44, 
#nullable restore
#line 58 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Orders\OrderCreateComponent.razor"
                                                          product.productId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                                    ");
            __builder.OpenElement(46, "p");
            __builder.AddAttribute(47, "class", "card-text");
            __builder.AddContent(48, 
#nullable restore
#line 59 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Orders\OrderCreateComponent.razor"
                                                          product.categoryId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                                    ");
            __builder.OpenElement(50, "p");
            __builder.AddAttribute(51, "class", "card-text");
            __builder.AddContent(52, "Precio Unitario $ COP - ");
            __builder.AddContent(53, 
#nullable restore
#line 60 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Orders\OrderCreateComponent.razor"
                                                                                  product.unitPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                                    ");
            __builder.OpenElement(55, "p");
            __builder.AddAttribute(56, "class", "card-text");
            __builder.AddContent(57, 
#nullable restore
#line 61 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Orders\OrderCreateComponent.razor"
                                                          product.productDesciption

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                                    <p class=\"card-text\"></p>\r\n                                    \r\n                                    ");
            __builder.AddMarkupContent(59, "<p class=\"card-text\"><small class=\"text-muted\">Last updated 3 mins ago</small></p>\r\n                                    ");
            __builder.OpenElement(60, "input");
            __builder.AddAttribute(61, "type", "button");
            __builder.AddAttribute(62, "value", "Agregar al Carrito");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Orders\OrderCreateComponent.razor"
                                                                                              (() => AddProductToOrder(product.productName, product.unitPrice))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
#nullable restore
#line 70 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Orders\OrderCreateComponent.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(69, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n\r\n\r\n");
            __builder.AddContent(73, 
#nullable restore
#line 76 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Orders\OrderCreateComponent.razor"
 message

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(74, ";\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Orders\OrderCreateComponent.razor"
       
    OrderEntity oOrder = new OrderEntity();

    List<ProductEntity> products = new List<ProductEntity>();
    List<ProductEntity> tmpProducts = new List<ProductEntity>();
    List<CategoryEntity> categories = new List<CategoryEntity>();

    string identifier;
    string message;

    protected override async Task OnInitializedAsync()
    {
        products = B_Product.ProductList();
        tmpProducts = products;
        categories = B_Category.CategoryList();

        if (String.IsNullOrEmpty(identifier))
        identifier = B_Order.CreateIdentifier().ToString();
    }
    private void CategoryChanged(ChangeEventArgs e)
    {
        message = "";
        tmpProducts = products.Where(c => c.categoryId == e.Value.ToString()).ToList();
    }
    private void AddProductToOrder(string productName, decimal unitePrice)
    {
        oOrder.productName = productName;
        oOrder.unitPrice = unitePrice;
        oOrder.clientIdentifier = identifier;
        oOrder.orderDate = DateTime.Now;

        B_Order.AddProducToOrder(oOrder);

        message = $"El producto {oOrder.productName} se ha agregado exitosamente a tu carrito de compras";

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
