<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="WebPage.student.profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <div class="my-3 my-md-5">
          <div class="container">
            <div class="page-header">
              <h1 class="page-title">
                Student info
              </h1>
                <div class="page-options d-flex">
              </div>
            </div>
            <div class="row">
            <div class="col-lg-12">
                <form runat="server" class="card">
                  <div class="card-body">
                    <h3 class="card-title">My profile</h3> 
                    <div class="row">
                      <div class="col-sm-6 col-md-6">
                        <div class="form-group">
                          <label class="form-label">Username</label>
                            <asp:TextBox class="form-control" placeholder="student2"  ID="UsernameTextBox" runat="server" disabled="disabled"></asp:TextBox>
                        </div>
                      </div>
                       <div class="col-sm-6 col-md-6">
                        <div class="form-group">
                          <label class="form-label">Name</label>
                          <asp:TextBox class="form-control" placeholder="Roberto"  ID="NameTextBox" runat="server" disabled="disabled"></asp:TextBox>
                        </div>
                      </div>
                      <div class="col-sm-6 col-md-6">
                        <div class="form-group">
                          <label class="form-label">Surname</label>
                          <asp:TextBox class="form-control" placeholder="Marquez"  ID="SurnameTextBox" runat="server" disabled="disabled"></asp:TextBox>
                        </div>
                      </div>
                        
                    </div>
                      <br />
                      <br />
                      <asp:Button class="btn btn-sm btn-success" ID="Button1" runat="server" Text="Export" OnClick="Button1_Click" />
                  </div>
                    <div class="card-body">
                    <h3 class="card-title">My subjects</h3>
                    <table id="tableContent" runat="server" class="table card-table table-vcenter">
                        <tr>
                      <th>Title</th>
                    </tr>
                    </table>
                  </div>
                </form>
              </div>
            </div>
          </div>
          </div>
</asp:Content>
