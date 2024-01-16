
//const form = document.getElementById('myForm');
//const firstname = document.getElementById('fname');
//    const lastname = document.getElementById("lname");
//    const gender = document.getElementById("gender").value;
//    var dateofbirth = document.getElementById("dateofbirth").value;
//    var age = document.getElementById("age").value;
//    var classVal = document.getElementById("class").value;
//    var address = document.getElementById("address").value;

//form.addEventListener('submit', function (e) {
//    e.preventDefault();
//    const firstnamevalue = firstname.value;
//    const lastnamevalue = lastname.value;
//    localStorage.setItem('first-name', firstnamevalue);
//    localStorage.setItem('last-name', lastnamevalue);
//    window.location
//})

//function addStudent() {
//    var studentName = document.getElementById("addStudent").value;
//    if (studentName.trim() !== "") {
//        // Create a new row and cells
//        var tableBody = document.getElementById("tablebody");
//        var newRow = tableBody.insertRow(tableBody.rows.length);
//        var cell1 = newRow.insertCell(0);
//        var cell2 = newRow.insertCell(1);
//        var cell3 = newRow.insertCell(2);
//        var cell4 = newRow.insertCell(3);
//        var cell5 = newRow.insertCell(4);

//        // Set the cell values
//        cell1.innerHTML = studentName;
//        cell2.innerHTML = ""; // You may set other properties here
//        cell3.innerHTML = "";
//        cell4.innerHTML = "";
//        cell5.innerHTML = "";

//        // Clear the input field
//        document.getElementById("addStudent").value = "";
//    } else {
//        alert("Please enter a student name.");
//    }
//}
//}


//onformsubmit(){|
//    var fromData = readFormData();
//    insertNewRecord(fromData);
//    }
//function readFormData() {
//    var fromData = ();
//    fromData["fullname"] = document.getElementById("fname").value;
//    fromData["lastname"] = document.getElementById("lname").value;
//    return fromData;
//}
//function insertNewRecord(data) {
//    var table = document.getElementById("tabledata").getElementsByTagName('tbody')[0];
//    var newRow = table.insertRow(table.length);
//    cell11 = newRow.insertCell(0)
//    cell11.innerHTML = data.firstname;
//    cell12 = newRow.insertCell(1);
//    cell12.innerHTML = data.firstname;
//}