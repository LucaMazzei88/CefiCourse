#include <iostream>
#include <stdlib.h>
#include <stdio.h>
#include <set>
#include <vector>
using namespace std;
vector<int>* leggiFile(FILE* id);
int main()
{
    FILE* dato1=fopen("dato1.txt","r");
    FILE* dato2=fopen("dato2.txt","r");
    if(dato1==NULL ||dato2==NULL){
        cout<<"File non trovato"<<endl;
        exit(0);
    }
    FILE* dato3=fopen("dato3.txt","w");

    set<int>* lista=new set<int>();
    vector<int>* vecDato1=new vector<int>();
    vector<int>* vecDato2=new vector<int>();

    vecDato1=leggiFile(dato1);
    vecDato2=leggiFile(dato2);

    vector<int>::iterator itDato1;
    vector<int>::iterator itDato2;
    set<int>::iterator itSet;

    for(itDato1=vecDato1->begin();itDato1!=vecDato1->end();itDato1++){
        for(itDato2=vecDato2->begin();itDato2!=vecDato2->end();itDato2++){
            if(*itDato1==*itDato2){
                lista->insert(*itDato1);
            }
        }
    }
    for(itSet=lista->begin();itSet!=lista->end();itSet++){
        fprintf(dato3,"%d\n",*itSet);
    }

    fclose(dato1);
    fclose(dato2);
    fclose(dato3);
    return 0;
}
vector<int>* leggiFile(FILE* id){
    char* numeri=new char[10];
    vector<int>* vec=new vector<int>();
    int i=0;
    while((numeri=fgets(numeri,10 ,id))!=NULL){
        vec->push_back(atoi(numeri));
    }
    return vec;
}
