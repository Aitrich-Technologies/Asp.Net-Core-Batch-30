const fullName = document.getElementById("fullName");
const userName = document.getElementById("userName");
const email = document.getElementById("email");
const phoneNo = document.getElementById("phoneNo");
const popupModal = document.getElementById("popupModal");
const popupText = document.getElementById("popupText");
const closeModal = document.getElementById("closeModal");

function validateForm() {
  if (
    !fullName.value.trim() ||
    !userName.value.trim() ||
    !email.value.trim() ||
    !phoneNo.value.trim()
  ) {
    alert("Please fill all the fields.");
    return false;
  }

    const fullNameRegex = /^[A-Za-z\s'-]+$/;
    const userNameRegex = /^[a-zA-Z0-9_]{3,16}$/;
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    const phoneRegex = /^[0-9]{10}$/;


    if(!fullNameRegex.test(fullName.value.trim())){
       alert("Full name not acceptable!");
       return false; 
    }
    if(!userNameRegex.test(userName.value.trim())){
        alert("Username not acceptable!");
        return false;
    }
    if(!emailRegex.test(email.value.trim())){
        alert("Email not acceptable!");
        return false;
    }
    if(!phoneRegex.test(phoneNo.value.trim())){
        alert("Phone number not acceptable!");
        return false;
    }
    else{
        
  popupText.innerHTML = `
    <strong>Full Name:</strong> ${fullName.value}<br>
    <strong>Username:</strong> ${userName.value}<br>
    <strong>Email:</strong> ${email.value}<br>
    <strong>Phone No:</strong> ${phoneNo.value}
  `;
  popupModal.style.display = "block";
    }
  return false; 
}

closeModal.onclick = function () {
  popupModal.style.display = "none";
};