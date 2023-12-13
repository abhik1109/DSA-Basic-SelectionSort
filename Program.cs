namespace Sorting;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter elements of array separated by space.");
        string[]? input =Console.ReadLine()?.Split(' ');

        if(input==null || input.Length==0){
            throw new NullReferenceException("Input arraay is empty.");
        }
        
        int[] inputArr=new int[input.Length];
        for(int i=0;i<inputArr.Length;i++){
            inputArr[i]=Convert.ToInt32(input[i]);
        }
        
        Console.WriteLine("Sorting using Selection sort algorithm...");
        Console.WriteLine("Below is the sorted array.");
        Console.WriteLine(string.Join(' ',Program.SelectionSort(inputArr)));
    }

    public static int[] SelectionSort(int[] arr){
        //Select current minimum to first element of array
        int min;
        int minIndex;

        for(int i=0;i<arr.Length;i++){
            /*
            *Select current element as minimum and compare it 
            *with next elements in second array to find minimum
            */
            minIndex=i;
            min=arr[i];

            for(int j=i+1;j<arr.Length;j++){
                if(arr[j]<min){
                    min=arr[j];
                    minIndex=j;
                }
            }

            //Swap current i with min
            arr[minIndex]=arr[i];
            arr[i]=min;
        }

       return arr;
    }
}
