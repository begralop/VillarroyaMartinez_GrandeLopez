<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="users.aspx.cs" Inherits="WebPage.admin.users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="my-3 my-md-5">
          <div class="container">
            <div class="page-header">
              <h1 class="page-title">
                Users
              </h1>
                <div class="page-options d-flex">
                <a href="../admin/newuser.aspx" class="btn btn-sm btn-primary">Add user</a>
              </div>
            </div>
            <div class="row row-cards">
             <div class="col-lg-12">
                <div class="card">
                    <table id="tableContent" runat="server" class="table card-table table-vcenter">
                        <tr>
                      <th>Username</th>
                      <th class="d-none d-sm-table-cell" >Name</th>
                      <th class="d-none d-md-table-cell">Surname</th>
                    </tr>
                    </table>
                </div>
              </div>
            </div>
          </div>
        </div>
</asp:Content>
