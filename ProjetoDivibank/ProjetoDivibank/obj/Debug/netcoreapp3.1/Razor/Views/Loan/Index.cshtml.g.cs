#pragma checksum "C:\Users\Scarpitta\Documents\GitHub\ProjetoDivibank\ProjetoDivibank\ProjetoDivibank\Views\Loan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b07b8b70c640d39f54b6591289bcd95ab7259e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Loan_Index), @"mvc.1.0.view", @"/Views/Loan/Index.cshtml")]
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
#line 1 "C:\Users\Scarpitta\Documents\GitHub\ProjetoDivibank\ProjetoDivibank\ProjetoDivibank\Views\_ViewImports.cshtml"
using ProjetoDivibank;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Scarpitta\Documents\GitHub\ProjetoDivibank\ProjetoDivibank\ProjetoDivibank\Views\_ViewImports.cshtml"
using ProjetoDivibank.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b07b8b70c640d39f54b6591289bcd95ab7259e9", @"/Views/Loan/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db24fc70e1f69e82726b0fef59ef05fe01521125", @"/Views/_ViewImports.cshtml")]
    public class Views_Loan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Scarpitta\Documents\GitHub\ProjetoDivibank\ProjetoDivibank\ProjetoDivibank\Views\Loan\Index.cshtml"
  
    ViewData["Title"] = "Pedidos";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n\ti {\r\n\t\tcursor: pointer;\r\n\t}\r\n</style>\r\n\r\n<h1>Pedidos</h1>\r\n\r\n<div class=\"container\">\r\n\t<div class=\"col-lg-12\">\r\n\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b07b8b70c640d39f54b6591289bcd95ab7259e94148", async() => {
                WriteLiteral("\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"form-group col-lg-4\">\r\n\t\t\t\t\t<select class=\"form-control\" id=\"clientes\">\r\n\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b07b8b70c640d39f54b6591289bcd95ab7259e94555", async() => {
                    WriteLiteral("Selecione um Cliente");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
					</select>
				</div>
			</div>
			<div class=""row"">
				<div class=""form-group col-lg-4"">
					<label for=""dtPedido"">Data do Pedido</label>
					<input type=""text"" class=""form-control"" id=""dtPedido"">
				</div>
				<div class=""form-group col-lg-4"">
					<label for=""vlPedido"">Valor do Pedido</label>
					<input type=""text"" class=""form-control"" id=""vlPedido"">
				</div>
			</div>
			<button class=""btn btn-primary"" id=""btnSalvar"">Salvar</button>
		");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
	</div>
	<div class=""col-lg-12 mt-5"">
		<table class=""table"">
			<thead>
				<tr>
					<th scope=""col"">Nome do Cliente</th>
					<th scope=""col"">Data do Pedido</th>
					<th scope=""col"">Valor do Pedido</th>
				</tr>
			</thead>
			<tbody>
			</tbody>
		</table>
	</div>
</div>


<script>
	$(document).ready(function () {
		id_editando = 0;

		getLoans = function () {
			$.ajax({
				url: ""Loans/GetLoans"",
				method: ""Post"",
				success: function (data) {
					console.info(data)
				}
			})
		}

		getLoan = function (id) {
			$.ajax({
				url: ""Loans/GetLoan"",
				method: ""Post"",
				data: {
					id: id,
				},
				success: function (data) {
					setFields(data)
				}
			})
		}

		getClientLoans = function (idCliente) {
			$.ajax({
				url: ""Loans/GetClientLoans"",
				method: ""Post"",
				data: {
					idCliente: idCliente,
				},
				success: function (data) {
					buildTableBody(data)
				}
			})
		}

		addLoan = function (dataPedido, valor, idCliente)");
            WriteLiteral(@" {
			valor = valor.replace(""."", """")
			$.ajax({
				url: ""Loans/AddLoan"",
				method: ""Post"",
				data: {
					dtPedido: dataPedido,
					vlPedido: valor,
					idCliente: idCliente
				},
				success: function (data) {
					clearFields();
					getClientLoans($(""#clientes"").val());
				}
			})
		}

		editLoan = function (idPedido, dataPedido, valor, idCliente) {
			valor = valor.replace(""."", """")
			$.ajax({
				url: ""Loans/EditLoan"",
				method: ""Post"",
				data: {
					idPedido: idPedido,
					dtPedido: dataPedido,
					vlPedido: valor,
					idCliente: idCliente
				},
				success: function (data) {
					clearFields();
					getClientLoans($(""#clientes"").val());
				}
			})
		}

		deleteLoan = function (idPedido) {
			$.ajax({
				url: ""Loans/DeleteLoan"",
				method: ""Post"",
				data: {
					id: idPedido
				},
				success: function (data) {
					getClientLoans($(""#clientes"").val());
				}
			})
		}

		getClients = function () {
			$.ajax({
				url: ""Clients/G");
            WriteLiteral(@"etClients"",
				method: ""Post"",
				success: function (data) {
					fillClientSelect(data)
				}
			})
		}

		fillClientSelect = function (data) {
			data.forEach(function (currentValue, index) {
				$('#clientes').append(`<option value=""${currentValue.idCliente}"">
                                       ${currentValue.nomeCliente}
                                  </option>`);
			});
		}

		clearFields = function () {
			$(""#dtPedido"").val("""");
			$(""#vlPedido"").val("""");
			id_editando = 0;
		}

		setFields = function (data) {
			$(""#dtPedido"").val(`${data.dtPedido.toString().substring(8, 10)}/${data.dtPedido.toString().substring(5, 7)}/${data.dtPedido.toString().substring(0, 4)}`);
			$(""#vlPedido"").val(data.vlPedido);
			id_editando = data.idPedido;
			console.info(id_editando)
		}

		buildTableBody = function (data) {
			var tbody = $(""tbody"");
			tbody.empty();
			data.forEach(function (currentValue, index) {
				tbody.append(""<tr>"" +
					`<td>${currentValue.nomeCliente}");
            WriteLiteral(@"</td>
					<td>${currentValue.dtPedido.toString().substring(8, 10)}/${currentValue.dtPedido.toString().substring(5, 7)}/${currentValue.dtPedido.toString().substring(0, 4)}</td>"" +
					<td>${currentValue.vlPedido}</td>
					<td><i class=""fas fa-pencil-alt edit"" id=""${currentValue.idPedido}""></i>&nbsp;&nbsp;<i class=""fas fa-times delete"" id=""${currentValue.idPedido}""></i></td>
					</tr>`);
				console.info(currentValue)
			});

			$("".delete"").click(function () {
				deleteLoan($(this).attr(""id""));
			})

			$("".edit"").click(function () {
				getLoan($(this).attr(""id""));
			})
		}

		$(""#clientes"").change(function () {
			getClientLoans($(this).val());
			clearFields();
		});

		$(""#btnSalvar"").click(function (e) {
			if (id_editando > 0) {
				editLoan(id_editando, $(""#dtPedido"").val(), $(""#vlPedido"").val(), $(""#clientes"").val());
			} else {
				addLoan($(""#dtPedido"").val(), $(""#vlPedido"").val(), $(""#clientes"").val());
			}
			e.preventDefault();
		})

		getClients();
		$(""#d");
            WriteLiteral("tPedido\").mask(\"99/99/9999\");\r\n\t\t$(\"#vlPedido\").mask(\'000.000.000.000.000,00\', { reverse: true });\r\n    })\r\n</script>");
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
