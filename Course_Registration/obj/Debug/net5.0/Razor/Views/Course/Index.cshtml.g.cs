#pragma checksum "C:\Users\seanr\OneDrive\Desktop\Study Reference\repos\Course_Registration\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0a437f7f6b8ceab7944d14df667dc937c391505"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Index), @"mvc.1.0.view", @"/Views/Course/Index.cshtml")]
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
#line 1 "C:\Users\seanr\OneDrive\Desktop\Study Reference\repos\Course_Registration\Views\_ViewImports.cshtml"
using Course_Registration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\seanr\OneDrive\Desktop\Study Reference\repos\Course_Registration\Views\_ViewImports.cshtml"
using Course_Registration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0a437f7f6b8ceab7944d14df667dc937c391505", @"/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a1a035f09945c2a0b14ed3c6760883f5c3d800c", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Course>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Course View</h2>\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0a437f7f6b8ceab7944d14df667dc937c3915053497", async() => {
                WriteLiteral("Create New Course");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>

<table class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"" style=""white-space: nowrap;"">Course Id</th>
            <th scope=""col"" style=""white-space: nowrap;"">Course Number</th>
            <th scope=""col"" style=""white-space: nowrap;"">Course Name</th>
            <th scope=""col"" style=""white-space: nowrap;"">Description</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 18 "C:\Users\seanr\OneDrive\Desktop\Study Reference\repos\Course_Registration\Views\Course\Index.cshtml"
         foreach (var v in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\seanr\OneDrive\Desktop\Study Reference\repos\Course_Registration\Views\Course\Index.cshtml"
               Write(v.CourseId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\seanr\OneDrive\Desktop\Study Reference\repos\Course_Registration\Views\Course\Index.cshtml"
               Write(v.CourseNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><span data-toggle=\"modal\" data-target=\"#exampleModalLong\" style=\"color: blue; cursor:pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 779, "\"", 814, 3);
            WriteAttributeValue("", 789, "showStudents(", 789, 13, true);
#nullable restore
#line 23 "C:\Users\seanr\OneDrive\Desktop\Study Reference\repos\Course_Registration\Views\Course\Index.cshtml"
WriteAttributeValue("", 802, v.CourseId, 802, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 813, ")", 813, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "C:\Users\seanr\OneDrive\Desktop\Study Reference\repos\Course_Registration\Views\Course\Index.cshtml"
                                                                                                                                                  Write(v.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\seanr\OneDrive\Desktop\Study Reference\repos\Course_Registration\Views\Course\Index.cshtml"
               Write(v.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 26 "C:\Users\seanr\OneDrive\Desktop\Study Reference\repos\Course_Registration\Views\Course\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <tbody>
</table>


<!-- Modal -->
<div class=""modal fade"" id=""exampleModalLong"" role=""dialog"">
    <div class=""modal-dialog"">
        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Enrolled Students</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>
            <div class=""modal-body"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>


<script>
function showStudents(id){
    $.get('");
#nullable restore
#line 53 "C:\Users\seanr\OneDrive\Desktop\Study Reference\repos\Course_Registration\Views\Course\Index.cshtml"
      Write(Url.Action("GetCourseStudentsID", "CourseStudent"));

#line default
#line hidden
#nullable disable
            WriteLiteral("/\' + id,\r\n        function (data) {\r\n            $(\".modal-body\").html(data)\r\n            console.log(data);\r\n\r\n});\r\n}\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
