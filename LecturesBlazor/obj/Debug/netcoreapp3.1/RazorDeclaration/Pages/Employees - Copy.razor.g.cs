// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LecturesBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dr.Fahad\source\repos\LecturesBlazor\LecturesBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dr.Fahad\source\repos\LecturesBlazor\LecturesBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dr.Fahad\source\repos\LecturesBlazor\LecturesBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dr.Fahad\source\repos\LecturesBlazor\LecturesBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dr.Fahad\source\repos\LecturesBlazor\LecturesBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dr.Fahad\source\repos\LecturesBlazor\LecturesBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dr.Fahad\source\repos\LecturesBlazor\LecturesBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dr.Fahad\source\repos\LecturesBlazor\LecturesBlazor\_Imports.razor"
using LecturesBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dr.Fahad\source\repos\LecturesBlazor\LecturesBlazor\_Imports.razor"
using LecturesBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Employees")]
    public partial class Employees___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\Dr.Fahad\source\repos\LecturesBlazor\LecturesBlazor\Pages\Employees - Copy.razor"
       
    int userloopreq = 0;
    int loopnum = 0;
    class employee
    {
        string imgsrc;
        string title;
        string description;
        string button;
    }
    List<employee> listEmp = new List<employee>();
    void displayEmp()
    {
        userloopreq = loopnum;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
