"""
6
"""
import System.Linq.Enumerable
a = (1, 2, 3)
print a.Aggregate({i, j | i + j})
