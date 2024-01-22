﻿
var genderValidation = function () {
    var genderValue = gender.value;
    console.log(genderValue);
    genderErr = document.getElementById("gender-err");

    if (genderValue !== "Male" || genderValue !== "Famale" || genderValue !== "Other") {
        genderErr.innerHTML = "This field is required.";
        console.log("g1");
    } else {
        genderErr.innerHTML = "";
        console.log("g2");
        return true;
    }
};
gender.oninput = function () {
    genderValidation();
}

var ageValidation = function () {

    var ageInput = document.getElementById("age").value;
    var ageValue = parseInt(ageInput, 10);
    var ageErr = document.getElementById('age-err');

    console.log(ageValue);

    if (ageInput.trim() === "") {
        ageErr.innerHTML = "Age is required";
        return false;
    }

    if (isNaN(ageValue) || ageValue < 5 || ageValue > 99) {
        ageErr.innerHTML = "Age should be <br/> between 5 and 99";
        console.log(ageErr.innerHTML);
        /*console.log("age1");*/
        return false;
    } else {
        ageErr.innerHTML = "";
        /*console.log("no age error");*/
        return true;
    }
};

age.oninput = function () {
    ageValidation();
}

var dob = Date(document.getElementById("dob").value);
var dobValidation = function () {
    
    dobValue = Date(dob.value);
    dobErr = document.getElementById('dob-err');
    var today = new Date();
    
    if (dobValue == today) {
        dobErr.innerHTML = "This field is required";
        console.log("d1");
      
    } else {
        dobErr.innerHTML = "";
        console.log("d2");
        return true;
    }
};
dob.oninput = function () {
    dobValidation();
};


function getUrlParameter(name) {
    name = name.replace(/[\[\]]/g, "\\$&");
    var regex = new RegExp("[?&]" + name + "(=([^&#]*)|&|#|$)"),
        results = regex.exec(window.location.href);
    if (!results) return null;
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, " "));
}

// Function to populate form with user data
function populateFormForEdit(index) {
    var firstName = getUrlParameter('firstName');
    var lastName = getUrlParameter('lastName');
    var gender = getUrlParameter('gender');
    var dob = getUrlParameter('dob');
    var age = getUrlParameter('age');
    var sclass = getUrlParameter('class');
    var address = getUrlParameter('address');

    document.getElementById("firstName").value = firstName;
    document.getElementById("lastName").value = lastName;
    document.getElementById("gender").value = gender;
    document.getElementById("dob").value = dob;
    document.getElementById("age").value = age;
    document.getElementById("class").value = sclass;
    document.getElementById("address").value = address;

}

// Check if 'edit' parameter is present in the URL
var editParameter = getUrlParameter('edit');
if (editParameter === 'true') {
    // If editing, populate the form with existing data
    var editIndex = getUrlParameter('index');
    populateFormForEdit(editIndex);
}
function addOrUpdateUser() {
    var firstName = document.getElementById("firstName").value;
    var lastName = document.getElementById("lastName").value;
    var gender = document.getElementById("gender").value;
    var dob = document.getElementById("dob").value;
    var age = document.getElementById("age").value;
    var sclass = document.getElementById("class").value;
    var address = document.getElementById("address").value;

    firstNameValidation();
    lastNameValidation();
    genderValidation();
    dobValidation();
    ageValidation();

    if (firstName && lastName) {
        var existingUsers = JSON.parse(localStorage.getItem('users')) || [];
        var editIndex = getUrlParameter('index');

        if (editParameter === 'true' && editIndex !== null) {
            // If editing, update existing user data
            existingUsers[editIndex].firstName = firstName;
            existingUsers[editIndex].lastName = lastName;
            existingUsers[editIndex].gender = gender;
            existingUsers[editIndex].dob = dob;
            existingUsers[editIndex].age = age;
            existingUsers[editIndex].sclass = sclass;
            existingUsers[editIndex].address = address;

        } else {
            // If adding, create a new user
            var user = {
                firstName: firstName,
                lastName: lastName,
                gender: gender,
                dob: dob,
                age: age,
                sclass: sclass,
                address: address
            };
            existingUsers.push(user);
        }
        

        localStorage.setItem('users', JSON.stringify(existingUsers));

        document.getElementById("firstName").value = '';
        document.getElementById("lastName").value = '';
        document.getElementById("gender").value = gender;
        document.getElementById("dob").value = dob;
        document.getElementById("age").value = age;
        document.getElementById("class").value = sclass;
        document.getElementById("address").value = address;

        alert('User saved successfully!');

        // Navigate to datadisplay.html after saving
        window.location.href = 'Index';
    }
    //else {
    //    alert('Please enter both first name and last name.');
    //}

}


function cancelUser() {
    window.location.href = 'Index';
}

function deleteUser() {
    var confirmDelete = confirm("Are you sure you want to delete this user?");

    if (confirmDelete) {
        var editIndex = getUrlParameter('index');
        var existingUsers = JSON.parse(localStorage.getItem('users')) || [];

        if (editParameter === 'true' && editIndex !== null) {
            // If editing, show the user data before deletion
            populateFormForEdit();

            // Delete the user at the specified index
            existingUsers.splice(editIndex, 1);
            localStorage.setItem('users', JSON.stringify(existingUsers));

            // Show a success message
            alert('User deleted successfully!');

            // Navigate to datadisplay.html after deletion
            window.location.href = 'Index';
        } else {
            alert('Cannot delete user. No user selected for deletion.');
        }
    }
}
var firstName = document.getElementById("firstName");

var firstNameValidation = function () {
    var firstNameValue = firstName.value.trim().replace(/\s/g, '');
    validFirstName = /^[A-Za-z]+$/;
    firstNameErr = document.getElementById('first-name-err');

    if (firstNameValue === "") {
        firstNameErr.innerHTML = "First Name is required.";
    }
    else if (firstNameValue.length < 3 || firstNameValue.length > 18) {
        firstNameErr.innerHTML = "First Name must be between 3 and 18 characters.";
    } else {
        firstNameErr.innerHTML = "";
        return true;
    }
};
firstName.oninput = function () {

    firstNameValidation();
}
var lastName = document.getElementById("lastName");

var lastNameValidation = function () {
    lastNameValue = lastName.value.trim().replace(/\s/g, '');
    validLastName = /^[A-Za-z]+$/;
    lastNameErr = document.getElementById('last-name-err');
    if (lastNameValue === "") {
        lastNameErr.innerHTML = "This Field is required.";
    }

    else if (lastNameValue.length < 2 || lastNameValue.length > 18) {
        lastNameErr.innerHTML = "Last Name must be between 2 and 18 characters.";
    } else {
        lastNameErr.innerHTML = "";
        return true;
    }
};


lastName.oninput = function () {
    lastNameValidation();
}




    