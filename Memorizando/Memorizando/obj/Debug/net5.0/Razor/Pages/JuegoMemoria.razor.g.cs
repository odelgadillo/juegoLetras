#pragma checksum "C:\Users\omarhdc\source\repos\odelgadillo\juegoLetras\Memorizando\Memorizando\Pages\JuegoMemoria.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a13570933d462106c3ae31a5768f3ea36912fa52"
// <auto-generated/>
#pragma warning disable 1591
namespace Memorizando.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\omarhdc\source\repos\odelgadillo\juegoLetras\Memorizando\Memorizando\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\omarhdc\source\repos\odelgadillo\juegoLetras\Memorizando\Memorizando\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\omarhdc\source\repos\odelgadillo\juegoLetras\Memorizando\Memorizando\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\omarhdc\source\repos\odelgadillo\juegoLetras\Memorizando\Memorizando\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\omarhdc\source\repos\odelgadillo\juegoLetras\Memorizando\Memorizando\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\omarhdc\source\repos\odelgadillo\juegoLetras\Memorizando\Memorizando\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\omarhdc\source\repos\odelgadillo\juegoLetras\Memorizando\Memorizando\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\omarhdc\source\repos\odelgadillo\juegoLetras\Memorizando\Memorizando\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\omarhdc\source\repos\odelgadillo\juegoLetras\Memorizando\Memorizando\_Imports.razor"
using Memorizando;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\omarhdc\source\repos\odelgadillo\juegoLetras\Memorizando\Memorizando\_Imports.razor"
using Memorizando.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\omarhdc\source\repos\odelgadillo\juegoLetras\Memorizando\Memorizando\Pages\JuegoMemoria.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/JuegoMemoria")]
    public partial class JuegoMemoria : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>JuegoMemoria</h3>");
#nullable restore
#line 7 "C:\Users\omarhdc\source\repos\odelgadillo\juegoLetras\Memorizando\Memorizando\Pages\JuegoMemoria.razor"
 foreach (var letra in palabra)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "letra border text-uppercase");
            __builder.OpenElement(3, "span");
            __builder.AddContent(4, 
#nullable restore
#line 10 "C:\Users\omarhdc\source\repos\odelgadillo\juegoLetras\Memorizando\Memorizando\Pages\JuegoMemoria.razor"
               letra

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\omarhdc\source\repos\odelgadillo\juegoLetras\Memorizando\Memorizando\Pages\JuegoMemoria.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<hr>");
#nullable restore
#line 15 "C:\Users\omarhdc\source\repos\odelgadillo\juegoLetras\Memorizando\Memorizando\Pages\JuegoMemoria.razor"
 foreach (var letra in palabra)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "letra border text-uppercase");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "name", 
#nullable restore
#line 18 "C:\Users\omarhdc\source\repos\odelgadillo\juegoLetras\Memorizando\Memorizando\Pages\JuegoMemoria.razor"
                                  letra

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "value");
            __builder.AddAttribute(12, "class", "text-uppercase");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\omarhdc\source\repos\odelgadillo\juegoLetras\Memorizando\Memorizando\Pages\JuegoMemoria.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<hr>\r\n");
            __builder.OpenElement(14, "h5");
            __builder.AddContent(15, 
#nullable restore
#line 23 "C:\Users\omarhdc\source\repos\odelgadillo\juegoLetras\Memorizando\Memorizando\Pages\JuegoMemoria.razor"
     letraSeleccionada

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n<hr>");
#nullable restore
#line 26 "C:\Users\omarhdc\source\repos\odelgadillo\juegoLetras\Memorizando\Memorizando\Pages\JuegoMemoria.razor"
 foreach (var letra in letras)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "name", "btn-" + (
#nullable restore
#line 28 "C:\Users\omarhdc\source\repos\odelgadillo\juegoLetras\Memorizando\Memorizando\Pages\JuegoMemoria.razor"
                                    letra

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "value", 
#nullable restore
#line 28 "C:\Users\omarhdc\source\repos\odelgadillo\juegoLetras\Memorizando\Memorizando\Pages\JuegoMemoria.razor"
                                                   letra

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\omarhdc\source\repos\odelgadillo\juegoLetras\Memorizando\Memorizando\Pages\JuegoMemoria.razor"
                                                                      () =>SeleccionarLetra(letra)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "class", "text-uppercase btn btn-secondary botonLetra m-1");
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\omarhdc\source\repos\odelgadillo\juegoLetras\Memorizando\Memorizando\Pages\JuegoMemoria.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\omarhdc\source\repos\odelgadillo\juegoLetras\Memorizando\Memorizando\Pages\JuegoMemoria.razor"
       
    Timer timer;
    string palabra = string.Empty;
    int nivel = 3;
    string letraSeleccionada = string.Empty;

    List<char> letras = new List<char>();
    private void CargarLetras()
    {
        for (int i = 0; i < 26; i++)
        {
            char letra = (char)('a' + i);
            letras.Add(letra);
        }
    }

    private void SeleccionarLetra(char letra)
    {
        letraSeleccionada = letra.ToString();
    }

    protected override void OnInitialized()
    {
        CargarLetras();
        timer = new Timer();
        timer.Interval = 500; // cada segundo
        timer.Elapsed += TimerOnElapsed; // ejecutar este método
        timer.Start();
    }

    private void TimerOnElapsed(object sender, ElapsedEventArgs e)
    {
        //Console.WriteLine(RandomLetter.GetLetter());
        palabra += RandomLetter.GetLetter();
        Console.WriteLine(palabra);
        if (palabra.Count() == nivel)
        {
            timer.Stop();
        }
        StateHasChanged();
    }

    public void Dispose()
    {
        if (timer != null)
        {
            timer.Dispose();
        }
    }

    static class RandomLetter
    {
        static Random _random = new Random();
        public static char GetLetter()
        {
            // This method returns a random lowercase letter.
            // ... Between 'a' and 'z' inclusize.
            int num = _random.Next(0, 26); // Zero to 25
            char let = (char)('a' + num);
            return let;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591