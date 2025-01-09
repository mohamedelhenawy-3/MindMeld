function firstnonConsecuctive(arr)
{
    for(let i=0;i<arr.length;i++){
        if(arr[i]-1 !== arr[i-1]){
            return 'is cons'
        }else{
            return "Null"
        }
    }
}
console.log(firstnonConsecuctive([1,2,3,4,5,9,10]))