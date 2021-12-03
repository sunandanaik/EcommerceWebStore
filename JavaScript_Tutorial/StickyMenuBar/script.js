window.addEventListener('scroll',function(){
    let navBar = this.document.getElementById('menu-bar');
    if(window.pageYOffset >= 204)
    {
        navBar.classList.add('sticky');
        //console.log("Ok");
    }
    else{
        navBar.classList.remove('sticky');
    }
});