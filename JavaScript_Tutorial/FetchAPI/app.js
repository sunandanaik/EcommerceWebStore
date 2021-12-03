const button=document.querySelector("#b1");
const root= document.querySelector("#root");

button.addEventListener("click",function(){
    fetch('https://jsonplaceholder.typicode.com/albums/1/photos')
    .then((res)=>{
        return res.json();
    }).then((photos)=>{
        displayItems(photos);
    });
    
});
//Display all photo items
function displayItems(photo_items)
{
    console.log(photo_items);
    photo_items.forEach((element) => {
        createItems(element);
    });
}
//Creating Each item to display in div element
function createItems(items)
{
 const card=document.createElement('div');
 card.classList.add('card');
 const photo=document.createElement('img');
 photo.src=items.thumbnailUrl;
 photo.style.border='2px solid red'; //css applied to dom elements using js
 const title=document.createElement('h4');
 title.innerHTML=items.title;
 card.appendChild(photo);
 card.appendChild(title);
 root.appendChild(card);
}


