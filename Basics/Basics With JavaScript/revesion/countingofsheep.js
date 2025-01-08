function countOfSheep(arr){
    let count=0;
    arr.map((m)=>{
        if(m === true) count++
    });
    console.log(count)
}
// for (let i=0;i<arr.length;i++){
//     if(arr[i]===true ){
//         count++
//     }
// }
console.log(countOfSheep([true,true,true,true]))