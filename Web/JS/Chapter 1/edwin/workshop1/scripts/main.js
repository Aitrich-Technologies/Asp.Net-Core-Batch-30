function validateForm()
{
    
    var jobTitle=document.myForm.jobTitle.value;  
    var description=document.myForm.jobDescription.value;  
    var salary=document.myForm.salary.value; 
    var location=document.myForm.location.value; 

    if(jobTitle==null || jobTitle=="")
    {
        alert(jobTitle+"Please enter your job title");
        return false;
    }
    else if (!validateCharacter(jobTitle)) {
        return false;
    }
     
     if(description==null || description=="")
    {
        alert("Please enter your job description");
        return false;

    }
    else if (!validateCharacter(description)) {
        return false;
    }
     
    if(salary==null || salary=="")
    {
        alert("Please enter your salary");
        return false;

    }
    else if (!validateNumber(salary)) {
        return false;
    }
     
    if(location==null ||location=="")
    {
        alert("Please enter your location");
        return false;

    }
else if (!validateCharacter(location)) {
        return false;
    }
     
    else{
            alert("Form Submitted");
            return true;
            
        }

}

function validateCharacter(inputChar)
{
    const alphaRegex = /^[a-zA-Z\s]+$/; // regular expression pattern for alphabetical characters
    if(!alphaRegex.test(inputChar))
    {
        alert("Allowed alphabets");
        return false;
    }
    return true;
}

function validateNumber(inputNum){
    const numRegex = /^[0-9]+$/;
    if(!numRegex.test(inputNum)){
        alert("Allowed Numbers");
        return false;
    }
    return true;
}