package esame;

public class Calcola {

	public Calcola(String[] testo) {
		super();
		this.testo = testo;
	}
	String[] testo;
	public String quindici(){
		int somme;
		String ret="";
		for(String ele:testo){
			for(int i=0;i<ele.length()-2;i++){
				somme=0;
				for(int j=i;j<3+i;j++){
					somme+=Integer.parseInt(ele.substring(j, j+1));
				}
				if(somme==15){
					ret+=ele.substring(i, i+3)+",";
				}
			}
		}
		return ret;
	}
	public String sommeMax(){
		int somme;
		int max=0;
		String ret="";
		for(String ele:testo){
			for(int i=0;i<ele.length()-2;i++){
				somme=0;
				for(int j=i;j<3+i;j++){
					somme+=Integer.parseInt(ele.substring(j, j+1));
				}
				if(somme>max){
					max=somme;
					ret=ele.substring(i, i+3)+" ";
				}
				else if(somme==max)
					ret+=ele.substring(i, i+3)+" ";
			}
		}
		return ret;
	}
}
