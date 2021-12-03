let flag = 0;

function slideShow(num)
{
    let slides = document.getElementsByClassName('slide');

    if(num === slides.length)
    {
        flag = 0;
        num = 0;
    }
    if(num < 0)
    {
        flag = slides.length - 1;
        num = slides.length - 1;
    }

    //to hide  slides
    for(let i of slides)
    {
        i.style.display = "none";
    }
    //console.log(slides);
    
    //to show numth slide
    slides[num].style.display = "block";
}

slideShow(flag);

//on click of prev and next arrow
function controller(x)
{
    //right click
    flag = flag + x;
    slideShow(flag);
     
}