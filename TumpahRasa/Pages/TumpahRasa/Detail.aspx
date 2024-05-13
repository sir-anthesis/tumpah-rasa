<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/TumpahRasa/TumphRasa.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="TumpahRasa.Pages.TumpahRasa.Detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="row-detail">
        <!-- Detail Section Started -->
        <section class="detail" id="detail">
            <div class="image">
                <img src="<%: thumbnail %>" alt="">
            </div>
            <div class="content">
                <div class="info">
                    <h1 class="heading"><%: name %></h1>
                    <h3 class="sub-heading"><%: created_at %> <i class="fas fa-clock"></i> <span style="margin: 0 1rem">||</span> <%: rating %> <i class="fas fa-star"></i></h3>
                </div>
                <div class="text">
                    <asp:Literal ID="DescLiteral" runat="server" Mode="PassThrough"></asp:Literal>
                </div>
            </div>
        </section>
        <!-- Detail Section Ended -->

        <!-- Others Section Started -->
        <section class="others box-container" id="others">
            <h3 class="sub-heading">Something You Never Felt Before!</h3>
            <asp:Repeater ID="OthersRepeater" runat="server">
                <ItemTemplate>
                    <div class="box">
                        <div class="icons">
                            <button class="fas fa-heart stars"></button>
                            <p><%# Eval("rating") %> <i class="fas fa-star"></i></p>
                        </div>
                        <img src="<%# Eval("thumbnail") %>" alt="">
                        <h3><%# Eval("name") %></h3>
                        <a href="Detail.aspx?id=<%# Eval("id") %>" class="btn">Open</a>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </section>

    </div>

    <!-- Review Section Started -->
    <section class="review" id="review">
        <h3 class="sub-heading">Tumpah Rasa's Canvas</h3>
        <h1 class="heading">What They Say!</h1>

        <div class="swiper review-slider">

            <div class="swiper-wrapper">
                <asp:Repeater ID="CommentRepeater" runat="server">
                    <ItemTemplate>
                        <div class="swiper-slide slide">
                            <i class="fas fa-quote-right"></i>
                            <div class="user">
                                <div class="user-info">
                                    <h3><%# Eval("name") %></h3>
                                    <div class="stars">
                                        <h4 style="display: inline;"><%# Eval("rate") %></h4>
                                        <i class="fas fa-star"></i>
                                    </div>
                                </div>
                            </div>
                            <p>
                                <%# Eval("comment") %>
                            </p>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>

        </div>

        <!-- Comment Section Started -->
        <section class="comment" id="comment">
            <h3 class="sub-heading">Tell Us</h3>
            <h1 class="heading">Your Thoughts!</h1>

            <form1 method="post">
                <div class="wrap">
                    <label for="" class="sub-heading">Rate</label>
                    <input type="number" name="rate">
                </div>
                <div class="wrap">
                    <label for="" class="sub-heading">Comment</label>
                    <textarea name="cmnt" id="" rows="10"></textarea>
                </div>
                <asp:Button ID="Button1" runat="server" Text="Add Comment" CssClass="btn" OnClick="Button1_Click" />
            </form1>
        </section>
        <!-- Comment Section Ended -->

    </section>
    <!-- Review Section Ended -->
</asp:Content>
