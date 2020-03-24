#pragma checksum "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06c80de8f2c6259515c102c35c70e750a8534f94"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorGmail.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using BlazorGmail;

#line default
#line hidden
#line 9 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using BlazorGmail.Shared;

#line default
#line hidden
#line 2 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\Pages\FetchData.razor"
using BlazorGmail.Services;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n");
#line 9 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#line 12 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#line 25 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#line 28 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\Pages\FetchData.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#line 29 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\Pages\FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#line 30 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\Pages\FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#line 31 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\Pages\FetchData.razor"
                         forecast.Summary

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#line 33 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\Pages\FetchData.razor"
            }

#line default
#line hidden
            __builder.AddContent(27, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#line 36 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\Pages\FetchData.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 38 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\Pages\FetchData.razor"
       
    WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591