<%@ Page Title="" Language="C#"  AutoEventWireup="true" CodeBehind="newuser.aspx.cs" %>
<!-- Inherits="WebPage.newuser" -->

<!DOCTYPE html>
<html lang="en">
<head runat="server">
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
  <meta name="description" content="">
  <meta name="author" content="">
  <title>New user</title>
  <link href="assets/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
  <link href="assets/vendor/fontawesome-free/css/all.min.css" rel="stylesheet">
  <link href="assets/vendor/simple-line-icons/css/simple-line-icons.css" rel="stylesheet" type="text/css">
  <link href="https://fonts.googleapis.com/css?family=Lato:300,400,700,300italic,400italic,700italic" rel="stylesheet" type="text/css">
  <link href="assets/css/landing-page.min.css" rel="stylesheet">
</head>
<body>

    <!-- HEADER -->

<nav class="navbar fixed-top navbar-expand-lg navbar-light bg-light">
  <img class="navbar-brand" src="luvehotellogo.png" alt="" width="110px" >
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse" id="navbarNav">
    <ul class="navbar-nav">
      <li class="nav-item active">
        <a class="nav-link" href="#">Home <span class="sr-only">(current)</span></a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="#">Our services</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="#">Contact</a>
      </li>
    </ul>
  </div>

        <a class="btn btn-danger" href="index.aspx">Sign out</a>

</nav>


    <!-- FORM -->

          <section style="align-content:center">
        <h1 style="margin: 64px 0px 64px 0px">Some example txt</h1>
     <div class="container">
      <div class="row">
        <div class="col-xs-3 col-sm-3">
        
            <form>
  <div class="form-group">
    <label for="exampleFormControlInput1">User</label>
    <input type="user" class="form-control" id="user_id">
  </div>
  <div class="form-group">
    <label for="exampleFormControlInput1">Username</label>
    <input type="username" class="form-control" id="username_id">
  </div>
              <div class="form-group">
    <label for="exampleFormControlInput1">Password</label>
    <input type="password" class="form-control" id="password_id">
  </div>
  <div class="form-group">
    <a class="btn btn-danger" href="login.aspx">Create user</a>
  </div>
</form>

        </div>
      </div> 
    </div>
  </section>



        <!-- Footer --> 

  <footer class="footer bg-light text-center">
    <div class="container">
      <div class="row">
        <div class="col-lg-6 h-100 text-center text-lg-left my-auto">
          <ul class="list-inline mb-2">
            <li class="list-inline-item">
              <a href="#">About</a>
            </li>      
            <li class="list-inline-item">&sdot;</li>
            <li class="list-inline-item">
              <a href="#">Terms of Use</a>
            </li>
            <li class="list-inline-item">&sdot;</li>
            <li class="list-inline-item">
              <a href="#">Privacy Policy</a>
            </li>
          </ul>
          <p class="text-muted small mb-4 mb-lg-0">&copy; Hotel Luve 2021. All Rights Reserved.</p>
        </div>
      </div>
    </div>
  </footer>

</nav>
    </body>
</html>