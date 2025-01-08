function cc(arr){
    let sum=0;
    let arrOfPositiveNum=[];
    for (let i=0;i<=arr.length;i++){
        if(arr[i]>0){
            arrOfPositiveNum.push(arr[i])
        }else{
             sum+=arr[i]
        }
    }
    return [arrOfPositiveNum.length,sum]
}
//another sol  (fiter-reduce)

console.log(cc([12,33,-11,-22,3732]))