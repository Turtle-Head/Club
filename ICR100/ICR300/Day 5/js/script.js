function stackofnum(xnum) {
  let sum = 0;
  for (let a = 0; a <= xnum; a++) {
    console.log(a);
    sum += a;
    console.log(sum);
  }
  alert(sum + " is the sum of 1 -> " + xnum);
}
stackofnum(100);
// hello world function
function hello(name) {
  console.log("Hello " + name);
}
hello("Maya k");
hello("World");
