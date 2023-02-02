// Random number generator
function randnums(){
    let number = Math.floor(Math.random() * 1000);
    // let num2 = Math.floor(Math.random() * 9);
    console.log(`this ${number} is random`);
    // console.log(`this ${num2} is random`);
    console.log(number);
    return number;
}
// gets 100 random numbers
let arRandy =[];
for(let i=0;i<100;i++) {
    arRandy.push[randnums()];
}
console.log(arRandy);
// Takes in 2 numbers
// checks if even or odd
// some addition between both user numbers and a counter
function addifeven(){
    let num1=+prompt("1");
    let num2=+prompt("9")
    let result=0;
    for (let i = num1; i < num2; i++){
        if(i%2==0){
            console.log(i);
            result+=i;
            alert(${i})
        }
        console.log(`the sum is ${result}`)
        
    }
    alert(`the sum is ${result}`)
}
addifeven();
// Multiplication
// takes in 2 numbers
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
// Takes in 2 numbers
function divit(xn,yn){
    let total = 0;
    for(let c = xn; c <= yn; c++){
        total = c/yn;
        console.log(`${total} is the result for ${yn} and ${xm}`);
    }
    alert(`${total} is the result of ${xm} and ${yn}`);
}
divit(5,69);
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