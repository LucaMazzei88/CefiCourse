package funzioni;

import java.util.ArrayList;

public class Funzioni {

	public static ArrayList<String> maxParolaVocali(String frase){
		ArrayList<String> parole=new ArrayList<>();
		String vocali="aeiouAEIOU",lettera;
		int numVoc=0, numVocaliParz;
		String[] par=frase.split(" ");
		for(String ele:par){
			numVocaliParz=0;
			for(int i=0;i<ele.length();i++){
				
				lettera=""+ele.charAt(i);
				if(vocali.contains(lettera)){
					numVocaliParz++;
				}
			}
			if(numVocaliParz>numVoc){
				numVoc=numVocaliParz;
				parole.clear();
				parole.add(ele);
			}
			else if(numVocaliParz==numVoc)
				parole.add(ele);
		}
		return parole;
	}
	public static String prefSuffString(String a, String b){
		String[] arr=a.split(" ");
		String temp="";
		for(String ele : arr){
			if(ele.startsWith(b) || ele.endsWith(b)){
				temp+=(temp.equals(""))?ele:"#"+ele;
			}
		}
		return temp;
	}
}
