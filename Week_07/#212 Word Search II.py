class Solution:
    def findWords(self, board: List[List[str]], words: List[str]) -> List[str]:
        self.m, self.n = len(board), len(board[0])
        self.res = []
        self.dx, self.dy = [-1, 1, 0, 0], [0, 0, -1, 1]
        trie = Trie()
        node = trie.root
        for word in words:
            trie.insert(word)
        for i in range(self.m):
            for j in range(self.n):
                if board[i][j] in node.next:
                    self.dfs(board, node.next[board[i][j]], i, j)
        return self.res
    
    def dfs(self, board, node, i, j):
        if node.word:
            self.res.append(node.word)
            node.word = None
        tmp, board[i][j] = board[i][j], '#'
        for k in range(4):
            x, y = i + self.dx[k], j + self.dy[k]
            if 0 <= x < self.m \
                and 0 <= y < self.n \
                and board[x][y] != '#'\
                and board[x][y] in node.next:
                self.dfs(board, node.next[board[x][y]], x, y)
        board[i][j] = tmp
             
class Trie:
    def __init__(self):
        self.root = TrieNode()

    def insert(self, word: str) -> None:
        curr = self.root
        for letter in word:
            curr = curr.next[letter]
        curr.word = word
        
class TrieNode:
    def __init__(self):
        self.next = collections.defaultdict(TrieNode)
        self.word = None