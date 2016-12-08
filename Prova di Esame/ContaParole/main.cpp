#include <iostream>
#include <stdlib.h>
#include <string.h>
using namespace std;

int main()
{
    char* frase=new char[50];
    char* parola;
    int num=0;
    cout<<"inserire frase"<<endl;
    cin.getline(frase,50);
    if(strtok(frase," ")!=NULL){
        num++;
        while(strrchr(parola,'.')==NULL){
            parola=strtok(NULL," ");
            if(strcmp(parola,".")!=0)
                num++;
        }
    }

    cout<<num<<endl;
    return 0;
}
