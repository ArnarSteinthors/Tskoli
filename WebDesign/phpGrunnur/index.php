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

<div class="parralax"><span class="parralaxText">Harpan</span></div>


<div class="container">
<h2>Jólatónleikar 20. desember í Hörpunni</h2>


<section class="I-I">
<figure>
<img class="normal_image" src="./images/HarpaBorðSalur.jpg">
<figcaption>Matur fyrir tónleika*</figcaption>
</figure>
<figure>
<img class="normal_image"  src="./images/HarpaSalur.jpg">
<figcaption>Jólatónleikar</figcaption>
</figure>
</section>

<div class="innercontainer">
<section class="I-II">
<p>Jólatónleikar verða haldnir 20. desember í Hörpunni og er bæði í boði að kaupa miða með mat fyrir tónleika í boði
<a href="http://www.kolabrautin.is/">Kolabrautin</a>.<br>
sérstakir gestír í ár eru<br>
Páll Óskar<br>
Egill Ólafsson<br>
Greta Salóme</p><p><br></p>
<p>Fyrir jólin 2015 var uppselt á tvenna ógleymanlega jólatónleika Hörpunar, en kvöldin voru sem töfrum líkust og stemningin sem myndaðist í salnum lét engan ósnortinn, enda lagavalið sambland af klassískum jólalögum, hressum poppjólalögum og mögnuðum ballöðum sem spiluðu á allan tilfinningaskala tónleikagesta. Umgjörðin utan um tónleikana var einkar falleg þar sem jólatré og falleg grafík spiluðu stóran þátt í að gera tónleikana bæði hlýlega, hátíðlega og afar eftirminnilega.</p>
</section>
<section class="I-III">
<a href="verslun.php" class="button">Kaupa Miða</a>
<p>
Hægt er að kaupa miða með jóla hlaðborð innifalið í boði <a href="http://www.kolabrautin.is/">Kolabrautin</a> og mikil stemning fyrir tónleika. Borðsalurinn opnar 3 klukkutímum fyrir tónleikum og verður tónlist spiluð af Egli Ólafssyni til að hita upp. yeye
</p>
</section>
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
