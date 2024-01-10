function submitform() {
    var fname = document.getElementById("fname").value;
    var lname = document.getElementById("lname").value;
    var gender = document.getElementById("gender").value;
    var dateofbirth = document.getElementById("dateofbirth").value;
    var age = document.getElementById("age").value;
    var classVal = document.getElementById("class").value;
    var address = document.getElementById("address").value;

    console.log("First Name: " + fname);
    console.log("Last Name: " + lname);
    console.log("Gender: " + gender);
    console.log("Date of Birth: " + dateofbirth);
    console.log("Age: " + age);
    console.log("Class: " + classVal);
    console.log("Address: " + address);
}
let form = document.getElementById("formsave");
let table = document.getElementById("tabledata");
form.addEventListener("submit", (e) => {
    e.preventDefault();
    submit();
})
