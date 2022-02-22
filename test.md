```C#
public int CountOdds(int low, int high) {
        return (high - low) / 2 + Convert.ToInt16(high % 2 == 1 || low % 2 == 1);
    }
```