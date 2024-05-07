<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="EditThumb.aspx.cs" Inherits="TumpahRasa.Pages.Admin.EditThumb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderCSS" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card">
        <div class="card-body">
            <h5 class="card-title fw-semibold mb-4">Edit Thumbnail</h5>
            <div class="card">
                <div class="card-body">
                    <form enctype="multipart/form-data" method="post" runat="server">
                        <div class="mb-3">
                            <label for="exampleInputEmail1" class="form-label">Thumbnail Active Now</label>
                            <div class="img" style="height: 30vw; width: 45vw; border-radius: 15px; overflow: hidden;">
                                <img src="<%: old_thumb %>" style="width: 100%; height: 100%; object-fit: cover;">
                            </div>
                        </div>
                        <div class="mb-3">
                            <label for="exampleInputPassword1" class="form-label">Thumbnail Picture</label>
                            <input type="file" class="form-control" id="thumb" name="thumb">
                        </div>
                        <asp:Button ID="Button1" runat="server" Text="SUBMIT" CssClass="btn btn-primary" OnClick="Button1_Click" />
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderJS" runat="server">
</asp:Content>
