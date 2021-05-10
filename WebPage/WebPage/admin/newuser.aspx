<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="newuser.aspx.cs" Inherits="WebPage.admin.newuser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="my-3 my-md-5">
          <div class="container">
            <div class="page-header">
              <h1 class="page-title">
                Add New User
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
                            <asp:TextBox class="form-control" placeholder="student2"  ID="UsernameTextBox" runat="server"></asp:TextBox>
                        </div>
                      </div>
                        <div class="col-sm-6 col-md-6">
                        <div class="form-group">
                          <label class="form-label">Password</label>
                          <asp:TextBox class="form-control" placeholder="Password"  ID="PasswordTextBox" runat="server"></asp:TextBox>
                        </div>
                      </div>
                      <div class="col-sm-6 col-md-6">
                        <div class="form-group">
                          <label class="form-label">Name</label>
                          <asp:TextBox class="form-control" placeholder="Mario"  ID="NameTextBox" runat="server"></asp:TextBox>
                        </div>
                      </div>
                      <div class="col-sm-6 col-md-6">
                        <div class="form-group">
                          <label class="form-label">Surname</label>
                          <asp:TextBox class="form-control" placeholder="Mola"  ID="SurnameTextBox" runat="server"></asp:TextBox>
                        </div>
                      </div>
                        <div class="col-sm-6 col-md-6">
                        <div class="form-group">
                          <label class="form-label">Function</label>
                            <asp:DropDownList class="form-control custom-select" ID="FunctionDropdown" runat="server">
                                <asp:listitem text="Admin" value="admin"></asp:listitem>
                                <asp:listitem text="Student" value="student"></asp:listitem>
                            </asp:DropDownList>
                        </div>
                      </div>
                    </div>
                  </div>
                  <div class="card-footer text-right">
                      <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Create New User" OnClick="Button1_Click" />
                  </div>
                </form>
              </div>
            </div>
          </div>
        </div>
</asp:Content>
