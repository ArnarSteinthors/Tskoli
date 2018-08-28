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
<div class="gallery">
<section class="Myndasafn">
<figure>
<a href="#openModal"><img class="normal_image"  src="./images/HarpaBorðSalur.jpg"></a>
<figcaption>Borðsalur hjá hörpunni</figcaption>
</figure>
<figure>
<a href="#openModal1"><img class="normal_image"  src="./images/HarpaArt.jpg"></a>
<figcaption>Splash image #1</figcaption>
</figure>
<figure>
<a href="#openModal2"><img class="normal_image"  src="./images/HarpanParralax.jpg"></a>
<figcaption>Harpan Mynd #1</figcaption>
</figure>
<figure>
<a href="#openModal3"><img class="normal_image"  src="./images/HarpaSalur.jpg"></a>
<figcaption>Eldborg</figcaption>
</figure>
<figure>
<a href="#openModal4"><img class="normal_image"  src="./images/HarpanFront.jpg"></a>
<figcaption>Harpan Mynd #2</figcaption>
</figure>
<figure>
<a href="#openModal5"><img class="normal_image"  src="./images/HarpanNott.jpg"></a>
<figcaption>Harpan um kvöld</figcaption>
</figure>
<figure>
<a href="#openModal6"><img class="normal_image"  src="./images/HarpanSalur2.jpg"></a>
<figcaption>Eldborg #2</figcaption>
</figure>
<figure>
<a href="#openModal7"><img class="normal_image"  src="./images/HarpanGler.jpg"></a>
<figcaption>Glerhjúpur</figcaption>
</figure>
<figure>
<a href="#openModal8"><img class="normal_image"  src="./images/HarpanMannequin.jpg"></a>
<figcaption>Menningasýning</figcaption>
</figure>
<figure>
<a href="#openModal9"><img class="normal_image"  src="./images/HarpanEittBord.jpg"></a>
<figcaption>Kolabrautin</figcaption>
</figure>
<figure>
<a href="#openModal10"><img class="normal_image"  src="./images/HarpanWinterSalur.jpg"></a>
<figcaption>Eitt af minni sölum Hörpunar</figcaption>
</figure>
<figure>
<a href="#openModal11"><img class="normal_image"  src="./images/HarpanBooz.jpg"></a>
<figcaption>Kolabrautin #2</figcaption>
</figure>
</section>
</div>




<footer>

<?php $file = './includes/botmenu.php';
        if (file_exists($file) && is_readable($file)) {
            require $file;
        } else {
            throw new Exception("$file can't be found");
        }?>
    
</footer>



<div id="openModal" class="modalDialog">
    <div>
        <a href="#close" title="Close" class="close">X</a>
            <img width="1236" height="642" src="./images/HarpaBorðSalur.jpg">
    </div>
</div>
<div id="openModal1" class="modalDialog">
    <div>
        <a href="#close" title="Close" class="close">X</a>
            <img width="1236" height="642" src="./images/HarpaArt.jpg">
    </div>
</div>
<div id="openModal2" class="modalDialog">
    <div>
        <a href="#close" title="Close" class="close">X</a>
            <img width="1236" height="642" src="./images/HarpanParralax.jpg">
    </div>
</div>
<div id="openModal3" class="modalDialog">
    <div>
        <a href="#close" title="Close" class="close">X</a>
            <img width="1236" height="642" src="./images/HarpaSalur.jpg">
    </div>
</div>
<div id="openModal4" class="modalDialog">
    <div>
        <a href="#close" title="Close" class="close">X</a>
            <img width="1236" height="642" src="./images/HarpanFront.jpg">
    </div>
</div>
<div id="openModal5" class="modalDialog">
    <div>
        <a href="#close" title="Close" class="close">X</a>
            <img width="1236" height="642" src="./images/HarpanNott.jpg">
    </div>
</div>
<div id="openModal6" class="modalDialog">
    <div>
        <a href="#close" title="Close" class="close">X</a>
            <img width="1236" height="642" src="./images/HarpanSalur2.jpg">
    </div>
</div>
<div id="openModal7" class="modalDialog">
    <div>
        <a href="#close" title="Close" class="close">X</a>
            <img width="1236" height="642" src="./images/HarpanGler.jpg">
    </div>
</div>
<div id="openModal8" class="modalDialog">
    <div>
        <a href="#close" title="Close" class="close">X</a>
            <img width="1236" height="642" src="./images/HarpanMannequin.jpg">
    </div>
</div>
<div id="openModal9" class="modalDialog">
    <div>
        <a href="#close" title="Close" class="close">X</a>
            <img width="1236" height="642" src="./images/HarpanEittBord.jpg">
    </div>
</div>
<div id="openModal10" class="modalDialog">
    <div>
        <a href="#close" title="Close" class="close">X</a>
            <img width="1236" height="642" src="./images/HarpanWinterSalur.jpg">
    </div>
</div>
<div id="openModal11" class="modalDialog">
    <div>
        <a href="#close" title="Close" class="close">X</a>
            <img width="1236" height="642" src="./images/HarpanBooz.jpg">
    </div>
</div>













</body>
</html>
<?php } catch (Exception $e) {
    ob_end_clean();
 header('Location: https://www.xtremerain.com/wp-content/uploads/2015/10/screenshot-aw-snap-error-chrome.jpg');
 }
 ob_end_flush(); 
 ?>