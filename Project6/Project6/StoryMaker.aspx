<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="StoryMaker.aspx.cs" Inherits="Project6.StoryMaker" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <h1>Story Maker</h1>
    <br />

    <h3>Enter the specified word type in each box and press genereate to make a story.</h3>
  
    <table style="width: auto; text-align: center">
        <tr>
            <td>Nouns</td>
            <td>Verbs</td>
            <td>Adjectives</td>
            <td>Adverbs</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="errN1" runat="server" Text=""></asp:Label></td>
            <td>
                <asp:Label ID="errV1" runat="server" Text=""></asp:Label></td>
            <td>
                <asp:Label ID="errAdj1" runat="server" Text=""></asp:Label></td>
            <td>
                <asp:Label ID="errAdv1" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td><asp:TextBox ID="Noun1" runat="server"></asp:TextBox></td>
            <td><asp:TextBox ID="Verb1" runat="server"></asp:TextBox></td>
            <td><asp:TextBox ID="Adjective1" runat="server"></asp:TextBox></td>
            <td><asp:TextBox ID="Adverb1" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:TextBox ID="Noun2" runat="server"></asp:TextBox></td>
            <td><asp:TextBox ID="Verb2" runat="server"></asp:TextBox></td>
            <td><asp:TextBox ID="Adjective2" runat="server"></asp:TextBox></td>
            <td><asp:TextBox ID="Adverb2" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="errN2" runat="server" Text=""></asp:Label></td>
            <td>
                <asp:Label ID="errV2" runat="server" Text=""></asp:Label></td>
            <td>
                <asp:Label ID="errAdj2" runat="server" Text=""></asp:Label></td>
            <td>
                <asp:Label ID="errAdv2" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td><asp:Button ID="btnGenerate" runat="server" OnClick="btnGenerate_Click" Text="Generate" /></td>
        </tr>
    </table>
    <br />
    <br />
    <br />
    <p id="Story" runat="server"></p>
</asp:Content>
