/*
    Week 3 - Assignment 2 - Invoice (Classes)
    Name: Juan Mireles II
    Course: CITP 3310.V20 - Survey of Programming Languages
    Semester: Summer III 2019
    Due Date: Sunday, June 23, 2019 at 11:59PM CDT
*/

/*  Sources
    Arrays
    https: //developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array
*/

// Variables
var invoiceTotal = 0

// Create class for objects
function Invoice(partNumber, partDescription, theQuantity, thePricePerUnit) {

    const object = {
        partNo: partNumber,
        partDesc: partDescription,
    }

    if (theQuantity > 0) {
        object.quantity = theQuantity
    } else {
        console.log(`\nThe quantity entered is not a valid entry for ${object.partDesc}`)
        object.quantity = 0
    }

    if (thePricePerUnit > 0) {
        object.pricePerUnit = thePricePerUnit
    } else {
        console.log(`The price per unit entered is not a valid entry for ${object.partDesc}`)
        object.pricePerUnit = 0
    }

    // Print to Console
    object.printInvoiceItem = function () {
        console.log(`${object.partNo}\t${object.partDesc}\t\t` +
            `${object.quantity}\t\t\$ ${object.pricePerUnit}`);
    }
    return object
}

// Create objects
const nails = new Invoice('N51487', 'Box of Nails', 5, 7.99)
const wood = new Invoice('W95237', 'Wood Panel', 2, 21.99)
const tile = new Invoice('T84537', 'Marble Tile', -5, -5.00)
const paint = new Invoice('P17254', 'Gallon of Paint', 1, 14.99)
const carpet = new Invoice('C81265', 'Green Carpet', -2, 4.99)
const pipe = new Invoice('PE5142', 'PVC Pipe 1/2in', 10, 'Pipe')


// Place objects in an array to process 
var items = [nails, wood, tile, paint, carpet, pipe]

console.log('\n=========================== INVOICE ===========================\n' +
    'PartNo\tPart Description\tQuantity\tPrice Per Unit\n')

// Calculate and show information to user
items.forEach(function (item) {

    invoiceTotal += item.quantity * item.pricePerUnit
    item.printInvoiceItem();

})

// Show invoice total
console.log(`\n\t\t\t\tInvoice Total: \t\$ ${invoiceTotal}`)