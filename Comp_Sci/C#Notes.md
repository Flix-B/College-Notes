# C#

All methods in C# are functions 
# Data types: 

int	    4 bytes	Stores whole numbers from -2,147,483,648 to 2,147,483,647
long	8 bytes	Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
float	4 bytes	Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
double	8 bytes	Stores fractional numbers. Sufficient for storing 15 decimal digits
bool	1 bit	Stores true or false values
char	2 bytes	Stores a single character/letter, surrounded by single quotes
string	2 bytes per character Stores a sequence of characters, surrounded by double quotes

## For Loops:

syntax



## Methods

void return type = no return

Syntax: 
<Static> (optional) <scope> (optional)<return type> <identifier> (inputs){
    // code block
}

example:
  static double areaOfRectangle(double height, double width){ 
    
    return height * width;
  }

## Objects + Classes

Class = description of an object 

instances of said object are then made in your code 

Class names = always start with capital

private variables start identifier with " _ " 

Class contains 3 things:
- Properties - variables/data within the class
- Methods - functions of procedures that interact with object - (procedure or function contained within a class)
- Constructor - a special method, called when new class instance made and sets up values - always has the same name as class and does not return any value 


keyword: "this" means the currrent instance is being referenced

## Properties
use "propfull" intellisense for properties

Property can contain: 
- get(<returning of value>)
- set(<updating of values>)

shorthand:

public string FirstName {get; set;}       // public version
private string _firstname;          // private version



## Scope

When working in different classes or methods, must make sure scope for values is correct - must consider namespace and scope
Keep in mind how the containers of a block are setup

can make new local classes - but must use "using" to use inbuilt methods e.g " using system.Console " 

Properties should be "public" - avaliable outside of the class

when declaring variables, can define as "public" or "private" - decides whether is avaliable outside of class or not

private member variables


<type> <identifier> = new <type>();

"this." used to set one 

person person1 = new person();
person person2 = new person();
person1.firstname
person1.Age


$ string - allows use of variables within strings

## Interface

What is an interface in C#?
An interface defines a contract. Any class or struct that implements that contract must provide an implementation of the members defined in the interface. An interface may define a default implementation for members. It may also define static members in order to provide a single implementation for common functionality.

INTERFACE TO REMEMBER: INotifyPropertyChanged

## MVVM

Model
View 
ViewModel


Views     Windows     Web
  |          |          |
  |          |          |
  |-->       v    <-----|
       ViewModels
            |
            v
          Models

Views = OS or implementation specific presentation of the program - should be completley seperable
Viewmodel =  Actual backend code/logic - made to be generic/adaptable (methods, classes, properties etc)
models - our data


## CommunityToolkit.Mvvm

ObservableCollection <identifier of what your are referencing>
ObservableProperty
ObservableObject

