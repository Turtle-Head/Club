// let moreInputs = "Y";
// let largest = "0";
// while (moreInputs === "Y") {
//     let userInput = +prompt("Please enter a number to compare for highest", "1");
//     if (largest < userInput) {
//         largest = userInput;
//     }
//     moreInputs = prompt("Are there any more inputs? Y or N", "Y")
// }
// alert(`The largest number is ${largest}`)
let num1=1;
let num2=9;
let result=0;
for(let i=num1, i < num2,i++){
    if(count%2==0){
        console.log(i);
        result=result+i;
    }
    console.log(`the sum is `+result)
}
