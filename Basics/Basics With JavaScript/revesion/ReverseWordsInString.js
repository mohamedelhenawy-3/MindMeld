//"hello world" => 'world hello'

function reverse(str){
    return str.toString().split(" ").reverse().join(" ")
}
console.log(reverse("hellow world"))