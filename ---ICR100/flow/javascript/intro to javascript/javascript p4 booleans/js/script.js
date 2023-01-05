// let a = 5;
// let b = "6";
// console.log(a!=="5" || b===6 || !(a==='5' && b===6)); // output is true

let drink = prompt("enter your order","coffee");
// if(drink==="coffee"){
//     alert("I'll have coffee");
// }else if(drink==="tea"){
//     alert("I'll have tea");
// }else if(drink==="hot chocolate"){
//     alert("I'll have hot chocolate");
// }else alert("i'll have water");

if (drink) {
    alert(`I'll have ${drink}`);
}