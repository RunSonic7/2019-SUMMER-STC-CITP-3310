/*
Week 2 - Assignment 1 - Video Lab
Name: Juan Mireles II
Course: CITP 3310.V20 - Survey of Programming Languages
Semester: Summer III 2019
Due Date: Sunday, June 16, 2019 at 11:59PM CDT
*/

// Sources
// Node.js Readline: https://nodejs.org/api/readline.html
// JS Function https://www.w3schools.com/jsref/jsref_return.asp

// Program using constant variables ============================================
// Variables
const name = 'Juan'
const age = 29
var approxLeapYearDays
var daysLived

// Welcome
console.log(`\n=== HOW LONG HAVE YOU LIVED FOR? ===`)
// Display name to user
console.log(`Hello ${name}.`)

// Calculate days lived
approxLeapYearDays = Math.round(age / 4)
daysLived = (age * 365) + approxLeapYearDays

// Display to user the number of lived days
console.log(`You have lived for over ${daysLived} days.`)

// Determine if the user is an adult
determineAdult(age)

//==============================================================================
// Program using Node.js Readline

var nodeApproxLeapYearDays
var nodeDaysLived

const readline = require('readline');

const readInput = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

// Welcome title
console.log(`\n\n=== HOW LONG HAVE YOU LIVED FOR? ===`)
console.log(`========== node.js Version =========\n`)

// Ask user for name and display name
readInput.question('Please enter your name: ', (nodeName) => {
    console.log(`Hello ${nodeName}\n`)

    // Ask user for age
    readInput.question('Please enter your age: ', (nodeAge) => {

        if (isNaN(nodeAge)) {
            console.log('I am sorry but that is not a valid age.' +
                '\nPlease re-run the program and try again.')
        } else {
            // Perform calculations to determine days
            nodeApproxLeapYearDays = Math.round(nodeAge / 4)
            nodeDaysLived = (nodeAge * 365) + nodeApproxLeapYearDays

            // Display number of days lived to user. 
            console.log(`You have lived for over ${nodeDaysLived} days.\n`)

            // Determine if user is an adult
            determineAdult(nodeAge)
        }

        readInput.close();


    });
});


// Determine if an adult function (DRY Principle)
function determineAdult(userAge) {
    if (userAge >= 18) {
        return console.log("Based on your age, you are considered a " +
            "legal adult.");
    } else {
        return console.log("Based on your age, you are not legally " +
            "considered an adult.");
    }
}