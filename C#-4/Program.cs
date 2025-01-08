using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int num, cnt=0;
        for(int i=0; i<n; i++){
            num=arr[i];
            cnt=0;

            for(int j=0; j<n; j++){
                if (num==arr[j]){
                    cnt++;
                }
                if (cnt>=2){
                    Console.WriteLine(num + " ");
                    break;
                }
            }
        }
    }
}