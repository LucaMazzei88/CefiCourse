package ads;

import java.util.HashSet;
import java.util.Hashtable;
public class ClasseStatica {
	private static int  valMax=0;
	private static int chiaveMax;
	public static int maxRipetizioni(int[] a){
		Hashtable<Integer, Integer> mappa=new Hashtable<>();
		int valore;
		for(int ele:a){
			valore=0;
			if(mappa.containsKey(ele)){
				valore=mappa.get(ele);
			}
			mappa.put(ele, ++valore);
		}
		mappa.forEach((k,v)->{if(v>valMax){valMax=v;chiaveMax=k;}});
		return chiaveMax;
	}
	public static String[] stringheComuni(String a, String b, int num){
		HashSet<String> setA=new HashSet<>();
		HashSet<String> setB=new HashSet<>();
		char carattere;
		for(int i=0;i<b.length();i++){
			carattere=b.charAt(i);
			for(int j=0;j<b.length() &&j!=i;j++){
				setA.add(carattere+""+b.charAt(j));
			}
		}
		for(int i=0;i<a.length();i++){
			carattere=a.charAt(i);
			for(int j=i+1;j<a.length();j++){
				setB.add(carattere+""+a.charAt(j));
			}
		}
	}
	public static String maxString(String[][] mat){
		String temp="";
		int conta, maxConta=0;
		for(String[] ele:mat){
			for(String ele1:ele){
				conta=contiene(ele1, mat);
				if(conta>maxConta){
					maxConta=conta;
					temp=ele1;
				}
				else if(conta==maxConta){
					temp+=" "+ele1;
				}
			}
		}
		return temp;
	}
	private static int contiene(String s, String[][] mat){
		int conta=0;
		for(String[] ele:mat){
			for(String ele1:ele){
				if(ele1.contains(s))
					conta++;
			}
		}
		return conta;
	}
}
