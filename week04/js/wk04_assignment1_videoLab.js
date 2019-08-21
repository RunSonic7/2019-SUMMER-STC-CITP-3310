/*
    Week 4 - Assignment 1 - Video Lab - Control Statements (Part 1)
    Name: Juan Mireles II
    Course: CITP 3310.V20 - Survey of Programming Languages
    Semester: Summer III 2019
    Due Date: Sunday, June 30, 2019 at 11:59PM CDT
*/

function Grade(number) {
    const obj = {}

    // Validate if number is between 0 and 100 inclusive
    if (number >= 0) {
        if (number <= 100) {
            obj.gradeNumber = number;
        } else {
            obj.gradeNumber = 0;
        }
    }

    // Convert number to Letter Equivalent
    obj.gradeLetter = function () {
        let gradeLetter;
        if (obj.gradeNumber >= 90) {
            gradeLetter = "A";
        } else if (obj.gradeNumber >= 80) {
            gradeLetter = "B";
        } else if (obj.gradeNumber >= 70) {
            gradeLetter = "C";
        } else if (obj.gradeNumber >= 60) {
            gradeLetter = "D";
        } else {
            gradeLetter = "F";
        }
        return gradeLetter;
    }

    // Determine if grade is passing or failing
    obj.gradeStatus = function () {
        console.log(obj.gradeNumber > 59 ? "Passed :)" : "Failed :(");
    }

    // Validate grade
    obj.sillyValidation = function () {
        let control = obj.gradeNumber
        let counter = 0

        while (control > 0) {
            console.log(`${++counter}.-`);
            obj.gradeStatus();
            control -= 10;
            // DRY: Don't Repeat Yourself
        }
    }
    return obj
}

// Output to console. 
const juan = new Grade(97)
console.log(juan.gradeNumber)
console.log(juan.gradeLetter())
juan.gradeStatus();
juan.sillyValidation();