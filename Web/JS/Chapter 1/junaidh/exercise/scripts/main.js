

function showDetails() {
  let name = document.getElementById("name").value.trim();
  let username = document.getElementById("username").value.trim();
  let email = document.getElementById("email").value.trim();
  let phone = document.getElementById("phone").value.trim();

  let errorBox = document.getElementById("error");

  let alphabetRegex = /^[A-Za-z]+$/;

  if (name === "" || username === "" || email === "" || phone === "") {
    errorBox.innerText = " All fields are required!";
    return; 
  }

  if(!alphabetRegex.test(name)){
    errorBox.innerText= "Name must contain only Alphabets (A-Z or a-z).";
    return;
  }

  if (!alphabetRegex.test(username)){
    errorBox.innerText = "username must contain only alphabets (A-Z or a-z).";
    return;
  }

  if (!email.includes("@") || !email.includes(".")) {
    errorBox.innerText = " Please enter a valid email address.";
    return;
  }

  if (!/^\d{10,}$/.test(phone)) {
    errorBox.innerText = " Please enter a valid phone number.";
    return;
  }

  errorBox.innerText = "";


  document.getElementById("outName").innerText = name;
  document.getElementById("outUser").innerText = username;
  document.getElementById("outEmail").innerText = email;
  document.getElementById("outPhone").innerText = phone;

  // Show popup
  document.getElementById("popup").style.display = "block";
}

function closePopup() {
  document.getElementById("popup").style.display = "none";
}

