function Square(arr){
    let array=[]
for(let i=0; i<arr.length; i++){
    if(Number.isInteger(Math.sqrt(arr[i]))){
        array.push(Math.sqrt(arr[i]))
    }else{
        array.push(array[i]  * array[i])
    }


}
return array;
}
console.log(Square([4,7,1,2,6]))

//isInteger show if integer or np 2.3 retrun false