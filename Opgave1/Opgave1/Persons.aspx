<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Persons.aspx.cs" Inherits="Opgave1.Persons" %>

<%@ Register Src="Controls/Backbone.ascx" TagName="Backbone" TagPrefix="customControls" %>
<%@ Register Src="Controls/End.ascx" TagName="End" TagPrefix="customControls" %>

<customControls:Backbone runat="server" />

<div class="bodyText">
	<h1>Opgave 4</h1>
    <form id="form2" runat="server">

        <table>
            <tr>
                <td><div><p>Navn:</p></td><td><asp:textbox id="Name" runat="server"></asp:textbox></div></td>
            </tr>
            <tr>
                <td><div><p>Alder:</p></td><td><asp:textbox id="Age" runat="server" textmode="Number"></asp:textbox></div></td>
            </tr>
            <tr>
                <td><div><p>E-mail Addresse:</p></td><td><asp:textbox id="Mail" runat="server"></asp:textbox></div></td>
            </tr>
            <tr>
                <td><div><asp:button runat="server" text="Button" OnClick="Unnamed3_Click" /></div></td>
            </tr>

        </table>

		<asp:requiredfieldvalidator runat="server" errormessage="RequiredFieldValidator" ControlToValidate="Name" ID="nameError"></asp:requiredfieldvalidator>
		<asp:rangevalidator runat="server" errormessage="RangeValidator" ControlToValidate="Age" ID="ageError" MaximumValue="50" MinimumValue="18"></asp:rangevalidator>
		<asp:regularexpressionvalidator runat="server" errormessage="RegularExpressionValidator" ControlToValidate="Mail" ID="mailError" ValidationExpression="^(?(&quot;)(&quot;.+?(?&lt;!\\)&quot;@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&amp;'\*\+/=\?\^`\{\}\|~\w])*)(?&lt;=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$"></asp:regularexpressionvalidator>

    </form>

</div>


<customControls:End runat="server" />

