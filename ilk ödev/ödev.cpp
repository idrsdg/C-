#include<iostream>
using namespace std;

enum Direction{NORTH,SOUTH,EAST,WEST};

int main()
{
	Direction myDirection=EAST;
	char myWay;
	int myNum;
	cin >> myWay >> myNum

	cout << "I am heading 0 units east! (initial direction)" << endl;
	while(myWay!='\0')
	{
		switch(myDirection)
		{
			case EAST:
				if(myWay=='L')
				{
					myDirection=NORTH;
					cin >> number;
					cout << "I am heading " << number << " units north!" << endl;
				}
				else if(myWay=='R')
				{
					myDirection=SOUTH;
					cin >> number;
					cout << "I am heading " << number << " units south!" << endl;
				}
				break;

			case WEST:
				if(myWay=='L')
				{
					myDirection=SOUTH;
					cin >> number;
					cout << "I am heading " << number << " units south!" << endl;
				}
				else if(myWay=='R')
				{
					myDirection=NORTH;
					cin >> number;
					cout << "I am heading " << number << " units north!" << endl;
				}
				break;

			case SOUTH:
				if(myWay=='L')
				{
					myDirection=EAST;
					cin >> number;
					cout << "I am heading " << number << " units east!" << endl;
				}
				else if(myWay=='R')
				{
					myDirection=WEST;
					cin >> number;
					cout << "I am heading " << number << " units west!" << endl;
				}
				break;

			case NORTH:
				if(myWay=='L')
				{
					myDirection=WEST;
					cin >> number;
					cout << "I am heading " << number << " units west!" << endl;
				}
				else if(myWay=='R')
				{
					myDirection=EAST;
					cin >> number;
					cout << "I am heading " << number << " units east!" << endl;
				}
				break;

		}

		cin >> myWay;
	}

}
