/*231a*/
#include<stdio.h>
int main ()
{
	int n ; 
	printf (" nhap so phan tu :");
	scanf(" %d", &n);
	int arr[n-1];
	for ( int a = 0 ; a <= n-1 ; a = a + 1)
	{
		printf (" nhap phan tu thu %d : ", a + 1);
		scanf (" %d", &arr[a]);
	}
   int x =0;
   for (int b = 0 ; b <= n-1 ; b = b +1)
   {
        if (arr[b]!=101 && arr[b]!=110 & arr[b]!=011)
        {
           x = x+1;
		}
   }
   printf ("%d", x); 
}
