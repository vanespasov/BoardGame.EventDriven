# BoardGame.EventDriven
Implementing Event Driven Programming concepts in a dummy fiction kind of a board game with balls.
The idea is not yet clear but it will go something like this. There is a table, four holes and predefined number of balls. Every hole has dedicated points like one, two three and five, and dedicated number of balls which can stay in a hole (ex.each hole can contain maximum of four balls, or every hole can have different number of balls). When the number of the balls in a hole is fulfilled then the first enterd ball in that hole is released and returned to the table, from where it can play again and can go in the holes once again. Also the initial number of the balls on the table can not exceed the sum of the numbers of each hole. The game ends when all balls fit into the holes.

Let's have 4 holes named H1, H2, H3 and H5. Each hole can contain max of 5 balls, then we can have max of 4x5=20 balls or H1(5), H2(5), H3(5) and H5(5).

Let's have the folowing balls numbered b1, b2, b3...b20. All the balls are placed on the board and they randomly start to enter into the holes:
ex:
1)
|Hole|Ball|
|---|--- |
|H1 |(b1)|
|H2|(b2)|
|H3|(b3)|
|H5|(b4)|

2)
|Hole|Ball|Return to Board|
|---|--- |---|
|H1|(b6, b5, b1)||
|H2|(b2)||
|H3|(b7, b3)||
|H5|(b8, b4)||

3)
|Hole|Ball|Return to Board|
|---|--- |--- |
|H1|(b10, b9, b6, b5, b1)||
|H2|(b12, b11, b2)||
|H3|(b13, b7, b3)||
|H5|(b14, b8, b4)||

4)
|Hole|Ball|Return to Board|
|---|--- |--- |
|H1|(b15, b10, b9, b6, b5)|->b1|
|H2|(b16, b12, b11, b2)||
|H3|(b17, b13, b7, b3)||
|H5|(b18, b14, b8, b4)||

5)
|Hole|Ball|Return to Board|
|---|--- |--- |
|H1|(b19, b15, b10, b9, b6)|->b5, b1|
|H2|(b16, b12, b11, b2)||
|H3|(b17, b13, b7, b3)||
|H5|(b20, b18, b14, b8, b4)||

6)
|Hole|Ball|Return to Board|
|---|--- |--- |
|H1|(b19, b15, b10, b9, b6)||
|H2|(b1, b16, b12, b11, b2)||
|H3|(b2, b17, b13, b7, b3)||
|H5|(b20, b18, b14, b8, b4)||
