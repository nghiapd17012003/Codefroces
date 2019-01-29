#include<iostream>
#include<string.h>
using namespace std ;
int main ()
{
   int x;
   cin >> x;
   char str[50][x] ;
   cin >> str[50][x];
   int len = strlen(str);
   if (len>10)
   {
       cout << str[1],len-2,str[len];
   }
   else 
   {
       cout << x;
   }
   
   return (0);
}
