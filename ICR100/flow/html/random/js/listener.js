//initialize the page
// const btnOver = document.getElementById('over')
// const btnUp = document.getElementById('clickUp')
// const btndown = document.getElementById('clickdown')
const keyPress = document.getElementById('my_text') = () => {
  console.log(event.target.value)
}
// btnOver.onmouseover = () => {
//   console.log('Mouse Over');
// }
// btnUp.onmouseup = () => {
//   console.log('Mouse Up');
// }
// btndown.onmousedown = () => {
//   console.log('Mouse Click');
// }
// keyPress.addEventListener(' ', event => {
//   console.log(event.target.value);
// })
// keyPress.addEventListener('keyup', event => {
//   console.log(event.target.value);
// })
const snagy = document.getElementById('b1').onclick = () => {
  console.log(`mouse click`);
  // snagy.style.backgroundColor="purple";
  // cd snagy.style.color="aliceblue";
}
const btnOver = document.getElementById('over').onmouseover = () => {
  console.log(`hover`);
  // btnOver.style.backgroundColor="bluegreen";
}
const btnUp = document.geElementById('clickup').onmouseup = () => {
  console.log(`Mouse Up`)
}
const btndown = document.getElementById('clickdown').onmousedown = () => {
  console.log(`Mouse Down`)
}
// const keyPress.addEventListener('keyup'), event => {
//     console.log(event.target.value)
// }