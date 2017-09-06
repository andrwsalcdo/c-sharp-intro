### C#-Intro 

Some notes and thoughts while learning C# <br>


 Create a new C# app

`dotnet new` creates a new app <br>
`console` is the type of app to create <br>
`-o myApp` sets an output directory

```shell
dotnet new console -o myApp
cd myApp
```

Create an overload method: <br>
- You create two or more methods with the same name, but with different number of input parameter and / or different data types

why choose a `do...while` statement <br>
- When you need to execute the block of code at least once. 
- `while` helps with continue iterating through a block of code until a given condition is no longer true 

#### STRINGS

For the following snippets:  `Code` --> Result

- `"My \"so-called\" life"` --> My "so-called" life <br>

- `"What if I need \na new line?"` --> <br>What if I need <br> a new line?

- `@"Go to your c:\ drive"` --> Go to your c:\ drive

- `string.Format("{1}-{0}", "first", "second");` --> second-first
    - `..."{0} - {0}"...` --> first - first 

- `string.Format("{0:C}", 123.45);` --> $123.45

- `string.Format("{0:N}", 1234556789);` --> 1,234, 556,789.00

- `string.Format("Percentage: {0:P}", .123);` --> 12.3% 

- `string.Format("Phone Number: {0:(###) ###-####}", 1234567890);` --> (123) 456-7890

StringBuilder class provides a more memory friendly way to work with strings. 

#### Static 
Static and Instance members of a Class. They are oil & water. Can't mix the two. 

#### var in C# 
var keyword let's the compiler figure out what the data type is. 
not the same var as in other programming languages such as VB or JS. 