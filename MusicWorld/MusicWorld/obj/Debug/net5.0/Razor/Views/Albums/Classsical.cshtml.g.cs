#pragma checksum "D:\Users\Music_World--Right\MusicWorld\MusicWorld\Views\Albums\Classsical.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89dc759d224dcf447e19e883e020b44e4432cac8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Albums_Classsical), @"mvc.1.0.view", @"/Views/Albums/Classsical.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Users\Music_World--Right\MusicWorld\MusicWorld\Views\_ViewImports.cshtml"
using MusicWorld;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\Music_World--Right\MusicWorld\MusicWorld\Views\_ViewImports.cshtml"
using MusicWorld.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Users\Music_World--Right\MusicWorld\MusicWorld\Views\_ViewImports.cshtml"
using MusicWorld.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89dc759d224dcf447e19e883e020b44e4432cac8", @"/Views/Albums/Classsical.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4b7d408ec3957d2417e75c4d7e8b583f55fe6be", @"/Views/_ViewImports.cshtml")]
    public class Views_Albums_Classsical : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Users\Music_World--Right\MusicWorld\MusicWorld\Views\Albums\Classsical.cshtml"
  
    Layout = "_AlbumsCloneLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"margin-bottom:50px;\">CLASSSICAL Albums</h1>\r\n");
#nullable restore
#line 7 "D:\Users\Music_World--Right\MusicWorld\MusicWorld\Views\Albums\Classsical.cshtml"
 foreach (var a in Model.Songs)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""one-music-songs-area mb-70"">
        <div class=""container"">
            <div class=""row"">

                <!-- Single Song Area -->
                <div class=""col-12"">
                    <div class=""single-song-area mb-30 d-flex flex-wrap align-items-end"">
                        <div class=""song-thumbnail"">
                            <img");
            BeginWriteAttribute("src", " src=\"", 536, "\"", 574, 2);
            WriteAttributeValue("", 542, "/img/Music/Classical/", 542, 21, true);
#nullable restore
#line 17 "D:\Users\Music_World--Right\MusicWorld\MusicWorld\Views\Albums\Classsical.cshtml"
WriteAttributeValue("", 563, a.UrlImage, 563, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 575, "\"", 581, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"song-play-area\">\r\n                            <div class=\"song-name\">\r\n                                <p>");
#nullable restore
#line 21 "D:\Users\Music_World--Right\MusicWorld\MusicWorld\Views\Albums\Classsical.cshtml"
                              Write(a.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 21 "D:\Users\Music_World--Right\MusicWorld\MusicWorld\Views\Albums\Classsical.cshtml"
                                         Write(a.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </div>
                            <audio preload=""auto"" controls>
                                <source src=""/audio/dummy-audio.mp3"">
                            </audio>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
");
#nullable restore
#line 33 "D:\Users\Music_World--Right\MusicWorld\MusicWorld\Views\Albums\Classsical.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
