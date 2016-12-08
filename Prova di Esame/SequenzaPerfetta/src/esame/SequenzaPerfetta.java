package esame;


import java.util.List;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.HashSet;

public class SequenzaPerfetta {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println(perfetto(new int[]{1,9,1,2,1,8,2,4,6,2,7,9,4,5,8,6,3,4,7,5,3,9,6,8,3,5,7}));

	}
	public static boolean controllo(int[] numeri){
		HashMap<Integer, Integer> mappa=new HashMap<>();
		int temp;
		for(int i=1;i<=9;i++){
			mappa.put(i, 0);
		}
		for(int ele:numeri){
			temp=mappa.get(ele);
			mappa.put(ele, ++temp);
		}
		HashSet<Integer> contr= new HashSet<>(mappa.values());
		if(contr.size()==1 && contr.contains(3))
			return true;
		else
			return false;
	}
	public static boolean perfetto(int[] numeri){
		if(!controllo(numeri))
			return false;
		int indice;
		ArrayList<Integer> lista=new ArrayList<>();
		for(int ele:numeri){
			lista.add(ele);
		}
		for(int i=1;i<=9;i++){
			indice=lista.indexOf(i);
			if(i!=lista.get(indice+i+1) || i!=lista.get(indice+2*(i+1)))
				return false;
		}
		return true;
	}
}
