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
In my solution I utilised a simple arithmic concept which can easily sum a sequence of numbers with a common difference. By calculating the sum of the sequence assuming nothing is missing
and the actual sum of the numbers given, we can find the missing number.

This arithmic calculation has a time complexity of O(1), however this needs the list of numbers to be sorted. I used the C# list.Sort() function, which by defenition has an average time complexity of O(n log n)*
and a max of O(n^2). This will cause the overall time complexity of the solution to be that of the sorting algorithm.

Additionally, to ensure the validity of my solution I created unit tests with a large range of number sets, from 1-100 numbers and each number missing in the set. This ensures the program will be able to handle any problem thrown at it when
evaluated by the technical team.

**Source: https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.sort?view=net-9.0&redirectedfrom=MSDN#system-collections-generic-list-1-sort*
