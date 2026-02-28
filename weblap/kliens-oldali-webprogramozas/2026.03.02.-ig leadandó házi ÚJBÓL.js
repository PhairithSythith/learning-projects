function Fuggveny( szam, Callback)
{if(szam%1==0 && typeof szam==="number" && szam>0)
{ Callback(szam);}
else console.log("NEM pozitív egész számot adott meg!");
}
function Callback(szam)
{
    for(let i=0;i<=szam;i++)
{if(szam%i==0) console.log(i+", ");}
}

Fuggveny(30,Callback);
Fuggveny("almafa",Callback);