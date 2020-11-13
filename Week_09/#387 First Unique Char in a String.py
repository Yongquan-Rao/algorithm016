class Solution:
    def firstUniqChar(self, s: str) -> int:
        char_dict = collections.Counter(s)
        for i, v in enumerate(s):
            if char_dict[v] == 1:
                return i
        return -1