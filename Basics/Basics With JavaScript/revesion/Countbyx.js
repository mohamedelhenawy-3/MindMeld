
//(2,10)=>2,4,6,8,10
function countBy(x, n){
    let arr=[];
     for(let i=1;i<= n;i++){
          arr.push(x*i)
     }
     return arr;
}
console.log(countBy(1,10))