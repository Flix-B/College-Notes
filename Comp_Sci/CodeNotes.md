# Variables

Variables are stored in the computer's memory - can be compared to a cupboard

- Java is typesafe
- Javascript is not typesafe

## Declaring:

In Python:

    A variable is created the moment you first assign a value to it.
    (type inferred)

    <identifier> = <value>

    e.g:

    person = craig
    print (person)

In C#:

    <type> <identifier> = <value>;

    e.g:

    int person = 10;
    console.vriteline(person);

In Javascript:

(type inferred)
var Name = value;
let Name = value;
const Name = value;

    e.g:

    var person = 10
    console.log(person);

## Assigning:

literal string = string we know the value of

In Python:

    A variable is created the moment you first assign a value to it.

    <identifier> = <value>

In C#:

    <type> <identifier> = value;

In Javascript:

    var = editable variable
    let = doesn't exist when out of scope
    const = is a constant value - cannot change

## JS in HTML

Javascript can be run in web pages using the <script> tags

e.g:

<script src="resources/JS/main.js"></script>

variables can be used in HTML through javascript.
This can be done by:

In the Javascript file:

(Text after "##" is comments)

var person = "Craig"; ## a new variable called "person" is made and the text "Craig" is stored inside

var content = document.querySelector(".content"); ## a new variable called "content" is made and is has the contents of the class ".content" from the HTML stored within

content.innerHTML = person; ## puts the contents of the variable "person" in the "content" class in the HTML

in the HTML file:

<script defer src="resources/JS/main.js"></script>

and

<body>
    <div class="content"></div>
  </body>

This will cause the webpage to display the word "Craig"

====== NEW LESSON ======

what is a procedure?
A block of code that fulfills a specific task (repeatable)

What is a function?
Same as procedure but returns a value to the program

What is a method?
A procedure or function that is contained within a class

always use camelcase when naming variables - first letter is always lowercase, new words start with cap
