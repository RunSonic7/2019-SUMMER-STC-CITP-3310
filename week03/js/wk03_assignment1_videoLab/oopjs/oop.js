/*
    Week 3 - Assignment 1 - Video Lab - Classes and Objects
    Name: Juan Mireles II
    Course: CITP 3310.V20 - Survey of Programming Languages
    Semester: Summer III 2019
    Due Date: Sunday, June 23, 2019 at 11:59PM CDT
*/

// Create Class
function Person(firstName, lastName, theAge) {
    const obj = {
        first: firstName,
        last: lastName,
    }

    // Validate Age
    if (theAge > 0) {
        obj.age = theAge
    } else {
        console.log('Age should be a positive number')
        obj.age = 0
    }

    // Will output to console
    obj.printName = function () {
        console.log(`My name is ${obj.first} ${obj.last}. I am ${obj.age} years old.`)
    }
    return obj
}

// Create objects
const john = new Person("John", "Smith", 21)
const juan = new Person("Juan", "Perez", -5)
const juanm = new Person("Juan", "Mireles II", 29)

// Print data to console. 
john.printName()
console.log(john.first)
console.log(john.age)

juan.printName()
console.log(juan.first)
console.log(juan.age)

juanm.printName()
console.log(juanm.first)
console.log(juanm.age)