
window.requestAnimFrame = (function(){ 
  return  window.requestAnimationFrame       ||  
          window.webkitRequestAnimationFrame ||  
          window.mozRequestAnimationFrame    ||  
          window.oRequestAnimationFrame      ||  
          window.msRequestAnimationFrame     ||  
          function( callback ){ 
            window.setTimeout(callback, 1000 / 60); 
          }; 
})();



var xcount = 0; 
function drawIt() { 
    window.requestAnimFrame(drawIt); 
    var canvas = document.getElementById('canvas'); 
    var c = canvas.getContext('2d'); 
    c.clearRect(0,0,canvas.width,canvas.height); //deletar það sem var verið að teikna
    c.fillStyle = "red"; 
    c.fillRect(x,100,200,200); 
    xcount+=5; 
    //resettar animationið
    if (xcount > 800) {
    	xcount = 0;
    }
}  
window.requestAnimFrame(drawIt); 



//snowfall
var canvas1 = document.getElementById('canvas1'); 
var particles = []; 
var tick = 0; 
function loop() { 
    window.requestAnimFrame(loop); 
    createParticles(); 
    updateParticles(); 
    killParticles(); 
    drawParticles(); 
} 
window.requestAnimFrame(loop); 



function createParticles() { 
    //check on every 10th tick check 
    if(tick % 10 == 0) { 
        //add particle if fewer than 50
        if(particles.length < 50) { 
            particles.push({ 
                    x: Math.random()*canvas1.width, //between 0 and canvas width 
                    y: 0, 
                    speed: 2+Math.random()*3, //between 2 and 5 
                    radius: 5+Math.random()*5, //between 5 and 10 
                    color: "white", 
            }); 
        } 
    } 
} 

function updateParticles() { 
    for(var i in particles) { 
        var part = particles[i]; 
        part.y += part.speed; 
    } 
} 

function killParticles() { 
    for(var i in particles) { 
        var part = particles[i]; 
        if(part.y > canvas1.height) { 
            part.y = 0; 
        } 
    } 
} 

function drawParticles() { 
    var c = canvas1.getContext('2d'); 
    c.fillStyle = "black"; 
    c.fillRect(0,0,canvas1.width,canvas1.height); 
    for(var i in particles) { 
        var part = particles[i]; 
        c.beginPath(); 
        c.arc(part.x,part.y, part.radius, 0, Math.PI*2); 
        c.closePath(); 
        c.fillStyle = part.color; 
        c.fill(); 
    } 
}

//picture manipulation
//failar load á breytti mynd stundum og stundum ekki.
document.getElementById("picture").onload = function() {
    var ccc = document.getElementById("pictureCanvas");
    var ctxx = ccc.getContext("2d");
    var imgg = document.getElementById("picture");
    ctxx.drawImage(imgg, 0, 0);
    var imgData = ctxx.getImageData(0, 0, ccc.width, ccc.height);
    // invert colors
    var i;
    for (i = 0; i < imgData.data.length; i += 4) {
        imgData.data[i] = 255 - imgData.data[i];
        imgData.data[i+1] = 255 - imgData.data[i+1];
        imgData.data[i+2] = 255 - imgData.data[i+2];
        imgData.data[i+3] = 255;
    }
    ctxx.putImageData(imgData, 0, 0);
};

//breakout game
//https://developer.mozilla.org/en-US/docs/Games/Tutorials/2D_Breakout_game_pure_JavaScript
var canvas = document.getElementById("myCanvas");
var ctx = canvas.getContext("2d");
var ballRadius = 10;
var x = canvas.width/2;
var y = canvas.height-30;
var dx = 2;
var dy = -2;
var paddleHeight = 10;
var paddleWidth = 75;
var paddleX = (canvas.width-paddleWidth)/2;
var rightPressed = false;
var leftPressed = false;
var brickRowCount = 5;
var brickColumnCount = 3;
var brickWidth = 75;
var brickHeight = 20;
var brickPadding = 10;
var brickOffsetTop = 30;
var brickOffsetLeft = 30;
var score = 0;
var lives = 3;

var bricks = [];
for(c=0; c<brickColumnCount; c++) {
    bricks[c] = [];
    for(r=0; r<brickRowCount; r++) {
        bricks[c][r] = { x: 0, y: 0, status: 1 };
    }
}

document.addEventListener("keydown", keyDownHandler, false);
document.addEventListener("keyup", keyUpHandler, false);
document.addEventListener("mousemove", mouseMoveHandler, false);

function keyDownHandler(e) {
    if(e.keyCode == 39) {
        rightPressed = true;
    }
    else if(e.keyCode == 37) {
        leftPressed = true;
    }
}
function keyUpHandler(e) {
    if(e.keyCode == 39) {
        rightPressed = false;
    }
    else if(e.keyCode == 37) {
        leftPressed = false;
    }
}
function mouseMoveHandler(e) {
    var relativeX = e.clientX - canvas.offsetLeft;
    if(relativeX > 0 && relativeX < canvas.width) {
        paddleX = relativeX - paddleWidth/2;
    }
}
function collisionDetection() {
    for(c=0; c<brickColumnCount; c++) {
        for(r=0; r<brickRowCount; r++) {
            var b = bricks[c][r];
            if(b.status == 1) {
                if(x > b.x && x < b.x+brickWidth && y > b.y && y < b.y+brickHeight) {
                    dy = -dy;
                    b.status = 0;
                    score++;
                    if(score == brickRowCount*brickColumnCount) {
                        alert("YOU WIN, CONGRATS!");
                        document.location.reload();
                    }
                }
            }
        }
    }
}

function drawBall() {
    ctx.beginPath();
    ctx.arc(x, y, ballRadius, 0, Math.PI*2);
    ctx.fillStyle = "#0095DD";
    ctx.fill();
    ctx.closePath();
}
function drawPaddle() {
    ctx.beginPath();
    ctx.rect(paddleX, canvas.height-paddleHeight, paddleWidth, paddleHeight);
    ctx.fillStyle = "#0095DD";
    ctx.fill();
    ctx.closePath();
}
function drawBricks() {
    for(c=0; c<brickColumnCount; c++) {
        for(r=0; r<brickRowCount; r++) {
            if(bricks[c][r].status == 1) {
                var brickX = (r*(brickWidth+brickPadding))+brickOffsetLeft;
                var brickY = (c*(brickHeight+brickPadding))+brickOffsetTop;
                bricks[c][r].x = brickX;
                bricks[c][r].y = brickY;
                ctx.beginPath();
                ctx.rect(brickX, brickY, brickWidth, brickHeight);
                ctx.fillStyle = "#0095DD";
                ctx.fill();
                ctx.closePath();
            }
        }
    }
}
function drawScore() {
    ctx.font = "16px Arial";
    ctx.fillStyle = "#0095DD";
    ctx.fillText("Score: "+score, 8, 20);
}
function drawLives() {
    ctx.font = "16px Arial";
    ctx.fillStyle = "#0095DD";
    ctx.fillText("Lives: "+lives, canvas.width-65, 20);
}

function draw() {
    ctx.clearRect(0, 0, canvas.width, canvas.height);
    drawBricks();
    drawBall();
    drawPaddle();
    drawScore();
    drawLives();
    collisionDetection();
    
    if(x + dx > canvas.width-ballRadius || x + dx < ballRadius) {
        dx = -dx;
    }
    if(y + dy < ballRadius) {
        dy = -dy;
    }
    else if(y + dy > canvas.height-ballRadius) {
        if(x > paddleX && x < paddleX + paddleWidth) {
            dy = -dy;
        }
        else {
            lives--;
            if(!lives) {
                alert("GAME OVER");
                document.location.reload();
            }
            else {
                x = canvas.width/2;
                y = canvas.height-30;
                dx = 3;
                dy = -3;
                paddleX = (canvas.width-paddleWidth)/2;
            }
        }
    }
    
    if(rightPressed && paddleX < canvas.width-paddleWidth) {
        paddleX += 7;
    }
    else if(leftPressed && paddleX > 0) {
        paddleX -= 7;
    }
    
    x += dx;
    y += dy;
    requestAnimationFrame(draw);
};

draw();
//breakout game end

