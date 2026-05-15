$(function(){

const adatTarolo=[{link:"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSd4wFarQURnRyZAAM5JdOiXuU1SPTmGLPLww&s", szoveg:"Cuki fekvő foltos malac"},
    {link:"https://i.pinimg.com/236x/4b/3c/57/4b3c57fa528418cd5f696ab57d4a8e9e.jpg", szoveg:"Cuki boci nyelvjútva"},
    {link:"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSWC2peqAzIXEub4x4vVLQT0CNKgH_D_dBADQ&s", szoveg:"Cuki nyuszi nyújtott nyelvvel"},
    {link:"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRY2I4zQlEec1drGz6xDKjJgNwrIw_9-yIRZQ&s", szoveg:"Cuki nyuszi fürdés közben"},
    {link:"https://img-9gag-fun.9cache.com/photo/adPPEAN_460s.jpg", szoveg:"Cuki nyuszi ül a fűben"},
    {link:"https://i.pinimg.com/236x/c9/0b/72/c90b72c658a37cf72068b4279188a678.jpg", szoveg:"Cuki kecske ugrás közben"},
    {link:"https://i.ytimg.com/vi/9krVutgCLMc/maxresdefault.jpg", szoveg:"Cuki kecske labdázik"},
    {link:"https://i.pinimg.com/236x/9b/57/b1/9b57b1a525f463787ad09953d15f2168.jpg", szoveg:"Cuki kecske nyelvét nyújtva"},
    {link:"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQmCmLQlS4QWynz26Cq6z4DWrz_LJyjv-Dekg&s", szoveg:"Cuki foltos malac fagyit eszik"},
    {link:"https://assets.4cdn.hu/kraken/74MVoLkW3gRhCuCus.jpeg", szoveg:"Cuki boci hóban játszik"},
    {link:"https://assets.4cdn.hu/kraken/74MVpMh7YqvyCu8cs.jpeg", szoveg:"Cuki boci pihen"},
    {link:"https://bopci.cafeblog.hu/files/2016/02/Cute-Pig-Pictures-29.jpg", szoveg:"Cuki fogott malac napszemüvegben"}
];
let hasznalt=[];
function randomIndex(){
        return  Math.floor(Math.random()*adatTarolo.length);
};
function kepGeneralas(){
    $('#tarolo').html("");
    hasznalt=[];
    for(let i=0;i<3;i++){
        let index;
        do{
        index=randomIndex();
        }while(hasznalt.includes(index));
        hasznalt.push(index);
        let adat=adatTarolo[index];
        let betesz=`<div class="kartya">
        <img src="${adat.link}" alt="${adat.szoveg}" class="kepek">
        <div class="szoveg">${adat.szoveg}</div>
        </div>`;
        $('#tarolo').append(betesz);
}};
    $('#tarolo').on('mouseenter', '.kartya', function(){
        $(this).find('.szoveg').show();
    })
    $('#tarolo').on('mouseleave', '.kartya', function(){
        $(this).find('.szoveg').hide();
    })
$('#tarolo').on('click', '.kartya', function(){
    kepGeneralas();
})
kepGeneralas();
});