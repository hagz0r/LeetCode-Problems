IList<IList<int>> Generate(int numRows) 
{
    IList<IList<int>> pascal = new int[numRows][];
    for (int i = 0; i < numRows; i++){
        int[] row = new int[i + 1];
        row[0] = 1;
        row[i] = 1;
        for (int j = 1; j < i; j++){
            row[j] = pascal[i - 1][j - 1] + pascal[i - 1][j];
        }
        pascal[i] = row;
    }
    return pascal;
}
