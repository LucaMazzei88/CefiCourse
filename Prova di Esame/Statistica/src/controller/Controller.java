package controller;

import java.io.BufferedReader;
import java.io.FileReader;
import java.util.ArrayList;
import java.util.Collections;

public class Controller {
	public static void statistica(String nomeFile) throws Exception{
		BufferedReader leggi=new BufferedReader(new FileReader(nomeFile));
		String riga,temp;
		int numRighe,numCaratteri=0,media=0,massimo=0,rigaMax=0;
		ArrayList<Integer> stat=new ArrayList<>();
		while((riga=leggi.readLine())!=null){
			temp=riga.replaceAll("\\s", "");
			stat.add(temp.length());
		}
		numRighe=stat.size();
		massimo=Collections.max(stat);
		rigaMax=stat.indexOf(massimo);
		for(int ele:stat){
			numCaratteri+=ele;
		}
		media=numCaratteri/numRighe;
		System.out.println("Numero Righe: "+numRighe+"\nNumero caratteri: "+numCaratteri+"\nMedia Caratteri: "+media+"\nCaratteri riga massima: "+massimo+"\nIndice riga massima: "+rigaMax);
		leggi.close();
	}
}
