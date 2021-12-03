let userName = document.getElementById("username");
let passWord = document.getElementById("password");
let flag = 1;

function validateForm()
{
    //Username Validation
    if(userName.value === "")
    {
        document.getElementById('usererror').innerText = "Username is empty";
        flag=0;
    }
    else if(userName.value.length < 3)
    {
        document.getElementById('usererror').innerText = "Username required minimum 3 characters.";
        flag=0;
    }
    else{
        document.getElementById('usererror').innerText='';
        flag=1;
    }

    //Password Validation
    if(passWord.value ==="")
    {
        document.getElementById('passerror').innerText = "Password is empty";
        flag=0;
    }
    else{
        document.getElementById('passerror').innerText='';
        flag=1;
    }

    if(flag)
    {
        return true;
    }
    else{
        return false;
    }
    
}