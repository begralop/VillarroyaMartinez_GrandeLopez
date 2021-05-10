<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="WebPage.admin.registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                <div class="my-3 my-md-5">
          <div class="container">
            <div class="page-header">
              <h1 class="page-title">
                Student Registration
              </h1>
            </div>
            <div class="row">
            <div class="col-lg-12">
                <form runat="server" class="card">
                  <div class="card-body">
                    <h3 class="card-title">Subject</h3>
                    <div class="row">
                      <div class="col-sm-6 col-md-6">
                        <div class="form-group">
                          <label class="form-label">Username</label>
                            <asp:DropDownList class="form-control custom-select" ID="DropDownList1" runat="server"></asp:DropDownList>
                        </div>
                      </div>
                    </div>
                  </div>
                  <div class="card-footer text-right">
                      <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
                  </div>
                </form>
              </div>
            </div>
          </div>
        </div>
</asp:Content>
