#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <vector>
#include <string.h>
using namespace std;
void temperatura(char nomeFile[], char luogo[], double soglia);
int main()
{
    temperatura("luoghi.txt","Torino",23.0);

    return 0;
}
void temperatura(char nomeFile[], char luogo[], double soglia){
    FILE* id=fopen(nomeFile,"r");
    if(id==NULL){
        cout<<"Errore apertura file"<<endl;
        exit(0);
    }
    char* riga;
    double temperatura;
    int conta=0;
    double somme=0;
    vector<double>* vec=new vector<double>;
    while(fgets(riga,100,id)!=NULL){
        riga=strtok(riga," ");
        temperatura=atof(riga);
        riga=strtok(NULL,"\n");
        if(strcmp(riga,luogo)==0){
            vec->push_back(temperatura);
        }
    }

    vector<double>::iterator it;
    for(it=vec->begin();it<vec->end();it++){
        somme+= *it;
        if(*it>soglia)
            conta++;
    }
    fclose(id);
    cout<<luogo<<":\nTemperatura Media: "<<somme/vec->size()<<"\n"<<conta<<" giorni superiori alla "<<soglia<<endl;
}
