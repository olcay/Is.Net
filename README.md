Is.Net
=====

####This is a general-purpose micro check library for back-end development. 

This library is a port of [is.js](http://is.js.org/) library by Aras Atasaygın.

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

Is.Integer(decimal value)
-----------------------
####Checks if the given value type is integer.

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

Is.Integer(string value)
-----------------------
####Checks if the given value type is integer.

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