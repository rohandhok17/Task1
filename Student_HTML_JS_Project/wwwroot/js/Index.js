var users = JSON.parse(localStorage.getItem('users')) || [];

var table = document.getElementById('userTable');
for (var i = 0; i < users.length; i++) {
    var user = users[i];
    var row = table.insertRow(-1);

    var cell1 = row.insertCell(0);
    var cell2 = row.insertCell(1);
    var cell3 = row.insertCell(2);
    var cell4 = row.insertCell(3);
    var cell5 = row.insertCell(4);

    // var cell3 = row.insertCell(2);

    cell1.innerHTML = user.firstName;
    cell2.innerHTML = user.lastName;
    cell3.innerHTML = user.gender;
    cell4.innerHTML = user.age;
    cell5.innerHTML = user.sclass;

    row.addEventListener('dblclick', function (event) {
        var rowIndex = event.target.parentNode.rowIndex;
        editUser(rowIndex - 1); // Subtract 1 to account for the header row
    });
}

function editUser(index) {

    var userToEdit = users[index];
    var editUrl = 'EditPage?edit=true&index=' + index +
        '&firstName=' + encodeURIComponent(userToEdit.firstName) +
        '&lastName=' + encodeURIComponent(userToEdit.lastName) +
        '&gender=' + encodeURIComponent(userToEdit.gender) +
        '&dob=' + encodeURIComponent(userToEdit.dob) +
        '&age=' + encodeURIComponent(userToEdit.age) +
        '&class=' + encodeURIComponent(userToEdit.sclass) +
        '&address=' + encodeURIComponent(userToEdit.address);
    // Redirect to userform.html with edit parameters
    window.location.href = editUrl;

}


function deleteUser(index) {
    users.splice(index, 1);

    localStorage.setItem('users', JSON.stringify(users));

    location.reload();
}
function openUserForm() {
    // Navigate to userform.html when the "Add User" button is clicked
    window.location.href = 'AddStudent';

}
function filterTable() {
    console.log("Enter1");
    var searchBox = document.getElementById('searchBox');
    var searchTerm = searchBox.value.toLowerCase();

    console.log('Search Term:', searchTerm);

    var table = document.getElementById('userTable');
    console.log("Enter00");
    var rows = table.getElementsByTagName('tr');
    console.log("Enter2");
    for (var i = 1; i < rows.length; i++) {
        console.log("Enter3");
        var row = rows[i];
        var cells = row.getElementsByTagName('td');
        var matchFound = false;

        // Check only first name, last name, and age
        var columnsToSearch = [0, 1, 3]; // Adjust these indices as needed
        console.log("Enter4");
        console.log(matchFound);
        for (var j = 0; j < columnsToSearch.length; j++) {
            console.log("Enter5");
            var columnIndex = columnsToSearch[j];
            var cellText = cells[columnIndex].textContent.toLowerCase();
            console.log("Enter6");
            if (cellText.includes(searchTerm)) {
                matchFound = true;
                break;
                console.log("Enter7");
            }
        }
        console.log("Enter8");
        row.style.display = matchFound ? '' : 'none';
        console.log(row.style.display);
    }
}
document.addEventListener('DOMContentLoaded', function () {
    var rows = document.querySelectorAll('#userTable tbody tr');

    rows.forEach(function (row) {
        row.addEventListener('click', function () {
            // Remove 'selected' class from all rows
            rows.forEach(function (r) {
                r.classList.remove('selected');
            });

            // Add 'selected' class to the clicked row
            this.classList.add('selected');
        });
    });
});

document.addEventListener("DOMContentLoaded", function () {
    // Change the color of the first row when the page loads
    highlightFirstRow();
});

function highlightFirstRow() {
    // Get the first row element
    var firstRow = document.querySelector("#userTable tbody tr.first-row");

    // Check if the first row exists before attempting to modify it
    if (firstRow) {
        // Add a class to change the background color or set the style directly
        firstRow.style.backgroundColor = "#FFFFCC"; // Set your desired background color
    }
}
