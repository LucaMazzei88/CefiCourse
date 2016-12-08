#include <iostream>
#include <stdlib.h>
#include <stdio.h>
#include <string.h>
using namespace std;

int main()
{
    FILE* vocali=fopen("Vocali.txt","r");
    if(vocali==NULL)
    {
        cout<<"File Non Trovato"<<endl;
        exit(0);
    }
    FILE* scriviVocali=fopen("Scrivi Vocali.txt","w");
    char stringVocali[]="AEIOUaeiou";
    char temp[50];
    int riga=0, conta;
    while(fgets(temp,50,vocali)!=NULL){
        riga++;
        conta=0;
        for(int i=0;i<strlen(temp);i++){
            if(strchr(stringVocali,temp[i])!=NULL){
                conta++;
            }
        }
        fprintf(scriviVocali,"Numero vocali nella riga %d e': %d\n",riga,conta);
    }
    fclose(vocali);
    fclose(scriviVocali);
    cout<<"programma terminato"<<endl;
    system("pause");
    return 0;
}
