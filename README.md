# StringEx
SE is a class library that delivers wide range of possibilites to your project when it comes to string analysis  
and case conversion or validation. You can find more information about project and it's functionalities below.
# Table of Contents
  - Number analysing methods
  - Boolean methods
  - Case Converting methods
  - Occurencies counting methods
### Note
  Every method in each class library is appointed with proper XML documentation comment  
    ![pp](https://i.imgur.com/ubMpFRU.png)

# Number Analysis
  When it comes to calculating divisibility of very large numbers, for example over 20 digits  
  long, your program can get very laggy if there are more and more tasks to complete.  
  Here comes very handy technique of checking divisibility which involves analyzing just  
  couple of digits for example (%4) can be calculated by applying the following algorithm
  > Let's represent a seven digit number 6522148 by:  
  (a1 * 1000000 + a2 * 100000 + a3 * 10000 + a4 * 1000 + a5 * 100 + a6 * 10 + a7 * 1)  
  > After checking if provided string is a number and throwing an ArgumentException when it is not  
  > apply following algorithm
    
    
    ( Char.GetNumericValue(*last character pos*) + Char.GetNumericValue(*one before last character pos*) ) % 4
    
  For larger numbers, performance of the operation is higher than regular % operation for whole number
    
  
