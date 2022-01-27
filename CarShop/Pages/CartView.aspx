﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CartView.aspx.cs" Inherits="CarShop.Pages.CartView" MasterPageFile="~/Pages/Store.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContent" runat="server">
    <div id="content">
        <h2>Koszyk</h2>
        <table id="cartTable">
            <thead>
                <tr>
                    <th>Liczba produktów</th>
                    <th>Nazwa</th>
                    <th>Cena</th>
                    <th>Calkowity koszt</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="Repeater1" ItemType="CarShop.Models.CartLine"
                    SelectMethod="GetCartLines" runat="server" EnableViewState="false">
                    <ItemTemplate>
                        <tr>
                            <td><%# Item.Quantity %></td>
                            <td><%# Item.Product.Name %></td>
                            <td><%# Item.Product.Price.ToString("c")%></td>
                            <td><%# ((Item.Quantity * 
                                Item.Product.Price).ToString("c"))%></td>
                            <td>
                                <button type="submit" class="actionButtons" name="remove"
                                    value="<%#Item.Product.ProductId %>">
                                    Usunąc</button>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
            <tfoot>
                <tr>
                    <td colspan="3">W calosci:</td>
                    <td><%= CartTotal.ToString("c") %></td>
                </tr>
            </tfoot>
        </table>
        <p class="actionButtons">
            <a href="<%= ReturnUrl %>">Kontynuowac zakupy</a>
             <a href="<%= CheckoutUrl %>">Zamówić</a>
        </p>
    </div>
</asp:Content>
