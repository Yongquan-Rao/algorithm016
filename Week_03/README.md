学习笔记

递归模板
public void recur (int level, int param) {

	// terminator
	if (level > MAX_LEVEL) { 
		return;
	}
	
	// process current logic
	process(level, param);
	
	// drill down
	recur(level + 1, newParam);
	
	// restore current status
}


分治模板：
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


#22 Generate Parentheses
https://leetcode.com/problems/generate-parentheses/

#98 Validate Binary Search Tree
https://leetcode.com/problems/validate-binary-search-tree/

#226 Invert Binary Tree
https://leetcode.com/problems/invert-binary-tree/