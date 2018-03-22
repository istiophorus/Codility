package main

 

import (

               "fmt"

)

 

//https://app.codility.com/demo/results/trainingS6Q46W-3HX/

func MissingInteger(arr []int) int {

               arrLen := len(arr)

              

               if arrLen <= 0 {

                              return 1

               }

              

               mm := make(map[int]int)

              

               for _, v := range(arr) {

                              mm[v] = 1

               }

              

               for i := 1; i <= arrLen; i++ {

                              _,y := mm[i]

                             

                              if !y {

                                            return i

                              }

               }

              

               return arrLen + 1

}

 

https://app.codility.com/demo/results/training5KETYS-RVW/

func MaxCounters(si int, arr []int) []int {

               res := make([]int, si, si)

              

               currentMaxValue := 0

               currentMaxValueIndex := -1

               maxValueToSet := -1

               touchedItems := make(map[int]bool)

              

               for _, v := range(arr) {

                              if (v > si) {

                                            maxValueToSet = currentMaxValue

                                            touchedItems = make(map[int]bool)

                                            touchedItems[currentMaxValueIndex] = true

                              } else {

                                            v--

                                            currentValue := res[v]

                                            if currentValue < maxValueToSet {

                                                           currentValue = maxValueToSet

                                                           touchedItems[v] = true

                                            }

                                           

                                            currentValue++

                                            res[v] = currentValue

                                            if res[v] > currentMaxValue {

                                                           currentMaxValue = res[v]

                                                           currentMaxValueIndex = v                                                       

                                            }

                              }

               }

              

               if maxValueToSet > 0 {

                              for ix := 0; ix < si; ix++ {

                                            _,y := touchedItems[ix]

                             

                                            if !y {

                                                           res[ix] = maxValueToSet

                                            }                           

                              }

               }

              

               return res

}

 

func main() {

               //res := MissingInteger([]int{})

               //fmt.Println(res)

              

               //res = MissingInteger([]int{1,3,5})

               //fmt.Println(res)

              

               //res = MissingInteger([]int{1,2,3,4,5})

               //fmt.Println(res)

              

               //res = MissingInteger([]int{1,2,3,4,5,8})

               //fmt.Println(res)            

              

               //res := MaxCounters(5, []int {3,4,4,6,1,4,4} );

               //fmt.Println(res)            

}