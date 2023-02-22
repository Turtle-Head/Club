let counter = 0;
const mbody = document.querySelector("body");
const interval = setInterval(() => {
    counter++;
    // if(counter %2 === 0){
    //     mbody.style.backgroundColor="blue";
    //     mbody.style.color="red";
    // }else{
    //     mbody.style.backgroundColor = "red";
    //     mbody.style.color="blue";
    // }
    if (counter === 10) {
        clearInterval(interval);
        mbody.style.backgroundColor="purple";
        mbody.style.color="aliceblue";
    } else if(counter === 1) {
        mbody.style.backgroundColor="blue";
        mbody.style.color="red";
    } else if(counter === 2){
        mbody.style.backgroundColor = "red";
        mbody.style.color="blue";
    }else if(counter === 3) {
        mbody.style.backgroundColor = "blue";
        mbody.style.color="red";
    }else if(counter === 4) {
        mbody.style.backgroundColor = "red";
        mbody.style.color="blue";
    }
    else if(counter === 5) {
        mbody.style.backgroundColor = "blue";
        mbody.style.color="red";
    }
    else if(counter === 6) {
        mbody.style.backgroundColor = "red";
        mbody.style.color="blue";
    }
    else if(counter === 7) {
        mbody.style.backgroundColor = "blue";
        mbody.style.color="red";
    }
    else if(counter === 8) {
        mbody.style.backgroundColor = "red";
        mbody.style.color="blue";
    }
    else if(counter === 9) {
        mbody.style.backgroundColor = "blue";
        mbody.style.color="red";
    }
    console.log("hello interval");
},900);
