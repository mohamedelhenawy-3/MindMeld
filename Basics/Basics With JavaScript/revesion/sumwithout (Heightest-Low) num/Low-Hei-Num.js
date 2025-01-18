//Empty return 0
//find heighest num
//find lowest num 
//filter in arr
// summ all array numbers -reduce 
function sumWithoutHeighestLowestNumber(arr){
if(arr == null) return 0;
 let maxValue= Math.max(...arr)//... that mean split operator
 let minValue=Math.min(...arr)
 let filterArray=arr.filter((x)=> x !==maxValue && x !==minValue)
 let newArray=filterArray.reduce((acc,current)=> acc + current, 0)
console.log(newArray)
}

sumWithoutHeighestLowestNumber([1,2,3,4,5,6]);