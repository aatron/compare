function calculate(sequence: number) : number {
  if ( sequence <= 1) {
    return 1;
  }

  return calculate(sequence - 1) + calculate(sequence - 2);
}