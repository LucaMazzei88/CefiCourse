#include <iostream>
#include <stdlib.h>
#include <stdio.h>
using namespace std;

int main()
{
    FILE* id=fopen("testo.txt","r");
    if(id==NULL){
        cout<<"file non trovato"<<endl;
        exit(0);
    }
    FILE* id2=fopen("testo2.txt","w");
    char* buffer=new char[100];
    while(buffer!=NULL){
        buffer=fgets(buffer,100,id);
        fputs(buffer,id2);
    }
    fclose(id);
    fclose(id2);
    return 0;
}
