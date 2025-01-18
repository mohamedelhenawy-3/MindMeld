function convert(arr){
    //  let newarr=[]
    //  for(let i=0;i<arr.length;i++){
    //     newarr.push(arr[i]*-1)
    //  }
    //  return newarr
    return arr.map(x=> x * -1)
}


console.log(convert([54,-12]))