// See https://aka.ms/new-console-template for more information

using Day1_HistorianHysteria;

var lists = ListHelper.GetListsFromInput("input.txt");
int[] leftList = lists.leftList.ToArray();
int[] rightList = lists.rightList.ToArray();

ListHelper.BubbleSort(leftList, leftList.Length);
ListHelper.BubbleSort(rightList, rightList.Length);

int totalDistance = ListHelper.GetTotalDistance(leftList, rightList);

Dictionary<int, int> occurencesDict = ListHelper.CalculateOccurences(leftList, rightList);
int totalSimilarity = ListHelper.CalcualteTotalSimilarity(leftList, occurencesDict);
Console.WriteLine(totalSimilarity);