DICE ROLLER
Objective: Random Numbers

Task: Create an application that simulates dice rolling.

What will the application do?
The application asks the user to enter the number of sides for a pair of dice. 
If you have learned about exception handling, make sure the user can only enter numbers
The application prompts the user to roll the dice.
The application “rolls” two n-sided dice, displaying the results of each along with a total
For 6-sided dice, the application recognizes the following dice combinations and displays a message for each. It should not output this for any other size of dice.
Snake Eyes: Two 1s
Ace Deuce: A 1 and 2
Box Cars: Two 6s
Win: A total of 7 or 11
Craps: A total of 2, 3, or 12 (will also generate another message!)
The application asks the user if he/she wants to roll the dice again.

Build Specifications:
Create a static method to generate the random numbers.
Proper method header: 2 points
Program generates random numbers validly within the user-specified range: 1 point
Method returns meaningful value of proper type: 1 point
Create a static method for six-sided dice that takes two dice values as parameters, and returns a string for one of the valid combinations (e.g. Snake Eyes, etc.) or an empty string if the dice don’t match one of the combinations.
Create a static method to implement output for different dice combinations
Proper method header: 2 points
Method recognizes all specified cases correctly: 1 point
Method displays properly to Console: 1 point
Application takes all user input correctly: 1 point
Application loops properly: 1 point

Hints:
Use the Random class to generate a random number.

Extra Challenges:
Come up with a set of winning combinations for other dice sizes besides 6. 