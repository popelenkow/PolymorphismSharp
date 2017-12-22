# SamplePolymorphicMethod1
## Single rhombic inheritance
### Description
This application demonstrates the priority of calling methods in rhombic inheritance.
### Inheritance hierarchy
![2017-12-22_21-44-41](https://user-images.githubusercontent.com/7475599/34301990-7ab3f428-e761-11e7-9266-8cfd1de3d423.png)
### Call priority

Class BC
```
- DoBC
- DoIC
- DoIB
- DoIA
```
Class CB
```
- DoCB
- DoIB
- DoIC
- DoIA
```
### Additional description
Method DoIB calls next method with a 50% probability.
