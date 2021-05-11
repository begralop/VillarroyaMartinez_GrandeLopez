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

    <!-- HEADER -->

    <nav class="navbar fixed-top navbar-expand-lg navbar-light bg-light">
  <img class="navbar-brand" src="luvehotellogo.png" alt="" width="110px" >
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse" id="navbarNav">
    <ul class="navbar-nav">
      <li class="nav-item active">
        <a class="nav-link" href="index.aspx">Home <span class="sr-only">(current)</span></a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="index.aspx">Our services</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="index.aspx">Contact</a>
      </li>
    </ul>
  </div>

        <a class="btn btn-danger" href="login.aspx">Sign In</a>
        <a class="btn btn-outline-danger" style="margin-left: 8px" href="CreateUser.aspx">Sign Up</a>

</nav>

<!-- Image with text section --> 

  <header class="masthead text-white text-center containerImg ">
    <div class="overlay"></div>
    <div class="container">
      <div class="row">
        <div class="col-xl-9 mx-auto">
          <h1>New rooms waiting for you</h1>
            <h3 style="font-weight:200">Discover all our new rooms with the best features</h3>
            <a class="btn btn-outline-light" href="">Book a room</a>
        </div>
      </div>
    </div>
  </header>

<!-- Our advantages section --> 

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

    <!-- Room recomendation section --> 

    <header style="text-align:center;padding:0px 0px 96px 0px">
        <h1 style="margin: 64px 0px 64px 0px">Some example txt</h1>
     <div class="container">
      <div class="row">
        <div class="col-xs-3 col-sm-4">
          <div class="card mx-auto" style="width: 18rem;">
              <img src="landing_image.jpg" class="card-img-top" alt="...">
              <div class="card-body">
                <h5 class="card-title" style="color:black">Colossus</h5>
                <p class="card-text" ">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                <a href="#" class="btn btn-primary">Book this room</a>
              </div>
            </div>
        </div>
        <div class="col-xs-3 col-sm-4">
          <div class="card mx-auto" style="width: 18rem;">
              <img src="landing_image.jpg" class="card-img-top" alt="...">
              <div class="card-body">
                <h5 class="card-title" style="color:black">Azteca</h5>
                <p class="card-text" style="color:black">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                <a href="#" class="btn btn-primary">Book this room</a>
               </div>
             </div>
        </div>
        <div class="col-xs-3 col-sm-4">
          <div class="card mx-auto" style="width: 18rem;">
              <img src="landing_image.jpg" class="card-img-top" alt="...">
              <div class="card-body">
                <h5 class="card-title" style="color:black">Azteca</h5>
                <p class="card-text" style="color:black">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                <a href="#" class="btn btn-primary">Book this room</a>
               </div>
             </div>
        </div>
      </div>
    </div>
    </header>

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
  <script src="vendor/jquery/jquery.min.js"></script>
  <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
</body>
</html>