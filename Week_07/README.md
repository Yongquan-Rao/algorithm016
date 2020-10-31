学习笔记
字典树实现：
# Python a
    class Trie(object):
	def __init__(self): 
		self.root = {} 
		self.end_of_word = "#" 
 
	def insert(self, word): 
		node = self.root 
		for char in word: 
			node = node.setdefault(char, {}) 
		node[self.end_of_word] = self.end_of_word 
 
	def search(self, word): 
		node = self.root 
		for char in word: 
			if char not in node: 
				return False 
			node = node[char] 
		return self.end_of_word in node 
 
	def startsWith(self, prefix): 
		node = self.root 
		for char in prefix: 
			if char not in node: 
				return False 
			node = node[char] 
		return True
		
# Python b
    class TrieNode:
	def __init__(self):
	    self.children = collections.defaultdict(TrieNode)
	    self.is_word = False

	class Trie:
	def __init__(self):
	    self.root = TrieNode()

	def insert(self, word):
	    current = self.root
	    for letter in word:
		current = current.children[letter]
	    current.is_word = True

	def search(self, word):
	    current = self.root
	    for letter in word:
		current = current.children.get(letter)
		if current is None:
		    return False
	    return current.is_word

	def startsWith(self, prefix):
	    current = self.root
	    for letter in prefix:
		current = current.children.get(letter)
		if current is None:
		    return False
	    return True

#208 Implement Trie (Prefix Tree)
https://leetcode.com/problems/implement-trie-prefix-tree/

#212 Word Search II
https://leetcode.com/problems/word-search-ii/
