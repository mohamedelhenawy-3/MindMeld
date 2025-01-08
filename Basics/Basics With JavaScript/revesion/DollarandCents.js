function formateMony(amount){
    let x=amount.toFixed(2);
    return`$ ${x}`
}
console.log(formateMony(2))