using EightQueens;

Queens eightQueens = new Queens(8);
eightQueens.GetEightQueens(0);
int count = eightQueens.GetSolutions();
Console.WriteLine($"EightQueens has {count} 種解法.");