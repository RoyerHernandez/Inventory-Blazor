#pragma checksum "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\UpdateProductComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b066ae401a909208874b6986e5bc29f5a2d3b1d"
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
#line 1 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\UpdateProductComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\UpdateProductComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class UpdateProductComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\UpdateProductComponent.razor"
                     oProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "form-group");
                __builder2.AddMarkupContent(6, "\r\n            ");
                __builder2.AddMarkupContent(7, "<label>Producto:</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(8);
                __builder2.AddAttribute(9, "class", "form-control");
                __builder2.AddAttribute(10, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\UpdateProductComponent.razor"
                                                         oProduct.productName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oProduct.productName = __value, oProduct.productName))));
                __builder2.AddAttribute(12, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oProduct.productName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group");
                __builder2.AddMarkupContent(17, "\r\n            ");
                __builder2.AddMarkupContent(18, "<label>Descripción:</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(19);
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\UpdateProductComponent.razor"
                                                             oProduct.productDesciption

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oProduct.productDesciption = __value, oProduct.productDesciption))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oProduct.productDesciption));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group");
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.AddMarkupContent(29, "<label>Precio Unitario:</label>\r\n            ");
                __Blazor.Inventory.Components.Products.UpdateProductComponent.TypeInference.CreateInputNumber_0(__builder2, 30, 31, "form-control", 32, 
#nullable restore
#line 16 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\UpdateProductComponent.razor"
                                                           oProduct.unitPrice

#line default
#line hidden
#nullable disable
                , 33, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oProduct.unitPrice = __value, oProduct.unitPrice)), 34, () => oProduct.unitPrice);
                __builder2.AddMarkupContent(35, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n        ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group");
                __builder2.AddMarkupContent(39, "\r\n            ");
                __builder2.AddMarkupContent(40, "<label>Categoria:</label>\r\n            ");
                __Blazor.Inventory.Components.Products.UpdateProductComponent.TypeInference.CreateInputSelect_1(__builder2, 41, 42, "form-control", 43, 
#nullable restore
#line 20 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\UpdateProductComponent.razor"
                                      oProduct.categoryId

#line default
#line hidden
#nullable disable
                , 44, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oProduct.categoryId = __value, oProduct.categoryId)), 45, () => oProduct.categoryId, 46, (__builder3) => {
                    __builder3.AddMarkupContent(47, "\r\n");
#nullable restore
#line 21 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\UpdateProductComponent.razor"
                 foreach (var category in categories)
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(48, "                    ");
                    __builder3.OpenElement(49, "option");
                    __builder3.AddAttribute(50, "value", 
#nullable restore
#line 23 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\UpdateProductComponent.razor"
                                    category.categoryId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(51, 
#nullable restore
#line 23 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\UpdateProductComponent.razor"
                                                          category.categoryName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(52, "\r\n");
#nullable restore
#line 24 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\UpdateProductComponent.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(53, "            ");
                }
                );
                __builder2.AddMarkupContent(54, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n\r\n        ");
                __builder2.OpenElement(56, "input");
                __builder2.AddAttribute(57, "type", "button");
                __builder2.AddAttribute(58, "value", "Actualizar Producto");
                __builder2.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\UpdateProductComponent.razor"
                                                                   UpdateProduct

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "D:\Platzi\Blazor\Inventory-Blazor\Inventory\Inventory\Components\Products\UpdateProductComponent.razor"
       
    [Parameter]
    public string IdProduct{ get; set; }

    ProductEntity oProduct = new ProductEntity();
    List<CategoryEntity> categories = new List<CategoryEntity>();

    protected override async Task OnInitializedAsync()
    {
        categories = B_Category.CategoryList();
        oProduct = B_Product.ProductById(IdProduct);
    }

    public void UpdateProduct()
    {
        B_Product.UpdateProduct(oProduct);        
        NavManager.NavigateTo("product/list");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
namespace __Blazor.Inventory.Components.Products.UpdateProductComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
