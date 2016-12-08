package asd;


public class Test {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Articoli art=new Articoli();
		art.inserisci("a001", "Imac", 12, "Informatica", 1010);
		art.inserisci("a002", "Hamburger", 56, "Cibo", 15.56);
		art.inserisci("a003", "Jeans", 17, "Vestiario", 156.89);
		art.inserisci("a004", "Intel", 18, "Informatica", 896.87);
		art.inserisci("a005", "Pizza", 78, "Cibo", 8.96);
		art.inserisci("a006", "Maglioni", 45, "Vestiario", 56.84);
		String [] arr=art.stampa();
		for(String ele:arr){
			System.out.println(ele);
		}
		art.media();
		System.out.println(art.totale("Cibo"));
	}

}
