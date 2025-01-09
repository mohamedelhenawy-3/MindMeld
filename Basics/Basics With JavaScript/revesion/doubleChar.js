//
function doubleChar(str){
return str
.split("")
.map((x)=> x.repeat(2))
.join('');
}
console.log(doubleChar('ahenawii'))