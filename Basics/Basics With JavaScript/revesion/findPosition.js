function findPos(number){
const alph='abcdefghijklmnopqrstuvwxyz'

for(let i=0;i<alph.length;i++){
    if(alph[i]==number){
        return `position is ${i+1}`
    }
}
}


console.log(findPos('z'))