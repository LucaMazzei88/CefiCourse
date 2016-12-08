package esame;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.Hashtable;

import javafx.collections.transformation.SortedList;

public class Conta {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Hashtable<Integer, Integer> mappa=calcola(1,8,1,5,8,1,6,1,2);
		mappa.forEach((k,v)->System.out.println("<"+k+","+v+">"));
		System.out.println(somma(mappa));

	}
	public static Hashtable<Integer, Integer> calcola(int... testo){
		Hashtable<Integer, Integer> mappa=new Hashtable<>();
		int temp;
		for(int ele:testo){
			if(!mappa.containsKey(ele)){
				temp=0;
				for(int ele1:testo){
					if(ele1>ele)
						temp++;
				}
				mappa.put(ele, temp);
			}
		}
		return mappa;
	}
	public static String somma(Hashtable<Integer, Integer> coppie){
		ArrayList<Integer> lista=new ArrayList<>(coppie.values());
		Comparator<Integer> c=Comparator.naturalOrder();
		lista.sort(c.reversed());
		String temp="";
		for(int ele:lista){
			temp+=ele;
		}
		return temp;
	}
}
