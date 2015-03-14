<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Address_Book._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <p class="lead"><asp:TextBox ID="LastName" runat="server" Width="254px"></asp:TextBox>
            &nbsp;Фамилия / Наименование</p>
        <p class="lead">
            <asp:TextBox ID="Name" runat="server" Width="254px"></asp:TextBox>
            Имя</p>
        <p class="lead">
            <asp:TextBox ID="Patronymic" runat="server" Width="251px"></asp:TextBox>
            Отчество</p>
        <p class="lead">
            <asp:TextBox ID="Phone" runat="server" Width="252px"></asp:TextBox>
            Телефон</p>
        <p class="lead">
            <asp:TextBox ID="Address" runat="server" Width="250px"></asp:TextBox>
            Адрес</p>
        <p class="lead">
            <asp:Button ID="Button1" runat="server" Text="Добавить запись" Width="201px" OnClick="Button1_Click" />
        </p>
        <p class="lead">
            <asp:Button ID="Button2" runat="server" Text="Показать последнюю запись" Width="201px" OnClick="Button2_Click" />
        </p>
        <p class="lead">
            <asp:Label ID="lblStatus" runat="server"></asp:Label>
        </p>
    </div>

    </asp:Content>
