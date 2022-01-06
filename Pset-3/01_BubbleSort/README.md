**Bubble Sort**
<hr>

Implement a program that sorts an array of integers using bubble sort. 

```dotnetcli
dotnet run 13 55 22 45 50

Sort: 13 22 45 50 55
```

**Background**
<hr>

Sorting algorithms represent foundational knowledge that every programmer should at least know at a basic level. And it turns out to be a great way of learning about why arrays are important well beyond mathematics.

The Bubble Sort algorithm works by repeatedly scanning through the array exchanging adjacent elements that are out of order. Each sweep picks up the largest remaining element and moves to the right as far as it can go. Here is a psuedocode example: 

    for i = 0 to n-2
    {
        for j = 0 to n-2
        {
            if Array[j] > Array[j+1]
            {
                swap Array[j] with Array[j+1]
            }
        }
    }
}

**Step-by-step example**
<hr>

Take an array of numbers "5 1 4 2 8", and sort the array from lowest number to greatest number using bubble sort. In each step, elements written in bold are being compared. Three passes will be required; 

First Pass
    
    ( 5 1 4 2 8 ) → ( 1 5 4 2 8 ) 
    Here, algorithm compares the first two elements, and swaps since 5 > 1.

    ( 1 5 4 2 8 ) → ( 1 4 5 2 8 )
    Swap since 5 > 4

    ( 1 4 5 2 8 ) → ( 1 4 2 5 8 )
    Swap since 5 > 2

    ( 1 4 2 5 8 ) → ( 1 4 2 5 8 )
    Now, since these elements are already in order (8 > 5), algorithm does not swap them.


Second Pass

    ( 1 4 2 5 8 ) → ( 1 4 2 5 8 )

    ( 1 4 2 5 8 ) → ( 1 2 4 5 8 )
    Swap since 4 > 2

    ( 1 2 4 5 8 ) → ( 1 2 4 5 8 )

    ( 1 2 4 5 8 ) → ( 1 2 4 5 8 )

Now, the array is already sorted, but the algorithm does not know if it is completed. The algorithm needs one additional whole pass without any swap to know it is sorted.

Third Pass

    ( 1 2 4 5 8 ) → ( 1 2 4 5 8 )

    ( 1 2 4 5 8 ) → ( 1 2 4 5 8 )

    ( 1 2 4 5 8 ) → ( 1 2 4 5 8 )

    ( 1 2 4 5 8 ) → ( 1 2 4 5 8 )


**Specification**
<hr>

- Your program must accept command-line arguments from the user for input.

- If the user enters less than 2 ints (we need at least 2 numbers to sort) generate 
  an error message of your choosing. 

- Validate all arguments are ints

- Your program must output the sorted result

- You may only use known functionality up to this point in C#, you may not make use 
  of the Array.Clone function

- You may Google relevant information about bubble sort, or specific problems, but be 
careful not to stumble upon actual implimentation of bubble sort, as that will ruin the point of this exercise. 