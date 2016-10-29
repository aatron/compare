function calculate (sequence) {
  if ( sequence <= 1) {
    return 1;
  }
  else {
    return calculate(sequence - 1) + calculate(sequence - 2);
  }
}

module.exports.calculate = calculate;