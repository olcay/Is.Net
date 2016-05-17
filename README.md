Is.Net
=====

####This is a general-purpose micro check library for back-end development. 

This library is a port of [is.js](http://is.js.org/) library by Aras Atasaygin.

####Usage:

Nuget:
```
will be nuget link with first release
```

####Contributing:

Thanks for considering to contribute Is.Net

- Be sure you've added tests if you are sending a new feature.


Type checks
===========

bool Is.Integer(decimal value)
-----------------------
####Checks if the given value is integer.

```cs
Is.Integer(5.0M);
=> true

Is.Integer(5.1M);
=> false

Is.Integer(-3);
=> true

Is.Integer(0);
=> true
```

bool Is.Integer(string value)
-----------------------
####Checks if the given value is integer.

```cs
Is.Integer("1");
=> true

Is.Integer("5.1M");
=> false

Is.Integer("-3");
=> true

Is.Integer("0");
=> true

Is.Integer("a");
=> false
```

Arithmetic checks
===========

bool Is.Even(decimal value)
-----------------------
####Checks if the given value is even.

```cs
Is.Even(2);
=> true

Is.Even(0);
=> true

Is.Even(-3);
=> false

Is.Even(3);
=> false
```

bool Is.Odd(decimal value)
-----------------------
####Checks if the given value is odd.

```cs
Is.Odd(3);
=> true

Is.Odd(-3);
=> true

Is.Odd(2);
=> false

Is.Odd(0);
=> false
```

bool Is.Above(decimal value, decimal min)
-----------------------
####Checks if the given value is above the other.

```cs
Is.Above(1, 0);
=> true

Is.Above(-1, 0);
=> false

Is.Above(0, 0);
=> false
```

bool Is.Under(decimal value, decimal max)
-----------------------
####Checks if the given value is under the other.

```cs
Is.Under(-1, 0);
=> true

Is.Under(1, 0);
=> false

Is.Under(0, 0);
=> false
```

bool Is.Between(decimal value, decimal min, decimal max)
-----------------------
####Checks if the given value is between the others.

```cs
Is.Between(1, 0, 2);
=> true

Is.Between(1, 2, 3);
=> false

Is.Between(2, 1, 2);
=> false

Is.Between(0, 0, 0);
=> false
```

bool Is.Finite(double value)
-----------------------
####Checks if the given value is finite.

```cs
Is.Finite(42);
=> true

Is.Finite(double.PositiveInfinity);
=> false

Is.Finite(double.NegativeInfinity);
=> false
```

bool Is.Prime(int value)
-----------------------
####Checks if the given value is a prime number.

```cs
Is.Prime(2);
=> true

Is.Prime(13);
=> true

Is.Prime(37);
=> true

Is.Prime(1);
=> false

Is.Prime(0);
=> false
```