function BasicOp(op,num1,num2){
let mul=0;
let sum=0;
let div=0;
let muc=0
// if(op==="*"){
//     return mul=num1*num2
// }else if(op === '-'){
//     return muc=num1-num2;
// }else if(op === '/'){
//     return div=num1/num2;
// }else{
//     return sum=num1+num2
// }
if(op==="*")   return mul=num1*num2;
if(op === '-')  return muc=num1-num2;
if(op === '/')   return div=num1/num2;
if(op === '+')   return sum=num1+num2;

}
console.log(BasicOp('+',22,44));