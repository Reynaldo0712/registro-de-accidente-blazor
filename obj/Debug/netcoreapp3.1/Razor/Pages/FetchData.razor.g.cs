#pragma checksum "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02a24889cae90919673b7a684a7df10fac66d290"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea4.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\DELL\Source\Repos\Tarea4\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Source\Repos\Tarea4\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DELL\Source\Repos\Tarea4\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DELL\Source\Repos\Tarea4\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DELL\Source\Repos\Tarea4\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\DELL\Source\Repos\Tarea4\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\DELL\Source\Repos\Tarea4\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\DELL\Source\Repos\Tarea4\_Imports.razor"
using Tarea4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\DELL\Source\Repos\Tarea4\_Imports.razor"
using Tarea4.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
using Tarea4.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddAttribute(2, "style", "overflow:auto;");
            __builder.AddMarkupContent(3, "<h1 class=\"text-monospace text-capitalize\">Accidentes Registrados</h1>\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group col-md-4");
            __builder.AddMarkupContent(6, "\r\n                ");
            __builder.AddMarkupContent(7, "<label for=\"Accidents\">Elegir accidente</label>\r\n                ");
            __builder.OpenElement(8, "select");
            __builder.AddAttribute(9, "id", "Accidents");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                               choose

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => choose = __value, choose));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "option");
            __builder.AddAttribute(15, "selected", true);
            __builder.AddContent(16, "Accidentes");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 11 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                      using (var accidents = new PersonContext()){
                         foreach(var item in accidents.Accidents.ToList()){

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "                             ");
            __builder.OpenElement(19, "option");
            __builder.AddAttribute(20, "value", 
#nullable restore
#line 13 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                                             item.AccidentsId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(21, 
#nullable restore
#line 13 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                                                                item.AccidentsId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, " - ");
            __builder.AddContent(23, 
#nullable restore
#line 13 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                                                                                    item.Place

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(24, " (");
            __builder.AddContent(25, 
#nullable restore
#line 13 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                                                                                                 item.Date

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(26, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 14 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                         }
                     }

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "container");
            __builder.AddAttribute(34, "style", "overflow:auto; height: 430px;");
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 20 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
             using (var db = new PersonContext())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                 foreach (var item in db.Accidents.ToList())
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                     if(choose == item.AccidentsId){

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "            ");
            __builder.OpenElement(37, "table");
            __builder.AddAttribute(38, "class", "table table-bordered");
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.AddMarkupContent(40, @"<thead class=""thead-dark"">
                    <tr class=""text-center"">
                        <th colspan=""6"">Accidentes</th>
                        <th></th>
                    </tr>
                    <tr>
                        <th>#</th>
                        <th>Descripcion</th>
                        <th>Fecha - Hora</th>
                        <th>Lugar</th>
                        <th>Longitud</th>
                        <th>Lactitud</th>
                        <th>Imagen</th>
                    </tr>
                </thead>
                ");
            __builder.OpenElement(41, "tbody");
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "tr");
            __builder.AddMarkupContent(44, "\r\n                        ");
            __builder.OpenElement(45, "th");
            __builder.AddContent(46, 
#nullable restore
#line 43 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                             item.AccidentsId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                        ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 44 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                             item.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                        ");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 45 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                             item.Date

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(53, " - ");
            __builder.AddContent(54, 
#nullable restore
#line 45 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                                          item.Time

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                        ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 46 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                             item.Place

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 47 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                             item.longitud

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                        ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 48 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                             item.latitude

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                        ");
            __builder.OpenElement(65, "td");
            __builder.OpenElement(66, "img");
            __builder.AddAttribute(67, "src", 
#nullable restore
#line 49 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                                      string.Format("data:image/jpg;base64, {0}", Convert.ToBase64String(getImage(Convert.ToBase64String(item.Imagen))))

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(68, "width", "35");
            __builder.AddAttribute(69, "height", "40");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.AddContent(73, 
#nullable restore
#line 52 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                 imgsrc

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(74, "\r\n                ");
            __builder.AddMarkupContent(75, @"<thead class=""thead-light"">
                    <tr class=""text-center"">
                        <th colspan=""6"">Involucrados</th>
                        <th></th>
                    </tr>
                    <tr>
                        <th>#</th>
                        <th>Nombre</th>
                        <th>Apellido</th>
                        <th>Telefono</th>
                        <th>Email</th>
                        <th>Cedula</th>
                        <th></th>
                    </tr>
                </thead>
");
#nullable restore
#line 68 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                 foreach (var list in db.Persons.ToList())
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                     if (item.AccidentsId == list.AccidentsId)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "                        ");
            __builder.OpenElement(77, "tbody");
            __builder.AddMarkupContent(78, "\r\n                            ");
            __builder.OpenElement(79, "tr");
            __builder.AddMarkupContent(80, "\r\n                                ");
            __builder.OpenElement(81, "th");
            __builder.AddContent(82, 
#nullable restore
#line 74 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                                     list.PersonsId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                                ");
            __builder.OpenElement(84, "td");
            __builder.AddContent(85, 
#nullable restore
#line 75 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                                     list.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                                ");
            __builder.OpenElement(87, "td");
            __builder.AddContent(88, 
#nullable restore
#line 76 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                                     list.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                                ");
            __builder.OpenElement(90, "td");
            __builder.AddContent(91, 
#nullable restore
#line 77 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                                     list.Phone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                                ");
            __builder.OpenElement(93, "td");
            __builder.AddContent(94, 
#nullable restore
#line 78 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                                     list.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                                ");
            __builder.OpenElement(96, "td");
            __builder.AddContent(97, 
#nullable restore
#line 79 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                                     list.Cedula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                                <th></th>\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n");
#nullable restore
#line 83 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(101, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, " <hr>\r\n");
#nullable restore
#line 86 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(103, "        ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 91 "C:\Users\DELL\Source\Repos\Tarea4\Pages\FetchData.razor"
      
    int choose;


    string imgsrc = "";
     public byte[] getImage (string sBase64String)
    {
        byte[] bytes = null;
        if (sBase64String != null)
        {
            bytes = Convert.FromBase64String(sBase64String);
        }

        return bytes;
    }





#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591