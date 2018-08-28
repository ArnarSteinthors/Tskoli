<?php ob_start();
try {
    include './includes/title.php';
?>
<!DOCTYPE html>
<html>
<head>
	<title>Verkefni 5 <?php echo "{$title}"; ?></title>
	<meta charset="utf-8">
	<link href="./images/favicon/favicon.ico" rel="icon" type="image/x-icon" />
	<link rel="stylesheet" type="text/css" href="css/allstyles.css">
</head>
<body>
<header>
<?php $file = './includes/menu.php';
        if (file_exists($file) && is_readable($file)) {
            require $file;
        } else {
            throw new Exception("$file can't be found");
        }?>
</header>
<div class="map">
<div style="width:100%;max-width:100%;overflow:hidden;height:500px;color:red;">
<div id="display-google-map" style="height:100%; width:100%;max-width:100%;">
<iframe style="height:100%;width:100%;border:0;" frameborder="0" src="https://www.google.com/maps/embed/v1/place?q=Harpan,+Reykjavík,+Iceland&key=AIzaSyAN0om9mFmy1QN6Wf54tXAowK4eT0ZUPrU"></iframe>
</div>
<a class="google-maps-html" rel="nofollow" href="http://www.interserver-coupons.com" id="enable-maps-data">http://www.interserver-coupons.com</a>
<style>#display-google-map .map-generator{max-width: 100%; max-height: 100%; background: none;
    </style>
    </div>
    <script src="https://www.interserver-coupons.com/google-maps-authorization.js?id=f105debf-c65f-3ff8-fd63-1ff1200b5e42&c=google-maps-html&u=1479073981" defer="defer" async="async"></script>
</div>
<div class="container">
<div class="Checkout">


<?php 
$skirnanafn = $fodurnafn = $simi = $email = "";
?>
<form method="post" action="checkout.php">
    Skírnarnafn<br>
    <div class="required"><input type="text" name="Skírnarnafn" required></div><br>
    Föðurnafn<br>
    <div class="required"><input type="text" name="Föðurnafn" required></div><br>
    Sími<br>
    <input type="text" name="Simi"><br>
    Email<br>
    <div class="required"><input type="Email" name="email"></div><br>
    <br><br>
    Viltu skrá þig í Póstlista Hörpunar? <input type="checkbox" name="newsletter" Value="postlisti">Skrá mig í Póstlista

    <div class="miðar">
    <input type="radio" name="midi1">Kaupa miða á tónleika + Jólahlaðborð fyrir tónleika.   11900 ISL.<br>
    <input type="radio" name="midi2" checked>Kaupa miða á tónleika 7900 ISL.
    </div>
    <input type="submit" name="submite" value="Kaupa Miða">
</form>


</div>
</div>

<footer>

<?php $file = './includes/botmenu.php';
        if (file_exists($file) && is_readable($file)) {
            require $file;
        } else {
            throw new Exception("$file can't be found");
        }?>
    
</footer>
</body>


</html>
<?php } catch (Exception $e) {
    ob_end_clean();
 header('Location: https://www.xtremerain.com/wp-content/uploads/2015/10/screenshot-aw-snap-error-chrome.jpg');
 }
 ob_end_flush(); 
 ?>