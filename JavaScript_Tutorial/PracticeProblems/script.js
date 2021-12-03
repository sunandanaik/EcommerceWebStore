//Q. Write a function called "squared" which takes 2 arrays. The function should return true if every value 
//in the array has its value squared in the second array. The frequency of values must be the same.

//Naive way - Method#1
// function squared(arr1, arr2)
// {
//     if (arr1.length !== arr2.length)
//     {
//         return false;
//     }
//     else{
//         for(let num of arr1)
//         {
//             let foundIndex = arr2.indexOf(num**2);
//             if(foundIndex === -1)
//             {
//                 return false;
//             }
            
//             arr2.splice(foundIndex,1);
//         }
//         return true;
//     }
// }

//Method#2
function squared(arr1,arr2)
{
    if (arr1.length !== arr2.length)
    {
        return false;
    }
    let freqCount1={};
    let freqCount2={};
    for(let num of arr1)
    {
        freqCount1[num] = freqCount1[num]+1 || 1;
        //console.log(freqCount1[num]);
    }
    for(let num of arr2)
    {
        freqCount2[num] = freqCount2[num]+1 || 1;
    }
    //Compare
    for(let key in freqCount1)
    {
        if(!(key**2 in freqCount2)){
            return false;
        }
        if(freqCount1[key]!== freqCount2[key**2]){
            return false;
        }
    }
    return true;
}

console.log(squared([1,2,3], [9,1,4])); //true
console.log(squared([1,2,3], [1,4])); //false
console.log(squared([2,2,3], [4,9,9])); //false

let a=[1,2,3,4,5];
let counter={};
for(let i of a)
{
 counter[i]=counter[i]+1 || 1;
 console.log(counter[i]);
}

