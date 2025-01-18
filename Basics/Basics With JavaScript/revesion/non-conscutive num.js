function nonConsicutive(arr){
for(let i =1;i<arr.length;i++){
  if(arr[i]-1 !== arr[i-1])return arr[i]
}
return null
}
console.log(nonConsicutive([1,2,3,4,5,7,8]))