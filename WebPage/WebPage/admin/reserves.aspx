<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="reserves.aspx.cs" Inherits="WebPage.admin.subjects" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="my-3 my-md-5">
          <div class="container">
            <div class="page-header">
              <h1 class="page-title">
                Subjects
              </h1>
                <div class="page-options d-flex">
                <a href="./newsubject.aspx" class="btn btn-sm btn-primary">New Subject</a>
              </div>
            </div>
            <div class="row row-cards">
             <div class="col-lg-12">
                <div class="card">
                    <table id="tableContent" runat="server" class="table card-table table-vcenter">
                        <tr>
                      <th class="d-none d-sm-table-cell" >Title</th>
                      <th class="d-none d-md-table-cell">Credits</th>
                        </tr>
                    </table>
                </div>
              </div>
            </div>
          </div>
        </div>
</asp:Content>
