#pragma checksum "C:\Users\urivape\source\repos\DigInteligencia\DigInteligencia\Views\MyLists\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d9984914cc6119c28b13a6136dc2837b9f79477"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyLists_Index), @"mvc.1.0.view", @"/Views/MyLists/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MyLists/Index.cshtml", typeof(AspNetCore.Views_MyLists_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d9984914cc6119c28b13a6136dc2837b9f79477", @"/Views/MyLists/Index.cshtml")]
    public class Views_MyLists_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DigInteligencia.Models.TaskToDoList>>
    {
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\urivape\source\repos\DigInteligencia\DigInteligencia\Views\MyLists\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(86, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(115, 520, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2125334d8cb49808abfce2fbe50532a", async() => {
                BeginContext(121, 507, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>My Lists</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.5.0/css/all.css"" integrity=""sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU"" crossorigin=""anonymous"">
");
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
            BeginContext(635, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(637, 5182, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4efc01c239e14d588d0e8915af700215", async() => {
                BeginContext(643, 1688, true);
                WriteLiteral(@"
    <nav class=""navbar navbar-dark bg-dark"">
        <a class=""navbar-brand"" href=""#"">
            <b>My Tasks To Do</b>
        </a>
        <div>
            <button id=""btnReloadLists"" class=""btn btn-outline-light"">
                <i class=""fa fa-sync-alt""></i> Reload Lists
            </button>
            <button id=""btnCreateList"" class=""btn btn-outline-light"">
                <i class=""fa fa-plus""></i> Create List
            </button>
        </div>
    </nav>
    <div class=""container-fluid p-5"">
        <div class=""row"">
            <div class=""col"">
                <div id=""DivLists"" class=""row"">
                </div>
            </div>
        </div>
    </div>
    <div id=""FModal"" class=""modal inmodal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true""></div>
    <script src=""https://code.jquery.com/jquery-3.3.1.min.js"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"" integrity=""sha384-ChfqqxuZUCnJSK3");
                WriteLiteral(@"+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"" integrity=""sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49"" crossorigin=""anonymous""></script>
    <script>
        var TaskToDoIDSelected = 0;
        var TaskToDoListIDSelected = 0;

        jQuery().ready(function () {
            jQuery(""#btnReloadLists"").on(""click"", function () {
                LoadLists();
            });

            jQuery(""#btnCreateList"").on(""click"", function () {
                jQuery.ajax({
                    url: '");
                EndContext();
                BeginContext(2332, 31, false);
#line 53 "C:\Users\urivape\source\repos\DigInteligencia\DigInteligencia\Views\MyLists\Index.cshtml"
                     Write(Url.Action("Create", "MyLists"));

#line default
#line hidden
                EndContext();
                BeginContext(2363, 787, true);
                WriteLiteral(@"',
                    dataType: 'html',
                    success: function (data) {
                        jQuery('#FModal').html(data);
                        jQuery('#FModal').modal();
                    }
                });
            });

            jQuery(""#btnDeleteTaskSelected"").on(""click"", function () {
                DeleteTaskToDo();
            });

            LoadLists();
        });

        function LoadLists() {
            TaskToDoIDSelected = 0;
            TaskToDoListIDSelected = 0;
            var icon = jQuery('<i />').addClass('fa fa-sync-alt fa-4x').css({ margin: '0 auto' });
            jQuery('#DivLists').html("""");
            jQuery(icon).appendTo(jQuery('#DivLists'));
            jQuery.ajax({
                url: '");
                EndContext();
                BeginContext(3151, 30, false);
#line 76 "C:\Users\urivape\source\repos\DigInteligencia\DigInteligencia\Views\MyLists\Index.cshtml"
                 Write(Url.Action("Lists", "MyLists"));

#line default
#line hidden
                EndContext();
                BeginContext(3181, 370, true);
                WriteLiteral(@"',
                dataType: 'html',
                success: function (data) {
                    jQuery('#DivLists').html(data);

                    jQuery("".btnCreateTask"").on(""click"", function () {
                        TaskToDoListIDSelected = jQuery(this).attr(""tasktodolistid"");
                        jQuery.ajax({
                            url: '");
                EndContext();
                BeginContext(3552, 35, false);
#line 84 "C:\Users\urivape\source\repos\DigInteligencia\DigInteligencia\Views\MyLists\Index.cshtml"
                             Write(Url.Action("CreateTask", "MyLists"));

#line default
#line hidden
                EndContext();
                BeginContext(3587, 626, true);
                WriteLiteral(@"',
                            dataType: 'html',
                            success: function (data) {
                                jQuery('#FModal').html(data);
                                jQuery('#FModal').modal();
                            }
                        });
                    });

                    jQuery("".btnEditTask"").on(""click"", function () {
                        TaskToDoListIDSelected = jQuery(this).attr(""tasktodolistid"");
                        TaskToDoIDSelected = jQuery(this).attr(""tasktodoid"");
                        jQuery.ajax({
                            url: '");
                EndContext();
                BeginContext(4214, 33, false);
#line 97 "C:\Users\urivape\source\repos\DigInteligencia\DigInteligencia\Views\MyLists\Index.cshtml"
                             Write(Url.Action("EditTask", "MyLists"));

#line default
#line hidden
                EndContext();
                BeginContext(4247, 568, true);
                WriteLiteral(@"' + '/' + TaskToDoIDSelected,
                            dataType: 'html',
                            success: function (data) {
                                jQuery('#FModal').html(data);
                                jQuery('#FModal').modal();
                            }
                        });
                    });

                    jQuery("".btnDeleteTask"").on(""click"", function () {
                        TaskToDoIDSelected = jQuery(this).attr(""tasktodoid"");
                        jQuery.ajax({
                            url: '");
                EndContext();
                BeginContext(4816, 35, false);
#line 109 "C:\Users\urivape\source\repos\DigInteligencia\DigInteligencia\Views\MyLists\Index.cshtml"
                             Write(Url.Action("DeleteTask", "MyLists"));

#line default
#line hidden
                EndContext();
                BeginContext(4851, 478, true);
                WriteLiteral(@"' + '/' + TaskToDoIDSelected,
                            dataType: 'html',
                            success: function (data) {
                                jQuery('#FModal').html(data);
                                jQuery('#FModal').modal();
                            }
                        });
                    });
                }
            });
        }

        function DeleteTaskToDo1() {
            jQuery.ajax({
                url: '");
                EndContext();
                BeginContext(5330, 40, false);
#line 123 "C:\Users\urivape\source\repos\DigInteligencia\DigInteligencia\Views\MyLists\Index.cshtml"
                 Write(Url.Action("DeleteTaskToDo", "TaskToDo"));

#line default
#line hidden
                EndContext();
                BeginContext(5370, 442, true);
                WriteLiteral(@"' + '/' + TaskToDoIDSelected,
                type: 'POST',
                dataType: 'json',
                success: function (data) {
                    jQuery('#FDeleteTaskModal').modal(""hide"");
                    LoadLists();
                },
                error: function (a, b, c) {
                    console.log(""Error to delete Task. Try again later."");
                }
            });
        }
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5819, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DigInteligencia.Models.TaskToDoList>> Html { get; private set; }
    }
}
#pragma warning restore 1591
