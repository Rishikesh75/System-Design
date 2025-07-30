public interface Sort
{
    public void sort(List<Integer>arr);
}
public class BubbleSort implements Sort{
    @Override
    public void sort(List<Integer>arr)
    {
        System.out.println("Bubble Sort Algoritham");
    }
}
public class SelectionSort implements Sort
{
    @Override
    public void sort(List<Integer>arr)
    {
        System.out.println("Selection Sort Algoritham");
    }
}
public class InsertionSort implements Sort
{
    @Override
    public void sort(List<Integer>arr)
    {
        System.out.println("Insertion sort Algoritham");
    }
}
public class MergeSort implements Sort
{
    @Override
    public void sort(List<Integer>arr)
    {
        System.out.println("Merge sort Algoritham");
    }
}
public class Quicksort implements Sort
{
    @Override
    public void sort(List<Integer>arr)
    {
        System.out.println("Quick sort Algoritham");
    }
}
public class Piviotsort implements Sort
{
    @Override
    public void sort(List<Integer>arr)
    {
        System.out.println("piviot  sort Algoritham");
    }
}
public class Algorithams
{
    Sort sort;

    Algorithams(Sort sortingAlog)
    {
        this.sort = sortingAlog;
    }

}