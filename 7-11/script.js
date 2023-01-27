//EX String----------------------------------------------------------------------

document.write("example for string :" + "<br>" + "<br>");
document.write("The length of the string is : ");



let text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
let length = text.length;

document.write(text.length + "<br>");
document.write(" The substr() method extract a part of a string : ");

let str = "Apple, Banana, Kiwi";

var newstr = str.substr(7, 6);

document.write(newstr + "<br>");

document.write("Convert str to Upper case : ");
document.write(str.toLocaleUpperCase() + "<br>");

document.write("Convert str to Lower case : ");
document.write(str.toLocaleLowerCase() + "<br>");

document.write(" Replace Banana with Orange in the paragraph below : ");
document.write(str.replace("Banana", "Orange") + "<br>");
document.write("<hr>" + "<br>");

//Ex Arrays-------------------------------------------------------------------

document.write("example for arrays :" + "<br>");



const names = ["Ahmad", "Ali", "Mohammad"];
document.write(names + "<br>");

for (let i = 0; i < names.length; i++) {
    document.write(names[i] + "<br>");
}
document.write("<hr>");
document.write("example for pop :");
const lang = ["html", "css", "js"];
document.write(lang + "<br>");

lang.pop();
document.write(lang + "<br>");

document.write("<hr>");
document.write("example for push :");
const fruits = ["apple", "banana"];
document.write(fruits + "<br>");
fruits.push("orange");
document.write(fruits + "<br>");



//EX function---------------------------------------------------------

document.write("<hr>" + "<br>");
document.write("example for function :");



function area(x, y) {
    let a = x * y;
    return a;
}
document.write(area(3, 4));

// Ex opject ------------------------------


document.write("<hr>" + "<br>");
document.write("example for object :" + "<br>");


const person = { firstName: "ahmad", lastName: "ali", age: 25 }
document.write(person.firstName + "<br>");
var fullName = person.firstName + "  " + person.lastName;
document.write(fullName + " age =" + person.age + "<br>");