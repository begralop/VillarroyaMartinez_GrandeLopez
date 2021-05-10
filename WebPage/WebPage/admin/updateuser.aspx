<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="updateuser.aspx.cs" Inherits="WebPage.admin.updateuser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="my-3 my-md-5">
          <div class="container">
            <div class="page-header">
              <h1 class="page-title">
                Update User Profile
              </h1>
            </div>
            <div class="row">
            <div class="col-lg-12">
                <form runat="server" class="card">
                  <div class="card-body">
                    <h3 class="card-title">User Profile</h3>
                    <div class="row">
                      <div class="col-sm-6 col-md-6">
                        <div class="form-group">
                          <label class="form-label">Username</label>
                            <asp:TextBox class="form-control" placeholder=""  ID="UsernameTextBox" runat="server" disabled="disabled"></asp:TextBox>
                        </div>
                      </div>
                      <div class="col-sm-6 col-md-6">
                        <div class="form-group">
                          <label class="form-label">Name</label>
                          <asp:TextBox class="form-control" placeholder="Daniel"  ID="NameTextBox" runat="server"></asp:TextBox>
                        </div>
                      </div>
                      <div class="col-sm-6 col-md-6">
                        <div class="form-group">
                          <label class="form-label">Surname</label>
                          <asp:TextBox class="form-control" placeholder="Marquez"  ID="SurnameTextBox" runat="server"></asp:TextBox>
                        </div>
                      </div>
                    </div>
                  </div>
                  <div class="card-footer text-right">
                      <asp:Button class="btn btn-success" ID="Button1" runat="server" Text="Export" OnClick="Button1_Click" />
                      <asp:Button class="btn btn-danger" ID="Button2" runat="server" Text="Remove" OnClick="Button2_Click" />
                      <asp:Button class="btn btn-primary" ID="Button3" runat="server" Text="Update" OnClick="Button3_Click" />
                  </div>
                </form>
              </div>
            </div>
          </div>
        </div>
</asp:Content>
