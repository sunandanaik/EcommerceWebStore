import {user} from './bridge.js';

console.log(user());


// import {default as member} from './library.js';
// import {message,user} from './library.js';

// member();
// console.log(message);
// console.log(user("Hrutika"));


//import { message ,user, test} from "./library.js";
//or using alias
//import { message as msg ,user as u, test} from "./library.js";
//or using * means all
// import * as member from "./library.js";

// console.log(member.message);
// //or
// document.body.innerHTML=member.message;

// //function call
// //user("Sunanda");
// console.log(member.user("Hrutika"));

// //create object of test class
// let t = new member.test();