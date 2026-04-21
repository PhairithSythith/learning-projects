function stilusFelLe(stilus){
    if(stilus==="vilagos"){
        document.body.style.backgroundColor="white";
        document.body.style.color="black";
    }else if(stilus==="sotet"){
        document.body.style.backgroundColor="black";
        document.body.style.color="white";
    }
}

const vilagos=document.getElementById("vilagos");
const sotet=document.getElementById("sotet");

window.addEventListener("load",function(){
    let stilus=sessionStorage.getItem("stilus");
    if(!stilus){
        stilus="vilagos";
        sessionStorage.setItem("stilus",stilus)
    }
    stilusFelLe(stilus);
    if(stilus==="sotet"){
        sotet.checked=true;
    }else if(stilus==="vilagos"){
        vilagos.checked=true;
    }
})
vilagos.addEventListener("change",function(){
    if(vilagos.checked) {
        sessionStorage.setItem("stilus","vilagos");
        stilusFelLe("vilagos");
    }
})
sotet.addEventListener("change",function(){
    if(sotet.checked) {
        sessionStorage.setItem("stilus","sotet");
        stilusFelLe("sotet");
    }
})