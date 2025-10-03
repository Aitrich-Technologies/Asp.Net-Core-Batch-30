var applicantList = [
    { name: "Manu", image: "images/m1.png", JobRole: "Java Developer", quali:"Btech",  experience: "2 years"  },
    { name: "Lamiya", image: "./images/m2.png",  JobRole: "Marketing Exexutive", quali:"MCA",  experience: "2 years"  },
    { name: "Alexander", image: "./images/m1.png", JobRole: "H R Manager", quali:"BCA",  experience: "4 years"  },
    { name: "Deepak Roy", image: "./images/m1.png", JobRole: "System Analyst", quali:"BCA",  experience: "4 years"  }
];

listApplicants();

function listApplicants() {
    var contentDiv = document.getElementById('card');
    contentDiv.innerHTML = ""; // clear old data

    for (let i = 0; i < applicantList.length; i++) {
        // create card container
        var cardDiv = document.createElement('div');
        cardDiv.classList.add("person-card"); // add css class

        var image = document.createElement('img');
        image.src = applicantList[i].image;

        var name = document.createElement('h3');
        name.textContent = applicantList[i].name;

        var JobRole = document.createElement('p');
        JobRole.textContent = "Job Role: " + applicantList[i].JobRole;

        var quali = document.createElement('p');
        quali.textContent = "Qualification: " + applicantList[i].quali;

        var experience = document.createElement('p');
        experience.textContent = "Experience: " + applicantList[i].experience;

        // append all elements
        cardDiv.appendChild(image);
        cardDiv.appendChild(name);
        cardDiv.appendChild(JobRole);
        cardDiv.appendChild(quali);
        cardDiv.appendChild(experience);

        contentDiv.appendChild(cardDiv);
    }
}