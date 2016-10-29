#load "Fibonacci.fs"

open System
open Fibonacci
 
printfn "Calculating Fibonacci:";
printfn "-7: %i" (Fibonacci.Calculate(-7));
printfn "-1: %i" (Fibonacci.Calculate(1));
printfn "0: %i" (Fibonacci.Calculate(0));
printfn "1: %i" (Fibonacci.Calculate(1));
printfn "2: %i" (Fibonacci.Calculate(2));
printfn "4: %i" (Fibonacci.Calculate(4));
printfn "7: %i" (Fibonacci.Calculate(7));
