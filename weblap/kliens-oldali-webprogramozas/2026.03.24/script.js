console.log('Hello');
document.getElementById('focim');//id alapján való elérése egy tag-nak
console.log(document.getElementById('focim').nodeName);//szövegnél azt adja vissza hogy text tag-nél pedig az értékét
document.getElementsByTagName('h1')[0].id; //tömbszerű dolgot ad vissza, bele vesszi az összes h1-et [0] így adom meg melyiket szeretném
//a document.getElementsByTagName('h1')[0].id; a .id az id-ját adja vissza, csak egyenként lehet őket kezelni!!!
document.getElementsByName('alcím')[0];//ez is tömbszerű dolgot ad vissza itt is [] meg kell adni melyiket akarom pontosan mert lehet több ugyanilyen name-el
document.getElementsByName('alcím')[0].textContent;//innerText- belső tartalom, textContent- minden szöveg ami el van rejtve azt is bele veszi
document.getElementsByClassName('fontos')[0].innerHTML; //az ebbe a stílus osztályba levő szövegeket/tageket gyűjti össze
document.querySelector('h2>u').style.fontFamily='Courier';//css jelölőket használja, konkrét css kód és átalakítás használható így
document.querySelectorAll('h2>u')[0].classList.add('fontos');//hozzá adhatjuk az osztáylokat másokhoz is, ki-be kapcsolhatjuk stb

const focim=document.getElementById('focim');
if(!focim.hasAttribute('title'))
    {focim.setAttribute('title','Document Object Model');}

document.getElementById('nev').value="Mekk Elek";


/*Események*/
const helovilag=function()
{
    console.log('Hello világ');
    //ez egy semény, click-re kiírja a konzolra
}

document.getElementById('tsa').onclick=function(){ //ez ffelüülírja az előzőt
    console.log('Hello én az első alkalmazásod vagyok');
};

document.getElementById('tsa').addEventListener('click',function(){ //ez az elözö lefutása után lefut és nem írja ffelül az előzőt
    console.log("Még én is itt vagyok");
})
//esemény figyelőben nincs a szó előtt on azon kívül van
document.getElementsByTagName('h2')[0].addEventListener('mouseover',function()
{
    this.style.color='red';
});
document.getElementsByTagName('h2')[0].addEventListener('mouseleave', function() 
{
    this.style.color="black";
})

document.getElementsByTagName('ul')[0].addEventListener('click', function(event)
{
    this.style.border='1px solid red';
    event.target.style.backgroundColor='yellow';
})

/*  */

document.getElementsByTagName('li')[0].addEventListener('dblclick',function()
{
    this.style.color="orange";
})

document.getElementsByTagName('li')[0].addEventListener('click', function()
{
    this.style.color="grey";
})


const General=function()
{
    let szamok=[1,2,3,4];

    for(let i=0;i<szamok.length;i++)
    {
        let j = Math.floor(Math.random() * 4);
        let cserel=szamok[i];
        szamok[i]=szamok[j];
        szamok[j]=cserel;
    }
   
    let tabla1=getElementsByTagName('table')[0].getElementsByTagName('td');
    let tabla2=getElementsByTagName('table')[1].getElementsByTagName('td');

    for (let i = 0; i < 4; i++) {
        tabla1[i].innerHTML = szamok[i];
    }
    for (let i = 0; i < 4; i++) {
        tabla2[i].innerHTML = szamok[i];
    }
      

}


   document.getElementsByTagName('button')[0].addEventListener('click',function(){
    General();
   })





