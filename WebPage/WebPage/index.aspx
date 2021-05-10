<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebPage.WebForm1" %>

<!DOCTYPE html>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
  <meta name="description" content="">
  <meta name="author" content="">
  <title>Hotel Luve - Home</title>
  <link href="assets/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
  <link href="assets/vendor/fontawesome-free/css/all.min.css" rel="stylesheet">
  <link href="assets/vendor/simple-line-icons/css/simple-line-icons.css" rel="stylesheet" type="text/css">
  <link href="https://fonts.googleapis.com/css?family=Lato:300,400,700,300italic,400italic,700italic" rel="stylesheet" type="text/css">
  <link href="assets/css/landing-page.min.css" rel="stylesheet">
</head>
<body>
  <nav class="navbar navbar-light bg-light static-top">
    <div class="container">
      <img src="luvehotellogo.png" alt="" width="150px">
      <a class="navbar-brand" href="#">Hotel Luve</a>
      <a class="btn btn-primary" href="login.aspx">Sign In</a>
    </div>
  </nav>
  <header class="masthead text-white text-center">
    <div class="overlay"></div>
    <div class="container">
      <div class="row">
        <div class="col-xl-9 mx-auto">
          <h1 class="mb-5">Your secret, our secret</h1>
        </div>
      </div>
    </div>
  </header>
  <section class="features-icons bg-light text-center">
    <div class="container">
      <div class="row">
        <div class="col-lg-4">
          <div class="features-icons-item mx-auto mb-5 mb-lg-0 mb-lg-3">
            <div class="features-icons-icon d-flex">
                <i class="fas fa-concierge-bell m-auto"></i>
            </div>
            <h3>24 hour service</h3>
            <p class="lead mb-0">We have any service 24 hours a day</p>
          </div>
        </div>
        <div class="col-lg-4">
          <div class="features-icons-item mx-auto mb-5 mb-lg-0 mb-lg-3">
            <div class="features-icons-icon d-flex ">
                <i class="fas fa-mask m-auto "></i>
            </div>
            <h3>Discretion</h3>
            <p class="lead mb-0">Private room and garage</p>
          </div>
        </div>
        <div class="col-lg-4">
          <div class="features-icons-item mx-auto mb-0 mb-lg-3">
            <div class="features-icons-icon d-flex">
              <i class="fas fa-hot-tub m-auto"></i>
            </div>
            <h3>Our suites</h3>
            <p class="lead mb-0">Our suites have the best heated pools and jacuzzis</p>
          </div>
        </div>
      </div>
    </div>
  </section>
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
  <script src="vendor/jquery/jquery.min.js"></script>
  <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
</body>
</html>