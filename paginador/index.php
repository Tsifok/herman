<!doctype html>
<html lang="en">
<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <title>Bootstrap demo</title>
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi" crossorigin="anonymous">
</head>
<body>
  <div class="container my-5 mx-5">
    <table class="table" style="border: solid">
      <thead>
        <tr>
          <th scope="col">ID</th>
          <th scope="col">content</th>
        </tr>
      </thead>
      <tbody>
        <?php require "php/show.php"; ?>
      </tbody>
    </table>
    <nav aria-label="Page navigation example">
      <ul class="pagination justify-content-end">
        <li class="page-item <?php echo($pag == 1 ? 'disabled' : '');?>">
          <a class="page-link" href="<?php echo ($pag == 1 ? '' : 'index.php?pag=' . ($pag - 1)); ?>">Previous</a>
        </li>
        <?php echo ($pag == 1 ? "" : '<li class="page-item"><a class="page-link" href="index.php?pag=1">First</a></li>');?>
        
        <li class="page-item"><a class="page-link" href="index.php?pag=<?php echo ($pag >= $total_pages-2 ? $num = $pag-4 : ($pag == 1 ? $num = $pag : ($pag <= 3 ? $num = 1 : $num = $pag-2))); ?>"><?php echo $num?></a></li>
        <li class="page-item"><a class="page-link" href="index.php?pag=<?php echo ($pag >= $total_pages-2 ? $num = $pag-3 : ($pag == 1 ? $num = $pag+ 1 : ($pag == 2 ? $num = $pag : $num = $pag-1 ))); ?>"><?php echo $num?></a></li>
        <li class="page-item"><a class="page-link" href="index.php?pag=<?php echo ($pag >= $total_pages-2 ? $num = $pag-2 : ($pag == 1 ? $num = $pag +2 : ($pag == 2 ? $num = $pag+ 1 : $num = $pag)));?>"><?php echo $num; ?></a></li>
        <li class="page-item"><a class="page-link" href="index.php?pag=<?php echo ($pag >= $total_pages-2 ? $num = $pag-1 : ($pag == 1 ? $num = $pag+3 : ($pag == 2 ? $num = $pag + 2 : $num = $pag+1))); ?>"><?php echo $num; ?></a></li>
        <li class="page-item"><a class="page-link" href="index.php?pag=<?php echo ($pag >= $total_pages-2 ? $num = $pag : ($pag == 1 ? $num = $pag+4 : ($pag == 2 ? $num = $pag + 3 : $num = $pag+2))); ?>"><?php echo $num; ?></a></li>
        
        <?php echo ($pag == $total_pages ? "" : '<li class="page-item"><a class="page-link" href="index.php?pag='.$total_pages.'">Last</a></li>');?>
        <li class="page-item <?php echo($pag == $total_pages ? 'disabled' : '');?>">
          <a class="page-link" href="<?php echo ($pag == $total_pages ? '' : 'index.php?pag=' . ($pag + 1)); ?>">Next</a>
        </li>
      </ul>
    </nav>
  </div>
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-OERcA2EqjJCMA+/3y+gxIOqMEjwtxJY7qPCqsdltbNJuaOe923+mo//f6V8Qbsw3" crossorigin="anonymous"></script>
</body>
</html>