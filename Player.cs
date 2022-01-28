public class Player : Personagem{
    private int moeda;
    public Player(string nome, int vida, int dano) : base(nome, vida, dano){
        this.moeda = 0;        
    }

    public int getMoeda(){
        return this.moeda;
    }
    public int getVida(){
        return this.vida;
    }
    public string getNome(){
        return this.nome;
    }
    public void ganhaMoeda(int moedasGanhas){
        moeda += moedasGanhas;
    }  
    public bool perdeMoeda(int moedasPerdidas){
        if(this.moeda >= moedasPerdidas){
            this.moeda -= moedasPerdidas;
            return true;
        }
        return false;
    }
    public void vidaUp(){
        vida+=10;
    }
    public void danoUp(){
        dano+=2;
    }
}