package esame;

import java.util.ArrayList;

public class Test {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		ArrayList<Colori> col=new ArrayList<>();
		col.add(new Colori( new Persona("Mario Esposito", 56),"red"));
		col.add(new Colori( new Persona("Mario Rossi", 78),"white"));
		col.add(new Colori( new Persona("El Barto", 25),"yellow"));
		col.add(new Colori( new Persona("Filippo Cacca", 35),"red"));
		col.add(new Colori(new Persona("Mr Grey",56),"grey"));
		col.forEach(e->System.out.println(e.toString()));
		AbinaColori sb=new AbinaColori(col);
		sb.ordinaColori();
		System.out.println();
		col.forEach(e->System.out.println(e.toString()));
		ArrayList<String> rag= sb.raggruppaColori();
		rag.forEach(e->System.out.println(e));
		System.out.println(sb.mediaColori());
		
	}

}
