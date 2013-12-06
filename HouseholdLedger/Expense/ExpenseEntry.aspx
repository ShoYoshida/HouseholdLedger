<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ExpenseEntry.aspx.cs" Inherits="HouseholdLedger.Expense.ExpenseEntry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script src="../Scripts/lib/Expense/ExpenseEntry.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Date" ClientIDMode="Static"></asp:Label>
        <asp:TextBox ID="TxtDate" runat="server" ClientIDMode="Static" Width="96px"></asp:TextBox>
    </div>
    <div>
      <table id="grid">
      </table>
      <div id="pager"></div>    
    </div>  
</asp:Content>
