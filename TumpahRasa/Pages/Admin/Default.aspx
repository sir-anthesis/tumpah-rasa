<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TumpahRasa.Pages.Admin.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <!--  Row 1 -->
        <div class="row">
            <div class="col-lg-12 d-flex align-items-stretch">
                <div class="card w-100">
                    <div class="card-body p-4">
                        <h5 class="card-title fw-semibold mb-4">Recent Transactions</h5>
                        <div class="table-responsive">
                            <table class="table text-nowrap mb-0 align-middle">
                                <thead class="text-dark fs-4">
                                    <tr>
                                        <th class="border-bottom-0">
                                            <h6 class="fw-semibold mb-0">No</h6>
                                        </th>
                                        <th class="border-bottom-0">
                                            <h6 class="fw-semibold mb-0">Name</h6>
                                        </th>
                                        <th class="border-bottom-0">
                                            <h6 class="fw-semibold mb-0">Rating</h6>
                                        </th>
                                        <th class="border-bottom-0">
                                            <h6 class="fw-semibold mb-0">Created At</h6>
                                        </th>
                                        <th class="border-bottom-0">
                                            <h6 class="fw-semibold mb-0">Action</h6>
                                        </th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <asp:Repeater ID="RecipeRepeater" runat="server">
                                        <ItemTemplate>
                                            <tr>
                                                <td class="border-bottom-0">
                                                    <h6 class="fw-semibold mb-0"><%# Container.ItemIndex + 1 %></h6>
                                                </td>
                                                <td class="border-bottom-0">
                                                    <h6 class="fw-semibold mb-1"><%# Eval("name") %></h6>
                                                </td>
                                                <td class="border-bottom-0">
                                                    <p class="mb-0 fw-normal"><%# Eval("rating") %></p>
                                                </td>
                                                <td class="border-bottom-0">
                                                    <p class="mb-0 fw-normal"><%# Eval("created_at") %></p>
                                                </td>
                                                <td class="border-bottom-0">
                                                    <a href="Edit.aspx?id=<%# Eval("id") %>" class="btn btn-warning">EDIT</a>
                                                    <asp:Button ID="Button2" runat="server" Text="DELETE" CommandArgument='<%# Eval("id") %>' OnClick="Delete_Click" CssClass="btn btn-danger" />
                                                </td>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
