using static System.Console;
class Program
{
	static void Main()
    {
		int[] test={1,2,3,4,5};
		for(int n=0;n<=4;n++)
			Write("test[{0}]={1}\n",n,test[n]);
		ReadKey();
	}
}
