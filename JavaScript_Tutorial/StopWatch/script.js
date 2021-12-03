var hr = 0;
var min = 0;
var sec = 0;
var ms = 0;
var timer = false; //this denotes timer is stopped

//Main function
function stopwatch(){
 if(timer === true)
 {
     ms = ms+1;
     if(ms === 100)
     {
         sec = sec+1;
         ms=0;
     }

     if(sec === 60)
     {
         min = min+1;
         sec=0;
     }

     if(min === 60)
     {
         hr = hr+1;
         min=0;
         sec=0;
     }
     //To counvert into String
     var hrStr = hr;
     var minStr = min;
     var secStr = sec;
     var msStr = ms;

     //Check if hr is single digit
     if(hr < 10)
     {
        hrStr ="0" + hrStr;
     }
     //Check if min is single digit
     if(min < 10)
     {
        minStr ="0" + minStr;
     }
     //Check if sec is single digit
     if(sec < 10)
     {
        secStr ="0" + secStr;
     }
     //Check if millisec is single digit
     if(ms < 10)
     {
        msStr ="0" + msStr;
     }

     document.getElementById('hour').innerText = hrStr;
     document.getElementById('min').innerText = minStr;
     document.getElementById('sec').innerText = secStr;
     document.getElementById('millisec').innerText = msStr;
     setTimeout(stopwatch,10);
 }
}

function start(){
    timer = true;
    stopwatch();
}

function stop(){
  timer = false;
}

function reset(){
    timer = false;
    hr=0;
    min=0;
    sec=0;
    ms=0;
    document.getElementById('hour').innerText="00";
    document.getElementById('min').innerText="00";
    document.getElementById('sec').innerText="00";
    document.getElementById('millisec').innerText="00";
}

