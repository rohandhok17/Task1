﻿function submitform() {
    var fname = document.getElementById("fname").value;
    var lname = document.getElementById("lname").value;
    var gender = document.getElementById("gender").value;
    var dateofbirth = document.getElementById("dateofbirth").value;
    var age = document.getElementById("age").value;
    var classVal = document.getElementById("class").value;
    var address = document.getElementById("address").value;

    var row = table.insertRow(1);
    var cell1 = row.insertCell(0);
    var cell2 = row.insertCell(1);
    var cell3 = row.insertCell(2);
    var cell4 = row.insertCell(3);
    var cell5 = row.insertCell(4);
    var cell6 = row.insertCell(5);
    var cell7 = row.insertCell(6);

    cell1.innerHTMl = firstname;
    cell1.innerHTMl = lastname;
    

}
