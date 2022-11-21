<!doctype html>
<html lang="en">
<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi" crossorigin="anonymous">
  <link rel="stylesheet" href="css/style.css">
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-OERcA2EqjJCMA+/3y+gxIOqMEjwtxJY7qPCqsdltbNJuaOe923+mo//f6V8Qbsw3" crossorigin="anonymous"></script>
  <script src="js/jQuery.js"></script>
  <script src="js/ajax.js"></script>
</head>
<body>
    
    
    <div id="tabla"></div>

    <nav aria-label="...">
      <ul class="pagination">
        <li id="beginning_btn" class="page-item">
          <a class="page-link" href="" id="beginning_btn">Beginning</a>
        </li>
        <li id="Previous" class="page-item">
          <a class="page-link" href="" id="previous_btn">Previous</a>
        </li>
        
        <div id="buttons"></div>
        
        <li class="page-item" id="Next">
          <a id="next_btn" class="page-link" href="">Next</a>
        </li>
        <li class="page-item" id="last">
          <a id="last_btn" class="page-link" href="">Last</a>
        </li>
      </ul>
    </nav>
    <div id="pag"></div>
</body>
</html>