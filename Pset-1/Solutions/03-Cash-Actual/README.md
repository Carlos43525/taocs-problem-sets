**CASH - Less comfortable**
<hr>

According to the National Institute of Standards and Technology (NIST), a greedy algorithm is one “that always takes the best immediate, or local, solution while finding an answer. Greedy algorithms find the overall, or globally, optimal solution for some optimization problems, but may find less-than-optimal solutions for some instances of other problems.”

Suppose that a cashier owes a customer some change and in that cashier’s drawer are quarters (25¢), dimes (10¢), nickels (5¢), and pennies (1¢). The problem to be solved is to decide which coins and how many of each to hand to the customer. Think of a “greedy” cashier as one who wants to take the biggest bite out of this problem as possible with each coin they take out of the drawer. For instance, if some customer is owed 41¢, the biggest first (i.e., best immediate, or local) bite that can be taken is 25¢. (That bite is “best” inasmuch as it gets us closer to 0¢ faster than any other coin would.) Note that a bite of this size would whittle what was a 41¢ problem down to a 16¢ problem, since 41 - 25 = 16. That is, the remainder is a similar but smaller problem. Needless to say, another 25¢ bite would be too big (assuming the cashier prefers not to lose money), and so our greedy cashier would move on to a bite of size 10¢, leaving him or her with a 6¢ problem. At that point, greed calls for one 5¢ bite followed by one 1¢ bite, at which point the problem is solved. The customer receives one quarter, one dime, one nickel, and one penny: four coins in total.

It turns out that this greedy approach (i.e., algorithm) is not only locally optimal but also globally so for America’s currency (and also the European Union’s). That is, so long as a cashier has enough of each coin, this largest-to-smallest approach will yield the fewest coins possible. 

![ScreenShot](../../imports/coins.jpg)

<br />

**Implementation Details**

<hr>

Implement a program that first asks the user how much change is owed and then prints the minimum number of coins with which that change can be made.

- Use ****Input.GetFloat()**** to get the user’s input and Console.WriteLine() to output your answer. Assume that the only coins available are quarters (25¢), dimes (10¢), nickels (5¢), and pennies (1¢).

    - Use **Input.GetFloat()** so that you can handle dollars and cents. In other words, if some customer is owed $9.75 (as in the case where a newspaper costs 25¢ but the customer pays with a $10 bill), assume that your program’s input will be 9.75 and not $9.75 or 975. However, if some customer is owed $9 exactly, assume that your program’s input will be 9.00 or just 9 but, again, not $9 or 900. Of course, by nature of floating-point values, your program will likely work with inputs like 9.0 and 9.000 as well; you need not worry about checking whether the user’s input is “formatted” like money should be.

- If the user fails to provide a non-negative value, your program should re-prompt the user for a valid amount again and again until the user complies.

- Beware the inherent imprecision of floating-point values. Recall: if x is 2, and y is 10, x / y is not precisely two tenths! And so, before making change, you’ll probably want to convert, perhaps cast, the user’s inputted dollars to cents (i.e., from a float to an int) to avoid tiny errors that might otherwise add up!

- Take care to round your cents to the nearest penny. The "System" library contains a file called "MathF", which conveniently contains MathF.Round(), which takes a floating point number and returns a rounded value. 

- MathF.Round() can take a float and an int as follows: MathF.Round(5.10, 4) or MathF.Round(dollars, decimalPlaces)

-For instance, if "dollars" is a float variable with the user's input (e.g., 0.20), then code like: 

<pre>float dollars = Input.GetFloat("Dollar amount: ");
MathF.Round(dollars * 100);</pre>

Will safely convert 0.20 (or even 0.200000002980232238769531250) to 20.

Your program should behave per the examples below.


```dotnetcli
dotnet run 
Change owed: 0.41
4
```


```dotnetcli
dotnet run
Change owed: -0.41
Change owed: foo
Change owed: 0.41
4
```


**How to Test Your Code:**
<br />
<hr>
Does your code work as prescribed when you input

    - -1.00 (or other negative numbers)?
    - 0.00?
    - 0.01 (or other positive numbers)?
    - letters or words?
    - no input at all, when you only hit Enter?