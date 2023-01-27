const myH1 = document.getElementById('my-H1')
console.log(myH1)
for (let i = 0; i < 7; i++) {
  for (let j = 0; j < 17; j++) {
    myH1.innerHTML += 'o'
  }
  myH1.innerHTML += '?@|<br>'
}
const myh2 = document.getElementById('my-h2')
console.log(myh2)
for (let k = 0; k < 7; k++) {
  for (let l = 0; l < (k - l); l++) {
    myh2.innerHTML += 'a';
  }
  for (let m = 0; m < k; m++) {
    myh2.innerHTML += '@'
  }
  for (let n = 0; n < k; n++) {
    myh2.innerHTML += '*'
  }
  for (let p = 0; p < k; p++) {
    myh2.innerHTML += '.'
  }
  myh2.innerHTML += '<br>'
}
