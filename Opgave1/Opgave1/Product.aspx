<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="~/Product.aspx.cs" Inherits="Opgave1.Person" %>

<%@ Register Src="Controls/Backbone.ascx" TagName="Backbone" TagPrefix="customControls" %>
<%@ Register Src="Controls/End.ascx" TagName="End" TagPrefix="customControls" %>
<script runat="server">

    
</script>



<customControls:Backbone runat="server" />


<div class="bodyText">

    <h1>Opgave 3</h1>

    <form id="form1" runat="server">

        <div><p>Pris:</p><asp:textbox id="Pris" runat="server" readonly="True">100</asp:textbox></div>

        <div><p>Antal:</p><asp:textbox id="Antal" runat="server" textmode="Number"></asp:textbox></div>

        <div><p>Moms?</p>
            <asp:radiobutton runat="server" ID="with" GroupName="test" Checked="True" Text="With moms"></asp:radiobutton>
            <asp:radiobutton runat="server" ID="without" GroupName="test" Text="Without moms"></asp:radiobutton>
        </div> 

        <div>
            <p>Currency to display?</p>
            <asp:dropdownlist runat="server" ItemType="int" ID="currency">
                <asp:ListItem Text="DKK" Value="0"></asp:ListItem>
                <asp:ListItem Text="EURO" Value="1"></asp:ListItem>
                <asp:ListItem Text="Dollar" Value="2"></asp:ListItem>
            </asp:dropdownlist>

        </div>

        <div><p>Lig med:</p><asp:textbox id="Lig" runat="server" readonly="True"></asp:textbox></div>

        <div><p>Udregning:</p><asp:Label id="valuta" runat="server"></asp:Label></div>

        <div><p>Error:</p><asp:textbox id="Error" runat="server" readonly="True"></asp:textbox></div>

        <div><asp:button id="Button1" runat="server" text="Button" OnClick="Button1_Click" /></div>

    </form>
</div>
<customControls:End runat="server" />
