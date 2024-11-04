/*
 *********************** Introduction to Inheritance **********************
1 min
Duplicated code leads to errors. Say you have two 
Preview: Docs Loading link description
classes
 Sedan and Truck. They’re different types, but they share a few properties and 
Preview: Docs Methods are blocks of code that can be called elsewhere in the program.
methods
, like SpeedUp() and SlowDown(). If one of those members (say it’s SpeedUp()) has to change,
then we would have to change the code in every location where SpeedUp() is defined.

In this case, it’s two classes, but in other programs, it may be many more! Imagine having 10
different classes that have a similar member, SpeedUp(), and needing to go through each of those
classes every time the method needs to be modified. There are two reasons we don’t want to make the
same change on code across multiple files:

it is more time-consuming
more importantly, it is a big risk of making mistakes
In this lesson, we learn about a solution to this problem: 
Preview: Docs Loading link description
inheritance
. With inheritance, you can define one superclass that contains the shared members (like SpeedUp()
and SlowDown()). All classes that need those members can then inherit them from the superclass.
*/

/*
 ***************** Superclass and Subclass ************************
3 min
In 
Preview: Docs Inheritance in object-oriented programming (OOP) is the concept of creating
new classes based on existing classes.
inheritance
, one class inherits the members of another class. The class that inherits is called a
subclass or derived class. The other class is called a superclass or base class.

In our car example, Sedan and Truck are subclasses (or derived classes). They will inherit members
from a new class called Vehicle, which is the superclass (or base class).

Before using inheritance, both 
Preview: Docs Loading link description
classes
 had:

Wheels, LicensePlate, and Speed properties
Honk(), SpeedUp(), and SlowDown() methods
similar constructors
We can pull these out of both classes and put them in a Vehicle class. Sedan and Truck will still
have access to those members, but we only need to write them in one place.

A class can also be both a superclass and a subclass, meaning we can create complex inheritance
hierarchies. Building on the Vehicle and Truck example, a new PickupTruck class could inherit from Truck,
which inherits from Vehicle. Vehicle could then inherit from a new Machine superclass.

In this hierarchy, PickupTruck inherits directly from Truck, but also inherits indirectly from
Vehicle and Machine. Multiple classes may inherit directly from a single superclass, as both Sedan and
Truck inherit from Vehicle. However, a class may only inherit directly from one superclass.
*/