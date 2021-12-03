function changeBg(color)
{
    document.body.style.backgroundColor = color;
    let txt = document.getElementsByClassName('text'); //we receive array here in txt
    if(color === "#000000")
    {
        for(let ele of txt)
        {
            ele.style.color="white";
        }
    }
    else{
        // for(let ele of txt)
        // {
        //     ele.style.color="black";
        // }
        //OR
        txt.forEach(element => {
            element.style.color="black";
        });
    }
}