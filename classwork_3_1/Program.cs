int NunFunc(int a)
{
    int summ = 1;
    while (a > 1)
    {
        summ = summ + a;
        a = a - 1; 
    }
    return summ;
}


Console.Write("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());
int Res = NunFunc(Num);
Console.WriteLine($"Сумма чисел от 1 до {Num} равна {Res}");

// function arrayDiff(a, b) {
//  if (a.length === 0) {
//    return [];
//  }
//  if (b.length === 0) {
//    return a;
//  }
  
  
//  for (let i = 0; i < b.length; i++) { 
//  
//    let isIncluded = a.includes(b[i])
//  
//    a.forEach(arrItem => {
//     if (isIncluded === true) {
      
//      let position = a.indexOf(b[i]);
//      a.splice(position, 1);
//    }
//  })
//  }
//  return a;
//}; 