﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LogDashboard.Views.Dashboard
{
    using System;
    
    #line 5 "..\..\Views\Dashboard\TraceLogList.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    using System.Linq;
    using System.Text;
    
    #line 6 "..\..\Views\Dashboard\TraceLogList.cshtml"
    using LogDashboard.Extensions;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Views\Dashboard\TraceLogList.cshtml"
    using LogDashboard.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class TraceLogList : LogDashboard.Views.RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n\r\n");


WriteLiteral("\r\n");




WriteLiteral(@"
<div class=""table-responsive"">
    <table class=""table row mx-0 table-hover table-expandable"">
        <thead class=""w-100"">
            <tr class=""row mx-0"">
                <th class=""col-1"">Id</th>
                <th class=""col-3"">Logger</th>
                <th class=""col-1"">级别</th>
                <th class=""col-5"">消息</th>
                <th class=""col-2"">时间</th>
            </tr>
        </thead>
        <tbody class=""w-100"">
");


            
            #line 21 "..\..\Views\Dashboard\TraceLogList.cshtml"
             foreach (var item in (IEnumerable<ILogModel>)ViewData["Model"])
            {

            
            #line default
            #line hidden
WriteLiteral("            <tr class=\"row mx-0\">\r\n                <td class=\"col-1\"><a href=\"jav" +
"ascript:void(0);\" onclick=\"logInfo(\'");


            
            #line 24 "..\..\Views\Dashboard\TraceLogList.cshtml"
                                                                             Write(item.Id.ToString());

            
            #line default
            #line hidden
WriteLiteral("\')\">");


            
            #line 24 "..\..\Views\Dashboard\TraceLogList.cshtml"
                                                                                                    Write(item.Id.ToString());

            
            #line default
            #line hidden
WriteLiteral("</a></td>\r\n                <td class=\"col-3\"><span>");


            
            #line 25 "..\..\Views\Dashboard\TraceLogList.cshtml"
                                   Write(item.Logger);

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n");


            
            #line 26 "..\..\Views\Dashboard\TraceLogList.cshtml"
                  
                        // if (item.Level== LogLevelConst.Error)
                        // {
                        //     <div class="modal fade" id="@item.Id.ToString()">
                        //         <div class="modal-dialog modal-lg" role="document">
                        //             <div class="modal-content">
                        //                 <div class="modal-header bg-danger border-0"><h5 class="modal-title text-white">Exception</h5><button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button></div><div class="modal-body">
                        //                     <pre>@item.Exception</pre>
                        //                 </div>
                        //             </div>
                        //         </div>
                        //     </div>
                        //     <td class="col-1"><button class="btn btn-outline-@item.Level.ToUpper().FormatLevel()" onclick='clickErrorBtn(event,"#@item.Id.ToString()");'>@item.Level.ToUpper().FormatLevel()</button></td>
                        // }
                        // else
                        // {

            
            #line default
            #line hidden
WriteLiteral("                            <td class=\"col-1\"><button class=\"btn btn-outline-");


            
            #line 42 "..\..\Views\Dashboard\TraceLogList.cshtml"
                                                                        Write(item.Level.ToUpper().FormatLevel());

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 42 "..\..\Views\Dashboard\TraceLogList.cshtml"
                                                                                                             Write(item.Level.ToUpper().FormatLevel());

            
            #line default
            #line hidden
WriteLiteral("</button></td>\r\n");


            
            #line 43 "..\..\Views\Dashboard\TraceLogList.cshtml"
                        // }
                    

            
            #line default
            #line hidden
WriteLiteral("                    <td class=\"col-5\">\r\n");


            
            #line 46 "..\..\Views\Dashboard\TraceLogList.cshtml"
                          
                            var message = item.Message;
                            if (message.Length > 150)
                            {
                                message = message.Substring(0, 150) + "........";
                            }
                    

            
            #line default
            #line hidden
WriteLiteral("                    ");


            
            #line 53 "..\..\Views\Dashboard\TraceLogList.cshtml"
               Write(message);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td class=\"col-2\">");


            
            #line 55 "..\..\Views\Dashboard\TraceLogList.cshtml"
                             Write(item.LongDate.ToString("yyyy-MM-dd HH:mm:ss"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n            </tr>\r\n");



WriteLiteral(@"            <tr class=""row mx-0"">
                <td colspan=""10"" style=""width: 100%"">
                    <div class=""table-responsive"">
                        <table class=""table table-bordered"">
                            <tbody>
                                <tr>
                                    <td>Id</td>
                                    <td class=""text-nowrap"">");


            
            #line 64 "..\..\Views\Dashboard\TraceLogList.cshtml"
                                                       Write(item.Id.ToString());

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr" +
">\r\n                                    <td>时间</td>\r\n                            " +
"        <td class=\"text-nowrap\">");


            
            #line 68 "..\..\Views\Dashboard\TraceLogList.cshtml"
                                                       Write(item.LongDate.ToString("yyyy-MM-dd HH:mm:ss"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr" +
">\r\n                                    <td>级别</td>\r\n                            " +
"            <td class=\"text-nowrap\"><button class=\"btn btn-outline-");


            
            #line 72 "..\..\Views\Dashboard\TraceLogList.cshtml"
                                                                                          Write(item.Level.ToUpper().FormatLevel());

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 72 "..\..\Views\Dashboard\TraceLogList.cshtml"
                                                                                                                               Write(item.Level.ToUpper().FormatLevel());

            
            #line default
            #line hidden
WriteLiteral("</button></td>\r\n                                </tr>\r\n                          " +
"      <tr>\r\n                                    <td>Logger</td>\r\n               " +
"                     <td class=\"text-nowrap\">");


            
            #line 76 "..\..\Views\Dashboard\TraceLogList.cshtml"
                                                       Write(item.Logger);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr" +
">\r\n                                    <td>消息</td>\r\n                            " +
"        <td class=\"text-nowrap\">");


            
            #line 80 "..\..\Views\Dashboard\TraceLogList.cshtml"
                                                       Write(item.Message);

            
            #line default
            #line hidden
WriteLiteral(@"</td>
                                </tr>

                            </tbody>
                        </table>
                        <div class=""card"">
                            <div class=""card-header bg-light"">
                                堆栈信息
                            </div>
                            <div class=""card-body"">
                                <pre>");


            
            #line 90 "..\..\Views\Dashboard\TraceLogList.cshtml"
                                Write(item.Exception);

            
            #line default
            #line hidden
WriteLiteral("</pre>\r\n                            </div>\r\n                        </div>\r\n     " +
"               </div>\r\n                </td>\r\n            </tr>\r\n");


            
            #line 96 "..\..\Views\Dashboard\TraceLogList.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");


        }
    }
}
#pragma warning restore 1591
