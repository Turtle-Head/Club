// Javascript function creation exercise
// Author: James Fehr
// For ICR300:Javascript
// January 31, 2023
//=======================================
//setting up sum of numbers function
function stackofnum(xnum) { 
  let sum = 0;  //initializing sum to hold value of calculations
  for (let a = 0; a <= xnum; a++) { //takes in value of number to be added up to and including
    console.log(a); //displays index to ensure viability of code
    sum += a;   //adds index to value of sum
    console.log(sum);   //displays sum
  }
  alert(sum + " is the sum of 1 -> " + xnum);   // displays sum of numbers
}
stackofnum(100);    //calling the addition function with value of 100
// hello world function
function hello(name) {  //takes in a name
  console.log("Hello " + name);     // displays messsage validating code viability
}
hello("Maya k");    //calling hello with instructor's name as the variable
hello("World");     //calling hello with World for posterity
