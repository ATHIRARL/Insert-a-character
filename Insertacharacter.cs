using System;

public class A
{
	public static void Main()
	{
		
		Console.WriteLine("limit");
		int n=Convert.ToInt32(Console.ReadLine());
	int [] a=new int[n];
		Console.WriteLine("pos");
		int p=Convert.ToInt32(Console.ReadLine());
		 Console.WriteLine("dee");
		int q=Convert.ToInt32(Console.ReadLine());
		
		int [] b=new int[p+1];
		int [] c= new int[n-p];
		int [] d= new int[n+1];
		
		Console.WriteLine("elements");
		for(int i=0;i<n;i++)
		{
		a[i]=Convert.ToInt32(Console.ReadLine());	
		}
		
		
		for(int i=0;i<p+1;i++)
		{ 
		
		
		
			
		
		
			if(i==(p-1))
			{
				int t=a[p-1];
			b[i]=q;
		b[i+1]=t;
					//Console.WriteLine(t);
				break;
			}
			else
			{
					b[i]=a[i];
			}
			
			
			
			
		}
		Console.WriteLine("hhjj");
			
			int k=0;	
		for(int i=p;i<n;i++)
		{
		
			
				c[k]=a[i];
			k++;
			
		
		}
	b.CopyTo(d, 0);
c.CopyTo(d,b.Length);	
		//b.CopyTo(d,0);
		//c.CopyTo(d,b.Length+1);
		Console.WriteLine("lrn"+b.Length);
		for(int i=0;i<b.Length;i++)
			{
			Console.WriteLine(b[i]);
		}
		Console.WriteLine("lrn"+c.Length);
		for(int i=0;i<c.Length;i++)
			{
			Console.WriteLine(c[i]);
			}
		Console.WriteLine("hhjj");
		for(int i=0;i<d.Length;i++)
			
			{
			Console.WriteLine(d[i]);
			}
	}
}