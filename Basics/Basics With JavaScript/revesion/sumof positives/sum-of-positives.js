function sumOfpositives(arr){
  return arr.filter((x)=>x>0).reduce((acc,current)=> acc+current ,0) //0 for intial value
// let initval=0;
// for(let i=0;i<arr.length;i++){
//     if(arr[i] >= 0 ){
//     initval +=  arr[i];
//     }
// }
// return initval;
}
console.log(sumOfpositives([13,-2,3]))