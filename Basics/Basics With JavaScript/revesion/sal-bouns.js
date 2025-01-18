function salaryBouns(salary,bouns)
{
    if(bouns == true){
       return "$ :" + salary*10
    }else{
        return salary
    }
}
console.log(salaryBouns(50,true))