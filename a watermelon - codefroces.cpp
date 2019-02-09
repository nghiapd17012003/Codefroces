/* a watermelon - codefroces */
#include<iostream>
using namespace std ;
int main()
{
	int x ;
	std :: cin >> x;
	if ( 2 <= x && x <= 100)
	{
		if ( x%2 == 0)
		{
			cout << "YES";
		}
		else 
		{
			cout << "NO";
		}
	}
	else 
	{
		cout << "NO";
	}
	
	return (0);	
}
