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

	<div class="slideshow">
		<div id="slider">
		<div id="mask">
		<ul>
         <li id="first" class="firstanimation">           
         <a href="#"> <img width="680px" height="320" src="images/HarpaArt.jpg" alt="Art"/> </a>
         </li>

         <li id="first" class="secondanimation">  
         <a href="#"> <img width="680px" height="320" src="images/HarpaBorðSalur.jpg" alt="Borðsalur"/> </a>
         </li>

         <li id="first" class="thirdanimation"> 
         <a href="#"> <img width="680px" height="320" src="images/HarpaSalur.jpg" alt="Salur"/> </a>
         </li>
         <li id="first" class="fourthanimation"> 
         <a href="#"> <img width="680px" height="320" src="images/HarpaBorðSalur.jpg" alt="Borðsalur"/> </a>
         </li>
         <li id="first" class="fifthanimation"> 
         <a href="#"> <img width="680px" height="320" src="images/HarpaSalur.jpg" alt="Salur"/> </a>
         </li>
         </ul>
</div>
</div>
</div>
<div class="container">
<?php

echo "Takk fyrir að versla hjá okkur ".$_POST['Skírnarnafn']. " ".$_POST['Föðurnafn'];
echo "<br>";
echo "<br>";
echo "Hér eru upplýsingar um þín kaup";
echo "<br>";
echo "<br>";
echo "Fullt Nafn : ".$_POST['Skírnarnafn'];
echo " ";
echo $_POST['Föðurnafn'];
echo "<br>";
echo "Sími : ".$_POST['Simi'];
echo "<br>";
echo "Netfang : ".$_POST['email'];
echo "<br>";
echo "<br>";
if (isset($_POST['midi1'])) {
	echo "Þú Keyptir Miða á tónleika og Mat í boði Kolabrautin.";
}
else{
	echo"Þú keyptir Miða á tónleika en ekki Mat.";
}
echo "<br>";
if (isset($_POST['newsletter'])) {
	echo "Framtíðar tónleikar færðu upplýsingar í gegnum mail";
}
?>

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