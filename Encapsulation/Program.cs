/* Introduction to Encapsulation
2 min
So far, we’ve learned that 
Preview: Docs Loading link description
classes
 can be a useful tool in the process of abstraction, or pulling related pieces of information and behavior into logical, reusable chunks. Classes act as blueprints that we can use to make multiple similar objects, also called “instances” of the class.

When we write programs that utilize classes and objects, it is often referred to as Object-Oriented Programming (OOP). Some languages, such as C#, heavily engrain the use of classes — you may have noticed that most of the programs we’ve written so far have included a class, Program, which holds the definition of the Main() method.

Abstraction is the first of 4 key tenets of OOP, which are often referred to as the “pillars” of object-oriented programming. The 4 pillars are:

Abstraction
Encapsulation
Inheritance
Polymorphism
Next, we’ll learn about encapsulation. In programming, we often need to control how parts of our program can
be accessed and modified, whether it’s to hide sensitive data, ensure that age is always set to a positive
integer, or to obscure complex implementation details. The process of hiding grouped data behind a barrier
(such as a class definition) and dictating how the data can be accessed and modified is known as encapsulation.

In this lesson, we will cover the following techniques that C# provides for implementing encapsulation:
control access to class members using public and private
control access to fields using properties and automatic properties
attach members to a class itself, instead of to its instances, using static
create and use static classes
 */

/* In C#, members of a class can be marked with an access modifier, such as public or private. A public member can be accessed by any class. A private member can only be accessed by code within the same class it is defined.

By default, fields, properties, and methods are private, and classes are public.
*/

using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest f = new Forest("Congo", "Tropical");
            f.AnnounceForest();

            f.Grow();

            f.AnnounceForest();
        }
    }
}


/*Properties
27 min
Often, we need to specify what values for a given field are valid and invalid. C# provides a special class member for this: properties.

A property controls access to a field, allowing us to validate values before they are set. A property consists of two methods:

a get() method, or getter, called when the property is accessed
a set() method, or setter, called when the property is assigned a value
This is a basic Area property without validation:
*/