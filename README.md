.Net2.0-ValueInjecter
================

This project provides a .Net Framework 2.0 port of ValueInjecter

Documentation and Examples
==========================
(Code examples are from http://valueinjecter.codeplex.com/)
#### Basic usage
``` C#
myObject.InjectFrom(anyOtherObject);

// inject from multiple sources
a.InjectFrom(b,c,d,e);

// inject using your own injection
a.InjectFrom<MyInjection>(b);
```

Licensing
=========
This project is developed and distributed under MIT License
* ValueInjecter - MIT License see http://valueinjecter.codeplex.com/license

References
==========
[ValueInjecter](http://valueinjecter.codeplex.com/)
