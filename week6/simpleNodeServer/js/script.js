var username = prompt("What is your name?");

display_name(username);


function display_name(name){
	// if(name.length > 10){
	// 	document.getElementById('name_heading').innerHTML = "Your name is too long!"; 
	// }
	// else{
	// 	document.getElementById('name_heading').innerHTML = "Hello " + name; 
	// }
	document.getElementById('name_heading').innerHTML = "Hello " + name; 
}
