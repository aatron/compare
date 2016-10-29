namespace Fibonacci

module Fibonacci =
  let rec Calculate sequenceIndex =
    if sequenceIndex = 1 then sequenceIndex 
    else (Calculate(sequenceIndex - 1)) + (Calculate(sequenceIndex - 2));