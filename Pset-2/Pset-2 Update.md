<h1>Update</h1>

**Instructions**
- Update your Tao.Help.dll file by dragging and dropping the new one into your imports folder, which was sent along with this Pset-2 Update.md file. Allow the old file to be overwritten. 

<br>
<br>

You can now use these functions in addition to the ones we've learned thus far.
<br>
<br>

- **Input.GetIntFromString()**

**Usage:**

This function from Tao.Help accepts a string and returns an integer of the string or string array if possible, otherwise it will end your program with an error message. 

*Please note that this function can accept a string or a string array, provided the array's index has been set, as seen in the following examples: 

```cs
 static int Main(string[] args)
        {
            // args[0] = 123
            int k = Input.GetIntFromString(args[0]);
            Console.WriteLine(k);
        }
        // Output: 123
```

```cs
 static int Main(string[] args)
        {
            string s = "hello!"
            int k = Input.GetIntFromString(s);
            Console.WriteLine(k);
        }
        // Invalid integer.
```

GetIntFromString can also accept a valid error message as shown below: 

```cs
 static int Main(string[] args)
        {
            string s = "hello!"
            int k = Input.GetIntFromString(s, "That ain't it chief.");
            Console.WriteLine(k);
        }
        // That ain't it chief.
```

```cs
 static int Main(string[] args)
        {
            string s = "hello!"
            string err = "Also ain't it chief.";
            int k = Input.GetIntFromString(s, err);
            Console.WriteLine(k);
        }
        // Also ain't it chief.
```
<br>
<br>

- **Char.IsLetter()**


**Usage:**

Checks if a given char is a unicode letter or not. 

*Note: you may use **Char.IsWhiteSpace(c)** or **String.IsNullOrWhiteSpace(s)** to explicitly check for whitespace if needed, but IsLetter checks for whitepsace as well.


```cs
        char c = '/';
        if (!Char.IsLetter(c)) // Note you can use '!Char.IsLetter(c)' to stand in for Char.IsLetter(c) != true
        {
            Console.WriteLine("Not a letter!");
        }
        else 
        {
            Console.WriteLine("Is a letter!");
        }
        // Output: "Not a letter!"
```

Works with strings as well: 

```cs
        string s = "hello, world!";
        if (!Char.IsLetter(s, 2))
        {
            Console.WriteLine("Not a letter!");
        }
        else 
        {
            Console.WriteLine("Is a letter!");
        }
        // Output: "Is a letter!"
```


- **Char.IsUpper(c)** 
- **Char.IsLower(c)** 

IsUpper returns true/false if the char is uppercase. 
IsLower returns true/false if the char is lowercase; 

```cs
        char c = 'H';
        if (!Char.IsUpper(c))
        {                    
            Console.WriteLine("Not uppercase");
        }
        else 
        {                    
            Console.WriteLine("Is uppercase");
        }
        // Output: Is uppercase
```