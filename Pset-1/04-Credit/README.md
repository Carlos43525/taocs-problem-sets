**CREDIT- More comfortable**
<hr>

A credit (or debit) card, of course, is a plastic card with which you can pay for goods and services. Printed on that card is a number that’s also stored in a database somewhere, so that when your card is used to buy something, the creditor knows whom to bill. There are a lot of people with credit cards in this world, so those numbers are pretty long: American Express uses 15-digit numbers, MasterCard uses 16-digit numbers, and Visa uses 13- and 16-digit numbers. And those are decimal numbers (0 through 9), not binary, which means, for instance, that American Express could print as many as 10^15 = 1,000,000,000,000,000 unique cards! (That’s, um, a quadrillion.)

Actually, that’s a bit of an exaggeration, because credit card numbers actually have some structure to them. All American Express numbers start with 34 or 37; most MasterCard numbers start with 51, 52, 53, 54, or 55 (they also have some other potential starting numbers which we won’t concern ourselves with for this problem); and all Visa numbers start with 4. But credit card numbers also have a “checksum” built into them, a mathematical relationship between at least one number and others. That checksum enables computers (or humans who like math) to detect typos (e.g., transpositions), if not fraudulent numbers, without having to query a database, which can be slow. Of course, a dishonest mathematician could certainly craft a fake number that nonetheless respects the mathematical constraint, so a database lookup is still necessary for more rigorous checks.



<br />

**Luhn’s Algorithm**
<hr>
So what’s the secret formula? Well, most cards use an algorithm invented by Hans Peter Luhn of IBM. According to Luhn’s algorithm, you can determine if a credit card number is (syntactically) valid as follows:


    1. Multiply every other digit by 2, starting with the number’s second-to-last digit, and then add those products’ digits together.

    2. Add the sum to the sum of the digits that weren’t multiplied by 2.

    3. If the total’s last digit is 0 (or, put more formally, if the total modulo 10 is congruent to 0), the number is valid!

That’s kind of confusing, so let’s try an example with a Visa: 4003600000000014.



    1. For the sake of discussion, let’s first underline every other digit, starting with the number’s second-to-last digit:
        4003600000000014
        Okay, let’s multiply each of the underlined digits by 2:
        1•2 + 0•2 + 0•2 + 0•2 + 0•2 + 6•2 + 0•2 + 4•2

        That gives us:
        2 + 0 + 0 + 0 + 0 + 12 + 0 + 8

    2. Now let’s add those products’ digits (i.e., not the products themselves) together:
        2 + 0 + 0 + 0 + 0 + 1 + 2 + 0 + 8 = 13

    3. Now let’s add that sum (13) to the sum of the digits that weren’t multiplied by 2 (starting from the end):
        13 + 4 + 0 + 0 + 0 + 0 + 0 + 3 + 0 = 20

    Yup, the last digit in that sum (20) is a 0, so the card is legit!



**Implementation Details**

<hr>

Write a program that prompts the user for a credit card number and then reports (via printf) whether it is a valid American Express, MasterCard, or Visa card number, per the definitions of each’s format herein. So that we can automate some tests of your code, we ask that your program’s last line of output be AMEX or MASTERCARD or VISA or INVALID, nothing more, nothing less. For simplicity, you may assume that the user’s input will be entirely numeric (i.e., devoid of hyphens, as might be printed on an actual card). But do not assume that the user’s input will fit in an int! Best to use **Input.GetLong()** input.

Consider the below representative of how your own program should behave when passed a valid credit card number (sans hyphens).


```dotnetcli
dotnet run
Number: 4003600000000014
VISA
```

It’s up to you to catch inputs that are not credit card numbers (e.g., a phone number), even if numeric:

```dotnetcli
dotnet run
Number: 6176292929
INVALID
```

**How to Test Your Code:**
<br />
<hr>

Test out your program with a whole bunch of inputs, both valid and invalid. (We certainly will!) Here are a few card numbers that [PayPal recommends for testing](https://developer.paypal.com/docs/payflow/payflow-pro/payflow-pro-testing/#credit-card-numbers-for-testing).
