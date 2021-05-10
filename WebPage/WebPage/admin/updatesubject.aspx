<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="updatesubject.aspx.cs" Inherits="WebPage.admin.updatesubject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div class="my-3 my-md-5">
          <div class="container">
            <div class="page-header">
              <h1 class="page-title">
                Edit subject
              </h1>
                <div class="page-options d-flex">
                <asp:HyperLink class="btn btn-sm btn-primary" ID="HyperLink1" runat="server">Student Registration</asp:HyperLink>
              </div>
            </div>
            <div class="row">
            <div class="col-lg-12">
                <form runat="server" class="card">
                  <div class="card-body">
                    <h3 class="card-title">Subject</h3>
                    <div class="row">
                      <div class="col-sm-6 col-md-6">
                        <div class="form-group">
                          <label class="form-label">Title</label>
                            <asp:TextBox class="form-control" placeholder="Maths"  ID="NameTextbox" runat="server"></asp:TextBox>
                        </div>
                      </div>
                        <div class="col-sm-6 col-md-6">
                        <div class="form-group">
                          <label class="form-label">Credits</label>
                          <asp:TextBox type="number" class="form-control" placeholder="12"  ID="CreditsTextBox" runat="server"></asp:TextBox>
                        </div>
                      </div>
                    </div>
                  </div>
                  <div class="card-footer text-right">
                      <asp:Button class="btn btn-danger" ID="Button1" runat="server" Text="Delete subject" OnClick="Button1_Click" />
                      <asp:Button class="btn btn-primary" ID="Button2" runat="server" Text="Update subject" OnClick="Button2_Click" />
                  </div>
                </form>
              </div>
            </div>
          </div>
        </div>
</asp:Content>
