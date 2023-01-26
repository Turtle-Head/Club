let suma=0;
let even=0;
let zero=0;
let odd=0;
const nums=[15,12,2,14,3,0,7,17,19,16,0,5,4,9,13,8,10,19,20,3];
for(let i=0;i<nums.length;i++){
    if(nums[i]===0){
        ++zero;
    }else if(nums[i]%2===0 && nums[i] !==0){
        ++even;
        suma+=nums[i];
    }else if(nums[i]%2!==0){
        ++odd;
    }
}
console.log("sum "+ suma);
console.log("even " + even);
console.log("odd "+ odd);
console.log("zero " + zero);
alert("There are "+ even + " even numbers with a sum of " + suma + " and there were " + odd + " odd numbers with " + zero + " zeros");
// let joe=Math.floor(Math.random() * 101);
// console.log(joe);
// randomize the array

const randy = [];
for (let x=0;x<100;x++){
    randy.push((Math.floor(Math.random() * 101)));
}
console.log(randy);