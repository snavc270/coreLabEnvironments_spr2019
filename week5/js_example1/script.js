console.log("what up console we be lookin' for new cities!!!!!");

var cities = ["Lima", "Dublin", "San Francisco", "Stockholm", "Buenos Aires", "Hong Kong", "Vancouver", 
		"Salzburg", "Prague", "Auckland", "Havana", "Barcelona", "Jaipur", "Rio De Janeiro"];

var theWorld = function(){
//loop through the array of cities...14 cities
for (var i = 0; i < 14; i++) {
	//always always always console.log...good to check if it works!
	console.log ("cities" + [i+1] + " is " + cities [i]);
	//write to the DOM
	document.write ("cities" + [i+1] + " is " + cities [i] + "<br>");
}
}
theWorld();