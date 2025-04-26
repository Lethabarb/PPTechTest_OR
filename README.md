# Parcell Partners Techical Test
## By Oliver Robin
oliver@robinnetwork.au

## Problem Description: 
In C# create a console app that finds the Missing Number using SOLID principles
Description: Given an array containing numbers taken from the range 0 to n, find the one number that is missing from the array.

Input:
An array of integers number where nums contains n distinct numbers from the range 0 to n.

Output:
Return the missing number.

Examples:
Input: [3, 0, 1]
Output: 2

Input: [9, 6, 4, 2, 3, 5, 7, 0, 1]
Output: 8

## My Solution
In my solution I utilised a simple airthmic concept which can easily sum a airthmic sequence of numbers with a common difference. by calculating what the sum of the range of numbers should be without the mising number
and the actual sum of the numbers, we can find the missing number. This calculation part of the algorithm is more efficient than checking each index for the next number and more versatile by being able to handle
larger common differences between numbers.

This airthmic calculation has a time complexity of O(1), however the preparation of this needs the list of numbers to be sorted. I use the C# list.Sort() function which by defenition has an average time complexity of O(n log n)
and a max of O(n^2). This will cause the overall time complexity of the solution to that of the sorting algorithm, which most of the time will be O(n log n). 

*Source: https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.sort?view=net-9.0&redirectedfrom=MSDN#system-collections-generic-list-1-sort*

Additionally, to ensure the validity of my solution I created unit tests with a large range of number sets, from 1-100 numbers and each number missing in the set. This ensures the program will be able to handle any problem thrown at it when
evaluated by the technical team.
