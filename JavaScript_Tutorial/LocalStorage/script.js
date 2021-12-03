// console.log(window.localStorage);
//OR
// console.log(localStorage);
// localStorage.setItem('theme','dark');

// //to remove the item
// localStorage.removeItem('theme');
// //to clear all items from storage
// //localStorage.clear();
// const theme = localStorage.getItem('theme');
// console.log(theme);
//create Object
// const userSettings = {
//     theme:'dark',
//     font:'normal',
//     score:100
// }
// //Now store object inside localstorage
// //localStorage.setItem('userSettings',userSettings); //it stores as [object Object]
// //So now to store object we need to convert object into JSON string using stringify()
// const settingString = JSON.stringify(userSettings);
// console.log(settingString);
// console.log(typeof settingString);
// console.log(typeof userSettings);
// localStorage.setItem('settingString',settingString);
// const uSetting = localStorage.getItem('settingString');
// console.log(uSetting);
// console.log(typeof uSetting);

// //Convert string into object back
// const objsetting=JSON.parse(uSetting);
// console.log(objsetting);
// console.log(objsetting.theme);//now you can access each item from object
// console.log( typeof objsetting);

//Mini Project
const themeSelector = document.querySelector('#themeSelector');

//on refresh of page the page theme gets reset, inorder to avoid
const theme = localStorage.getItem('theme');
changeTheme(theme);

themeSelector.addEventListener('change',(e)=>{
    //console.log(e.target.value); //to fetch select tag value on change
    //Now to sync to multiple tabs
    localStorage.setItem('theme',e.target.value);
    changeTheme(e.target.value);
});

function changeTheme(theme)
{
 if(theme === 'dark')
 {
     document.body.style.backgroundColor='#222';
 }
 else if(theme === 'light')
 {
    document.body.style.backgroundColor='#e5e5e5';
 }
 else
 {
    document.body.style.backgroundColor='#fff';
 }
}

//Storage event to be listened
 window.addEventListener('storage',(e)=>{
 console.log(e);
 if(e.key === 'theme')
 {
    changeTheme(e.newValue);
    //to reset select tag value
    themeSelector.value=e.newValue;
 }
 
});
//if browsers are old or localstorage is put off
//So we check if localstorage is available or no
if(storageAvailable('localStorage'))
{
    console.log("Working");
}
else
{
    console.log('Not Working');
}

//error handling to check for other browsers
function storageAvailable(type)
{
    let storage;
    try{
        storage=window[type];
        let x = '__storage_test__';
        storage.setItem(x,x);
        storage.removeItem(x);
        return true;
    }
    catch(err)
    {
        return err instanceof DOMException && (e.code===22||e.code===1014||e.name==='QuotaExceededError'||e.name==='NS_ERROR_DM_QUOTA_REACHED')&&(storage&&storage.length!==0);
    }
}