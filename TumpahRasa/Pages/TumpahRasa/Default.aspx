﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/TumpahRasa/TumphRasa.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TumpahRasa.Pages.TumpahRasa.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
        <!-- Home Section Started -->
        <section class="home" id="home">

            <div class="swiper home-slider">
                <div class="swiper-wrapper">

                    <asp:Repeater ID="JumbotronRepeater" runat="server">
                        <ItemTemplate>
                            <div class="swiper-slide slide">
                                <div class="content">
                                    <span>Our Special Dish</span>
                                    <h3><%# Eval("name") %></h3>
                                    <p><%# Eval("rating") %> <i class="fas fa-star"></i></p>
                                    <a class="btn" href="Detail.aspx?id=<%# Eval("id") %>">VIEW</a>
                                </div>
                                <div class="image">
                                    <img src="<%# Eval("thumbnail") %>" alt="rusak">
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>

                </div>
                <div class="swiper-pagination"></div>
            </div>

        </section>
        <!-- Home Section Ended -->

        <!-- About Section Started -->
        <section class="about" id="about">

            <h3 class="sub-heading">Your Second Home</h3>
            <h1 class="heading">Story of Tumpah Rasa</h1>

            <div class="row">

                <div class="image">
                    <img src="../../App_Themes/RecipeTheme/asset/abt.jpg" alt="">
                </div>
                <div class="content">
                    <p>
                        Welcome to Tumpah Rasa, your digital kitchen of endless culinary inspiration! Embark on a journey
                    where every page turns like a delicious chapter in a recipe book, and every dish tells a story of
                    flavor, culture, and creativity.
                    <br>
                        <br>
                        On Tumpah Rasa, we believe that cooking is an art form, a language spoken with ingredients,
                    textures,
                    and aromas. Whether you're a seasoned chef or a kitchen novice, our virtual shelves are stocked with
                    recipes to tantalize taste buds, ignite imaginations, and bring people together around the universal
                    love for food.
                    </p>
                    <div class="plus">
                        <i class="fa-solid fa-heart-circle-bolt">
                            <h3>Loveable Taste</h3>
                        </i>
                        <i class="fa-solid fa-ranking-star">
                            <h3>Approved by People</h3>
                        </i>
                    </div>
                </div>

            </div>

        </section>
        <!-- About Section Ended -->

        <!-- Dishes Section Started -->
        <section class="dishes" id="recipe">

            <h3 class="sub-heading">Something You Never Felt Before!</h3>
            <h1 class="heading">Our Main Menus</h1>

            <div class="box-container">

                <asp:Repeater ID="RecipeRepeater" runat="server">
                    <ItemTemplate>
                        <div class="box">
                            <div class="icons">
                                <asp:LinkButton ID="LinkButton1" runat="server" CssClass="fas fa-heart stars" CommandArgument='<%# Eval("id") %>' OnCommand="BtnLove"></asp:LinkButton>
                                <p><%# Eval("rating") %> <i class="fas fa-star"></i></p>
                            </div>
                            <img src="<%# Eval("thumbnail") %>" alt="">
                            <h3><%# Eval("name") %></h3>
                            <a href="Detail.aspx?id=<%# Eval("id") %>" class="btn">Open</a>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>

            </div>

        </section>
        <!-- Dishes Section Ended -->
</asp:Content>
