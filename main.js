//Verilmis artan sira ile duzulmus eddeler siyahisindaki N ededinin
// indexini tapan alqoritm

var n=100;
var wantedIndex=-1;
var count=0;

var numbers=[10,20,34,46,55,56,57,58,59,70]

// for(var i=0;i<numbers.length;i++){
//     count++;
//     if(numbers[i]==n){
//         wantedIndex=i;
//         break;
//     }
// }

// console.log(wantedIndex)
// console.log(count)

var min=0;
var max=numbers.length-1;

while(min<=max)
{
    count++;
    var mid = Math.floor((min+max)/2)

    if(numbers[mid]==n){
        wantedIndex=mid;
        break;
    }
    else if(numbers[mid]>n){
        max=mid-1;
    }
    else{
        min=mid+1;
    }
}

console.log(count)