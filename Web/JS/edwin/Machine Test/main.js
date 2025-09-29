document.getElementById("startQuizBtn").onclick = function() {
    if (confirm("Are you sure you want to begin?")) {
        this.classList.add("confirmed");
        document.getElementById("welcomeMessage").style.display = "block";
    }
    else {
        
         this.classList.remove("confirmed");
        document.getElementById("Try").style.display = "block";
    }
};
 