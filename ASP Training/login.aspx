<%@ Page Title="login" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ASP_Training.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="page" class="container">
		<div id="content">
			<div class="title">
				<h2>login</h2>
                <br />
		

        
                <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" ></asp:TextBox>
                <br />
		

        
                <br />
		

        
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password">password</asp:TextBox>
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 26px" Text="login" />
                <br />
                <br />
            </div>

	</div>

</asp:Content>
