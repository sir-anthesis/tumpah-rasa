<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="TumpahRasa.Pages.Admin.Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderCSS" runat="server">
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>

    <link href="https://cdn.jsdelivr.net/npm/summernote@0.8.18/dist/summernote-bs4.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/summernote@0.8.18/dist/summernote-bs4.min.js"></script>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card">
        <div class="card-body">
            <h5 class="card-title fw-semibold mb-4">Edit Form</h5>
            <div class="card">
                <div class="card-body">
                    <form enctype="multipart/form-data" method="post" runat="server">
                        <div class="mb-3">
                            <label for="exampleInputEmail1" class="form-label">Food Name</label>
                            <input type="text" class="form-control" id="name" name="name">
                        </div>
                        <div class="mb-3">
                            <label for="exampleInputPassword1" class="form-label">Description</label>
                            <div id="summernote"></div>
                            <input type="hidden" id="summernoteContent" name="description">
                        </div>
                        <asp:Button ID="Button1" runat="server" Text="SUBMIT" CssClass="btn btn-primary me-2" OnClick="Button1_Click" />
                        <asp:Button ID="Button2" runat="server" Text="EDIT THUMB" CssClass="btn btn-primary" OnClick="Button2_Click" />
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderJS" runat="server">
    <script>
        $('#summernote').summernote({
            tabsize: 2,
            height: 100
        });

        $(function () {
            $('form').submit(function () {
                // Get the HTML content from Summernote
                var summernoteContent = $('#summernote').summernote('code');

                // Encode the HTML content to prevent ASP.NET request validation error
                var encodedContent = $('<div />').text(summernoteContent).html();

                // Set the value of hidden input to the encoded HTML content
                $('#summernoteContent').val(encodedContent);
            });
        });
    </script>
</asp:Content>
