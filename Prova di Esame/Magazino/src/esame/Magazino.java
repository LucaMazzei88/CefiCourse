package esame;

import java.util.HashMap;

public class Magazino {

	private Object[][] beni={{"viti","E",10},{"dadi","E",50},{"viti","U",5},{"viti","E",3},{"cellulari","U",12}};
	public String[] entrataUscita(){
		int ent=0, usc=0;
		String[] temp=new String[3];
		for(Object[] ele:beni){
			if(ele[1].equals("E"))
				ent+=(int)ele[2];
			else
				usc+=(int)ele[2];
		}
		temp[0]="Entrate:"+ent;
		temp[1]="Uscite:"+usc;
		temp[2]="Disponibile:"+(ent-usc);
		return temp;
	}
	public void riepilogo(){
		HashMap<String, Integer> riepilogo= new HashMap<>();
		int temp;
		for(Object[] ele:beni){
			temp=(ele[1].equals("E"))?(int)ele[2]:-(int)ele[2];
			if(riepilogo.containsKey((String)ele[0]))
				temp+=riepilogo.get((String)ele[0]);
			riepilogo.put((String)ele[0], temp);
		}
		riepilogo.forEach((str,num)->{System.out.println(str+" "+num);});
	}
}
