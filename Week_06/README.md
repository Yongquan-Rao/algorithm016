学习笔记

动态规划定义：https://en.wikipedia.org/wiki/Dynamic_programming

动态规划和递归、分治没有本质区别 关键看有无最优子结构
共性：找到重复子问题
差异性：最优子结构、中途可以淘汰次优解

动态规划关键点：
1. 最优子结构
2. 存储中间状态
3. 递推公式 状态转移方程或DP方程
	Fib: opt[i]=opt[i-1]+opt[i-2]
	二维路径：opt[i,j]=opt[i+1,j] + opt[i,j+1]

递归模板：
// Java
public void recur(int level, int param) { 
  // terminator 
  if (level > MAX_LEVEL) { 
    // process result 
    return; 
  }
  // process current logic 
  process(level, param); 
  // drill down 
  recur( level: level + 1, newParam); 
  // restore current status 
 
}

分治模板：
// Java
private static int divide_conquer(Problem problem, ) {
  
  if (problem == NULL) {
    int res = process_last_result();
    return res;     
  }
  subProblems = split_problem(problem)
  
  res0 = divide_conquer(subProblems[0])
  res1 = divide_conquer(subProblems[1])
  
  result = process_result(res0, res1);
  
  return result;
}


#62 Unique Path
https://leetcode.com/problems/unique-paths/

#63 Unique Path 2
https://leetcode.com/problems/unique-paths-ii/
