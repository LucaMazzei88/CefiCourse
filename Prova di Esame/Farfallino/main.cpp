#include <iostream>
#include <stdio.h>
#include<stdlib.h>

using namespace std;

int main()
{
    string stampa="";
    FILE* id=fopen("dati.txt","r");
    if(id==NULL){
        cout<<"Fottutissimo File"<<endl;
        exit(0);
    }
    char carattere;
    while ((carattere=fgetc(id))!=EOF){
            stampa+=carattere;
        switch(carattere){
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U': stampa.append("F"); break;
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u': stampa.append("f"); break;
            default:  break;
        }
    }
    cout<<stampa<<endl;
    fclose(id);
    return 0;
}
