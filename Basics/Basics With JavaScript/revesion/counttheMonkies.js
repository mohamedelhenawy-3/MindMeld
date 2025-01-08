function count(n){
    let arr=[]
    let count=0;
    for(let i=0;i<n;i++){
        count++
        arr.push(count);
    }
    return arr ;
}
console.log(count(17))