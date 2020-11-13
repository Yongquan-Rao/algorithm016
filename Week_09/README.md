学习笔记

不同路径2的算法：

    1. If the first cell i.e. obstacleGrid[0,0] contains 1, this means there is an obstacle in the first cell. Hence the robot won't be able to make any move and we would return the number of ways as 0.
    2. Otherwise, if obstacleGrid[0,0] has a 0 originally we set it to 1 and move ahead.
    3. Iterate the first row. If a cell originally contains a 1, this means the current cell has an obstacle and shouldn't contribute to any path. Hence, set the value of that cell to 0. Otherwise, set it to the value of previous cell i.e. obstacleGrid[i,j] = obstacleGrid[i,j-1]
    4. Iterate the first column. If a cell originally contains a 1, this means the current cell has an obstacle and shouldn't contribute to any path. Hence, set the value of that cell to 0. Otherwise, set it to the value of previous cell i.e. obstacleGrid[i,j] = obstacleGrid[i-1,j]
    5. Now, iterate through the array starting from cell obstacleGrid[1,1]. If a cell originally doesn't contain any obstacle then the number of ways of reaching that cell would be the sum of number of ways of reaching the cell above it and number of ways of reaching the cell to the left of it.

     obstacleGrid[i,j] = obstacleGrid[i-1,j] + obstacleGrid[i,j-1]

    6. If a cell contains an obstacle set it to 0 and continue. This is done to make sure it doesn't contribute to any other path.


#387 First Unique Character in a String
https://leetcode.com/problems/first-unique-character-in-a-string/

#63 Unique Paths II
https://leetcode.com/problems/unique-paths-ii/
