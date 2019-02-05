#include<stdio.h>
int main ()
{
   int n , k  ;
   int arr [n-1];
   printf("so nguoi tham gia :");
   scanf ("%d", &n);
   printf("so thu tu dc chon : ");
   scanf ("%d", &k);
   int count = 1;
   for (int a = 0 ; a<= n -1; a = a + 1)
   {
      printf ("so diem cua nguoi %d :", a+1);
	  scanf ("%d", arr[a]);
   }
   for (int b= 0; b <= n-1; b= b + 1)
   {
      if ( arr[b]>= arr[k])
      {
          count = count + 1; 
	  }
   }
   
   printf("%d", count );
   
}
