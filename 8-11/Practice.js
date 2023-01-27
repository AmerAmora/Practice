document.getElementById("Amer").innerHTML="Amer";
const x=document.getElementsByClassName("edit");
x[0].innerHTML="odai";
x[0].innerHTML+=" Editing";
x[1].innerHTML="Editing2";
const y=document.getElementsByTagName("div");
y[1].style.backgroundColor="Red";
function ChangeImage() {
    var url = document.getElementById('Image').src;
    console.log(url);
    if(url=="http://127.0.0.1:5500/8-11/Kan.png")
    document.getElementById("Image").src = "Sherlock.jpg";
    else if(url=="http://127.0.0.1:5500/8-11/Sherlock.jpg")
    document.getElementById("Image").src = "Kan.png";
  
  }
  document.getElementById("Amer").setAttribute("style","background-color:red;");
  function Destroy() {
    document.getElementById("Image").src = "..";

    
    
  }

  function Text() {
    document.getElementById("Amer").setAttribute("style","background-color:green;");
  }
  function down() {
    document.getElementById("Amer").setAttribute("style","background-color:red;");
  }
  function myFunction() {
    var color1= document.getElementById("color");
    var color2 = color1.value;
    var color3= "background-color:"+color2;
    document.getElementById("container").setAttribute("style",color3);
    
  }
  document.querySelector(".edit").innerHTML="Changing using selector";
  document.querySelectorAll(".edit")[1].innerHTML="Changing 2ed index in class edit using selector all";