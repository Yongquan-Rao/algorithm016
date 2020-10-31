class Trie:
    def __init__(self):
        self.root = TrieNode()

    def insert(self, word: str) -> None:
        curr = self.root
        for letter in word:
            curr = curr.next[letter]
        curr.is_word = True

    def search(self, word: str) -> bool:
        curr = self.root
        for letter in word:
            curr = curr.next.get(letter)
            if curr is None:
                return False
        return curr.is_word
        
    def startsWith(self, prefix: str) -> bool:
        curr = self.root
        for letter in prefix:
            curr = curr.next.get(letter)
            if curr is None:
                return False
        return True
        
class TrieNode:
    def __init__(self):
        self.next = collections.defaultdict(TrieNode)
        self.is_word = False


# Your Trie object will be instantiated and called as such:
# obj = Trie()
# obj.insert(word)
# param_2 = obj.search(word)
# param_3 = obj.startsWith(prefix)