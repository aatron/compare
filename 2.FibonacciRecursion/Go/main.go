package main

import "fmt"
import f "./fibonacci"

func main() {
	fmt.Printf("Calculating Fibonacci:\n")
	fmt.Printf("-7: %v\n", f.Calculate(-7))
	fmt.Printf("-1: %v\n", f.Calculate(-1))
	fmt.Printf("0: %v\n", f.Calculate(0))
	fmt.Printf("1: %v\n", f.Calculate(1))
	fmt.Printf("2: %v\n", f.Calculate(2))
	fmt.Printf("4: %v\n", f.Calculate(4))
	fmt.Printf("7: %v\n", f.Calculate(7))
}
