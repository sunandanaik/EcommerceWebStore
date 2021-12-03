let input = document.querySelector('#input');
let searchBtn = document.querySelector('#search');
let apiKey = '293f23cd-5f98-498c-9e40-caec161d31f5';
let notFound = document.querySelector('.not-found');
let defBox = document.querySelector('.def');
let audioBox = document.querySelector('.audio');
let loading = document.querySelector('.loading');

searchBtn.addEventListener("click",function(e){
    e.preventDefault();

    //to clear previous data
    audioBox.innerHTML='';
    notFound.innerText='';
    defBox.innerText='';

    
    //Now to get input data
    let word = input.value;

    //Call API get data
    if(word == '')
    {
        alert('Word is required');
        return;
    }
    getData(word);//function calling
});

async function getData(word)
{
    loading.style.display='block'; //css styling done to DOM elements in JS.
    //We need to call API
    const response = await fetch(`https://www.dictionaryapi.com/api/v3/references/learners/json/${word}?key=${apiKey}`);
    //To extract data
    const data = await response.json();

    //if empty result
    if(!data.length)
    {
        //also if empty result comes , then we hide loading
        loading.style.display='none';
        notFound.innerText = 'No result found';
        return;
    }

    //if result is suggestions
    if(typeof data[0] == 'string')
    {
        loading.style.display='none';
        let heading = document.createElement('h3');
        heading.innerText= 'Did you mean ?';
        notFound.appendChild(heading); //to attach to existing div content.
        data.forEach((element)=>{
            let suggestion = document.createElement('span');
            suggestion.classList.add('suggested');
            suggestion.innerText = element;
            notFound.appendChild(suggestion);
        });
        return;
    }
    //If result found
    loading.style.display='none';
    let definition = data[0].shortdef[0];
    defBox.innerText = definition;

    //To put audio sound
    const soundName = data[0].hwi.prs[0].sound.audio;
    //for some, audio property may not exist,if exists
    if(soundName)
    {
        //if sound file available then call renderSound()
        renderSound(soundName);
    }

    console.log(data);
}

//function calling
function renderSound(soundName)
{
    //to get first letter from sound name
    let subfolder = soundName.charAt(0);
    let soundSrc = `https://media.merriam-webster.com/soundc11/${subfolder}/${soundName}.wav?key=${apiKey}`;

    //now to generate audio
    let audi = document.createElement('audio');
    audi.src=soundSrc;
    audi.controls=true;
    audioBox.appendChild(audi);
}