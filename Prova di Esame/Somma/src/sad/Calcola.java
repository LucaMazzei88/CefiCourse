package sad;

public class Calcola {

	String [] testo;

	public Calcola(String[] testo) {
		super();
		this.testo = testo;
	}
	public String somma(){
		int somma;
		String ritorna="";
		for(String ele:testo){
			somma=0;
			for(int i=0;i<ele.length();i++){
				somma+=Integer.parseInt(""+ele.charAt(i));
			}
			ritorna+=somma+" ";
		}
		return ritorna;
	}
	public String sommeConsegutive(){
		String ritorna="";
		int somma;
		for(int i=0;i<testo.length-1;i++){
			somma=0;
			for(int j=0;j<testo[i].length();j++){
				somma+=Integer.parseInt(""+testo[i].charAt(j));
			}
			for(int j=0;j<testo[i+1].length();j++){
				somma+=Integer.parseInt(""+testo[i+1].charAt(j));
			}
			ritorna+=somma+" ";
		}
		return ritorna;
	}
}
