# Algorithms and Data Structures
## point of equilibrium

Consider an array A with n of positive integers. An integer idx is called a POE (point of equilibrium) of A, if A[0]+A[1]+...+A[idx-1] is equal to A[idx+1]+A[idx+2]+...+A[n-1].

Write a function to return POE of an array, if it exists and -1 otherwise.

The signature of the function is: int f(int[] a)

Examples:
 
| if the input arrays are | return                                                       |
|-|-|
| {1,8,3,7,10,2}          | 3 Reason: a[0]+a[1]+a[2] is equal to a[4]+a[5]               |
| {1,5,3,1,1,1,1,1,1}     | 2 Reason: a[0]+a[1] is equal to a[3]+a[4]+a[5]+a[6]+a[7]+a[8]|
| {2,1,1,1,2,1,7}         | 5 Reason: a[0]+a[1]+a[2]+a[3]+a[4] is equal to a[6]          |
| {1,2,3}                 | -1 Reason: No POE                                            |
| {3,4,5,10}              | -1 Reason: No POE                                            |
| {1,2,10,3,4}            | -1 Reason: No POE                                            |

**The solution is presented in C#.Net.

**#You can try your own solution in the programming language of your choice.**