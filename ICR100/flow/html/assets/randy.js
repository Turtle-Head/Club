function rdnums(){
    let number = Math.floor(Math.random() * 100);
    let num2 = Math.floor(Math.random() * 9);
    console.log(`this ${number} is random`);
    console.log(`this ${num2} is random`);
    alert(number);
    return number;
} 
rdnums();