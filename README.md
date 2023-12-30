# Binary Search Arrays 
 Achieving O(log n) search 
# Binary Search Program
* Overview
This C# program implements a binary search algorithm to search for a value in a sorted integer array.

# Time and Space Complexity
* Time Complexity
The time complexity of the binary search algorithm is O(log n) where n is the length of the input array.

This is because the search space is halved each iteration, so the number of iterations is proportional to the logarithm of the array length.

* Space Complexity
The space complexity is O(1) or constant space since it only stores a few integer variables like start, end, midpoint etc. The input array is stored outside the BinarySearch class.

# How it Works
The BinarySearch class contains the main logic for the binary search.

# The key aspects are:
It takes in a sorted integer array in the constructor
It exposes a find method to search for a value in the array
The find method implements the binary search logic

* The Program class:
Initializes a sample integer array
Creates an instance of BinarySearch with the array
Calls find to search for a value

* Main Classes
BinarySearch - Contains the binary search logic
Program - Initializes sample data and executes search

* Key Methods
BinarySearch
find - Executes the binary search
Program
Main - Entry point that runs the search