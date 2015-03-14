<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllRecordsShow.aspx.cs" Inherits="Address_Book.AllRecordsShow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="AddressBookTitle" runat="server" class="ContentHead"><h1>Address Book</h1></div>
    <asp:GridView ID="AddressList" runat="server" AutoGenerateColumns="False" ShowFooter="True" GridLines="Vertical" CellPadding="3"
        ItemType="Address_Book.Models.RecordContext" SelectMethod="GetRecords"
        CssClass="table table-striped table-bordered" >   
        <Columns>
        <asp:BoundField DataField="Record.RecordID" HeaderText="ID" />        
        <asp:BoundField DataField="Record.LastName" HeaderText="Last Name" />        
        <asp:BoundField DataField="Record.Name" HeaderText="Name" />     
    </Columns>    
    </asp:GridView>
    <br />
</asp:Content>
