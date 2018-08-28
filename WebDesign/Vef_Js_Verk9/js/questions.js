/*
var spurningar = [
	{
		spurning: "Hvað er 5 * 5?",
		svarmoguleiki: ["5","10","25","30"],
		rettSvar: "25"
	},
	{
		spurning: "Hvað er 7 * 3?",
		svarmoguleiki: ["14","21","28","35"],
		rettSvar: "21"
	},
	{
		spurning: "Hvað er 8 * 8?",
		svarmoguleiki: ["56","64","72","80"],
		rettSvar: "64"
	}
];
var elsp = document.getElementById('question');
elsp.textContent = spurningar[0].spurning;

var elch0 = document.getElementById('choice0');
elch0.textContent = spurningar[0].svarmoguleiki[0];

var elch1 = document.getElementById('choice1');
elch1.textContent = spurningar[0].svarmoguleiki[1];

var elch2 = document.getElementById('choice2');
elch2.textContent = spurningar[0].svarmoguleiki[2];

var elch3 = document.getElementById('choice3');
elch3.textContent = spurningar[0].svarmoguleiki[3];
*/
(function(){
	"use strict";
let elContainer = document.getElementById('grid');

var rettsvor = 0;
var spurnCount = 0;
var gisk = 0;
var delayMillis = 1000;//1sek
function Question(question, answers, correctAnswer) {
	this.question = question;
	this.answers = answers;
	this.correctAnswer = correctAnswer;
}

let questions = [
	new Question('Hvað er 5 * 5?', ["5","10","25","30"], '25'),
	new Question('Hvað er 7 * 3?', ["7","14","21","28"], '21'),
	new Question('Hvað er 8 * 8?', ["56","64","72","48"], '64'),
];

	function shuffleArray(array) {
		let m = array.length, t, i;
		while (m) {
			i = Math.floor(Math.random() * m--);
			t = array[m];
			array[m] = array[i];
			array[i] = t;
		}
	}
	shuffleArray(questions);

Question.prototype.getTemplate = function(){
	let tmplAnswers = "";
	for(let i = 0; i < this.answers.length; i++) {
		tmplAnswers += "<div>" + this.answers[i] + "</div>";
	}
	return "<h1>" + this.question + "</h1>" + tmplAnswers;
	};

	elContainer.innerHTML = questions[spurnCount].getTemplate();
/*
var getTemplates = function(){
	let tmplAnswers = "";
	return "<h1>" +  gisk/rettsvor + ' af gískum voru rétt"</h1"'> + tmplAnswers;
};
*/
elContainer.addEventListener('click', function(e) {
  	if(e.target.nodeName.toLowerCase() === 'div'){
 		window.console.log(e.target.textContent);	

 		if (e.target.textContent === questions[spurnCount].correctAnswer) {
 			e.target.className = " activeCorrect";
 			rettsvor++;
 			gisk++;
 			spurnCount++;
 			if (rettsvor === 3) {
 				setTimeout(function() {
 				elContainer.innerHTML = (rettsvor + " af " + gisk + " var rett " + "("+(rettsvor/gisk*100)+"%)");
 				},delayMillis);
 			}
 			else{
 				setTimeout(function() {
 				elContainer.innerHTML = questions[spurnCount].getTemplate();
 				}, delayMillis);
 			}
 		}
 		else{
 			e.target.className = " activeIncorrect";
 			gisk++;
 			/*

 			for(let i = 0; i < questions[spurnCount].answers.length)
 			{
 				if (questions === questions[spurnCount].correctAnswer) {
 					e.target.className = " activeCorrect";
 					spurnCount++;
 				}
 				i++;
 			}
 			}*/
 		}
	}
});

//ef ýtt er á arrowkey niður
document.onkeydown = function(key){ reactKey(key); };
function reactKey(evt) {
	if (evt.keyCode==40) {
		window.alert((rettsvor/gisk*100)+"%");
	}
}



})();