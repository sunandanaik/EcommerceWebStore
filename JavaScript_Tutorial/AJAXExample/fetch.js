const url = 'https://jsonplaceholder.typicode.com/users';

function myAxios(method, url, body = null) {
    //fetch's by default method is GET and by default it returns Promise
    //If doing POST request then we pass data as object
    const headers={'Content-Type':'application/json'}
    return fetch(url,{
        method:method,
        headers:headers,
        body:JSON.stringify(body)
    }).then((res) => {
        //return res.text();
        //or If we need in Json format
        return res.json();
    })
}
//TO do GET request
// myAxios('GET', url).then((res) => {
//     console.log(res);
// }).catch((err) => {
//     console.log(err);
// })
//TO do POST request
myAxios('POST', url,{name:'Sunanda',job:'Software Developer'}).then((res) => {
    console.log(res);
}).catch((err) => {
    console.log(err);
})