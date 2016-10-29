package fibonacci

func Calculate(sequenceIndex int) int {
	if sequenceIndex <= 1 {
		return 1
	}

	return Calculate(sequenceIndex-1) + Calculate(sequenceIndex-2)
}
