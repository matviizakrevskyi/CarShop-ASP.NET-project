﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Games.aspx.cs" Inherits="CarShop.Pages.Admin.Games" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListView ID="ListView1" ItemType="GameStore.Models.Game" SelectMethod="GetGames"
        DataKeyNames="GameId" UpdateMethod="UpdateGame" DeleteMethod="DeleteGame"
        InsertMethod="InsertGame" InsertItemPosition="LastItem" EnableViewState="false"
        runat="server">
        <LayoutTemplate>
            <div class="outerContainer">
                <table id="productsTable">
                    <tr>
                        <th>Nazwa gry</th>
                        <th>Opis gry</th>
                        <th>Kategoria</th>
                        <th>Cena</th>
                    </tr>
                    <tr runat="server" id="itemPlaceholder"></tr>
                </table>
            </div>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td><%# Item.Name %></td>
                <td class="description"><span><%# Item.Description %></span></td>
                <td><%# Item.Category %></td>
                <td><%# Item.Price.ToString("c") %></td>
                <td>
                    <asp:Button ID="Button1" CommandName="Edit" Text="Zmienić" runat="server" />
                    <asp:Button ID="Button2" CommandName="Delete" Text="Usunąć" runat="server" />
                </td>
            </tr>
        </ItemTemplate>
        <EditItemTemplate>
            <tr>
                <td>
                    <input name="name" value="<%# Item.Name %>" />
                    <input type="hidden" name="ProductID" value="<%# Item.GameId %>" />
                </td>
                <td>
                    <input name="description" value="<%# Item.Description %>" /></td>
                <td>
                    <input name="category" value="<%# Item.Category %>" /></td>
                <td>
                    <input name="price" value="<%# Item.Price %>" /></td>
                <td>
                    <asp:Button ID="Button3" CommandName="Update" Text="Resetować" runat="server" />
                    <asp:Button ID="Button4" CommandName="Cancel" Text="Cofnij" runat="server" />
                </td>
            </tr>
        </EditItemTemplate>
        <InsertItemTemplate>
            <tr>
                <td>
                    <input name="name" />
                    <input type="hidden" name="ProductID" value="0" />
                </td>
                <td>
                    <input name="description" /></td>
                <td>
                    <input name="category" /></td>
                <td>
                    <input name="price" /></td>
                <td>
                    <asp:Button ID="Button5" CommandName="Insert" Text="Wstawić" runat="server" />
                </td>
            </tr>
        </InsertItemTemplate>
    </asp:ListView>
</asp:Content>