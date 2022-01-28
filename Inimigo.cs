public class Inimigo : Personagem {
    
    private int dificuldade;

    public Inimigo(int dificuldade) : base("Inimigo", 100, dificuldade * 2){
        this.dificuldade = dificuldade;
    }

    public int getDificuldade(){
        return dificuldade;
    }

    public int getVida(){
        return this.vida;
    }

}