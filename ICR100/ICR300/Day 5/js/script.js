// Javascript function creation exercise
// Author: James Fehr
// For ICR300:Javascript
// January 31, 2023
//=======================================
//setting up sum of numbers function
function stackofnum(ynum,xnum) { 
  let sum = 0;  //initializing sum to hold value of calculations
  for (let a = ynum; a <= xnum; a++) { //takes in value of number to be added up to and including
    // console.log(a); //displays index to ensure viability of code
    sum += a;   //adds index to value of sum
    console.log(sum);   //displays sum
  }
  alert(`${sum} is the sum of
    ${ynum} 
    up to 
    ${xnum}`);   // displays sum of numbers
}
stackofnum(1,100);    //calling the addition function with value of 100
stackofnum(-32,-6);

// hello world function
function hello(greet, name){  //takes in a name
  console.log(greet,name);     // displays messsage validating code viability
}
hello("Hello","Superman!");    //calling hello with instructor's name as the variable
hello("Greetings","World!");     //calling hello with World for posterity
// Multiplication 
function mult(xn,yn){
    let total=0;
    for(let b = xn; b <= yn; b++){
        total = b*yn;
        console.log(`${total} so far`);
    }
    alert(`${total} is the multiplied values between ${xn} and ${yn}`);
}
mult(9,19);
//Division
function divit(xm,yn){
    let total = 0;
    for(let c = xm; c <= yn; c++){
        total = c/yn;
        console.log(`${total} is the result for ${yn} and ${xm}`);
    }
    alert(`${total} is the result of ${xm} and ${yn}`);
}
divit(5,69);