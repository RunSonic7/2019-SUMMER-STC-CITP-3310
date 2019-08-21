/*
    Week 4 - Assignment 2 - Sales/Commission Calculator (Control Statements Part 1)
    Name: Juan Mireles II
    Course: CITP 3310.V20 - Survey of Programming Languages
    Semester: Summer III 2019
    Due Date: Sunday, June 30, 2019 at 11:59PM CDT
*/

// Variables
var salesTotal = 0
var commissionTotal = 0
var payoutTotal = 0
var lineNumber = 1
var BASE_SALARY = 200.00

// Class
function Sales(itemQuantity, itemValue) {

    const obj = {}

    // Validate item quantity is positive
    if (itemQuantity > 0) {
        obj.quantity = itemQuantity
    } else {
        console.log(`The quantity entered is not valid`)
        obj.quantity = 0
    }

    // Validate item value is positive
    if (itemValue > 0) {
        obj.value = itemValue
    } else {
        console.log(`The value entered is not valid`)
        obj.value = 0
    }

    // Print to Console
    obj.printPayout = function (value) {
        console.log(`${value}\t${obj.quantity}\t\t$ ${obj.value}`)
    }
    return obj
}

// Create objects
const item1 = new Sales(1, 239.99)
const item2 = new Sales(1, 129.75)
const item3 = new Sales(1, 99.95)
const item4 = new Sales(1, 350.89)

// Place objects in an array to process
var items = [item1, item2, item3, item4]

// Start of print to console
console.log("\n=======================================================")
console.log("==================== PAYOUT REPORT ====================")
console.log("=======================================================\n")
console.log("No.\tQuanitity\tItem Value")

// Process each object, calculate totals for sales
items.forEach(function (item) {
    salesTotal += item.value * item.quantity
    item.printPayout(lineNumber)
    lineNumber++
})

// Calculate Grand Total and Comission
commissionTotal = salesTotal * 0.09
payoutTotal = BASE_SALARY + commissionTotal

// Print to console final calculations
console.log(`\nSales Total\t\t$ ${salesTotal.toFixed(2)}\n`)
console.log(`Base Salary\t\t$ ${BASE_SALARY.toFixed(2)}`)
console.log(`Commission Total\t$ ${commissionTotal.toFixed(2)}`)
console.log(`Payout Total\t\t$ ${payoutTotal.toFixed(2)}`)