package valute;

import java.util.ArrayList;

public class Test {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Valuta val=new Valuta("Tasso di cambio 1.txt", "Tasso di cambio 2.txt");
		ArrayList<String > giorno=new ArrayList<>();
		ArrayList<String > giornoSuccessivo=new ArrayList<>();
		giorno.add("Germania Marco 1029.83");
		giorno.add("USA Dollaro 1526.72");
		giorno.add("RegnoUnito Sterlina 2378.94");
		giorno.add("Francia Franco 303.61");
		giornoSuccessivo.add("Germania Marco 1029.87");
		giornoSuccessivo.add("USA Dollaro 1111135.72");
		giornoSuccessivo.add("RegnoUnito Sterlina 1843.44");
		giornoSuccessivo.add("Francia Franco 435.61");
		val.scriviCambio(giorno, giornoSuccessivo);
		System.out.println(val.rialzo("Marco"));
		ArrayList<String> rialzi=new ArrayList<>();
		rialzi=val.rialzo();
		rialzi.forEach(s->System.out.println(s));
	}

}
