let moreInputs = "Y";
let largest = "0";
while (moreInputs === "Y") {
    let userInput = +prompt("Please enter a number to compare for highest", "1");
    if (largest < userInput) {
        largest = userInput;
    }
    moreInputs = prompt("Are there any more inputs? Y or N", "Y")
}
alert(`The largest number is ${largest}`)