
// 1) Take in one number, and check if it is even or odd 
// Case 1) Input = 55
//               Output = odd 
//  Case 2) input = 22
//               output = even

let input = +prompt("Enter a number");
if (isNaN(input)){ console.log("Not a number");
} else if (input%2==0) { console.log(`${input} is even`);
} else console.log(`${input} is odd`);

// 2) Determine if a number is evenly divisible by 3 or evenly divisible by 5. When the number is evenly divisible by 3 print "fizz". When the number is evenly divisible by 5 print "buzz". When it is evenly divisible by both print "FizzBuzz". In all other circumstances print "No fizz No buzz"
//            Case1) Input = 25
//                         output = Buzz
//            Case 2) Input = 30
//                           output = FizzBuzz
//            Case 3) Input = 12
//                           output = Fizz
//            Case 4) Input = 11
//                           output = No fizz No buzz

if ((input % 3 === 0) && (input % 5 ===0)){ console.log("FizzBuzz");
}else if ((input % 3 == 0) && (input % 5 != 0)){ console.log("Fizz");
}else if ((input % 5 == 0) && (input %3 != 0)){ console.log("Buzz");
} else console.log("No Fizz or Buzz");