var users = JSON.parse(localStorage.getItem('users')) || [];
// var table = document.getElementById('userTable');
// var tbody = table.querySelector('tbody');
var table = document.getElementById('userTable');
// var tbody = table.querySelector('tbody');

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



    if (i === 0) {
        row.classList.add('first-row-color');
    }

    row.addEventListener('click', function (event) {
        var rows = table.getElementsByTagName('tr');
        var firstRow = rows[0];

        // Reset background color for all rows
        for (var j = 0; j < rows.length; j++) {
            rows[j].style.backgroundColor = 'window';
        }

        // Remove the color class from the first row
        // firstRow.classList.remove('first-row-color');

        // Set background color for the clicked row
        event.currentTarget.style.backgroundColor = '#eaf2c2';
    });

    row.addEventListener('dblclick', function (event) {
        var rowIndex = event.target.parentNode.rowIndex;
        editUser(rowIndex - 1);
    
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

           
            this.classList.add('selected');
        });
    });
});

th = document.getElementsByTagName('th');
for (let c = 0; c < th.length; c++) {
    th[c].addEventListener('click',item(c))
}
function item(c) {
    return function () {
        console.log(c);
        sortTable(c)
    }
}

function sortTable(c) {
    let table;
    table = document.getElementById('userTable');
    let rows,
        i,
        x,
        y,
        count = 0;
    let switching = true;

    // Order is set as ascending
    let direction = 'ascending';

    // Run loop until no switching is needed
    while (switching) {
        switching = false;
        let rows = table.rows;

        //Loop to go through all rows
        for (i = 1; i < rows.length - 1; i++) {
            var Switch = false;

            // Fetch 2 elements that need to be compared
            x = rows[i].getElementsByTagName('TD')[c];
            y = rows[i + 1].getElementsByTagName('TD')[c];

            // Check the direction of order
            if (direction == 'ascending') {
                // Check if 2 rows need to be switched
                if (x.innerHTML.toLowerCase() > y.innerHTML.toLowerCase()) {
                    // If yes, mark Switch as needed and break loop
                    Switch = true;
                    break;
                }
            } else if (direction == 'descending') {
                // Check direction
                if (x.innerHTML.toLowerCase() < y.innerHTML.toLowerCase()) {
                    // If yes, mark Switch as needed and break loop
                    Switch = true;
                    break;
                }
            }
        }
        if (Switch) {
            // Function to switch rows and mark switch as completed
            rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
            switching = true;

            // Increase count for each switch
            count++;
        } else {
            // Run while loop again for descending order
            if (count == 0 && direction == 'ascending') {
                direction = 'descending';
                switching = true;
            }
        }
    }
}