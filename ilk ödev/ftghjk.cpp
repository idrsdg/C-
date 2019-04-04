#include<iostream>
using namespace std;

int volume(	int l=1, int h=1, int w=1);


int main(){
    cout << volume(5,5);
}


int volume(int l, int h, int w){
    return l*h*w;
}

