<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Estudiantes.aspx.cs" Inherits="Matricula_de_Estudiantes.Estudiantes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 28px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table align="center" border="0" cellpadding="2" cellspacing="2" style="font-weight: normal; font-size: 9pt; font-family: Tahoma; background-color: #f5f5f5"
            width="98%">
            <tr>
                <td colspan="4" align="center">
                    <br />
                    <font size="3"><strong>REGISTRO DE ESTUDIANTES               
                    </strong></font>
                    <br />
                </td>
            </tr>
            <tr style="color: #000000">
                <td style="text-align: left" colspan="4">
                    <asp:Label ID="lblError" runat="server" Font-Bold="True" Font-Names="Tahoma"
                        ForeColor="Red" Font-Size="10pt"></asp:Label>
                </td>
            </tr>
            <tr style="font-size: 9pt; color: #000000">
                <td style="text-align: left">Consecutivo:</td>
                <td>
                    <asp:TextBox ID="txtConsecutivo" runat="server"></asp:TextBox></td>
                <td style="text-align: left"></td>
                <td style="text-align: left"></td>
            </tr>
            <tr>
                <td style="text-align: left">Código Estudiante:</td>
                <td style="text-align: left">
                    <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox></td>
                <td style="text-align: left">Nombre:</td>
                <td style="text-align: left">
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align: left">Promedio:</td>
                <td style="text-align: left">
                    <asp:TextBox ID="txtPromedio" runat="server"></asp:TextBox></td>
                <td style="text-align: left">Teléfono:</td>
                <td style="text-align: left">
                    <asp:TextBox CssClass="form-control" runat="server" ID="txtTelefono"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align: left">&nbsp;</td>
                <td style="text-align: left">
                    &nbsp;</td>
                <td style="text-align: left">&nbsp;</td>
                <td style="text-align: left">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: left" class="auto-style1">&nbsp;</td>
                <td style="text-align: left" class="auto-style1">
                    </td>
                <td style="text-align: left" class="auto-style1">&nbsp;</td>
                <td style="text-align: left" class="auto-style1">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: left" class="auto-style1">&nbsp;</td>
                <td style="text-align: left" class="auto-style1">
                    </td>
                <td style="text-align: left" class="auto-style1">&nbsp;</td>
                <td style="text-align: left" class="auto-style1">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: center" colspan="4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: center" colspan="4">
                    <br />
                    <asp:Button ID="btnGuardar" runat="server" Text="Registrar" OnClick="btnGuardar_Click" /></td>
            </tr>

            <tr>
                <td style="text-align: center" colspan="4">
                    <asp:GridView ID="gvDatos" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" PageSize="20" Style="font-size: 9pt" Width="100%" AutoPostBack="True">
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="Consecutivo" />
                            <asp:BoundField DataField="Codigo" HeaderText="Código" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="Promedio" HeaderText="Promedio" />
                            <asp:BoundField DataField="Id_Telefono" HeaderText="Teléfono" />

                            <%--<asp:BoundField DataField="ReservaAlimentacionTexto" HeaderText="Reserva Alimentacion" />
                <asp:BoundField DataField="FechaModificacion" HeaderText="Fecha Reserva" />--%>


                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:ImageButton runat="server" ID="btnEditar" ImageUrl="~/Imagenes/view_report.png" ToolTip="Editar Proyecto" />
                                </ItemTemplate>
                            </asp:TemplateField>

                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                </td>
            </tr>



        </table>
    </form>
</body>
</html>

