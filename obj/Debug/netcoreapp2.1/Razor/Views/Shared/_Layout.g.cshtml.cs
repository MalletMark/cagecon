#pragma checksum "C:\Projects\CageCon\CageCon\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2c2d9f50bd8fafc6651878e5503ef8d063b3c92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2c2d9f50bd8fafc6651878e5503ef8d063b3c92", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 939, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f4df35e84924440a483e969438d2c4b", async() => {
                BeginContext(41, 181, true);
                WriteLiteral("\r\n    <title>Cage Con</title>\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    \r\n    <!-- Bootstrap core CSS -->\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 222, "\"", 285, 1);
#line 9 "C:\Projects\CageCon\CageCon\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 229, Url.Content("~/vendor/bootstrap/css/bootstrap.min.css"), 229, 56, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(286, 76, true);
                WriteLiteral(" rel=\"stylesheet\">\r\n\r\n    <!-- Custom fonts for this template -->\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 362, "\"", 431, 1);
#line 12 "C:\Projects\CageCon\CageCon\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 369, Url.Content("~/vendor/font-awesome/css/font-awesome.min.css"), 369, 62, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(432, 308, true);
                WriteLiteral(@" rel=""stylesheet"" type=""text/css"">
    <link href=""https://fonts.googleapis.com/css?family=Montserrat:400,700"" rel=""stylesheet"" type=""text/css"">
    <link href=""https://fonts.googleapis.com/css?family=Lato:400,700,400italic,700italic"" rel=""stylesheet"" type=""text/css"">

    <!-- Plugin CSS -->
    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 740, "\"", 805, 1);
#line 17 "C:\Projects\CageCon\CageCon\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 747, Url.Content("~/vendor/magnific-popup/magnific-popup.css"), 747, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(806, 93, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\">\r\n\r\n    <!-- Custom styles for this template -->\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 899, "\"", 946, 1);
#line 20 "C:\Projects\CageCon\CageCon\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 906, Url.Content("~/css/freelancer.min.css"), 906, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(947, 20, true);
                WriteLiteral(" rel=\"stylesheet\">\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(974, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(976, 5057, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74090161dbdb4599825986048341787a", async() => {
                BeginContext(996, 1710, true);
                WriteLiteral(@"

    <!-- Navigation -->
    <nav class=""navbar navbar-expand-lg bg-secondary fixed-top text-uppercase"" id=""mainNav"">
      <div class=""container"">
        <a class=""navbar-brand js-scroll-trigger"" href=""#page-top"">Start Bootstrap</a>
        <button class=""navbar-toggler navbar-toggler-right text-uppercase bg-primary text-white rounded"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
          Menu
          <i class=""fa fa-bars""></i>
        </button>
        <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
          <ul class=""navbar-nav ml-auto"">
            <li class=""nav-item mx-0 mx-lg-1"">
              <a class=""nav-link py-3 px-0 px-lg-3 rounded js-scroll-trigger"" href=""#portfolio"">Portfolio</a>
            </li>
            <li class=""nav-item mx-0 mx-lg-1"">
              <a class=""nav-link py-3 px-0 px-lg-3 rounded js-scroll-trigger"" href=""#about"">About</a>
     ");
                WriteLiteral(@"       </li>
            <li class=""nav-item mx-0 mx-lg-1"">
              <a class=""nav-link py-3 px-0 px-lg-3 rounded js-scroll-trigger"" href=""#contact"">Contact</a>
            </li>
          </ul>
        </div>
      </div>
    </nav>

    <!-- Header -->
    <header class=""masthead bg-primary text-white text-center"">
      <div class=""container"">
        <img class=""img-fluid mb-5 d-block mx-auto"" src=""img/profile.png"" alt="""">
        <h1 class=""text-uppercase mb-0"">Start Bootstrap</h1>
        <hr class=""star-light"">
        <h2 class=""font-weight-light mb-0"">Web Developer - Graphic Artist - User Experience Designer</h2>
      </div>
    </header>

    ");
                EndContext();
                BeginContext(2707, 12, false);
#line 58 "C:\Projects\CageCon\CageCon\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(2719, 2633, true);
                WriteLiteral(@"
        
    <!-- Footer -->
    <footer class=""footer text-center"">
      <div class=""container"">
        <div class=""row"">
          <div class=""col-md-4 mb-5 mb-lg-0"">
            <h4 class=""text-uppercase mb-4"">Location</h4>
            <p class=""lead mb-0"">2215 John Daniel Drive
              <br>Clark, MO 65243</p>
          </div>
          <div class=""col-md-4 mb-5 mb-lg-0"">
            <h4 class=""text-uppercase mb-4"">Around the Web</h4>
            <ul class=""list-inline mb-0"">
              <li class=""list-inline-item"">
                <a class=""btn btn-outline-light btn-social text-center rounded-circle"" href=""#"">
                  <i class=""fa fa-fw fa-facebook""></i>
                </a>
              </li>
              <li class=""list-inline-item"">
                <a class=""btn btn-outline-light btn-social text-center rounded-circle"" href=""#"">
                  <i class=""fa fa-fw fa-google-plus""></i>
                </a>
              </li>
              <li class=""list-");
                WriteLiteral(@"inline-item"">
                <a class=""btn btn-outline-light btn-social text-center rounded-circle"" href=""#"">
                  <i class=""fa fa-fw fa-twitter""></i>
                </a>
              </li>
              <li class=""list-inline-item"">
                <a class=""btn btn-outline-light btn-social text-center rounded-circle"" href=""#"">
                  <i class=""fa fa-fw fa-linkedin""></i>
                </a>
              </li>
              <li class=""list-inline-item"">
                <a class=""btn btn-outline-light btn-social text-center rounded-circle"" href=""#"">
                  <i class=""fa fa-fw fa-dribbble""></i>
                </a>
              </li>
            </ul>
          </div>
          <div class=""col-md-4"">
            <h4 class=""text-uppercase mb-4"">About Freelancer</h4>
            <p class=""lead mb-0"">Freelance is a free to use, open source Bootstrap theme created by
              <a href=""http://startbootstrap.com"">Start Bootstrap</a>.</p>
          </di");
                WriteLiteral(@"v>
        </div>
      </div>
    </footer>

    <div class=""copyright py-4 text-center text-white"">
      <div class=""container"">
        <small>Copyright &copy; Your Website 2018</small>
      </div>
    </div>

    <!-- Scroll to Top Button (Only visible on small and extra-small screen sizes) -->
    <div class=""scroll-to-top d-lg-none position-fixed "">
      <a class=""js-scroll-trigger d-block text-center text-white rounded"" href=""#page-top"">
        <i class=""fa fa-chevron-up""></i>
      </a>
    </div>

    <!-- Bootstrap core JavaScript -->
    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 5352, "\"", 5403, 1);
#line 122 "C:\Projects\CageCon\CageCon\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5358, Url.Content("~/vendor/jquery/jquery.min.js"), 5358, 45, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5404, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 5427, "\"", 5494, 1);
#line 123 "C:\Projects\CageCon\CageCon\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5433, Url.Content("~/vendor/bootstrap/js/bootstrap.bundle.min.js"), 5433, 61, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5495, 57, true);
                WriteLiteral("></script>\r\n\r\n    <!-- Plugin JavaScript -->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 5552, "\"", 5617, 1);
#line 126 "C:\Projects\CageCon\CageCon\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5558, Url.Content("~/vendor/jquery-easing/jquery.easing.min.js"), 5558, 59, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5618, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 5641, "\"", 5715, 1);
#line 127 "C:\Projects\CageCon\CageCon\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5647, Url.Content("~/vendor/magnific-popup/jquery.magnific-popup.min.js"), 5647, 68, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5716, 63, true);
                WriteLiteral("></script>\r\n\r\n    <!-- Contact Form JavaScript -->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 5779, "\"", 5830, 1);
#line 130 "C:\Projects\CageCon\CageCon\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5785, Url.Content("~/js/jqBootstrapValidation.js"), 5785, 45, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5831, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 5854, "\"", 5894, 1);
#line 131 "C:\Projects\CageCon\CageCon\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5860, Url.Content("~/js/contact_me.js"), 5860, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5895, 72, true);
                WriteLiteral("></script>\r\n\r\n    <!-- Custom scripts for this template -->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 5967, "\"", 6011, 1);
#line 134 "C:\Projects\CageCon\CageCon\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5973, Url.Content("~/js/freelancer.min.js"), 5973, 38, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6012, 14, true);
                WriteLiteral("></script>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6033, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
