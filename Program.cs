using System;
using System.Buffers;
using System.Numerics;
using System.Runtime.InteropServices;

namespace BinarySearch{
    class Program{
        static void Main(string [] args){
            int [] array = {12, 34,54,55, 78, 98, 1212 ,2132}; //we initialize our array
            Binarysearch LookUp = new Binarysearch(array); // we create an instance of our array as an object of binary search
            LookUp.find(99); // we call our method find

        }
        class Binarysearch{// class that handles our binary search properties(start,end, midpoint) and method look up
            public int start {get; set;}
            public int end {get; set;}
            public int [] Array;
            public Binarysearch(int [] array) {// constructor allows us to parse our array
                start = 0; // start at 0
                end = array.Length; //start on the index of last element in the array
                Array = array; // we assign our array to the array we want to do a search on 
            }

            public int midpoint(int start, int end){ // helper function but is not necessary
                int midpoint = (start + end)/ 2;
                return midpoint;
            }

            public bool find(int value){ // we use a bool and take in the value we want to find in the array
                int middlepoint = 0; // this helps give our while loop a starting point even though the midpoint will be updated

                while(Array[middlepoint]!=value){ // if(our middle point in the array is not equal to what we are looking for, we keep looking )
                    middlepoint = (start + end)/2; // we keep adding the two indexes and having them to get the midpoint
                    if(Array[middlepoint]==value){
                        Console.WriteLine($"Found {value} value at {middlepoint} in Array");
                        return true;// if found we return true
                    } else if(Array[middlepoint]<value){ //if the index value is less than our value we looking for, we know its in the upper half
                        start = middlepoint + 1; //start is updated to midpoint + 1
                      //  find(value);
                    } else if(Array[middlepoint]>value) { //if the index value is more than our value we looking for,  we know its in the lower half
                        end = middlepoint;   // end is updated to the midpoint
                       // find(value);
                    } else {
                        Console.WriteLine("Value is not in the array");
                        return false; // if not found we return false
                    }

                }
                 return true;
            }
        }
    }
}