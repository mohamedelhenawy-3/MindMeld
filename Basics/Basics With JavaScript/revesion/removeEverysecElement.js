function RemoveEl(arr){
    let newarr=[];
    for(let i=0;i<arr.length;i++){
        if(i %2 ===0){
            newarr.push(arr[i])
        }
    }
    return newarr;
}

console.log(RemoveEl(["mm","kk"]))