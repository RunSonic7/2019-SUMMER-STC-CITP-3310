/*
Week 2 - Assignment 2 - Odd or Even
Name: Juan Mireles II
Course: CITP 3310.V20 - Survey of Programming Languages
Semester: Summer III 2019
Due Date: Sunday, June 16, 2019 at 11:59PM CDT
*/

//Sources
// https://www.w3schools.com/jsref/jsref_foreach.asp

// Variables
let userInput = [25, 84, 159663540421, 654316268974];
let remainder;

// Welcome
console.log('=== Welcome to ODD or EVEN ===');

// Check if number is Odd or Even 
userInput.forEach(numberCheck)

function numberCheck(input) {
    // Determine remainder for input
    remainder = input % 2

    // Determine if Odd or Even based on remainder
    if (remainder == 0) {
        return console.log(`\nThe number ${input} is even.`);
    } else {
        return console.log(`\nThe number ${input} is odd.`);
    }
}