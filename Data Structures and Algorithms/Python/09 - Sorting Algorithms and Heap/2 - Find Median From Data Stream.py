#Find Median From Data Stream

# The median is the middle value in an ordered integer list. If the size of the list is even, there is no middle value and the median is the mean of the two middle values.
# For example, for arr = [2,3,4], the median is 3.
# For example, for arr = [2,3], the median is (2 + 3) / 2 = 2.5.
# Implement the MedianFinder class:
# MedianFinder() initializes the MedianFinder object.
# void addNum(int num) adds the integer num from the data stream to the data structure.
# double findMedian() returns the median of all elements so far. Answers within 10-5 of the actual answer will be accepted.

# Example:
# Input
# ["MedianFinder", "addNum", "addNum", "findMedian", "addNum", "findMedian"]
# [[], [1], [2], [], [3], []]
# Output
# [null, null, null, 1.5, null, 2.0]
# Explanation
# MedianFinder medianFinder = new MedianFinder();
# medianFinder.addNum(1);    // arr = [1]
# medianFinder.addNum(2);    // arr = [1, 2]
# medianFinder.findMedian(); // return 1.5 (i.e., (1 + 2) / 2)
# medianFinder.addNum(3);    // arr[1, 2, 3]
# medianFinder.findMedian(); // return 2.0

# Solution
import heapq
class MedianFinder:
    def __init__(self):
        self.smallHeap = []
        self.largeHeap = []
        
    def addNum(self, num: int) -> None:
        heapq.heappush(self.smallHeap, -1 * num) # because there is no maxHeap in python
        
        #small numbers in small heap, large numbers in large heap
        if self.smallHeap and self.largeHeap  and (-1 * self.smallHeap[0]) > self.largeHeap[0]:
            value = -1 * heapq.heappop(self.smallHeap)
            heapq.heappush(self.largeHeap, value)
            
        # small heap and large heap are almost equal in size
        if len(self.smallHeap) > len(self.largeHeap) + 1:
            value = -1 * heapq.heappop(self.smallHeap)
            heapq.heappush(self.largeHeap,value)
        if len(self.largeHeap) > len(self.smallHeap) + 1:
            value = heapq.heappop(self.largeHeap)
            heapq.heappush(self.smallHeap,-1 * value)
            
    def findMedian(self) -> float:
        if len(self.smallHeap) > len(self.largeHeap):
            return -1 * self.smallHeap[0]
        if len(self.largeHeap) > len(self.smallHeap):
            return self.largeHeap[0]
        return (-1 * self.smallHeap[0] + self.largeHeap[0]) / 2
    
medianFinder = MedianFinder()
medianFinder.addNum(1) # arr = [1]
medianFinder.addNum(2) # arr = [1, 2]
print(medianFinder.findMedian()) # return 1.5 (i.e., (1 + 2) / 2)
medianFinder.addNum(3) # arr[1, 2, 3]
print(medianFinder.findMedian()) # return 2.0

