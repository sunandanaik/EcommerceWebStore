let txtBox = document.getElementById('textbox');

txtBox.addEventListener('input', function(e){
    var text = this.value;
    //to count characters
    let char = text.length;
    document.getElementById('char').innerHTML = char;

    //Trim start space
    text = text.trim(); //this removes start and end space.
    //to count words
    let words = text.split(" ");// this creates array of words after splitting
    //after receiving array of words, clean extra empty items from array
    let newList = words.filter(function(ele){
        return ele !== "";
    })
    //console.log(words);
    document.getElementById('word').innerHTML = newList.length;
    
});