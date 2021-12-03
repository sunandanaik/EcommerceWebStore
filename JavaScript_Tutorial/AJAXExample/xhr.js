//to make it universal by creating custom axios
function myAxios(method, url,body=null) {

    return new Promise((resolve,reject)=>{

    //to send GET request to server
    const xhr = new XMLHttpRequest();
    xhr.open(method, url); //request is opened
    //Rather than manually parsing JSON data we do as follow
    xhr.responseType = 'json';

    //Need to add header to inform Server that data is in json format
    xhr.setRequestHeader('Content-Type','application/json');

    //to get data and display 
    xhr.onload = () => {
        console.log('OK');
        //To get Status Code
        if (xhr.status >= 400) {
            reject(xhr.response);
            console.log('Failed');
        }
        else {
            resolve(xhr.response);
            console.log(xhr.response); //data we receive is in JSON string format so we convert to object
        }
        console.log(xhr.status);

        //console.log(JSON.parse(xhr.response)); // or check above line:8

    }
    //To handle error before sending the request
    xhr.onerror = () => {
        reject('Error!');
        console.log('Error!');
    }

    xhr.send(JSON.stringify(body)); //data to be converted into JSON string
    });
}

//link available from json placeholder of users data
const url = 'https://jsonplaceholder.typicode.com/users';
//myAxios('GET',url);

//Now to send POST request with data i.e. object
myAxios('POST',url,{
    name:'Sunanda',
    job:'Software Developer'
}).then((res)=>{
    console.log('Message from then block');
}).catch((err)=>{
    console.log('Error occured');
})


