# FizzBuzz
The classic interview question.

FizzBuzz is a common programming interview question, so I've spent a bit of time thinking about it.
This code is my current best iteration, designed to be easily extensible. Adding new numbers to check for 
(and the associated words to use), is as simple as adjusting the relevant arrays. The only issue is making 
sure that the number and associated word are in the same position in their respective arrays, and that the 
arrays are properly sorted. This could be solved by using a Dictionary, but at this point I think we're
really over-engineering FizzBuzz.
