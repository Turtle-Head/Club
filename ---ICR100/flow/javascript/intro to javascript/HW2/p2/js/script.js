// Exercise 1:
// The user inputs two numbers
// The program will print and sum all the even numbers between the user’s input.
// Input = 1, 9
// Output = 2, 4, 6, 8 (this could be in the console) “The sum of all the even numbers is 20”

// let num1 = +prompt("enter first number");
// let num2 = +prompt("enter second number");
// let sum = 0;
// if ((num1 > 0)&&(num2 > 0)){
//     if(num1 % 2 === 0){
//         sum = sum + num1;
//         //console.log(sum);
//     }
//     if(num2 % 2 === 0){
//         sum = sum + num2;
//         //console.log(sum);
//     }
//     console.log(sum);
// }
// sum = 0;
// for(x=1;x<10;++x){
//     if(x % 2 === 0){
//         sum = sum + x;
//     } console.log(`${sum}`);
// }


// Exercise 2:
// Make a loop that finds the highest number from a set of user inputs
// Input = 1,5,6,8,9,55,10,9
// Output =  55

// const nums = ["1","5","6","8","9","55","10","9"];
// let len = (nums.length);
// let biggest = Math.max(...nums);
// for(let y=0;nums[y]<=Math.max(...nums);y++){
//     if (nums[y]==biggest){
//         console.log(biggest + " is the largest number in an array of "+ len);
//     }
// }

// Exercise 3: 
// Make a program that calculates how many books you can buy. Take in the Budget, and cost of each book (each book price will be different, and you will keep buying books till your budget is 0 or the last book you input is greater than your budget). Print, how many books can be purchased and the remaining budget.
// Input = Case 1: Budget 85$, cost of each book (25, 35, 15)
//         Output = “You can purchase 3 books and you have 10 dollars left over”
// Input = Case 2: Budget 60$, cost of each book (5, 15, 10, 20, 30)
//         Output = “You can purchase 4 books and you have 10$ remaining”


// let A = 12;
// let B = 3;
// let sum = A+B;
// alert(`${A} + ${B} =${sum}`);

// let fname = prompt("enter first name","Jeff");
// let lname = prompt("enter last name","Bezos");
// let age = +prompt("enter age","58");
// let occ = prompt("enter your occupation","Business owner");
// let occupation = occ.toLowerCase();
// alert(`Hi! My name is ${fname} ${lname}, I am ${age} and I am a  ${occupation}.`); 

// let a = +prompt("Enter a number:");
// let b = +prompt("Enter a number:");
// if ((a%2!==0)&&(b%2!==0)){
//     let sum=a*b;
//     console.log(`${a} * ${b} = ${sum}`);
// }else if ((a%2==0)&&(b%2==0)){
//     let sum=a/b;
//     console.log(`${a} / ${b} = ${sum}`);
// }else if ((a%2!==0)&&(b%2==0)){
//     let sum=a+b;
//     console.log(`${a} + ${b} = ${sum}`);
// }else if ((a%2==0)&&(b%2!==0)){
//     let sum=a-b;
//     console.log(`${a} - ${b} = ${sum}`);
// }


// let input=+prompt("enter a number","1");
// for(let x=1;x<=100;x++){
//     let sum=input * x;
//     console.log(`${input}*${x}=${sum}`);
// }

// let  checkPrime = +prompt("Please input a number check","1399");
// let isPrime = true;
// if (checkPrime === 1){
//     isPrime = false;
// }
// for (let i = 2; i < checkPrime / 2; i++){
//     if (checkPrime % i === 0){
//         isPrime = false;
//     }
// }
// alert(`It is ${isPrime} that your number is Prime`);