// sessionStorage.setItem("name","Amer");
// sessionStorage.setItem("age",23);
// sessionStorage.setItem("lname","Amora");

//  document.write("printing age <br>");
//   var x = sessionStorage.getItem("age");
// document.write(x+"<br>");
// document.write("printing key number 2 <br>");

// var y=sessionStorage.key(2);
// document.write(y+"<br>");
// document.write(" run after deleting key age  <br>");

// sessionStorage.removeItem("age");
// var x = sessionStorage.getItem("age");
// document.write(x+"<br>");
// document.write(" declaring the key age and it's value again  <br>");
// sessionStorage.setItem("age",23)
// var x = sessionStorage.getItem("age");
// document.write(x+"<br>");
// document.write(" clear method  <br>");

//  sessionStorage.clear();
// var x = sessionStorage.getItem("age");
// var z=sessionStorage.getItem("name");
// document.write(x);
// document.write(z);
localStorage.setItem("name","Amer");
localStorage.setItem("age",23);
localStorage.setItem("lname","Amora");
localStorage.setItem("name","mohammad");

localStorage.setItem("age",25);

 document.write("printing age <br>");
  var x = localStorage.getItem("age");
document.write(x+"<br>");
document.write("printing key number 2 <br>");

var y=localStorage.key(2);
document.write(y+"<br>");
document.write(" run after deleting key age  <br>");

sessionStorage.removeItem("age");
var x = localStorage.getItem("age");
document.write(x+"<br>");
document.write(" declaring the key age and it's value again  <br>");
localStorage.setItem("age",23)
var x = localStorage.getItem("age");
document.write(x+"<br>");
document.write(" clear method  <br>");
