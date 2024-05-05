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
                    <h3 class="sub-heading"><%: created_at %> <i class="fas fa-clock"></i> || <%: rating %> <i class="fas fa-star"></i></h3>
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

            <div class="box">
                <div class="icons">
                    <button class="fas fa-heart stars"></button>
                    <p>4.7 <i class="fas fa-star"></i></p>
                </div>
                <img src="image/hero-1.jpg" alt="">
                <h3>Cheesy Butt</h3>
                <a href="" class="btn">Open</a>
            </div>

            <div class="box">
                <div class="icons">
                    <button class="fas fa-heart stars"></button>
                    <p>4.7 <i class="fas fa-star"></i></p>
                </div>
                <img src="image/hero-1.jpg" alt="">
                <h3>Cheesy Butt</h3>
                <a href="" class="btn">Open</a>
            </div>

            <div class="box">
                <div class="icons">
                    <button class="fas fa-heart stars"></button>
                    <p>4.7 <i class="fas fa-star"></i></p>
                </div>
                <img src="image/hero-1.jpg" alt="">
                <h3>Cheesy Butt</h3>
                <a href="" class="btn">Open</a>
            </div>

        </section>

    </div>

    <!-- Review Section Started -->
    <section class="review" id="review">
        <h3 class="sub-heading">Tumpah Rasa's Canvas</h3>
        <h1 class="heading">What They Say!</h1>

        <div class="swiper review-slider">

            <div class="swiper-wrapper">

                <div class="swiper-slide slide">
                    <i class="fas fa-quote-right"></i>
                    <div class="user">
                        <div class="user-info">
                            <h3>Robert Downey Jr</h3>
                            <div class="stars">
                                <i class="fas fa-star"></i>
                                <i class="fas fa-star"></i>
                                <i class="fas fa-star"></i>
                                <i class="fas fa-star"></i>
                                <i class="fas fa-star-half-alt"></i>
                            </div>
                        </div>
                    </div>
                    <p>
                        Lorem, ipsum dolor sit amet consectetur adipisicing elit. Dolores provident quo obcaecati dolorem
                        cumque? Dignissimos officia quisquam optio accusantium, modi facilis fuga laudantium. Commodi,
                        autem
                        omnis dolore deleniti deserunt nesciunt?
                    </p>
                </div>

                <div class="swiper-slide slide">
                    <i class="fas fa-quote-right"></i>
                    <div class="user">
                        <div class="user-info">
                            <h3>Christ Evans</h3>
                            <div class="stars">
                                <i class="fas fa-star"></i>
                                <i class="fas fa-star"></i>
                                <i class="fas fa-star"></i>
                                <i class="fas fa-star"></i>
                                <i class="fas fa-star-half-alt"></i>
                            </div>
                        </div>
                    </div>
                    <p>
                        Lorem, ipsum dolor sit amet consectetur adipisicing elit. Dolores provident quo obcaecati dolorem
                        cumque? Dignissimos officia quisquam optio accusantium, modi facilis fuga laudantium. Commodi,
                        autem
                        omnis dolore deleniti deserunt nesciunt?
                    </p>
                </div>

                <div class="swiper-slide slide">
                    <i class="fas fa-quote-right"></i>
                    <div class="user">
                        <div class="user-info">
                            <h3>Christ Hermswoth</h3>
                            <div class="stars">
                                <i class="fas fa-star"></i>
                                <i class="fas fa-star"></i>
                                <i class="fas fa-star"></i>
                                <i class="fas fa-star"></i>
                                <i class="fas fa-star-half-alt"></i>
                            </div>
                        </div>
                    </div>
                    <p>
                        Lorem, ipsum dolor sit amet consectetur adipisicing elit. Dolores provident quo obcaecati dolorem
                        cumque? Dignissimos officia quisquam optio accusantium, modi facilis fuga laudantium. Commodi,
                        autem
                        omnis dolore deleniti deserunt nesciunt?
                    </p>
                </div>

                <div class="swiper-slide slide">
                    <i class="fas fa-quote-right"></i>
                    <div class="user">
                        <div class="user-info">
                            <h3>Mark Rufaldo</h3>
                            <div class="stars">
                                <i class="fas fa-star"></i>
                                <i class="fas fa-star"></i>
                                <i class="fas fa-star"></i>
                                <i class="fas fa-star"></i>
                                <i class="fas fa-star-half-alt"></i>
                            </div>
                        </div>
                    </div>
                    <p>
                        Lorem, ipsum dolor sit amet consectetur adipisicing elit. Dolores provident quo obcaecati dolorem
                        cumque? Dignissimos officia quisquam optio accusantium, modi facilis fuga laudantium. Commodi,
                        autem
                        omnis dolore deleniti deserunt nesciunt?
                    </p>
                </div>

                <div class="swiper-slide slide">
                    <i class="fas fa-quote-right"></i>
                    <div class="user">
                        <div class="user-info">
                            <h3>Scarlet Johanson</h3>
                            <div class="stars">
                                <i class="fas fa-star"></i>
                                <i class="fas fa-star"></i>
                                <i class="fas fa-star"></i>
                                <i class="fas fa-star"></i>
                                <i class="fas fa-star-half-alt"></i>
                            </div>
                        </div>
                    </div>
                    <p>
                        Lorem, ipsum dolor sit amet consectetur adipisicing elit. Dolores provident quo obcaecati dolorem
                        cumque? Dignissimos officia quisquam optio accusantium, modi facilis fuga laudantium. Commodi,
                        autem
                        omnis dolore deleniti deserunt nesciunt?
                    </p>
                </div>

            </div>

        </div>

        <!-- Comment Section Started -->
        <section class="comment" id="comment">
            <h3 class="sub-heading">Tell Us</h3>
            <h1 class="heading">Your Thoughts!</h1>

            <form action="">
                <div class="wrap">
                    <label for="" class="sub-heading">Rate</label>
                    <input type="number">
                </div>
                <div class="wrap">
                    <label for="" class="sub-heading">Comment</label>
                    <textarea name="" id="" rows="10"></textarea>
                </div>
                <button class="btn">Submit</button>
            </form>
        </section>
        <!-- Comment Section Ended -->

    </section>
    <!-- Review Section Ended -->
</asp:Content>
