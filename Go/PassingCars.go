package PassingCars

import (
	"fmt"
)

// https://app.codility.com/programmers/lessons/5-prefix_sums/passing_cars/
// https://app.codility.com/demo/results/trainingGNAZ5Z-D4M/

func Solution(arr []int) int {
	zeros := 0
	result := 0
	
	for _,v := range arr {
		if v == 0 {
			zeros += 1
		} else {
			if result > 1000000000 - zeros {
				return -1
			}
			
			result += zeros
		}
	}
	
	return result
}

func main() {
	fmt.Println(Solution([]int{0,0,1,0,1,1}))
	fmt.Println(Solution([]int{0,1,0,1,1}))	
}
