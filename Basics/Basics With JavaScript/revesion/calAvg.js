function calavg(array){
    let sum=0;
    for(let i=0;i<array.length;i++){
      sum+=array[i];
    }
     let avg =sum / array.length
     return avg
}
console.log(calavg([12,1,2]))