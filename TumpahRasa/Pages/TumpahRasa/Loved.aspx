<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/TumpahRasa/TumphRasa.Master" AutoEventWireup="true" CodeBehind="Loved.aspx.cs" Inherits="TumpahRasa.Pages.TumpahRasa.Loved" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <!-- Loved Section Started -->
    <section class="dishes" id="loved" style="padding-top:8em;">

        <h3 class="sub-heading">Something You Ever Felt Before!</h3>
        <h1 class="heading">Your Loved Recipes</h1>

        <div class="box-container">

            <asp:Repeater ID="LovedRepeater" runat="server">
                <ItemTemplate>
                    <div class="box">
                        <div class="icons">
                            <button class="fas fa-heart stars"></button>
                            <p><%# Eval("rating") %> <i class="fas fa-star"></i></p>
                        </div>
                        <img src="<%# Eval("thumbnail") %>" alt="">
                        <h3><%# Eval("name") %></h3>
                        <a href="Detail.aspx?id=<%# Eval("id") %>" class="btn">Add to Cart</a>
                    </div>
                </ItemTemplate>
            </asp:Repeater>

        </div>

    </section>
    <!-- Dishes Section Ended -->
</asp:Content>
