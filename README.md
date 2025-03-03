Robot Simulator

📌 Overview

This is a .NET C# console application that simulates a toy robot moving on a 5x5 tabletop. 
The robot follows commands from a file (commands.txt). 
The available commands include placing the robot, moving, rotating left/right, and reporting its position.


🛠️ Installation & Setup

Clone the Repository: 

By default, the application reads from commands.txt. Ensure this file exists in the project root

📜 Commands Format

The application accepts the following commands:

PLACE X,Y,F : Places the robot at (X, Y) facing F (NORTH, SOUTH, EAST, WEST).

MOVE : Moves the robot one step forward in its current direction.

LEFT : Rotates the robot 90 degrees left.

RIGHT : Rotates the robot 90 degrees right.

REPORT : Outputs the current position and direction.

Example commands.txt:

PLACE 0,0,NORTH
MOVE
REPORT

Expected Output:

0,1,NORTH

🧪 Running Unit Tests

Unit tests are written using NUnit. To execute them, run:

dotnet test


Happy coding! 🚀
