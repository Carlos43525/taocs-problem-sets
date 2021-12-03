**MARIO - More comfortable**
<hr>

Toward the end of World 1-1 in Super Mario Brothers, 
Mario must ascend a right-aligned pyramid of blocks.

![ScreenShot](../../imports/pyramids.png)

Let’s recreate those pyramids in C#, albeit in text, using hashes (#) for bricks, a la the below. Each hash is a bit taller than it is wide, so the pyramids themselves are also be taller than they are wide.

<br />

<pre>
   #  #
  ##  ##
 ###  ###
####  ####
</pre>

The program we’ll write will be called mario. And let’s allow the user to decide just how tall the pyramids should be by first prompting them for a positive integer between, say, 1 and 8, inclusive.

Here’s how the program might work if the user inputs 8 when prompted:


```dotnetcli
dotnet run
Height: 8
```

<pre>
       #  #
      ##  ##
     ###  ###
    ####  ####
   #####  #####
  ######  ######
 #######  #######
########  ########
</pre>

Here’s how the program might work if the user inputs 4 when prompted:


```dotnetcli
dotnet run
Height: 4
```

<pre>
   #  #
  ##  ##
 ###  ###
####  ####
</pre>


If the user doesn’t, in fact, input a positive integer between 1 and 8, 
inclusive, when prompted, the program should re-prompt the user until 
they cooperate:


```dotnetcli
dotnet run
Height: -1
Height: 0
Height: 42
Height: 50
Height: 4
```
<pre>
   #  #
  ##  ##
 ###  ###
####  ####
</pre>

Notice that width of the “gap” between adjacent pyramids is equal to the width of two hashes, irrespective of the pyramids’ heights.

Feel free to write pseudocode to get your ideas out first: 


    1. Prompt user for height
    2. If height is less than 1 or greater than 8 (or not an integer at all), go back one step
    3. Iterate from 1 through height:
    4. On iteration i, print i hashes and then a newline

Recall that you can get an integer from the user with Input.GetInt();
Recall that we prompted the user for a positive integer using a while loop

If it helps, you can imagine your pyramid white spaces as so: 

<pre>
.......#
......##
.....###
....####
...#####
..######
.#######
########
</pre>


**How to Test Your Code:**
<br />
<hr>
Does your code work as prescribed when you input:

    - -1 (or other negative numbers)?
    - 0?
    - 1 through 8?
    - 9 or other positive numbers?
    - letters or words?
    - no input at all, when you only hit Enter?





