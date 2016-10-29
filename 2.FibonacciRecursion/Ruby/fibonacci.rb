def calculate(sequence)
  if sequence <= 1 then
    return 1
  end

  return calculate(sequence - 1) + calculate(sequence - 2)
end