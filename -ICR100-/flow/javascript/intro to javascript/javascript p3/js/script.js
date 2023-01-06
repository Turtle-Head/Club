let gree = "Hello";
let ting = "World";
alert(`${gree} ${ting} !`);
console.log(`${gree} ${ting} !`);
let num1 = "1";
let num2 = "3";
alert(`${num1}${num2}`);
console.log(`${num1}${num2}`);
let fname = prompt("Please enter your first name", "James");
let lname = prompt("Please enter your last name", "Dean");
let age = +prompt("Please enter your age", "1000000000");
console.log(`${fname} ${lname} ${age}`);
alert(`${fname} ${lname} ${age}`);

//  above works finally
let activity = prompt("enter an activity", "skydiving");
let friend = prompt("enter a friend's name", "Gary");
let act = prompt("enter a word", "harrow");
let itm1 = prompt("enter item", "rake");
let itm2 = prompt("enter item 2", "girls");
let emo = prompt("enter an emotion", "happy");
let phrase = `Hi! Last week I went  ${activity}  . My friend   ${friend}  and I had so much  ${act}  There were  ${itm1} and ${itm2}  When we saw it we felt really ${emo} . You should come next time!`;
console.log(phrase);
alert(phrase);
